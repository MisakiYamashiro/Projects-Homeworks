create database LibraryDB
go
use LibraryDB
go
create table Yazarlar
(
ID int primary key identity(1,1),
Isim nvarchar(75),
Soyisim nvarchar(75)
)
go
create table YayinEvleri
(
ID int primary key identity(1,1),
Isim nvarchar(75),
Yerli_Mi bit
)
go
create table Kitaplar
(
ID int primary key Identity(1,1),
Yazar_ID int,
YayinEvi_ID int,
Isim nvarchar(75),
SayfaSayi nvarchar(75),
Cilt bit,
constraint fk_KitapYazari foreign key(Yazar_ID) references Yazarlar(ID),
constraint fk_KitapYayinEvi foreign key(YayinEvi_ID) references YayinEvleri(ID)
)
--use master
--go
--drop database LibraryDB