using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QRCoder;
using System.Net.Mail;
using System.IO;
using iTextSharp.text.pdf;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Mkci_Frabs
{
    public partial class Form1 : Form
    {
        // --- KONFIGURASI DATABASE ---
        string connectionString = "server=localhost;user=root;database=db_mkci_frabs;port=3306;password=;";

        // --- VARIABEL GLOBAL KAMERA ---
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        public Form1()
        {
            InitializeComponent();
            SetupEvents();
            LoadDashboard();
            SetupCamera();
        }

        // --- SETUP EVENT HANDLER ---
        private void SetupEvents()
        {
            // Tombol Utama
            this.btnDaftar.Click += new EventHandler(btnDaftar_Click);
            this.btnCetakTiket.Click += new EventHandler(btnCetakTiket_Click);
            this.txtScanInput.KeyDown += new KeyEventHandler(txtScanInput_KeyDown);

            // Tombol Search & Reset
            this.btnSearchMember.Click += new EventHandler(btnSearchMember_Click);
            this.btnSearchRiwayat.Click += new EventHandler(btnSearchRiwayat_Click);
            this.btnNewMember.Click += new EventHandler(btnNewMember_Click);
            this.btnNewBooking.Click += new EventHandler(btnNewBooking_Click);

            // Event Dropdown (Logika Otomatis)
            this.cmbAsal.SelectedIndexChanged += new EventHandler(cmbAsal_SelectedIndexChanged);
            this.cmbTujuan.SelectedIndexChanged += new EventHandler(HitungOtomatis);
            this.cmbJamBerangkat.SelectedIndexChanged += new EventHandler(HitungOtomatis);
            this.cmbBus.SelectedIndexChanged += new EventHandler(cmbBus_SelectedIndexChanged);

            // Kontrol Kamera
            this.btnStartCamera.Click += new EventHandler(btnStartCamera_Click);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            // Menu Klik Kanan
            SetupContextMenu();
        }

        // --- LOGIC TOMBOL RESET (PERBAIKAN DISINI) ---

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            txtNIK.Clear();
            txtEmail.Clear();
            cmbKategori.SelectedIndex = -1;
            picQRPreview.Image = null;
            txtNama.Focus();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            // 1. Bersihkan Input Scan & Hasilnya
            txtScanInput.Clear();
            lblNamaMember.Text = "-";
            lblNamaMember.ForeColor = Color.Black;
            lblNIK.Text = "-";
            lblKategori.Text = "-";

            // 2. Reset Pilihan Rute & Waktu (Hapus Text & Pilihan)
            cmbAsal.SelectedIndex = -1;
            cmbAsal.Text = string.Empty;

            cmbTujuan.SelectedIndex = -1;
            cmbTujuan.Text = string.Empty;

            cmbJamBerangkat.SelectedIndex = -1;
            cmbJamBerangkat.Text = string.Empty;

            // 3. Reset Bus & Bangku (Hapus Item List-nya juga)
            cmbBus.SelectedIndex = -1;
            cmbBus.Text = string.Empty;
            cmbBus.Items.Clear(); // Kosongkan daftar bus karena kota asal di-reset

            cmbBangku.SelectedIndex = -1;
            cmbBangku.Text = string.Empty;
            cmbBangku.Items.Clear(); // Kosongkan daftar bangku

            // 4. Reset Estimasi
            lblJamTiba.Text = "00:00";
            lblHarga.Text = "Rp 0";

            // 5. Fokus Balik
            txtScanInput.Focus();
        }

        // --- LOGIC PILIH BUS & BANGKU ---
        private void cmbAsal_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungOtomatis(sender, e);

            // Load Data Bus sesuai Kota Asal
            if (cmbAsal.SelectedItem != null)
            {
                string kota = cmbAsal.SelectedItem.ToString();
                List<string> busList = RouteHelper.GetBusByKota(kota);

                cmbBus.Items.Clear();
                cmbBus.Text = string.Empty; // Reset text
                foreach (var bus in busList)
                {
                    cmbBus.Items.Add(bus);
                }
                cmbBus.SelectedIndex = -1;

                // Reset bangku karena bus berubah
                cmbBangku.Items.Clear();
                cmbBangku.Text = string.Empty;
            }
        }

        private void cmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kalau bus dipilih, isi bangku 1-55
            if (cmbBus.SelectedItem != null)
            {
                cmbBangku.Items.Clear();
                cmbBangku.Text = string.Empty;
                for (int i = 1; i <= 55; i++)
                {
                    cmbBangku.Items.Add(i.ToString());
                }
            }
        }

        // --- FUNGSI DASHBOARD (LOAD DATA) ---
        void LoadDashboard()
        {
            LoadMembers("");
            LoadRiwayat("");
        }

        void LoadMembers(string keyword)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT nik AS 'NIK', nama_lengkap AS 'Nama', email AS 'Email', kategori AS 'Kategori' FROM members";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += " WHERE nama_lengkap LIKE @key OR nik LIKE @key";
                    }
                    query += " ORDER BY created_at DESC LIMIT 20";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridMembers.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void LoadRiwayat(string keyword)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            b.id AS 'ID', 
                            b.member_nik AS 'NIK', 
                            m.nama_lengkap AS 'Nama', 
                            b.asal AS 'Kota Awal', 
                            b.tujuan AS 'Tujuan', 
                            b.tanggal_perjalanan AS 'Tanggal', 
                            b.jam_berangkat AS 'Jam Berangkat', 
                            b.jam_tiba AS 'Estimasi Tiba', 
                            b.bus_kode AS 'Kode Bus', 
                            b.no_bangku AS 'Kursi', 
                            b.harga AS 'Harga' 
                        FROM bookings b
                        LEFT JOIN members m ON b.member_nik = m.nik";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += " WHERE b.tujuan LIKE @key OR b.tanggal_perjalanan LIKE @key";
                    }

                    if (string.IsNullOrEmpty(keyword))
                    {
                        query += " WHERE DATE(b.tanggal_perjalanan) = CURDATE()";
                    }

                    query += " ORDER BY b.id DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridRiwayat.DataSource = dt;

                    // Formatting Tampilan Grid
                    if (gridRiwayat.Columns["ID"] != null) gridRiwayat.Columns["ID"].Width = 40;
                    if (gridRiwayat.Columns["Nama"] != null) gridRiwayat.Columns["Nama"].Width = 200;
                    if (gridRiwayat.Columns["Kursi"] != null) gridRiwayat.Columns["Kursi"].Width = 50;
                    if (gridRiwayat.Columns["NIK"] != null) gridRiwayat.Columns["NIK"].Width = 80;
                    if (gridRiwayat.Columns["Kode Bus"] != null) gridRiwayat.Columns["Kode Bus"].Width = 150;
                    if (gridRiwayat.Columns["Harga"] != null) gridRiwayat.Columns["Harga"].DefaultCellStyle.Format = "Rp #,##0";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // --- FUNGSI SEARCH & FILTER ---
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            LoadMembers(txtSearchMember.Text.Trim());
        }

        private void btnSearchRiwayat_Click(object sender, EventArgs e)
        {
            LoadRiwayat(txtSearchRiwayat.Text.Trim());
        }

        // --- FUNGSI KAMERA & SCANNER ---
        private void SetupCamera()
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    cmbCamera.Items.Add(filterInfo.Name);
                }
                if (cmbCamera.Items.Count > 0) cmbCamera.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak ada kamera terdeteksi: " + ex.Message);
            }
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            if (cmbCamera.SelectedIndex == -1) return;

            if (captureDevice != null && captureDevice.IsRunning)
            {
                StopCamera();
            }
            else
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCamera.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                btnStartCamera.Text = "Stop Kamera";
            }
        }

        private void StopCamera()
        {
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
                captureDevice = null;
            }
            picWebcam.Image = null;
            btnStartCamera.Text = "Mulai Kamera";
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmapDisplay = (Bitmap)eventArgs.Frame.Clone();
            Bitmap bitmapScan = (Bitmap)eventArgs.Frame.Clone();

            try
            {
                // Update Tampilan UI (Thread Safe)
                picWebcam.Invoke((MethodInvoker)delegate
                {
                    if (picWebcam.Image != null)
                    {
                        var oldImage = picWebcam.Image;
                        picWebcam.Image = null;
                        oldImage.Dispose();
                    }
                    picWebcam.Image = bitmapDisplay;
                });

                // Proses Scan QR
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmapScan);

                if (result != null)
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        txtScanInput.Text = result.Text;
                        StopCamera();

                        string[] data = result.Text.Split('|');
                        if (data.Length > 0) CariDataMember(data[0]);
                    }));
                }
            }
            catch (Exception) { }
            finally { bitmapScan.Dispose(); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        // --- FUNGSI REGISTRASI MEMBER ---
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNIK.Text) || string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("NIK dan Nama wajib diisi!");
                return;
            }

            string nik = txtNIK.Text;
            string nama = txtNama.Text;
            string email = txtEmail.Text;
            string kategori = cmbKategori.SelectedItem?.ToString() ?? "Reguler";
            string qrData = $"{nik}|{nama}";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrImage = qrCode.GetGraphic(20);

            picQRPreview.Image = qrImage;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO members (nik, nama_lengkap, kategori, email, qr_code_data) VALUES (@nik, @nama, @kat, @email, @qr)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nik", nik);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@kat", kategori);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@qr", qrData);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registrasi Berhasil!");
                LoadDashboard();

                if (!string.IsNullOrWhiteSpace(email))
                {
                    KirimEmailQR(email, nama, qrImage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan: " + ex.Message);
            }
        }

        private void KirimEmailQR(string penerima, string nama, Bitmap qrBmp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                string myEmail = "mkcifrabs.executivebus@gmail.com";
                string myPassword = "yynb zayp wzzh orla";

                mail.From = new MailAddress(myEmail);
                mail.To.Add(penerima);
                mail.Subject = "Kartu Member MKCI FRABS - " + nama;
                mail.Body = $"Halo {nama},\n\nTerlampir adalah QR Code Member MKCI FRABS Anda.";

                using (MemoryStream ms = new MemoryStream())
                {
                    qrBmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Position = 0;
                    mail.Attachments.Add(new Attachment(ms, "member_qr.png", "image/png"));

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(myEmail, myPassword);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal kirim email: " + ex.Message);
            }
        }

        // --- FUNGSI PEMESANAN & LOGIKA BUS ---
        private void txtScanInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string rawData = txtScanInput.Text;
                string[] data = rawData.Split('|');
                if (data.Length > 0) CariDataMember(data[0]);
                txtScanInput.SelectAll();
            }
        }

        private void CariDataMember(string nik)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM members WHERE nik = @nik LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nik", nik);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNamaMember.Text = reader["nama_lengkap"].ToString();
                            lblNIK.Text = reader["nik"].ToString();
                            lblKategori.Text = reader["kategori"].ToString();
                            lblNamaMember.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblNamaMember.Text = "Member Tidak Ditemukan!";
                            lblNamaMember.ForeColor = Color.Red;
                            lblKategori.Text = "-";
                            lblNIK.Text = "-";
                        }
                    }
                }
                HitungOtomatis(null, null);
            }
            catch (Exception ex) { MessageBox.Show("Error Database: " + ex.Message); }
        }

        private void HitungOtomatis(object sender, EventArgs e)
        {
            if (cmbAsal.SelectedItem != null && cmbTujuan.SelectedItem != null && cmbJamBerangkat.SelectedItem != null)
            {
                string asal = cmbAsal.SelectedItem.ToString();
                string tujuan = cmbTujuan.SelectedItem.ToString();

                if (asal == tujuan)
                {
                    lblHarga.Text = "Rute Invalid";
                    return;
                }

                TimeSpan jamBerangkat = TimeSpan.Parse(cmbJamBerangkat.SelectedItem.ToString());
                TimeSpan jamTiba = RouteHelper.HitungJamTiba(asal, tujuan, jamBerangkat);

                decimal hargaDasar = RouteHelper.HitungHarga(asal, tujuan);
                string kategoriMember = lblKategori.Text;

                decimal hargaAkhir = RouteHelper.HitungHargaDiskon(hargaDasar, kategoriMember);

                lblJamTiba.Text = jamTiba.ToString(@"hh\:mm");
                lblHarga.Text = "Rp " + hargaAkhir.ToString("N0");
            }
        }

        private bool IsSeatAvailable(string busKode, int noBangku, string tanggal)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM bookings WHERE bus_kode = @bus AND no_bangku = @seat AND DATE(tanggal_perjalanan) = @tgl";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@bus", busKode);
                    cmd.Parameters.AddWithValue("@seat", noBangku);
                    cmd.Parameters.AddWithValue("@tgl", tanggal);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0;
                }
            }
            catch (Exception) { return false; }
        }

        private void btnCetakTiket_Click(object sender, EventArgs e)
        {
            // Validasi Input
            if (lblNamaMember.Text == "-" || lblHarga.Text == "Rp 0" || lblHarga.Text == "Rute Invalid")
            {
                MessageBox.Show("Pastikan Member sudah discan dan Rute valid!");
                return;
            }
            if (cmbBus.SelectedItem == null || cmbBangku.SelectedItem == null)
            {
                MessageBox.Show("Mohon pilih Armada Bus dan Nomor Bangku!");
                return;
            }

            string nama = lblNamaMember.Text;
            string nik = lblNIK.Text;
            string kategoriMember = lblKategori.Text;
            string emailMember = "-";

            // Ambil Email
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string queryEmail = "SELECT email FROM members WHERE nik = @nik LIMIT 1";
                    MySqlCommand cmdEmail = new MySqlCommand(queryEmail, conn);
                    cmdEmail.Parameters.AddWithValue("@nik", nik);
                    object result = cmdEmail.ExecuteScalar();
                    if (result != null) emailMember = result.ToString();
                }
            }
            catch (Exception) { }

            string asal = cmbAsal.SelectedItem.ToString();
            string tujuan = cmbTujuan.SelectedItem.ToString();
            string jamB = cmbJamBerangkat.SelectedItem.ToString();
            string jamT = lblJamTiba.Text;
            string hargaStr = lblHarga.Text;

            string busKode = cmbBus.SelectedItem.ToString();
            int noBangku = int.Parse(cmbBangku.SelectedItem.ToString());
            string tglSekarang = DateTime.Now.ToString("yyyy-MM-dd");

            // Cek Ketersediaan Kursi
            if (!IsSeatAvailable(busKode, noBangku, tglSekarang))
            {
                MessageBox.Show($"Maaf, Kursi No {noBangku} di Bus {busKode} sudah terisi untuk hari ini!", "Kursi Penuh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal hargaRaw = decimal.Parse(hargaStr.Replace("Rp ", "").Replace(".", ""));

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO bookings (member_nik, asal, tujuan, bus_kode, no_bangku, jam_berangkat, jam_tiba, tanggal_perjalanan, harga) VALUES (@nik, @asal, @tujuan, @bus, @seat, @jb, @jt, CURDATE(), @harga)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nik", nik);
                    cmd.Parameters.AddWithValue("@asal", asal);
                    cmd.Parameters.AddWithValue("@tujuan", tujuan);
                    cmd.Parameters.AddWithValue("@bus", busKode);
                    cmd.Parameters.AddWithValue("@seat", noBangku);
                    cmd.Parameters.AddWithValue("@jb", jamB);
                    cmd.Parameters.AddWithValue("@jt", jamT);
                    cmd.Parameters.AddWithValue("@harga", hargaRaw);
                    cmd.ExecuteNonQuery();
                }

                CetakPDF(nama, nik, emailMember, asal, tujuan, jamB, jamT, hargaStr, kategoriMember, busKode, noBangku.ToString());

                MessageBox.Show("Tiket Berhasil Dicetak!");
                LoadDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Proses Tiket: " + ex.Message);
            }
        }

        // --- FUNGSI CETAK PDF (TIKET) ---
        private void CetakPDF(string nama, string nik, string email, string asal, string tujuan, string jamB, string jamT, string harga, string kategoriMember, string busKode, string noBangku)
        {
            try
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A5.Rotate(), 10, 10, 10, 10);
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Tiket_MKCIFRABS_{nama}_{DateTime.Now.Ticks}.pdf");

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();

                var headerFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 14, iTextSharp.text.BaseColor.WHITE);
                var labelFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 9, iTextSharp.text.BaseColor.GRAY);
                var valueFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 11, iTextSharp.text.BaseColor.BLACK);
                var priceFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 16, iTextSharp.text.BaseColor.RED);
                var brandColor = new iTextSharp.text.BaseColor(0, 102, 204);

                PdfPTable mainTable = new PdfPTable(1);
                mainTable.WidthPercentage = 100;
                mainTable.KeepTogether = true;

                // --- HEADER ---
                PdfPCell cellHeader = new PdfPCell(new iTextSharp.text.Phrase("MKCI FRABS EXECUTIVE BUS - BOARDING PASS", headerFont));
                cellHeader.BackgroundColor = brandColor;
                cellHeader.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                cellHeader.Padding = 8;
                cellHeader.BorderWidth = 0;
                mainTable.AddCell(cellHeader);

                // --- KONTEN TIKET ---
                PdfPTable contentTable = new PdfPTable(2);
                contentTable.WidthPercentage = 100;
                contentTable.SetWidths(new float[] { 1f, 1f });

                PdfPCell CreateCell(string label, string value, iTextSharp.text.Font valFont)
                {
                    PdfPTable cTable = new PdfPTable(1);
                    cTable.AddCell(new PdfPCell(new iTextSharp.text.Phrase(label, labelFont)) { Border = 0 });
                    cTable.AddCell(new PdfPCell(new iTextSharp.text.Phrase(value, valFont)) { Border = 0, PaddingBottom = 4 });

                    PdfPCell wrapper = new PdfPCell(cTable);
                    wrapper.Border = 0;
                    wrapper.Padding = 6;
                    wrapper.BorderWidthBottom = 0.5f;
                    wrapper.BorderColorBottom = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    return wrapper;
                }

                // Kolom Kiri (Penumpang)
                PdfPTable leftTable = new PdfPTable(1);
                leftTable.AddCell(new PdfPCell(new iTextSharp.text.Phrase("DATA PENUMPANG", labelFont)) { Border = 0, PaddingTop = 5, PaddingLeft = 6 });

                leftTable.AddCell(CreateCell("NIK", nik, valueFont));
                leftTable.AddCell(CreateCell("Nama Penumpang", nama.ToUpper(), valueFont));
                leftTable.AddCell(CreateCell("Email", email, valueFont));

                string kategoriDisplay = string.IsNullOrEmpty(kategoriMember) || kategoriMember == "-" ? "REGULER" : kategoriMember.ToUpper();
                leftTable.AddCell(CreateCell("Kategori Tiket", kategoriDisplay, valueFont));
                leftTable.AddCell(CreateCell("Armada Bus", busKode, valueFont));

                PdfPCell leftCell = new PdfPCell(leftTable);
                leftCell.BorderWidthRight = 1;
                leftCell.BorderWidthTop = 0; leftCell.BorderWidthBottom = 0; leftCell.BorderWidthLeft = 0;
                leftCell.BorderColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                contentTable.AddCell(leftCell);

                // Kolom Kanan (Perjalanan)
                PdfPTable rightTable = new PdfPTable(1);
                rightTable.AddCell(new PdfPCell(new iTextSharp.text.Phrase("DETAIL PERJALANAN", labelFont)) { Border = 0, PaddingTop = 5, PaddingLeft = 6 });
                rightTable.AddCell(CreateCell("Rute Perjalanan", $"{asal}  >>  {tujuan}", valueFont));
                rightTable.AddCell(CreateCell("Tanggal Keberangkatan", DateTime.Now.ToString("dddd, dd MMMM yyyy"), valueFont));
                rightTable.AddCell(CreateCell("Waktu", $"Berangkat: {jamB} WIB  |  Estimasi Tiba: {jamT} WIB", valueFont));
                rightTable.AddCell(CreateCell("Nomor Kursi", noBangku, priceFont));
                rightTable.AddCell(CreateCell("Total Harga", harga, priceFont));

                PdfPCell rightCell = new PdfPCell(rightTable);
                rightCell.Border = 0;
                contentTable.AddCell(rightCell);

                PdfPCell contentWrapper = new PdfPCell(contentTable);
                contentWrapper.Padding = 2;
                mainTable.AddCell(contentWrapper);

                // --- FOOTER BARCODE ---
                PdfPTable footerTable = new PdfPTable(1);
                footerTable.DefaultCell.Border = 0;
                footerTable.DefaultCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;

                Barcode128 barcode = new Barcode128();
                barcode.CodeType = Barcode.CODE128;
                barcode.Code = "BUS-" + DateTime.Now.Ticks.ToString().Substring(10);
                barcode.Font = null;

                iTextSharp.text.Image imgBarcode = barcode.CreateImageWithBarcode(writer.DirectContent, iTextSharp.text.BaseColor.BLACK, iTextSharp.text.BaseColor.GRAY);
                imgBarcode.ScalePercent(120);

                PdfPCell barcodeCell = new PdfPCell(imgBarcode);
                barcodeCell.Border = 0;
                barcodeCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                barcodeCell.PaddingTop = 5;
                barcodeCell.PaddingBottom = 5;

                footerTable.AddCell(barcodeCell);
                footerTable.AddCell(new iTextSharp.text.Phrase("*Harap datang 30 menit sebelum keberangkatan.", labelFont));

                PdfPCell footerWrapper = new PdfPCell(footerTable);
                footerWrapper.BorderWidthTop = 1;
                footerWrapper.BorderWidthBottom = 0; footerWrapper.BorderWidthLeft = 0; footerWrapper.BorderWidthRight = 0;
                footerWrapper.PaddingTop = 20;
                footerWrapper.PaddingBottom = 5;
                footerWrapper.PaddingLeft = 5;
                footerWrapper.PaddingRight = 5;

                mainTable.AddCell(footerWrapper);

                doc.Add(mainTable);
                doc.Close();

                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex) { MessageBox.Show("Gagal membuat PDF: " + ex.Message); }
        }

        // --- FUNGSI UTILITIES (CONTEXT MENU, HAPUS) ---
        private void SetupContextMenu()
        {
            ContextMenuStrip menuMember = new ContextMenuStrip();
            ToolStripMenuItem itemHapusMember = new ToolStripMenuItem("Hapus Member Ini");
            itemHapusMember.Click += ItemHapusMember_Click;
            itemHapusMember.Image = SystemIcons.Error.ToBitmap();
            menuMember.Items.Add(itemHapusMember);
            gridMembers.ContextMenuStrip = menuMember;

            ContextMenuStrip menuRiwayat = new ContextMenuStrip();
            ToolStripMenuItem itemHapusRiwayat = new ToolStripMenuItem("Hapus Riwayat Ini");
            itemHapusRiwayat.Click += ItemHapusRiwayat_Click;
            itemHapusRiwayat.Image = SystemIcons.Error.ToBitmap();
            menuRiwayat.Items.Add(itemHapusRiwayat);
            gridRiwayat.ContextMenuStrip = menuRiwayat;
        }

        private void ItemHapusMember_Click(object sender, EventArgs e)
        {
            if (gridMembers.CurrentRow == null || gridMembers.CurrentRow.Index == -1) return;
            string nikTarget = gridMembers.CurrentRow.Cells["NIK"].Value.ToString();
            string namaTarget = gridMembers.CurrentRow.Cells["Nama"].Value.ToString();

            if (MessageBox.Show($"Hapus Member: {namaTarget}?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        new MySqlCommand($"DELETE FROM bookings WHERE member_nik = '{nikTarget}'", conn).ExecuteNonQuery();
                        new MySqlCommand($"DELETE FROM members WHERE nik = '{nikTarget}'", conn).ExecuteNonQuery();
                    }
                    MessageBox.Show("Data dihapus!");
                    LoadDashboard();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void ItemHapusRiwayat_Click(object sender, EventArgs e)
        {
            if (gridRiwayat.CurrentRow == null || gridRiwayat.CurrentRow.Index == -1) return;
            string idBooking = gridRiwayat.CurrentRow.Cells["ID"].Value.ToString();

            if (MessageBox.Show($"Hapus riwayat ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        new MySqlCommand($"DELETE FROM bookings WHERE id = {idBooking}", conn).ExecuteNonQuery();
                    }
                    MessageBox.Show("Riwayat dihapus!");
                    LoadDashboard();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}