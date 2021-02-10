Select * from Appointment
select * from Instructor
Select * from Client
Select * from Vehicle

--Drop table Appointment
--Drop table Vehicle
--Drop table Client
--Drop table Instructor

Create table Client
(
fname varchar(30),
lname varchar(30),
Phone varchar(20),
CID varchar(10),
Nationality varchar(30),
email varchar(40),
DOB varchar(30),
address1 varchar(30),
address2 varchar(30)
primary key(CID)
)

insert into Client values('Bob', 'Jones', '027000671','BJ001','Bulgaria','BobJones@gmail.com','21/07/1992', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Sam', 'Simmonds', '027805002','SS001','Norway','SamSimmonds.gmail.com','17/04/1995', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Steve', 'Smith', '027708003', 'SS002','Cambodia','SteveSmith@gmail.com','18/05/1999', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Harry', 'King', '027608004', 'HK001','France','HarryKing@gmail.com','06/01/1990', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Phill', 'Jonas', '027950461', 'PJ001','Lithuania','PhillJones@gmail.com','10/10/2000', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Thomas', 'Jefferson', '0223647856', 'TJ001','Jamaica','ThomasJefferson@gmail.com','07/07/2001', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Luke', 'Aldrich', '0224780097', 'LA001','Australia','LukeAldrich@gmail.com','01/09/1991', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Charles', 'Masters', '022317584','CM001','Iceland','CharlesMasters@gmail.com','25/03/1989', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Fred', 'Flintstone', '022386790','FF001','Canada','FredFlintstone@gmail.com','23/04/1994', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Bruce', 'Barrel', '027654801','BB001','Belgium','BruceBarrell@gmail.com','20/09/1991', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Tiffany', 'Childs', '022123456','TC001','Switzerland','TiffanyChilds@gmail.com','19/05/1991', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Lucy', 'Lahmert', '0224563194','LL001','Madagascar','LucyLahmert@gmail.com','03/03/1993', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Anna', 'Roberts', '0278659432','AR001','South Africa','AnnaRoberts@gmail.com','07/05/1994', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Delila', 'Townsend', '0223476013','DT001','Peru','DelilaTownsned@gmail.com','22/12/1994', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Rose', 'Richmond', '0213586824','RR001','Denmark','RoseRichmond@gmail.com','21/03/2001', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Sarah', 'Jones', '0218474032','SJ001','Austria','SarahJones@gmail.com','30/07/1984', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Caitlyn', 'Jinx', '0218673856','CJ001','Egypt','CaitlynJinx@gmail.com','12/03/1981', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Camille', 'Vayne', '0214582094','CV001','Malaysia','CamilleVayne@gmail.com','11/11/1993', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Zoe', 'Fortune', '0219847732','ZF001','Holland','ZoeFortune@gmail.com','10/10/2000', '41 Hillcrest Road', 'Hamilton')
insert into Client values('Nicola','Boyle','022546786','NB001','New Zealand','NicolaBoyle@gmail.com','23/01/2003', '41 Hillcrest Road', 'Hamilton')
insert into Client values('No','Client','','NC1','','','', '', '')

Create table Vehicle
(
Carmake varchar(30),
LicenseNo varchar(10),
rego varchar(10),
wof varchar(30),
transmission varchar(30),
primary key(LicenseNo),
CHECK (transmission = 'Manual' or transmission = 'Automatic')
)

insert into Vehicle values('Honda','002fgr','17/04/2019','17/04/2019','Automatic')
insert into Vehicle values('Ford','1pd987','17/04/2020','17/04/2019','Automatic')
insert into Vehicle values('No Car','000000','7/04/2019','17/09/2019','Manual')
insert into Vehicle values('No Car','000000','7/04/2019','17/09/2019','Manual')



Create table Instructor
(
fname varchar(30),
lname varchar(30),
phone varchar(30),
email varchar(30),
ID varchar(30),
dob varchar(30),
primary key (ID)
)

insert into Instructor values('Jane','Doe','027435671','JaneDoe@yahoo.com','1','21/07/1989')
insert into Instructor values('Billy','Thekid','021964531','BillyThekid@yahoo.com','2','21/07/1990')
insert into Instructor values('No Instructor','Instructor','021964531','BillyThekid@yahoo.com','NO1','21/07/1989')

create table Appointment
(

dayofsession Date,
timeofsession Time,
ID int,
Car_License varchar(10),
Instructor_ID varchar(30),
Client_ID varchar(10),
FOREIGN KEY (Car_License)REFERENCES Vehicle(LicenseNo),
FOREIGN KEY (Instructor_ID)REFERENCES Instructor(ID),
FOREIGN KEY (Client_ID)REFERENCES Client(CID),
primary key(ID)
)

Declare @ID int
SET @ID = 1
		DECLARE @d DATE
		SET @d = '2021/02/01'
		WHILE @d <= '2021/02/28'
			BEGIN
				DECLARE @t TIME
				SET @t = '07:00:00'
				WHILE @t <= '19:00:00'
					BEGIN
						DECLARE @dayName varchar(9)
						
						SET @dayName = DATENAME(DW, @d)
						IF(@dayName != 'Sunday' AND @dayName != 'Saturday')
						
							INSERT INTO Appointment VALUES(@d, @t, @ID, '000000', 'NO1', 'NC1') 
							Set @ID += 1
						SET @t = DATEADD(hh,1,@t)
						
					END
				SET @d = DATEADD(dd,1,@d)
			END
