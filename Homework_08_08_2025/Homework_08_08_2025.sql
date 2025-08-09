--Oyuncuların kontrat değerleri.
select P.Name + ' ' + P.Surname as Oyuncular, C.Value as 'Kontrat Değeri' from Players as P
join Contracts as C on C.Player_ID = P.ID

--Tüm oyuncuların detaylı sıralanması
select P.ID as 'Oyuncu ID',P.Name + ' ' + P.Surname as Oyuncular,P.Jersey_Number as 'Forma Numarası',P.Age as 'Yaş' ,P.BirthDate as 'Doğum Tarihi', P.Position as Pozisyon, P.Annual_Salary as 'Yıllık Maaş',
FCB.Name as 'Oynadığı Takım', FCB.Value as 'Takım Değeri', C.SignDate as 'Kontrat İmzalama Tarihi', C.Transfer_fee as 'Transfer Ücreti' from Players as P
join FCB_Teams as FCB on P.Team_ID = FCB.ID 
join Contracts as C on C.Player_ID = P.ID

--FCB Takımlarının toplam değerleri
select sum(value) as 'Takım Değerleri'from FCB_Teams

--Yıllık maaşı 1 milyon üzerinde olan oyuncular
select Name, Surname, Age, BirthDate, Jersey_Number, Position, Annual_Salary from Players where Annual_Salary > 1000000

--Tüm oyuncuların kontrat değerlerinin toplamı
select sum(Value) from Contracts




