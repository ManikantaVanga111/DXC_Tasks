create database Products_db
use Products_db
create table Products(
productid int primary key,
productname varchar(20),
Quantity int ,
price int
)
create table customers (
customerid int primary key,
customername varchar(20),
email varchar(20),
city varchar(20),
productid int references Products(productid)
)
create table orders(
orderid int,
ordername varchar(20),
amount int,
orderdate DateTime,
productid int 
)
Alter table orders add nothing int
alter table orders drop column nothing
alter table orders add constraint validqty check(nothing<0)
alter table orders alter column orderid int not null
alter table orders add constraint pk primary key (orderid)
alter table orders drop constraint pk

alter table orders add constraint fk1 foreign key(productid) references Products(productid)
drop table customers
alter table customers drop constraint FK__customers__produ__5BE2A6F2





