# Vispro-Sultan

## 📌 What is Vispro-Sultan

Vispro-Sultan is a Windows Forms (C#) desktop application for managing executive-class bus ticketing and operations on the Rantauprapat ↔ Medan route. It brings together modern features like QR-code based member IDs, webcam scanning, and auto-generated PDF boarding passes — turning bus ticketing into a professional, efficient process.

## ✨ Key Features

* **Admin Dashboard & Real-Time Statistics** — Monitor new member registrations and daily travel histories.
* **Smart Booking & Seat Management** — Choose available buses, select seats, automatically prevent double bookings.
* **Membership System** — Quick registration of passengers (members), with unique QR codes and automatic email notifications.
* **QR-Code & Webcam Integration** — Verify member identity via webcam scan at boarding.
* **Automatic Price Calculation & Discounts** — Fare computed based on route distance; supports discount categories (e.g. employees, students).
* **Professional Boarding Pass as PDF (A5)** — Compact yet detailed tickets including passenger name, ID (NIK), bus code, seat number, departure/arrival, price, barcode etc.
* **Database-Backed** — Uses MySQL (via XAMPP/PhpMyAdmin) for storing member data, bookings, and transaction history.

## 🧰 Tech Stack

* Language / Framework: C# (.NET Framework 4.8 / .NET 6)
* IDE: Microsoft Visual Studio 2022
* Database: MySQL (via XAMPP / phpMyAdmin)
* Third-party Libraries (NuGet):

  * MySql.Data — Database connectivity
  * QRCoder — Generate QR codes
  * iTextSharp — Generate PDF tickets / reports
  * AForge.Video.DirectShow — Access webcam for QR scanning
  * ZXing.Net — Decode QR codes from images

## 🛠 Installation & Setup (for local development)

1. Ensure XAMPP is running (or another MySQL server).
2. Open `phpMyAdmin`, then create a database:

   ```sql
   CREATE DATABASE IF NOT EXISTS db_mkci_frabs;
   USE db_mkci_frabs;
   ```
3. Create the required tables. For example:

   ```sql
   CREATE TABLE members (
     id INT AUTO_INCREMENT PRIMARY KEY,
     nik VARCHAR(20) NOT NULL UNIQUE,
     nama_lengkap VARCHAR(100) NOT NULL,
     kategori ENUM('Karyawan', 'Mahasiswa', 'Reguler') NOT NULL,
     email VARCHAR(100) NOT NULL,
     qr_code_data TEXT,
     created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
   );
   ```

   And similarly for the `bookings` table.
4. Open the Visual Studio solution `Mkci_Frabs.sln`.
5. Adjust the connection string in `Form1.cs`, e.g.:

   ```csharp
   string connectionString = "server=localhost;user=root;database=db_mkci_frabs;port=3306;password=;";
   ```
6. Build and run the application.

## 🎯 Usage

Once setup is complete, the application allows you to:

* Register new members (with QR-code generation)
* Book tickets by selecting bus, seat, and date
* Scan member QR-code via webcam to check in
* Generate and export PDF boarding passes for printing or emailing


## 👥 Contributing

Contributions are welcome. If you want to help out, you can:

* Submit bug reports or feature requests via Issues.
* Fork the repo, make improvements, and open a Pull Request.
* Maintain consistent coding style, comment your changes, and include documentation or tests where relevant.
<!-- 
## 📝 (Optional) Future / Roadmap Ideas

* Add user-friendly installer for distribution.
* Improve UI/UX: e.g. smoother seat selection, responsive layout.
* Add test suite for important modules.
* Internationalization (i18n) / multi-language support.
* Logging and error handling enhancements. 
-->
