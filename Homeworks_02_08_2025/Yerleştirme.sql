use BlogWebsiteDB
go
insert into Kategoriler(Kategori_Isim) values('Fizik')
go
insert into Kategoriler(Kategori_Isim) values('Biyoloji')
go
insert into Kategoriler(Kategori_Isim) values('Tarih')
go
insert into Kategoriler(Kategori_Isim) values('Ice Tea neden bu kadar güzel?')
go
insert into Uyeler (Nickname,Isim,Soyisim,DogumTarih,Yas) values('Misaki Yamashiro','Efe','Palaz','2025-05-04',16)
go
insert into Uyeler (Nickname,Isim,Soyisim,DogumTarih,Yas) values('Terimsporluyuz123','Winston','Churchill','2025-06-03',17)
go
insert into Uyeler (Nickname,Isim,Soyisim,DogumTarih,Yas) values('Miquella','Umut','Yılmaz','2025-07-02',22)
go
insert into Uyeler (Nickname,Isim,Soyisim,DogumTarih,Yas) values('WinstonRED','Joseph','Joestar','2025-05-04',83)
go
insert into Uyeler (Nickname,Isim,Soyisim,DogumTarih,Yas) values('Uzun Adam','Recep','Kılıçdaroğan','2025-05-04',71)
go
insert into Yazarlar(Uye_ID) values(4)
go
insert into Yazarlar(Uye_ID) values(5)
go
insert into Makale(Kategori_ID, Yazar_ID, Konu_Isim, Makale_Icerik, Yayinlanma_Tarih, YorumSayi, LikeSayi,DislikeSayi,AlintiSayi,GuncellenmeTarih)
values (4,1,'Ice tea niye güzel', '
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer ut purus et mi hendrerit aliquam. Fusce elementum lorem a arcu interdum volutpat. Etiam egestas id ipsum vel ultricies. Pellentesque eu interdum metus, auctor vehicula dui. Aenean nec nulla risus. Integer condimentum lectus sit amet libero pulvinar congue. Donec euismod justo et purus sollicitudin, eget iaculis elit dictum. Sed non varius risus, sit amet lacinia eros. Maecenas accumsan interdum lacus vel mattis. Fusce lacinia a metus ut efficitur.
Suspendisse odio nunc, finibus sed dui quis, faucibus sodales nunc. Donec interdum dolor dolor, id ornare nisi scelerisque sed. Nulla ut fringilla arcu, non scelerisque magna. Proin vitae porta quam. Curabitur hendrerit urna nec nisl sagittis, non elementum risus tempus. Maecenas sed mi mattis, rhoncus tellus vel, lacinia ex. Nullam non massa ligula. Sed a tortor quis tortor feugiat iaculis. Ut nec pharetra neque, tincidunt interdum mi. Curabitur imperdiet ut justo nec malesuada. Quisque eu facilisis leo, vitae rhoncus tortor. Sed non tincidunt felis, quis rutrum risus. Aliquam risus erat, imperdiet id mollis eu, hendrerit vel leo.',
'2025-07-28',1,35,11,1,'2025-07-28')
go
insert into Makale(Kategori_ID, Yazar_ID, Konu_Isim, Makale_Icerik, Yayinlanma_Tarih, YorumSayi, LikeSayi,DislikeSayi,AlintiSayi,GuncellenmeTarih)
values (2,2,'Coffin Dance niye komik', '
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer ut purus et mi hendrerit aliquam. Fusce elementum lorem a arcu interdum volutpat. Etiam egestas id ipsum vel ultricies. Pellentesque eu interdum metus, auctor vehicula dui. Aenean nec nulla risus. Integer condimentum lectus sit amet libero pulvinar congue. Donec euismod justo et purus sollicitudin, eget iaculis elit dictum. Sed non varius risus, sit amet lacinia eros. Maecenas accumsan interdum lacus vel mattis. Fusce lacinia a metus ut efficitur.',
'2025-07-23',1,123,0,2,'2025-07-25')
go
insert into Makale(Kategori_ID, Yazar_ID, Konu_Isim, Makale_Icerik, Yayinlanma_Tarih, YorumSayi, LikeSayi,DislikeSayi,AlintiSayi,GuncellenmeTarih)
values (3,2,'Wide Putin niye 4K değil?', 'Nulla facilisi. Aliquam posuere in nunc sit amet consectetur. Sed sollicitudin felis sit amet accumsan pellentesque. Curabitur sollicitudin venenatis tellus ac hendrerit. Phasellus venenatis magna nunc, ut elementum elit lobortis id. Donec at dolor non ipsum pretium ornare eu sagittis turpis. Nunc quis sodales velit. Phasellus et ex a enim ornare varius. Aliquam bibendum ex vel augue viverra auctor. Ut in luctus nibh. Aenean congue nisl at metus venenatis malesuada. Aenean quam ex, euismod ultrices ultrices id, congue eget justo. Nulla pellentesque, turpis ac dignissim vulputate, quam enim consequat nisl, vel eleifend arcu elit eu libero. Vivamus rutrum, ante nec pellentesque maximus, neque velit fringilla nunc, non sagittis sem erat ac sem. Praesent ac volutpat ex.',
'2025-07-20',0,1,523,0,'2025-07-20')
go
insert into Yorumlar(Makale_ID, Uye_ID, Yapildigi_Tarih, Yorum) values(1,3,'2025-07-28','ABI COK IYI OXFORD SENI NIYE KABUL ETMIYO')
go
insert into Yorumlar(Makale_ID, Uye_ID, Yapildigi_Tarih, Yorum) values(2,1,'2025-07-23','bak güzel kardeşim, nijeryada küçük bir kabilenin reisiyim. kabilemin modern çağa ayak uydurması için bir bilgisayar aldım ve bu programı buldum. herşey çok iyiydi. kabiledeki herkes mutluydu. ta ki senin attığın makale ye denk gelene kadar. kabilem dağıldı bu senin komik olmayan, bilgisiz makalelerin ve mağara mizahların yüzünden. uzun uğraşlar sonucu telefonunu buldum. sabahtan beri arıyorum cevap vermiyorsun. adresin de elimde. ilk uçakla icabına bakmaya geliyorum')
--MAKALE KATEGORİLERİ DOLDURMADIM ÇÜNKÜ YOK.

