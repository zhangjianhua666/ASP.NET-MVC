if DB_ID('fashionshoppingDB') is not null
	drop database fashionshoppingDB
go

create database fashionshoppingDB on(
	name='fashionshoppingDB',
	filename='c:\db_data\G3\fashionshoppingDB.mdf'
)
go

use fashionshoppingDB
go

create table [users]
(
	userid int primary key identity(1,1),--���
	username nvarchar(50) not null,
	pwd nvarchar(50) not null,
	email nvarchar(50) 
)
go
create table [Sysuser]
(
  id int primary key identity(1,1),
  username nvarchar(50) not null,
  pwd nvarchar(50) not null,
  [role] int ,--��ɫid��0����ͨ����Ա��1����������Ա��
)

insert into users values('����','123','zhangsan@163.com')
insert into users values('����','123','lisi@163.com')
insert into users values('����','123','wangwu@163.com')

insert into [Sysuser] values('admin','123',1)
insert into [Sysuser] values('sysadmin','123',0)

select * from users
select * from Sysuser
