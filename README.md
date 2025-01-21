# Oto Yıkama Müşteri Takip Web Uygulaması

**DÖKÜMAN**

İsmayil Öztürk
Ögr No: 132130122 Bursa Uludağ Üniversitesi

Oto Yıkama Müşteri Takip Uygulaması, oto yıkama dükkanına gelen müşterilerin bilgilerini takip etme ve yönetmeye yarayan bir web uygulamasıdır.<br><br>

**Özellikler**<br>
+Müşteri Bilgisi Listeleme<br>
+Müşteri Bilgisi Ekleme<br>
+Müşteri Bilgisi Görüntüleme<br>
+Müşteri Bilgisi Düzenleme<br>
+Müşteri Bilgisi Silme<br>

 Listelenen bilgiler:
- Ad Soyad - Telefon - Plaka - Hizmet Adı - Hizmet Tarihi

**Proje Kullanımı, Kod Dosyaları(Kod Yapısı, ASP.NET MVC), SQL Express Veri Tabanı Yapısı - Tanıtım, Anlatım Youtube Videosu**

Youtube Link: https://www.youtube.com/watch?v=bb6xuRGFgpw

**Müşteri Bilgisi Listeleme (Index.cshtml)**<br><br>
![Ekran görüntüsü 2025-01-22 000736](https://github.com/user-attachments/assets/110e4daf-6c96-402a-a448-bdc61b236396)


**Müşteri Bilgisi Ekleme (Yeni.cshtml)**<br><br>
![Ekran görüntüsü 2025-01-22 000831](https://github.com/user-attachments/assets/01d1617e-f532-4d1e-b99f-a382f8995330)


**Müşteri Bilgisi Görüntüleme (Detay.cshtml)**<br><br>
![Ekran görüntüsü 2025-01-22 000744](https://github.com/user-attachments/assets/7c84e4f4-43f5-4bc5-8518-e4fac4eca7fb)


**Müşteri Bilgisi Düzenleme (Duzenle.cshtml)**<br><br>
![Ekran görüntüsü 2025-01-22 000804](https://github.com/user-attachments/assets/37155662-994e-488e-8d92-dfb9749a3555)


**Müşteri Bilgisi Silme (Sil.cshtml)**<br><br>
![Ekran görüntüsü 2025-01-22 000818](https://github.com/user-attachments/assets/1d31efc4-4b07-4f74-a1a6-30296f4a5487)

**Nuget Packages > Entity Framework**

**Veritabanı Tablo ve Sütun Yapısı için SQL Kodları:**

CREATE DATABASE OtoYikamaVeritabani;<br>

USE OtoYikamaVeritabani;
CREATE TABLE Musteriler (
    Id INT PRIMARY KEY IDENTITY(1,1),
    AdSoyad NVARCHAR(100) NOT NULL,
    Telefon NVARCHAR(15) NOT NULL,
    Plaka NVARCHAR(15) NOT NULL,
    Hizmet NVARCHAR (15) NOT NULL,
    HizmetTarihi DATETIME
);<br>
