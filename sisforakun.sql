select * from data_akun;
drop table data_akun

create table akun(
	id_user smallserial primary key,
	first_name varchar(20) not null,
	last_name varchar(20) not null,
	nomer_telp varchar(20) not null,
	username varchar(20) not null,
	password varchar (20) not null,
	email varchar(50) not null,
	deskripsi text
	
);
alter table akun
add constraint id_identitas_fk
foreign key (id_user)
references identitas (id_user);

insert into akun (id_user,first_name,last_name,nomer_telp,username,password,email,deskripsi)
values(100,'Rohmatulloh','Fadhilah','085604834565','fadil','fadhil111','rohmatfadhil12@gmail.com','Mahasiswa'),
(101,'Rahardyan','Rizqy','081234567','rizqy','rizqi112','fadhil12@gmail.com','Mahasiswa Jember'),
(102,'Sayyid','Yasin','08560412345','Yasin','yasin113','sayyid12@gmail.com','Mahasiswa Aktif')

select* from akun
alter table data_akun
add constraint id_user_fk
foreign key (id_user)
references akun (id_user);


create table data_akun(
	Id_akun smallint primary key,
	Email varchar (50) not null,
	Contact varchar(20) not null,
	Username varchar(50) not null,
	Password varchar(20) not null,
	Category varchar(20) not null,
	Deskripsi text
);
drop table data_akun
insert into data_akun(Id_akun,email,Contact,username,Password,Category,Deskripsi) values
(213,'raden@gmail.com','0865478910','raden','raden123','Elerning','ruangguru'),
(212,'sayid@gmail.com','0812567234','sayyid','sayid123','sosmed', 'Facebook'),
(211,'rohmatfadhil12@gmail.com','08512345678','fadil','fadhil123','Technical','github')

alter table data_akun
add constraint category_id_fk
foreign key (category_id)
references category (category_id);



create table category(
	category_id smallserial primary key,
	nama_category varchar(50) not null,
	deskripsi text
);

insert into category(nama_category,deskripsi)values
('sosmed','akun sosial media seperti facebook instagram dll.'),
('Elerning', 'academic, eLearning, student account'),
('Technical','github, freecodecamp, myskill, skillshare, etc'),
('mail','emails, mailings, ie. gmail, yahoo, onmail, etc'),
('others','')