using System;
using System.Collections.Generic;

public static class RouteHelper
{
    // --- DATA KONFIGURASI RUTE & HARGA ---

    // Key: Nama Kota, Value: Jarak waktu (jam) dari Rantauprapat (Titik 0)
    public static Dictionary<string, double> RuteWaktu = new Dictionary<string, double>()
    {
        {"Rantauprapat", 0},
        {"Aek Kanopan", 1.5},
        {"Kisaran", 3.0},
        {"Tebing Tinggi", 4.5},
        {"Lubuk Pakam", 6.0},
        {"Medan", 7.0}
    };

    // Key: Nama Kota, Value: Harga dasar dari titik 0
    public static Dictionary<string, decimal> RuteHarga = new Dictionary<string, decimal>()
    {
        {"Rantauprapat", 0},
        {"Aek Kanopan", 20000},
        {"Kisaran", 40000},
        {"Tebing Tinggi", 70000},
        {"Lubuk Pakam", 90000},
        {"Medan", 110000}
    };

    // --- DATA ARMADA BUS ---

    // Key: Nama Kota Asal, Value: List Kode Bus yang standby di sana
    public static Dictionary<string, List<string>> DataBus = new Dictionary<string, List<string>>()
    {
        {"Rantauprapat", new List<string> { "FRABS-RAP-01 (Executive)", "FRABS-RAP-02 (Royal)", "FRABS-RAP-03 (Sultan)" } },
        {"Aek Kanopan",  new List<string> { "FRABS-AKP-01 (Executive)", "FRABS-AKP-02 (Royal)" } },
        {"Kisaran",      new List<string> { "FRABS-KIS-01 (Executive)", "FRABS-KIS-02 (Royal)", "FRABS-KIS-03 (Sultan)" } },
        {"Tebing Tinggi",new List<string> { "FRABS-TBT-01 (Executive)", "FRABS-TBT-02 (Royal)" } },
        {"Lubuk Pakam",  new List<string> { "FRABS-LBP-01 (Executive)", "FRABS-LBP-02 (Royal)" } },
        {"Medan",        new List<string> { "FRABS-MDN-01 (Executive)", "FRABS-MDN-02 (Royal)", "FRABS-MDN-03 (Sultan)", "FRABS-MDN-04 (Super)" } }
    };

    // --- LOGIKA PENCARIAN DATA ---

    public static List<string> GetBusByKota(string kotaAsal)
    {
        if (DataBus.ContainsKey(kotaAsal))
        {
            return DataBus[kotaAsal];
        }
        return new List<string>(); // Kosong jika kota tidak ada
    }

    // --- LOGIKA KALKULASI WAKTU & HARGA ---

    public static TimeSpan HitungJamTiba(string asal, string tujuan, TimeSpan jamBerangkat)
    {
        double waktuAsal = RuteWaktu[asal];
        double waktuTujuan = RuteWaktu[tujuan];
        double durasi = Math.Abs(waktuTujuan - waktuAsal);
        return jamBerangkat.Add(TimeSpan.FromHours(durasi));
    }

    public static decimal HitungHarga(string asal, string tujuan)
    {
        decimal hargaAsal = RuteHarga[asal];
        decimal hargaTujuan = RuteHarga[tujuan];
        return Math.Abs(hargaTujuan - hargaAsal);
    }

    public static decimal HitungHargaDiskon(decimal hargaDasar, string kategori)
    {
        string kat = kategori?.Trim().ToLower() ?? "";
        if (kat == "karyawan") return hargaDasar * 0.90m; // Diskon 10%
        else if (kat == "mahasiswa") return hargaDasar * 0.75m; // Diskon 25%
        return hargaDasar; // Normal
    }
}