create database FC_Bayern_Database
go
use FC_Bayern_Database
go
create table FCB_Teams
(
ID int primary key identity(1,1),
Name nvarchar(200) not null,
Value money not null,
)
go
create table Contracts
(
ID int primary key identity(1,1),
Player_ID int ,
Value money not null,
SignDate date not null,
EndDate date not  null,
Transfer_fee money not null,
)
go
create table Players
(
ID int primary key identity(1,1),
Team_ID int not null,
Contract_ID int not null,
Name nvarchar(150) not null,
Surname nvarchar(150) not null,
Age nvarchar(40) not null,
BirthDate date,
Jersey_Number int not null,
Position nvarchar(100),
Annual_Salary money not null,
Monthly_Salary money,

constraint fk_PlayerTeam foreign key(Team_ID) references FCB_Teams(ID),
constraint fk_PlayerContract foreign key(Contract_ID) references Contracts(ID)
)
go
create table Players_Statistic
(
ID int primary key identity(1,1),
Player_ID int,
Goal int,
Assists int,
Saves int,
constraint fk_PlayerID_Statistic foreign key(Player_ID) references Players(ID)
)
go
alter table Contracts add constraint fk_ContractPlayer foreign key(Player_ID) references Players(ID)
go
create table Duties 
(
ID int primary key identity(1,1),
Name nvarchar(120) not null,
)
go
create table Personnel
(
ID int primary key identity(1,1),
Duty_ID int not null,
Name nvarchar(150) not null,
Surname nvarchar(150) not null,
Age nvarchar(40) not null,
)
go
create table Personnel_Duties
(
Duty_ID int not null,
Personnel_ID int not null,
constraint pk_Personnel_Duties primary key (Duty_ID, Personnel_ID),
constraint fk_PersonnelDuty foreign key (Duty_ID) references Duties(ID),
constraint fk_DutyPersonnel foreign key (Personnel_ID) references Personnel(ID),
)
go
create table Teams
(
ID int primary key identity(1,1),
Name nvarchar(130) not null,
League_Name nvarchar(130) not null
)
go
create table Players_OldTeam_Statistics
(
Player_ID int,
Team_ID int,
Goal int,
Assists int,
Saves int,
constraint pk_Players_OldTeam_Statistics primary key(Player_ID, Team_ID),
constraint fk_Players_OldTeam_Statistics foreign key(Player_ID) references Players(ID),
constraint fk_Players_OldTeam_Statistics_TeamID foreign key(Team_ID) references Teams(ID)
)

