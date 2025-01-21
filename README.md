# OtoYikamaMusteriTakibi

SQL

CREATE DATABASE OtoYikamaVeritabani;
GO

USE OtoYikamaVeritabani;
GO

CREATE TABLE Musteriler (
    Id INT PRIMARY KEY IDENTITY(1,1),
    AdSoyad NVARCHAR(100) NOT NULL,
    Telefon NVARCHAR(15) NOT NULL,
    Plaka NVARCHAR(15) NOT NULL,
	Hizmet NVARCHAR (15) NOT NULL,
    HizmetTarihi DATETIME
);
GO


Nuget entity framework
