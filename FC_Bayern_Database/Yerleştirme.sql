use FC_Bayern_Database
go

insert into FCB_Teams(Name, Value) values('FCB Männer',936000000)
go
insert into FCB_Teams( Name	,Value) values('FCB Frauen',2434564)
go
insert into Duties(Name) values('Head Coach')
go
insert into Duties(Name) values('Sports Director')
go
insert into Duties(Name) values('Team Doctor')
go
insert into Duties(Name) values('President')
go
insert into Duties(Name) values('First Aider')
go
insert into Personnel(Duty_ID,Name,Surname,Age) values(1,'Vincent','Kompany',39)
go
insert into Personnel(Duty_ID,Name,Surname,Age) values(2,'Christoph','Freund',48)
go
insert into Personnel(Duty_ID,Name,Surname,Age) values(3,'Prof. Dr.Peter','Ueblacker',47)
go
insert into Personnel(Duty_ID,Name,Surname,Age) values(3,'Dr.Jochen','Hahne',46)
go
insert into Personnel(Duty_ID,Name,Surname,Age) values(4,'Herbert','Hainer',71)
go
insert into Personnel_Duties(Duty_ID, Personnel_ID) values(5,3)
go
insert into Personnel_Duties(Duty_ID, Personnel_ID) values(5,4)
go
insert into Contracts(Value,SignDate,EndDate,Transfer_fee) values(92739376,'2025-03-08','2029-03-08',87382372)
go
insert into Contracts(Value,SignDate,EndDate,Transfer_fee) values(32323326,'2025-03-08','2029-03-08',42323214)
go
insert into Contracts(Value,SignDate,EndDate,Transfer_fee) values(5332323,'2025-03-08','2029-03-08',12331121)
go
insert into Contracts(Value,SignDate,EndDate,Transfer_fee) values(47383484,'2025-03-08','2029-03-08',32332323)
go
insert into Contracts(Value,SignDate,EndDate,Transfer_fee) values(53435644,'2025-03-08','2029-03-08',16343432)
go
insert into Players(Team_ID,Contract_ID,Name,Surname,Age,BirthDate,Jersey_Number,Position,Annual_Salary,Monthly_Salary) values(1,1,'Harry','Kane',30,'1995-12-11',9,'ST',10293281,1231236)
go
insert into Players(Team_ID,Contract_ID,Name,Surname,Age,BirthDate,Jersey_Number,Position,Annual_Salary,Monthly_Salary) values(1,2,'Kingsley','Coman',24,'2000-12-11',18,'LW',523231,12342)
go
insert into Players(Team_ID,Contract_ID,Name,Surname,Age,BirthDate,Jersey_Number,Position,Annual_Salary,Monthly_Salary) values(1,3,'Jamal','Musiala',20,'2006-01-22',9,'CM',15283722,3233533)
go
insert into Players(Team_ID,Contract_ID,Name,Surname,Age,BirthDate,Jersey_Number,Position,Annual_Salary,Monthly_Salary) values(2,4,'Lorem','İpsum',52,'2000-11-19',10,'GK',111111,12323)
go
insert into Players(Team_ID,Contract_ID,Name,Surname,Age,BirthDate,Jersey_Number,Position,Annual_Salary,Monthly_Salary) values(2,5,'Dot silur','Amet',11,'2000-11-19',1,'RB',11111,11123)
go
insert into Teams(Name,League_Name) values('Manchester United','Premier League')
go
insert into Teams(Name,League_Name) values('Galatasaray','Super League')
go
update Contracts set Player_ID=1 where ID=1
go
update Contracts set Player_ID=2 where ID=2
go
update Contracts set Player_ID=3 where ID=3
go
update Contracts set Player_ID=4 where ID=4
go
update Contracts set Player_ID=5 where ID=5




