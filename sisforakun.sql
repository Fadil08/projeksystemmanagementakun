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
	id_data smallint primary key,
	category_id smallserial not null,
	id_user smallint not null,
	username varchar(50) not null,
	email varchar (50) not null,
	passwd varchar(20) not null,
	telpon varchar(20) not null,
	nama_category varchar(20) not null
);
drop table category
alter table data_akun
add constraint category_id_fk
foreign key (category_id)
references category (category_id);
select * from category

insert into data_akun(id_data,category_id,id_user,username,email,passwd,telpon,category_id,nama_category) values
(211,100,'github','rohmatfadhil12@gmail.com','fadhil123','08512345678',3,'Technical'),
(211,101,'facebook','fadhil12@gmail.com','fadhil123',0812567234,1,'sosmed'),
(213,102,'ruang guru','sayyid12@gmail.com','sayyid123',0865478910,2,'Elerning')
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




