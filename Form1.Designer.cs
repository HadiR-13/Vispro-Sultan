namespace Mkci_Frabs
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.panelDashContent = new System.Windows.Forms.Panel();
            this.grpRiwayat = new System.Windows.Forms.GroupBox();
            this.gridRiwayat = new System.Windows.Forms.DataGridView();
            this.panelSearchRiwayat = new System.Windows.Forms.Panel();
            this.btnSearchRiwayat = new System.Windows.Forms.Button();
            this.txtSearchRiwayat = new System.Windows.Forms.TextBox();
            this.lblSearchRiwayat = new System.Windows.Forms.Label();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.gridMembers = new System.Windows.Forms.DataGridView();
            this.panelSearchMember = new System.Windows.Forms.Panel();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.lblSearchMember = new System.Windows.Forms.Label();
            this.panelHeaderDash = new System.Windows.Forms.Panel();
            this.lblJudulDash = new System.Windows.Forms.Label();
            this.tabRegistrasi = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelReg = new System.Windows.Forms.TableLayoutPanel();
            this.grpInputMember = new System.Windows.Forms.GroupBox();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpQR = new System.Windows.Forms.GroupBox();
            this.picQRPreview = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPemesanan = new System.Windows.Forms.TabPage();
            this.panelBookingContent = new System.Windows.Forms.Panel();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnCetakTiket = new System.Windows.Forms.Button();
            this.grpDetailPerjalanan = new System.Windows.Forms.GroupBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblJamTiba = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbJamBerangkat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTujuan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAsal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.labelBus = new System.Windows.Forms.Label();
            this.cmbBangku = new System.Windows.Forms.ComboBox();
            this.labelBangku = new System.Windows.Forms.Label();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNIK = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNamaMember = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelScan = new System.Windows.Forms.Panel();
            this.txtScanInput = new System.Windows.Forms.TextBox();
            this.picWebcam = new System.Windows.Forms.PictureBox();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.panelDashContent.SuspendLayout();
            this.grpRiwayat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRiwayat)).BeginInit();
            this.panelSearchRiwayat.SuspendLayout();
            this.grpMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            this.panelSearchMember.SuspendLayout();
            this.panelHeaderDash.SuspendLayout();
            this.tabRegistrasi.SuspendLayout();
            this.tableLayoutPanelReg.SuspendLayout();
            this.grpInputMember.SuspendLayout();
            this.grpQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRPreview)).BeginInit();
            this.tabPemesanan.SuspendLayout();
            this.panelBookingContent.SuspendLayout();
            this.grpDetailPerjalanan.SuspendLayout();
            this.grpMemberInfo.SuspendLayout();
            this.panelScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabDashboard);
            this.tabControlMain.Controls.Add(this.tabRegistrasi);
            this.tabControlMain.Controls.Add(this.tabPemesanan);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1283, 926);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.panelDashContent);
            this.tabDashboard.Controls.Add(this.panelHeaderDash);
            this.tabDashboard.Location = new System.Drawing.Point(4, 37);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDashboard.Size = new System.Drawing.Size(1275, 885);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // panelDashContent
            // 
            this.panelDashContent.Controls.Add(this.grpRiwayat);
            this.panelDashContent.Controls.Add(this.grpMembers);
            this.panelDashContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashContent.Location = new System.Drawing.Point(3, 79);
            this.panelDashContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDashContent.Name = "panelDashContent";
            this.panelDashContent.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panelDashContent.Size = new System.Drawing.Size(1269, 802);
            this.panelDashContent.TabIndex = 1;
            // 
            // grpRiwayat
            // 
            this.grpRiwayat.Controls.Add(this.gridRiwayat);
            this.grpRiwayat.Controls.Add(this.panelSearchRiwayat);
            this.grpRiwayat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRiwayat.Location = new System.Drawing.Point(11, 324);
            this.grpRiwayat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRiwayat.Name = "grpRiwayat";
            this.grpRiwayat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRiwayat.Size = new System.Drawing.Size(1247, 466);
            this.grpRiwayat.TabIndex = 1;
            this.grpRiwayat.TabStop = false;
            this.grpRiwayat.Text = "Riwayat Perjalanan";
            // 
            // gridRiwayat
            // 
            this.gridRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRiwayat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRiwayat.Location = new System.Drawing.Point(3, 93);
            this.gridRiwayat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridRiwayat.Name = "gridRiwayat";
            this.gridRiwayat.RowHeadersWidth = 62;
            this.gridRiwayat.Size = new System.Drawing.Size(1241, 369);
            this.gridRiwayat.TabIndex = 1;
            // 
            // panelSearchRiwayat
            // 
            this.panelSearchRiwayat.Controls.Add(this.btnSearchRiwayat);
            this.panelSearchRiwayat.Controls.Add(this.txtSearchRiwayat);
            this.panelSearchRiwayat.Controls.Add(this.lblSearchRiwayat);
            this.panelSearchRiwayat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchRiwayat.Location = new System.Drawing.Point(3, 31);
            this.panelSearchRiwayat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSearchRiwayat.Name = "panelSearchRiwayat";
            this.panelSearchRiwayat.Size = new System.Drawing.Size(1241, 62);
            this.panelSearchRiwayat.TabIndex = 0;
            // 
            // btnSearchRiwayat
            // 
            this.btnSearchRiwayat.BackColor = System.Drawing.Color.Teal;
            this.btnSearchRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRiwayat.ForeColor = System.Drawing.Color.White;
            this.btnSearchRiwayat.Location = new System.Drawing.Point(472, 10);
            this.btnSearchRiwayat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchRiwayat.Name = "btnSearchRiwayat";
            this.btnSearchRiwayat.Size = new System.Drawing.Size(112, 40);
            this.btnSearchRiwayat.TabIndex = 2;
            this.btnSearchRiwayat.Text = "Cari";
            this.btnSearchRiwayat.UseVisualStyleBackColor = false;
            // 
            // txtSearchRiwayat
            // 
            this.txtSearchRiwayat.Location = new System.Drawing.Point(180, 12);
            this.txtSearchRiwayat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchRiwayat.Name = "txtSearchRiwayat";
            this.txtSearchRiwayat.Size = new System.Drawing.Size(281, 34);
            this.txtSearchRiwayat.TabIndex = 1;
            // 
            // lblSearchRiwayat
            // 
            this.lblSearchRiwayat.AutoSize = true;
            this.lblSearchRiwayat.Location = new System.Drawing.Point(11, 16);
            this.lblSearchRiwayat.Name = "lblSearchRiwayat";
            this.lblSearchRiwayat.Size = new System.Drawing.Size(146, 28);
            this.lblSearchRiwayat.TabIndex = 0;
            this.lblSearchRiwayat.Text = "Cari Tujuan/Tgl:";
            // 
            // grpMembers
            // 
            this.grpMembers.Controls.Add(this.gridMembers);
            this.grpMembers.Controls.Add(this.panelSearchMember);
            this.grpMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMembers.Location = new System.Drawing.Point(11, 12);
            this.grpMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMembers.Size = new System.Drawing.Size(1247, 312);
            this.grpMembers.TabIndex = 0;
            this.grpMembers.TabStop = false;
            this.grpMembers.Text = "Member";
            // 
            // gridMembers
            // 
            this.gridMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMembers.Location = new System.Drawing.Point(3, 93);
            this.gridMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridMembers.Name = "gridMembers";
            this.gridMembers.RowHeadersWidth = 62;
            this.gridMembers.Size = new System.Drawing.Size(1241, 215);
            this.gridMembers.TabIndex = 1;
            // 
            // panelSearchMember
            // 
            this.panelSearchMember.Controls.Add(this.btnSearchMember);
            this.panelSearchMember.Controls.Add(this.txtSearchMember);
            this.panelSearchMember.Controls.Add(this.lblSearchMember);
            this.panelSearchMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchMember.Location = new System.Drawing.Point(3, 31);
            this.panelSearchMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSearchMember.Name = "panelSearchMember";
            this.panelSearchMember.Size = new System.Drawing.Size(1241, 62);
            this.panelSearchMember.TabIndex = 0;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.BackColor = System.Drawing.Color.Teal;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.ForeColor = System.Drawing.Color.White;
            this.btnSearchMember.Location = new System.Drawing.Point(472, 10);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(112, 40);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Cari";
            this.btnSearchMember.UseVisualStyleBackColor = false;
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(180, 12);
            this.txtSearchMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(281, 34);
            this.txtSearchMember.TabIndex = 1;
            // 
            // lblSearchMember
            // 
            this.lblSearchMember.AutoSize = true;
            this.lblSearchMember.Location = new System.Drawing.Point(11, 16);
            this.lblSearchMember.Name = "lblSearchMember";
            this.lblSearchMember.Size = new System.Drawing.Size(147, 28);
            this.lblSearchMember.TabIndex = 0;
            this.lblSearchMember.Text = "Cari Nama/NIK:";
            // 
            // panelHeaderDash
            // 
            this.panelHeaderDash.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelHeaderDash.Controls.Add(this.lblJudulDash);
            this.panelHeaderDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderDash.ForeColor = System.Drawing.Color.White;
            this.panelHeaderDash.Location = new System.Drawing.Point(3, 4);
            this.panelHeaderDash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeaderDash.Name = "panelHeaderDash";
            this.panelHeaderDash.Size = new System.Drawing.Size(1269, 75);
            this.panelHeaderDash.TabIndex = 0;
            // 
            // lblJudulDash
            // 
            this.lblJudulDash.AutoSize = true;
            this.lblJudulDash.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudulDash.Location = new System.Drawing.Point(17, 14);
            this.lblJudulDash.Name = "lblJudulDash";
            this.lblJudulDash.Size = new System.Drawing.Size(690, 45);
            this.lblJudulDash.TabIndex = 0;
            this.lblJudulDash.Text = "DASHBOARD - MKCI FRABS EXECUTIVE BUS";
            // 
            // tabRegistrasi
            // 
            this.tabRegistrasi.Controls.Add(this.tableLayoutPanelReg);
            this.tabRegistrasi.Location = new System.Drawing.Point(4, 37);
            this.tabRegistrasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRegistrasi.Name = "tabRegistrasi";
            this.tabRegistrasi.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRegistrasi.Size = new System.Drawing.Size(1275, 885);
            this.tabRegistrasi.TabIndex = 1;
            this.tabRegistrasi.Text = "Registrasi Member";
            this.tabRegistrasi.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelReg
            // 
            this.tableLayoutPanelReg.ColumnCount = 2;
            this.tableLayoutPanelReg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReg.Controls.Add(this.grpInputMember, 0, 0);
            this.tableLayoutPanelReg.Controls.Add(this.grpQR, 1, 0);
            this.tableLayoutPanelReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelReg.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanelReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelReg.Name = "tableLayoutPanelReg";
            this.tableLayoutPanelReg.RowCount = 1;
            this.tableLayoutPanelReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReg.Size = new System.Drawing.Size(1269, 877);
            this.tableLayoutPanelReg.TabIndex = 0;
            // 
            // grpInputMember
            // 
            this.grpInputMember.Controls.Add(this.btnDaftar);
            this.grpInputMember.Controls.Add(this.btnNewMember);
            this.grpInputMember.Controls.Add(this.cmbKategori);
            this.grpInputMember.Controls.Add(this.label4);
            this.grpInputMember.Controls.Add(this.txtEmail);
            this.grpInputMember.Controls.Add(this.label3);
            this.grpInputMember.Controls.Add(this.txtNIK);
            this.grpInputMember.Controls.Add(this.label2);
            this.grpInputMember.Controls.Add(this.txtNama);
            this.grpInputMember.Controls.Add(this.label1);
            this.grpInputMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInputMember.Location = new System.Drawing.Point(3, 4);
            this.grpInputMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInputMember.Name = "grpInputMember";
            this.grpInputMember.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInputMember.Size = new System.Drawing.Size(628, 869);
            this.grpInputMember.TabIndex = 0;
            this.grpInputMember.TabStop = false;
            this.grpInputMember.Text = "Data Diri Member";
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDaftar.ForeColor = System.Drawing.Color.White;
            this.btnDaftar.Location = new System.Drawing.Point(26, 438);
            this.btnDaftar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(461, 56);
            this.btnDaftar.TabIndex = 8;
            this.btnDaftar.Text = "Daftarkan Member";
            this.btnDaftar.UseVisualStyleBackColor = false;
            // 
            // btnNewMember
            // 
            this.btnNewMember.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewMember.ForeColor = System.Drawing.Color.White;
            this.btnNewMember.Location = new System.Drawing.Point(26, 506);
            this.btnNewMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(461, 50);
            this.btnNewMember.TabIndex = 9;
            this.btnNewMember.Text = "Reset / Data Baru";
            this.btnNewMember.UseVisualStyleBackColor = false;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Karyawan",
            "Mahasiswa",
            "Reguler"});
            this.cmbKategori.Location = new System.Drawing.Point(26, 274);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(461, 36);
            this.cmbKategori.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 365);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(461, 34);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtNIK
            // 
            this.txtNIK.Location = new System.Drawing.Point(26, 185);
            this.txtNIK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(461, 34);
            this.txtNIK.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIK";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(26, 95);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(461, 34);
            this.txtNama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Lengkap";
            // 
            // grpQR
            // 
            this.grpQR.Controls.Add(this.picQRPreview);
            this.grpQR.Controls.Add(this.label5);
            this.grpQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpQR.Location = new System.Drawing.Point(637, 4);
            this.grpQR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpQR.Name = "grpQR";
            this.grpQR.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpQR.Size = new System.Drawing.Size(629, 869);
            this.grpQR.TabIndex = 1;
            this.grpQR.TabStop = false;
            this.grpQR.Text = "Generated QR Code";
            // 
            // picQRPreview
            // 
            this.picQRPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQRPreview.Location = new System.Drawing.Point(93, 95);
            this.picQRPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picQRPreview.Name = "picQRPreview";
            this.picQRPreview.Size = new System.Drawing.Size(337, 374);
            this.picQRPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRPreview.TabIndex = 1;
            this.picQRPreview.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(89, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 56);
            this.label5.TabIndex = 0;
            this.label5.Text = "QR Code akan muncul di sini setelah \r\ntombol daftar diklik.";
            // 
            // tabPemesanan
            // 
            this.tabPemesanan.Controls.Add(this.panelBookingContent);
            this.tabPemesanan.Controls.Add(this.panelScan);
            this.tabPemesanan.Location = new System.Drawing.Point(4, 37);
            this.tabPemesanan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPemesanan.Name = "tabPemesanan";
            this.tabPemesanan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPemesanan.Size = new System.Drawing.Size(1275, 885);
            this.tabPemesanan.TabIndex = 2;
            this.tabPemesanan.Text = "Pemesanan Tiket";
            this.tabPemesanan.UseVisualStyleBackColor = true;
            // 
            // panelBookingContent
            // 
            this.panelBookingContent.Controls.Add(this.btnNewBooking);
            this.panelBookingContent.Controls.Add(this.btnCetakTiket);
            this.panelBookingContent.Controls.Add(this.grpDetailPerjalanan);
            this.panelBookingContent.Controls.Add(this.grpMemberInfo);
            this.panelBookingContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookingContent.Location = new System.Drawing.Point(3, 179);
            this.panelBookingContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBookingContent.Name = "panelBookingContent";
            this.panelBookingContent.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.panelBookingContent.Size = new System.Drawing.Size(1269, 702);
            this.panelBookingContent.TabIndex = 1;
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewBooking.BackColor = System.Drawing.Color.DimGray;
            this.btnNewBooking.FlatAppearance.BorderSize = 0;
            this.btnNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnNewBooking.Location = new System.Drawing.Point(22, 544);
            this.btnNewBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(1224, 50);
            this.btnNewBooking.TabIndex = 3;
            this.btnNewBooking.Text = "Reset / Booking Baru";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            // 
            // btnCetakTiket
            // 
            this.btnCetakTiket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCetakTiket.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCetakTiket.FlatAppearance.BorderSize = 0;
            this.btnCetakTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetakTiket.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCetakTiket.ForeColor = System.Drawing.Color.White;
            this.btnCetakTiket.Location = new System.Drawing.Point(22, 606);
            this.btnCetakTiket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCetakTiket.Name = "btnCetakTiket";
            this.btnCetakTiket.Size = new System.Drawing.Size(1224, 75);
            this.btnCetakTiket.TabIndex = 2;
            this.btnCetakTiket.Text = "CETAK TIKET SEKARANG";
            this.btnCetakTiket.UseVisualStyleBackColor = false;
            // 
            // grpDetailPerjalanan
            // 
            this.grpDetailPerjalanan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetailPerjalanan.Controls.Add(this.lblHarga);
            this.grpDetailPerjalanan.Controls.Add(this.label13);
            this.grpDetailPerjalanan.Controls.Add(this.lblJamTiba);
            this.grpDetailPerjalanan.Controls.Add(this.label11);
            this.grpDetailPerjalanan.Controls.Add(this.cmbJamBerangkat);
            this.grpDetailPerjalanan.Controls.Add(this.label10);
            this.grpDetailPerjalanan.Controls.Add(this.cmbTujuan);
            this.grpDetailPerjalanan.Controls.Add(this.label9);
            this.grpDetailPerjalanan.Controls.Add(this.cmbAsal);
            this.grpDetailPerjalanan.Controls.Add(this.label8);
            this.grpDetailPerjalanan.Controls.Add(this.cmbBus);
            this.grpDetailPerjalanan.Controls.Add(this.labelBus);
            this.grpDetailPerjalanan.Controls.Add(this.cmbBangku);
            this.grpDetailPerjalanan.Controls.Add(this.labelBangku);
            this.grpDetailPerjalanan.Location = new System.Drawing.Point(22, 225);
            this.grpDetailPerjalanan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDetailPerjalanan.Name = "grpDetailPerjalanan";
            this.grpDetailPerjalanan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDetailPerjalanan.Size = new System.Drawing.Size(1224, 300);
            this.grpDetailPerjalanan.TabIndex = 1;
            this.grpDetailPerjalanan.TabStop = false;
            this.grpDetailPerjalanan.Text = "Detail Perjalanan";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHarga.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHarga.Location = new System.Drawing.Point(781, 189);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(130, 65);
            this.lblHarga.TabIndex = 9;
            this.lblHarga.Text = "Rp 0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(786, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 28);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Harga:";
            // 
            // lblJamTiba
            // 
            this.lblJamTiba.AutoSize = true;
            this.lblJamTiba.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJamTiba.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblJamTiba.Location = new System.Drawing.Point(783, 89);
            this.lblJamTiba.Name = "lblJamTiba";
            this.lblJamTiba.Size = new System.Drawing.Size(101, 45);
            this.lblJamTiba.TabIndex = 7;
            this.lblJamTiba.Text = "00:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(786, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "Estimasi Jam Tiba:";
            // 
            // cmbJamBerangkat
            // 
            this.cmbJamBerangkat.FormattingEnabled = true;
            this.cmbJamBerangkat.Items.AddRange(new object[] {
            "07:00",
            "09:00",
            "13:00",
            "15:00",
            "20:00"});
            this.cmbJamBerangkat.Location = new System.Drawing.Point(29, 225);
            this.cmbJamBerangkat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbJamBerangkat.Name = "cmbJamBerangkat";
            this.cmbJamBerangkat.Size = new System.Drawing.Size(253, 36);
            this.cmbJamBerangkat.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Jam Berangkat";
            // 
            // cmbTujuan
            // 
            this.cmbTujuan.FormattingEnabled = true;
            this.cmbTujuan.Items.AddRange(new object[] {
            "Rantauprapat",
            "Aek Kanopan",
            "Kisaran",
            "Tebing Tinggi",
            "Lubuk Pakam",
            "Medan"});
            this.cmbTujuan.Location = new System.Drawing.Point(29, 150);
            this.cmbTujuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTujuan.Name = "cmbTujuan";
            this.cmbTujuan.Size = new System.Drawing.Size(393, 36);
            this.cmbTujuan.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kota Tujuan";
            // 
            // cmbAsal
            // 
            this.cmbAsal.FormattingEnabled = true;
            this.cmbAsal.Items.AddRange(new object[] {
            "Rantauprapat",
            "Aek Kanopan",
            "Kisaran",
            "Tebing Tinggi",
            "Lubuk Pakam",
            "Medan"});
            this.cmbAsal.Location = new System.Drawing.Point(29, 75);
            this.cmbAsal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAsal.Name = "cmbAsal";
            this.cmbAsal.Size = new System.Drawing.Size(393, 36);
            this.cmbAsal.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kota Asal";
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(454, 75);
            this.cmbBus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(180, 36);
            this.cmbBus.TabIndex = 11;
            // 
            // labelBus
            // 
            this.labelBus.AutoSize = true;
            this.labelBus.Location = new System.Drawing.Point(450, 44);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(88, 28);
            this.labelBus.TabIndex = 10;
            this.labelBus.Text = "Pilih Bus:";
            // 
            // cmbBangku
            // 
            this.cmbBangku.FormattingEnabled = true;
            this.cmbBangku.Location = new System.Drawing.Point(454, 150);
            this.cmbBangku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBangku.Name = "cmbBangku";
            this.cmbBangku.Size = new System.Drawing.Size(180, 36);
            this.cmbBangku.TabIndex = 13;
            // 
            // labelBangku
            // 
            this.labelBangku.AutoSize = true;
            this.labelBangku.Location = new System.Drawing.Point(450, 119);
            this.labelBangku.Name = "labelBangku";
            this.labelBangku.Size = new System.Drawing.Size(117, 28);
            this.labelBangku.TabIndex = 12;
            this.labelBangku.Text = "No. Bangku:";
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblKategori);
            this.grpMemberInfo.Controls.Add(this.label14);
            this.grpMemberInfo.Controls.Add(this.lblNIK);
            this.grpMemberInfo.Controls.Add(this.label12);
            this.grpMemberInfo.Controls.Add(this.lblNamaMember);
            this.grpMemberInfo.Controls.Add(this.label7);
            this.grpMemberInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMemberInfo.Location = new System.Drawing.Point(22, 25);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMemberInfo.Size = new System.Drawing.Size(1225, 175);
            this.grpMemberInfo.TabIndex = 0;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Informasi Member (Hasil Scan)";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKategori.Location = new System.Drawing.Point(920, 94);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(24, 32);
            this.lblKategori.TabIndex = 5;
            this.lblKategori.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(921, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 28);
            this.label14.TabIndex = 4;
            this.label14.Text = "Kategori:";
            // 
            // lblNIK
            // 
            this.lblNIK.AutoSize = true;
            this.lblNIK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNIK.Location = new System.Drawing.Point(512, 94);
            this.lblNIK.Name = "lblNIK";
            this.lblNIK.Size = new System.Drawing.Size(24, 32);
            this.lblNIK.TabIndex = 3;
            this.lblNIK.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(513, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 28);
            this.label12.TabIndex = 2;
            this.label12.Text = "NIK:";
            // 
            // lblNamaMember
            // 
            this.lblNamaMember.AutoSize = true;
            this.lblNamaMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNamaMember.Location = new System.Drawing.Point(25, 94);
            this.lblNamaMember.Name = "lblNamaMember";
            this.lblNamaMember.Size = new System.Drawing.Size(24, 32);
            this.lblNamaMember.TabIndex = 1;
            this.lblNamaMember.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(25, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nama:";
            // 
            // panelScan
            // 
            this.panelScan.BackColor = System.Drawing.Color.Gainsboro;
            this.panelScan.Controls.Add(this.txtScanInput);
            this.panelScan.Controls.Add(this.picWebcam);
            this.panelScan.Controls.Add(this.btnStartCamera);
            this.panelScan.Controls.Add(this.cmbCamera);
            this.panelScan.Controls.Add(this.label6);
            this.panelScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelScan.Location = new System.Drawing.Point(3, 4);
            this.panelScan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelScan.Name = "panelScan";
            this.panelScan.Size = new System.Drawing.Size(1269, 175);
            this.panelScan.TabIndex = 0;
            // 
            // txtScanInput
            // 
            this.txtScanInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtScanInput.Location = new System.Drawing.Point(540, 62);
            this.txtScanInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScanInput.Name = "txtScanInput";
            this.txtScanInput.Size = new System.Drawing.Size(706, 39);
            this.txtScanInput.TabIndex = 4;
            // 
            // picWebcam
            // 
            this.picWebcam.BackColor = System.Drawing.Color.Black;
            this.picWebcam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWebcam.Location = new System.Drawing.Point(338, 12);
            this.picWebcam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picWebcam.Name = "picWebcam";
            this.picWebcam.Size = new System.Drawing.Size(180, 150);
            this.picWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWebcam.TabIndex = 3;
            this.picWebcam.TabStop = false;
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.BackColor = System.Drawing.Color.DimGray;
            this.btnStartCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCamera.ForeColor = System.Drawing.Color.White;
            this.btnStartCamera.Location = new System.Drawing.Point(34, 100);
            this.btnStartCamera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(281, 50);
            this.btnStartCamera.TabIndex = 2;
            this.btnStartCamera.Text = "Mulai Kamera";
            this.btnStartCamera.UseVisualStyleBackColor = false;
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(34, 50);
            this.cmbCamera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(281, 36);
            this.cmbCamera.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(29, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pilih Webcam:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 926);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MKCI FRABS - Sistem Tiket Bus";
            this.tabControlMain.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.panelDashContent.ResumeLayout(false);
            this.grpRiwayat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRiwayat)).EndInit();
            this.panelSearchRiwayat.ResumeLayout(false);
            this.panelSearchRiwayat.PerformLayout();
            this.grpMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
            this.panelSearchMember.ResumeLayout(false);
            this.panelSearchMember.PerformLayout();
            this.panelHeaderDash.ResumeLayout(false);
            this.panelHeaderDash.PerformLayout();
            this.tabRegistrasi.ResumeLayout(false);
            this.tableLayoutPanelReg.ResumeLayout(false);
            this.grpInputMember.ResumeLayout(false);
            this.grpInputMember.PerformLayout();
            this.grpQR.ResumeLayout(false);
            this.grpQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRPreview)).EndInit();
            this.tabPemesanan.ResumeLayout(false);
            this.panelBookingContent.ResumeLayout(false);
            this.grpDetailPerjalanan.ResumeLayout(false);
            this.grpDetailPerjalanan.PerformLayout();
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.panelScan.ResumeLayout(false);
            this.panelScan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWebcam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabRegistrasi;
        private System.Windows.Forms.TabPage tabPemesanan;
        private System.Windows.Forms.Panel panelHeaderDash;
        private System.Windows.Forms.Label lblJudulDash;
        private System.Windows.Forms.Panel panelDashContent;
        private System.Windows.Forms.GroupBox grpRiwayat;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.DataGridView gridRiwayat;
        private System.Windows.Forms.DataGridView gridMembers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelReg;
        private System.Windows.Forms.GroupBox grpInputMember;
        private System.Windows.Forms.GroupBox grpQR;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNIK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.PictureBox picQRPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelScan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScanInput;
        private System.Windows.Forms.Panel panelBookingContent;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNamaMember;
        private System.Windows.Forms.GroupBox grpDetailPerjalanan;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNIK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbTujuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAsal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbJamBerangkat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblJamTiba;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCetakTiket;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.PictureBox picWebcam;
        private System.Windows.Forms.Panel panelSearchMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Label lblSearchMember;
        private System.Windows.Forms.Panel panelSearchRiwayat;
        private System.Windows.Forms.Button btnSearchRiwayat;
        private System.Windows.Forms.TextBox txtSearchRiwayat;
        private System.Windows.Forms.Label lblSearchRiwayat;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.ComboBox cmbBangku;
        private System.Windows.Forms.Label labelBangku;
    }
}