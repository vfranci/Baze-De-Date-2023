create table INSTRUCTORI(
id_instructor number(4) constraint pk_instructori primary key,
nume varchar2(30) not null,
prenume varchar2(30),
calificare varchar2(20) not null,
nr_telefon varchar(12) not null,
email varchar2(40));

create table LOCATII(
id_locatie number(4) constraint pk_locatie primary key,
adresa varchar2(30) not null,
capacitate number(2) not null);

create table INCHIRIERI(
id_inchiriere number(3) constraint pk_inchirieri primary key,
id_locatie number(4) not null,
nume_client varchar2(30) not null,
nr_telefon varchar2(12) not null,
data_inchiriere date not null,
ora_inceput varchar2(5) not null,
ora_sfarsit varchar2(5) not null,
cost_inchiriere number(4),
constraint fk_id_loc_inchr foreign key (id_locatie) references LOCATII(id_locatie) on delete cascade);

create table CURSURI(
id_curs number(3) constraint pk_cursuri primary key,
id_instructor number(3) not null,
id_locatie number(4) not null constraint fk_id_locatie_curs references LOCATII(id_locatie) on delete cascade,
nume_curs varchar2(20) not null,
nivel varchar2(10),
ora_inceput varchar2(5) not null,
ora_sfarsit varchar2(5) not null,
data_inceput date not null,
data_sfarsit date not null,
zi_sapt varchar2(10) not null,
cost_curs number(4),
constraint fk_id_instructor foreign key (id_instructor) references INSTRUCTORI(id_instructor) on delete cascade,
constraint chk_date_curs check (data_inceput < data_sfarsit));

create table ELEVI(
id_elev number(3) constraint pk_elevi primary key,
nume varchar2(30) not null,
prenume varchar2(30),
email varchar2(40),
nr_telefon varchar2(12) not null,
data_nastere date);

create table EXAMENE(
id_exam number(3) constraint pk_exam primary key,
id_elev number(3) not null,
data_exam date not null,
rezultat varchar2(8) constraint chk_rezultat check (UPPER(rezultat) IN('PROMOVAT', 'PICAT')),
constraint fk_id_elevi_exam foreign key (id_elev) references ELEVI(id_elev) on delete cascade);

create table INSCRIERI(
id_inscriere number(3) constraint pk_inscrieri primary key,
id_elev number(3) not null,
id_curs number(3) not null,
data_inscriere date not null,
constraint fk_id_elevi_inscr foreign key (id_elev) references ELEVI(id_elev) on delete cascade,
constraint fk_id_curs_inscr foreign key (id_curs) references CURSURI(id_curs) on delete cascade);

create table PLATI(
id_plata number(3) constraint pk_plati primary key,
metoda_de_plata varchar2(10) not null,
suma number(4) not null,
data_plata date not null);

alter table PLATI add constraint pk_fk_id_plata foreign key (id_plata) references INSCRIERI(id_inscriere);

insert into ELEVI values(100, 'Popescu', 'Alexandru', 'popalex@gmail.com', '0722232323', to_date('12-04-2002','dd-mm-yyyy'));
insert into ELEVI values(101, 'Bradea', 'Ioana', 'braioana@gmail.com', '0722232324', to_date('26-02-1999','dd-mm-yyyy'));
insert into ELEVI values(102, 'Marin', 'Raluca', 'ralum@yahoo.com', '0722232325', to_date('04-11-2006','dd-mm-yyyy'));
insert into ELEVI values(103, 'Voicu', 'Dan', 'danvoicu@gmail.com', '0722232326', to_date('12-11-2004','dd-mm-yyyy'));
insert into ELEVI values(104, 'Negoiu', 'Vlad', 'vladn@gmail.com', '0722232327', to_date('30-03-2002','dd-mm-yyyy'));
insert into ELEVI values(105, 'Neacsu', 'Andra', 'andra02@gmail.com', '0722232328', to_date('02-05-2002','dd-mm-yyyy'));
insert into ELEVI values(106, 'Andrei', 'Rares', 'arares21@yahoo.com', '0722232329', to_date('14-10-2003','dd-mm-yyyy'));
insert into ELEVI values(107, 'Enescu', 'Daria', 'dariaenescu@yahoo.com', '0722232330', to_date('14-12-2001','dd-mm-yyyy'));

insert into LOCATII values(200, 'str. Unirii nr, 82', 80);
insert into LOCATII values(201, 'str. Macului nr. 40', 90);
insert into LOCATII values(202, 'str. Florilor nr. 9A', 75);
insert into LOCATII values(203, 'str. Traian Vuia nr. 6', 80);

insert into EXAMENE values(300, 103, to_date('01-10-2021','dd-mm-yyyy'), 'picat');
insert into EXAMENE values(301, 105, to_date('05-10-2021','dd-mm-yyyy'), 'promovat');
insert into EXAMENE values(302, 107, to_date('01-10-2021','dd-mm-yyyy'), 'promovat');
insert into EXAMENE values(303, 104, to_date('05-10-2021','dd-mm-yyyy'), null);

