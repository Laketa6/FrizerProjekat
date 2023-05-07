use master

create database Frizer

use Frizer

drop table Klijent
drop table Zaposleni
drop table Usluge
drop table Termin

create table Usluge(
id INT IDENTITY(1,1) PRIMARY KEY,
naziv NVARCHAR(35),
trajanje NVARCHAR(20),
cena int
)

create table Zaposleni(
id INT IDENTITY(1,1) PRIMARY KEY,
ime NVARCHAR(15) not null,
prezime NVARCHAR(15) not null,
JMBG NVARCHAR(13) not null,
telefon NVARCHAR(15)
)

create table Klijent(
id INT IDENTITY(1,1) PRIMARY KEY,
ime NVARCHAR(20) not null,
prezime NVARCHAR(20) not null,
telefon NVARCHAR(20) not null,
pol NVARCHAR(6),
datum_rodjenja date,
)

create table Termin(
id INT IDENTITY(1,1) PRIMARY KEY,
datum date,
vreme_pocetka time(0),
vreme_zavrsetka time(0),
Klijent_id INT FOREIGN KEY REFERENCES Klijent(id),
Zaposleni_id INT FOREIGN KEY REFERENCES Zaposleni(id),
Usluge_id INT FOREIGN KEY REFERENCES Usluge(id))

CREATE TRIGGER obrisiKlijenta ON Klijent
INSTEAD OF DELETE
AS
	DELETE FROM Termin
    WHERE Klijent_id = (SELECT deleted.id FROM deleted)

	 DELETE Klijent
     FROM DELETED D
     INNER JOIN Klijent T ON T.id = D.id

CREATE TRIGGER obrisiZaposlenog ON Zaposleni
INSTEAD OF DELETE
AS
	DELETE FROM Termin
    WHERE Zaposleni_id = (SELECT deleted.id FROM deleted)

	 DELETE Zaposleni
     FROM DELETED D
     INNER JOIN Zaposleni T ON T.id = D.id

insert into Usluge(naziv, trajanje, cena)
values ('Šišanje Muško', 20, 500),
('Šišanje Muško (Fade)', 25, 700),
('Šišanje Muško (Duža kosa)', 30, 800),
('Brijanje brade', 20, 500),
('Štucovanje brade', 10, 300),
('Pranje kose', 5, 300),
('Feniranje', 25, 500),
('Šišanje Žensko', 30, 1000),
('Figaro uvijanje kose', 40, 650),
('Svečana frizura', 40, 1500)

select*from Usluge

insert into Zaposleni(ime, prezime, JMBG, telefon)
values('Andrija', 'Milenković', '0098976786571', '062736284'),
('Milena', 'Karadjordjević', '0012876786571', '061765097'),
('Miloš', 'Marinković', '0065584736485', '064829485')

select*from Zaposleni

insert into Klijent(ime, prezime, telefon, pol, datum_rodjenja)
values('Aleksa', 'Avramović', '062736284', 'Muški', '2000-10-20'),
('Kevin', 'Panter', '061765097', 'Muški', '2001-3-11'),
('Dante', 'Eksum', '064829485', 'Muški', '2003-5-11'),
('Alen', 'Smajlagić', '063459485', 'Muški', '1999-1-19'),
('Danilo', 'Anđušić', '066789485', 'Muški', '1995-12-11'),
('Dana', 'Marković', '063789485', 'Ženski', '2004-11-23')

select*from Klijent

select*from Termin






