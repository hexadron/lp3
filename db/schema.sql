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
	expired bit
)
go

create table size (
	id int not null primary key identity,
	description varchar(255)
)
go

create table detailedTshirt (
	dTshirt_id int not null primary key identity,
	tshirt_id int not null references tshirt,
	size_id int not null references size,
	genre varchar(255),
	stock int
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
	detailedTshirt_id int not null references detailedTshirt,
	quantity int,
	sellOrder_id int not null references sellOrder
)
go

-- Data
insert into size (description) values('S')
insert into size (description) values('M')
insert into size (description) values('L')
insert into size (description) values('XL')