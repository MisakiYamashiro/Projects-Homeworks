create database BlogWebsiteDB
go
use BlogWebsiteDB
go
create table Kategoriler
(
ID int primary key identity(1,1),
Kategori_Isim nvarchar(60),
)
go
create table Uyeler 
(
ID int primary key identity(1,1),
Nickname nvarchar(60),
Isim nvarchar(120),
Soyisim nvarchar(120),
DogumTarih date,
Yas nvarchar(30)
)
go
create table Yazarlar 
(
ID int primary key identity(1,1),
Uye_ID int,
constraint fk_UyeID foreign key (Uye_ID) references Uyeler(ID)
)
go
create table Makale
(
ID int primary key identity(1,1),
Kategori_ID int,
Yazar_ID int,
Konu_Isim nvarchar(200),
Makale_Icerik nvarchar(MAX),
Yayinlanma_Tarih date,
YorumSayi int,
LikeSayi int,
DislikeSayi int,
AlintiSayi int,
GuncellenmeTarih date
constraint fk_KategoriID foreign key(Kategori_ID) references Kategoriler(ID),
constraint fk_YazarID foreign key(Yazar_ID) references Yazarlar(ID)
)
go
create table Yorumlar
(
ID int primary key identity(1,1),
Makale_ID int,
Uye_ID int,
Yapildigi_Tarih date,
Yorum nvarchar(1000)
constraint fk_MakaleID foreign key(Makale_ID) references Makale(ID),
constraint fk_UyeIDs foreign key(Uye_ID) references Uyeler(ID)
)
go
create table Makale_Kategorileri
(
Makale_ID int,
Kategori_ID int
constraint pk_MakaleKategorisi primary key(Makale_ID, Kategori_ID),
constraint fk_Makale foreign key(Makale_ID) references Makale(ID),
constraint fk_MakaleKategorileri foreign key(Kategori_ID) references Kategoriler(ID)
)
