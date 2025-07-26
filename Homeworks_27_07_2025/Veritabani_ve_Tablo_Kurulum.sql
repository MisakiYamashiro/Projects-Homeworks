create database GaleriDB
go
use GaleriDB
go
create table Markalar
(
ID int primary key identity(1,1),
Isim nvarchar(60),
CEO_Isim nvarchar(60),
KurulduguYil nvarchar(10),
)
go
create table Arabalar
(
ID int primary key identity(1,1),
Plaka nvarchar(40) not null,
Model nvarchar(60) not null,
Model_Yili nvarchar(10),
Fiyat money not null,
Galeri_Gelis_Tarih date not null,
Marka_ID int not null,
constraint fk_MarkaninArabasi foreign key(Marka_ID) references Markalar(ID)
)

