use master
go

drop database tshirts
go

create database tshirts
go

use tshirts
go

create table client (
	id int not null primary key identity,
	email varchar(255),
	password varchar(255),
	is_admin bit not null
)
go

create table tshirt (
	id int not null primary key identity,
	expire_time datetime,
	name varchar(255),
	description varchar(255),
	price decimal,
	imagen varchar(255)
)
go

create table sellOrder (
	id int not null primary key identity,
	client_id int not null references client,
	ordered_at datetime default GETDATE(),
	total decimal
)
go

create table item (
	tshirt_id int not null references tshirt,
	quantity int,
	sellOrder_id int not null references sellOrder,
	size varchar(255),
	genre varchar(255)
)
go

insert into client values ('admin@example.com', 'password', 1);