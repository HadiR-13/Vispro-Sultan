MKCI FRABS - Sistem Tiket Bus Eksekutif (Desktop)
MKCI FRABS adalah aplikasi desktop berbasis Windows Forms (C#) yang dirancang khusus untuk manajemen operasional dan pemesanan tiket bus rute Rantauprapat - Medan. Aplikasi ini mengintegrasikan teknologi modern seperti QR Code, Webcam Scanning, dan Dynamic PDF Generation untuk menciptakan pengalaman ticketing yang profesional dan efisien.

Fitur Unggulan
1. Dashboard Admin & Manajemen Data
Statistik Real-time: Memantau pendaftaran member baru dan riwayat perjalanan harian.
Advanced Search: Fitur pencarian cepat untuk menemukan data member (Nama/NIK) atau riwayat transaksi (Tujuan/Tanggal).
CRUD Data: Klik kanan pada tabel untuk menghapus data member atau membatalkan tiket yang salah input.
2. Keanggotaan (Membership)
Registrasi Cepat: Form input data (Nama, NIK, Email, Kategori).
QR Code Generator: Setiap member mendapatkan QR Code unik sebagai identitas.
Email Notification: Kartu member digital dikirim otomatis ke email pendaftar.
3. Sistem Pemesanan Cerdas (Smart Booking)
Webcam Scanning: Scan QR Code member langsung menggunakan kamera laptop/PC.
Manajemen Armada & Kursi:
Pilih Bus: Sistem otomatis menampilkan daftar armada yang tersedia berdasarkan Kota Keberangkatan (Misal: Bus Medan beda dengan Bus Rantauprapat).
Pilih Kursi: Dropdown pemilihan nomor kursi (1-55).
Validasi Kapasitas: Sistem mencegah double booking (kursi yang sudah dipesan tidak bisa dipilih lagi pada tanggal yang sama).
Kalkulasi Harga Otomatis:
Harga dihitung berdasarkan Jarak Rute.
Diskon Kategori: Karyawan (10%), Mahasiswa (25%), Reguler (Normal).
4. Boarding Pass Profesional
Format PDF A5: Desain tiket yang compact, hemat kertas, dan informatif.
Barcode 128: Dilengkapi barcode standar industri untuk keperluan gate checking.
Detail Lengkap: Memuat Nama, NIK, Armada Bus, Nomor Kursi, Waktu Berangkat/Tiba, dan Harga.

Teknologi
Bahasa: C# (.NET Framework 4.8 / .NET 6)
IDE: Microsoft Visual Studio 2022
Database: MySQL (via XAMPP/PhpMyAdmin)
External Libraries (NuGet):
MySql.Data (Koneksi Database)
QRCoder (Generate QR Code)
iTextSharp (Generate PDF Laporan & Tiket)
AForge.Video.DirectShow (Akses Webcam)
ZXing.Net (Membaca QR Code dari Gambar)

Persiapan Instalasi (Setup)
1. Setup Database (Wajib Update!)
Pastikan XAMPP aktif.
Buka http://localhost/phpmyadmin.
Buat database: db_mkci_frabs.
Jalankan SQL berikut (Struktur Terbaru):
CREATE DATABASE IF NOT EXISTS db_mkci_frabs;
USE db_mkci_frabs;

-- Tabel Member
CREATE TABLE members (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nik VARCHAR(20) NOT NULL UNIQUE,
    nama_lengkap VARCHAR(100) NOT NULL,
    kategori ENUM('Karyawan', 'Mahasiswa', 'Reguler') NOT NULL,
    email VARCHAR(100) NOT NULL,
    qr_code_data TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabel Transaksi / Booking (Updated)
CREATE TABLE bookings (
    id INT AUTO_INCREMENT PRIMARY KEY,
    member_nik VARCHAR(20),
    asal VARCHAR(50),
    tujuan VARCHAR(50),
    bus_kode VARCHAR(50) NOT NULL, -- Menyimpan Kode Bus (e.g., FRABS-RAP-01)
    no_bangku INT NOT NULL,        -- Menyimpan Nomor Kursi (1-55)
    jam_berangkat TIME,
    jam_tiba TIME,
    tanggal_perjalanan DATE,
    harga DECIMAL(10, 2),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (member_nik) REFERENCES members(nik) ON DELETE CASCADE
);
2. Konfigurasi Project
Buka Form1.cs.
Cek connectionString di bagian atas:
string connectionString = "server=localhost;user=root;database=db_mkci_frabs;port=3306;password=;";

(Isi password jika MySQL kamu menggunakan password).

3. Konfigurasi Email (Opsional)
Untuk fitur kirim email, gunakan Google App Password:
Edit method KirimEmailQR di Form1.cs.
Masukkan email Gmail dan App Password 16 digit kamu.

Cara Penggunaan
Registrasi: Masukkan data diri > Klik "Daftar". QR Code akan muncul dan dikirim ke email.
Scan Member: Masuk tab "Pemesanan" > Klik "Mulai Kamera" > Arahkan QR Code ke kamera. Data akan terisi otomatis.
Isi Detail Perjalanan:
Pilih Kota Asal & Tujuan.
Pilih Armada Bus (Otomatis muncul sesuai kota asal).
Pilih Nomor Kursi & Jam.
Cetak Tiket: Klik tombol "CETAK TIKET SEKARANG". PDF akan terbuka otomatis.
Reset: Gunakan tombol "Reset" berwarna oranye/abu-abu untuk membersihkan form dengan cepat.
🐛 Troubleshooting
Kamera Gelap/Tidak Muncul: Cek apakah ada aplikasi lain (Zoom/Meet) yang memakai kamera. Restart aplikasi jika perlu.
Error "Kursi Penuh": Artinya kursi nomor tersebut pada bus dan tanggal yang dipilih sudah ada di database. Pilih nomor lain.
Database Error: Pastikan XAMPP (MySQL) sudah di-start.

Project by Albert | MKCI FRABS - 2025