insert into  INSTRUCTORI values(400, 'Dumitru', 'Matei', 'streetdance', '0722111110', 'dumatei@yahoo.com');
insert into  INSTRUCTORI values(401, 'Mita', 'Bogdan', 'dans modern', '0722111111', 'mbogdan9@yahoo.com');
insert into  INSTRUCTORI values(402, 'Gorja', 'Emma', 'streetdance', '0722111112', 'emmagj@yahoo.com');
insert into  INSTRUCTORI values(403, 'Patrascu', 'Mara', 'streetdance', '0722111113', 'mpatr@gmail.com');
insert into  INSTRUCTORI values(404, 'Danca', 'Diana', 'dansuri africane', '0722111114', 'didiana@gmail.com');

insert into CURSURI values(500, 400, 200, 'Hip Hop Basics', 'incepatori', '14:00', '15:00', to_date('10-01-2021', 'dd-mm-yyyy'), to_date('20-09-2021', 'dd-mm-yyyy'), 'joi', 700);
insert into CURSURI values(501, 400, 200, 'Hip Hop Choreo', 'mediu', '15:00', '16:00',to_date('10-01-2021', 'dd-mm-yyyy'), to_date('20-09-2021', 'dd-mm-yyyy'), 'joi', 800);
insert into CURSURI values(502, 402, 200, 'Popping', 'incepatori', '16:00', '17:00', to_date('10-01-2021', 'dd-mm-yyyy'), to_date('20-09-2021', 'dd-mm-yyyy'), 'joi', 700);
insert into CURSURI values(503, 402, 200, 'Body Control', 'incepatori', '14:00', '15:00', to_date('10-01-2021', 'dd-mm-yyyy'), to_date('20-09-2021', 'dd-mm-yyyy'), 'joi', 700);
insert into CURSURI values(504, 401, 201, 'Dans Contemporan', 'incepatori', '14:00', '15:00', to_date('20-01-2021', 'dd-mm-yyyy'), to_date('30-09-2021', 'dd-mm-yyyy'), 'sambata', 700);
insert into CURSURI values(505, 401, 201, 'Contemporan Choreo', 'mediu', '15:00', '16:00',  to_date('20-01-2021', 'dd-mm-yyyy'), to_date('30-09-2021', 'dd-mm-yyyy'), 'sambata', 800);
insert into CURSURI values(506, 403, 201, 'Street Dance', 'incepatori', '17:00', '18:00',  to_date('20-01-2021', 'dd-mm-yyyy'), to_date('30-09-2021', 'dd-mm-yyyy'), 'sambata', 700);
insert into CURSURI values(507, 404, 202, 'Afro Basics', 'incepatori', '14:00', '15:00',  to_date('20-01-2021', 'dd-mm-yyyy'), to_date('30-09-2021', 'dd-mm-yyyy'), 'duminica', 700);
insert into CURSURI values(508, 404, 202, 'Dancehall', 'incepatori', '15:00', '16:00',  to_date('20-01-2021', 'dd-mm-yyyy'), to_date('30-09-2021', 'dd-mm-yyyy'), 'duminica', 700);

insert into INSCRIERI values(600, 100, 500, to_date('10-01-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(601, 104, 501, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(602, 101, 502, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(603, 100, 503, to_date('10-01-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(604, 102, 504, to_date('16-02-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(605, 102, 508, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(606, 103, 506, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(607, 105, 505, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(608, 106, 505, to_date('10-02-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(609, 107, 507, to_date('11-02-2021', 'dd-mm-yyyy'));
insert into INSCRIERI values(610, 104, 505, to_date('11-02-2021', 'dd-mm-yyyy'));

insert into PLATI values(600, 'cash', 700, to_date('10-01-2021', 'dd-mm-yyyy'));
insert into PLATI values(601, 'cash', 800, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into PLATI values(602, 'card', 700, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into PLATI values(603, 'card', 700, to_date('10-01-2021', 'dd-mm-yyyy'));
insert into PLATI values(604, 'cash', 700, to_date('16-02-2021', 'dd-mm-yyyy'));
insert into PLATI values(605, 'cash', 700, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into PLATI values(606, 'cash', 700, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into PLATI values(607, 'cash', 800, to_date('09-01-2021', 'dd-mm-yyyy'));
insert into PLATI values(608, 'cash', 800, to_date('10-02-2021', 'dd-mm-yyyy'));
insert into PLATI values(609, 'cash', 700, to_date('11-02-2021', 'dd-mm-yyyy'));
insert into PLATI values(610, 'cash', 800, to_date('11-02-2021', 'dd-mm-yyyy'));

insert into INCHIRIERI values(800, 203, 'Manea', '0722555551', to_date('11-06-2021', 'dd-mm-yyyy'), '11:00', '12:00', 50);
insert into INCHIRIERI values(801, 203, 'Andrei', '0722555550', to_date('12-06-2021', 'dd-mm-yyyy'), '11:00', '12:00', 50);
insert into INCHIRIERI values(802, 201, 'Ionascu', '0722555551', to_date('11-06-2021', 'dd-mm-yyyy'), '09:00', '11:00', 120);

commit;



