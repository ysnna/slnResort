use master;
go
-- Tạo Database DangNhap-PhanQuyen
if DB_ID('ManagementResort') is not null
	drop database ManagementResort;
go

create database ManagementResort;
go

--Sử dụng Database
use ManagementResort;
go

if OBJECT_ID('ACCOUNT') is not null drop table ACCOUNT;
go-------Acount--
-------------------------------------
create table ACCOUNT
(
Username varchar(100) not null unique,
Password varchar(100) not null,
IDGroup varchar(50)  not null,
IDEmployee varchar(50) not null ,
Constraint pk_ACCOUNT primary key (Username)
)
go 
if OBJECT_ID('TABLES') is not null drop table TABLES;
go-------Acount--
-------------------------------------
create table TABLES
(
IDTable int not null ,
Slot int  not null,
State nvarchar not null,
Constraint pk_TABLES primary key (IDTable)
)
go 

if OBJECT_ID('GROUPUSER') is not null drop table GROUPUSER;
go-------GroupUser--
-------------------------------------
create table GROUPUSER
(
IDGroup varchar(50) not null,
Name nvarchar(200) not null unique,
Description nvarchar(200) not null,
Constraint pk_GROUPUSER primary key (IDGroup)
)
go 


if OBJECT_ID('PERMISSION') is not null drop table PERMISSION;
go-------Permission--
-------------------------------------
create table PERMISSION
(
IDPermission int not null,
Name nvarchar(200) not null unique,
Description nvarchar(200) not null,
Constraint pk_PERMISSION primary key (IDPermission)
)
go 


if OBJECT_ID('GROUP_PERMISSION') is not null drop table GROUP_PERMISSION;
go
--Group_Permission--
-------------------------------
create table GROUP_PERMISSION
(
IDGroup varchar(50) not null,
IDPermission int not null,

)
go 

if OBJECT_ID('ACCOUNT_PERMISSION') is not null drop table ACCOUNT_PERMISSION;
go
-------Group_Permission--
-------------------------------------
create table ACCOUNT_PERMISSION
(
Username varchar(100) not null,
IDPermission int not null,
)
go 




if OBJECT_ID('EMPLOYEE') is not null drop table EMPLOYEE;
go
---create EMPLOYEE
create table EMPLOYEE
(
IDEmployee varchar(50) not null,
Fullname nvarchar(200)  null,
Avatar image  null,
Birthday date  null,
Gender bit  null,
Adress nvarchar(200)  null,
IDCard varchar(10) not null,
Phone varchar(10)  null,
IDBaseSalary int null,
IDArea int null,
State nvarchar(200) not null,
constraint pk_EMPLOYEE primary key (IDEmployee)
);
go

if OBJECT_ID('AREA') is not null drop table AREA;
go
--create AREA
create table AREA
(
IDArea int not null,
Name nvarchar(200)  null unique,
IDManager varchar(50) not null, ---ID nhân viên
NameManager nvarchar(200) null,
constraint pk_AREA primary key (IDArea)
);
go

if OBJECT_ID('BASESALARY') is not null drop table BASESALARY;
go

---create BASESALARY
create table BASESALARY
(
IDBaseSalary int not null,
TypeEmployee nvarchar(200) not null,
Salary float null,
constraint pk_BASESALARY primary key (IDBaseSalary)
);

If OBJECT_ID('SCHEDULE') is not null drop table SCHEDULE;
go

--create SCHEDULE
create table SCHEDULE
(
Date date unique not null,
State nvarchar(200) not null,
constraint pk_SCHEDULE primary key(Date)
);
go

if OBJECT_ID('EMPLOYEE_SCHEDULE') is not null drop table EMPLOYEE_SCHEDULE;
go

--create EMPLOYEE_SCHEDULE
create table EMPLOYEE_SCHEDULE
(
IDEmployee varchar(50) not null,
Date date not null,
State nvarchar(200),
);
go

if OBJECT_ID('FORMS') is not null drop table FORMS;
go

--create FORMS
create table FORMS
(
IDForm int not null,
Date datetime not null,
Reason nvarchar(200),
IDEmployee varchar(50),
Constraint pk_FORMS primary key(IDForm)
);
go

if OBJECT_ID('DETAILFORM') is not null drop table DETAILFORM;
go

--create DETAILFORM
create table DETAILFORM
(
IDForm int not null,
DateOff date not null,
);
go

if OBJECT_ID('REPORT') is not null drop table REPORT;
go

--create REPORT
create table REPORT
(
IDReport int not null,
IDEmployee varchar(50) not null,
Date datetime not null,
Contents nvarchar(200) not null,
Week int not null,
Total float not null,
constraint pk_REPORT primary key(IDReport)
);
go

if OBJECT_ID('INVOICE') is not null drop table INVOICE;
go

---create INVOICE
create table INVOICE
(
IDInvoice varchar(50) not null,
IDCustomer varchar(50) not null,
IDEmployee varchar(50) not null,
Type nvarchar(200) not null,
DatePayment datetime not null,
Total float null,
IDVoucher int null,
TotalDiscount float null,
Payment float null,
Change float null,
State nvarchar(200) not null,
constraint pk_INVOICE primary key(IDInvoice)
);
go

if OBJECT_ID('DETAILINVOICESERVICES') is not null drop table DETAILINVOICESERVICES
go

--create DETAILINVOICESERVICES
create table DETAILINVOICESERVICES
(
IDInvoice varchar(50) not null,
Name int not null,
Quantity int not null,
Price float not null,
);
go

if OBJECT_ID('DETAILINVOICEROOM') is not null drop table DETAILINVOICEROOM
go

--create DETAILINVOICEROOM
create table DETAILINVOICEROOM
(
IDInvoice varchar(50) not null,
IDRoom varchar(50) not null, 
DateBooked datetime not null,
DateCheckOut datetime not null,
CheckedOut datetime not null,
Price float not null,
);
go

if OBJECT_ID('DETAILINVOICEFOOD') is not null drop table DETAILINVOICEFOOD
go

--create DETAILINVOICEFOOD
create table DETAILINVOICEFOOD
(
IDInvoice varchar(50) not null,
Food int not null,
Quantity int not null,
Price float not null,
);

if OBJECT_ID('DETAILINVOICEPARK') is not null drop table DETAILINVOICEPARK
go

--create DETAILINVOICEPARK
create table DETAILINVOICEPARK
(
IDInvoice varchar(50) not null,
Ticket int not null,
Quantity int not null,
Price float not null,
);
go

if OBJECT_ID('VOUCHER') is not null drop table VOUCHER
go

--create VOUCHER
create table VOUCHER
(
IDVoucher int not null,
Area nvarchar(200) not null,
Name nvarchar(200) not null,
StartDate datetime not null,
ExprirationDate datetime not null,
Percents int not null,
constraint pk_VOUCHER primary key(IDVoucher)
);


if OBJECT_ID('CUSTOMER') is not null drop table CUSTOMER
go

--create CUSTOMER
create table CUSTOMER
(
IDCustomer varchar(50) not null,
Name nvarchar(100) not null,
Birthday date null,
Gender bit not null,
Phone varchar(10) null,
IDCard varchar(10) not null,
IDRoom varchar(50) not null,
constraint pk_CUSTOMER primary key(IDCustomer)
);

if OBJECT_ID('COMMENTS') is not null drop table COMMENTS
go

--create COMMENTS
create table COMMENTS
(
IDComment int not null,
Comment nvarchar(200) not null,
IDCustomer varchar(50) not null,
Rating int not null,
constraint pk_COMMENTS primary key(IDComment)
);
go

if OBJECT_ID('ROOMS') is not null drop table ROOMS
go

--create ROOMS
create table ROOMS
(
IDRoom varchar(50) not null,
Requirement nvarchar(200) not null,
KindOf nvarchar(200) not null,
Type nvarchar(200) not null,
Price float not null,
State nvarchar(200) not null,
constraint pk_ROOMS primary key(IDRoom)
);

If OBJECT_ID('BOOK_ROOM') is not null drop table BOOK_ROOM
go

--create BOOK_ROOM
create table BOOK_ROOM
(
IDCard varchar(10) not null,
IDRoom varchar(50) not null,
DateBooked datetime not null,
DateCheckin datetime not null,
DateCheckout datetime not null,
State nvarchar(200) null,
);
go

if OBJECT_ID('SERVICES') is not null drop table SERVICES
go

--create SERVICES
create table SERVICES
(
IDService int not null, 
Name nvarchar(200) not null,
Picture image null,
Description nvarchar(500) not null,
Price float not null,
Available int not null,
constraint pk_SERVICES primary key(IDService)
);
go

if OBJECT_ID('ROOM_SERVICE') is not null drop table ROOM_SERVICE
go

---create ROOM_SERVICE
create table ROOM_SERVICE
(
IDService int not null,
IDInvoice varchar(50) not null,
IDRoom varchar(50) not null,
Quantity int not null,
);
go

if OBJECT_ID('TABLES') is not null drop table TABLES
go

--create TABLES
create table TABLES
(
IDTable int not null,
Slot int not null,
State nvarchar(200) not null,
constraint pk_TABLES primary key(IDTable)
);

if OBJECT_ID('BOOK_TABLE') is not null drop table BOOK_TABLE
go

--create BOOK_TABLE
create table BOOK_TABLE
(
IDTable int not null,
Phone varchar(10) not null,
DateBooked datetime null,
Timeline datetime null,
State nvarchar(200) null,
);
go

if OBJECT_ID('ORDER_FOOD') is not null drop table ORDER_FOOD
go

--create ORDER_FOOD
create table ORDER_FOOD
(
IDInvoice varchar(50) not null,
IDTable int not null,
IDFood int not null,
Quantity int not null,
);
go

if OBJECT_ID('MENUFOOD') is not null drop table MENUFOOD
go

--create MENUFOOD
create table MENUFOOD
(
IDFood int not null,
Name nvarchar(200) not null,
Price float not null,
Description nvarchar(200) not null,
Picture image  null,
Available int not null,
constraint pk_MENUFOOD primary key(IDFood)
);
go

if OBJECT_ID('TICKETBOOKING') is not null drop table TICKETBOOKING
go

--create TICKETBOOKING
create table TICKETBOOKING
(
IDTicketbooking int not null,
Name nvarchar(200) not null,
Price float not null,
Picture image null,
Available int not null,
constraint pk_TICKETBOOKING primary key(IDTicketbooking)
);
go

if OBJECT_ID('SYSTEMLOGIN') is not null drop table SYSTEMLOGIN
go

--create SYSTEMLOGIN
create table SYSTEMLOGIN
(
Username varchar(100) not null,
TypeUser varchar(50) not null,
Date datetime not null,
State nvarchar(200) not null,
);
go

if OBJECT_ID('HISTORY') is not null drop table HISTORY
go 

--create HISTORY
create table HISTORY
(
Username varchar(100) not null,
Date datetime not null,
Action nvarchar(200) not null,
);
go




alter table  GROUP_PERMISSION
with nocheck add constraint fk_GROUP_PERMISSION_PERMISSION
foreign key (IDPermission) references PERMISSION(IDPermission);
go

alter table  GROUP_PERMISSION
with nocheck add constraint fk_GROUP_PERMISSION_GROUPUSER
foreign key (IDGroup) references GROUPUSER(IDGroup);
go

alter table  ACCOUNT_PERMISSION
with nocheck add constraint fk_ACCOUNT_PERMISSION_PERMISSION
foreign key (IDPermission) references PERMISSION(IDPermission);
go

alter table  ACCOUNT
with nocheck add constraint fk_ACCOUNT_GROUPUSER
foreign key (IDGroup) references GROUPUSER(IDGroup);
go



alter table  ACCOUNT
with nocheck add constraint fk_ACCOUNT_EMPLOYEE
foreign key (IDEmployee) references EMPLOYEE(IDEmployee);
go

alter table  EMPLOYEE
with nocheck add constraint fk_EMPLOYEE_AREA
foreign key (IDArea) references AREA(IDArea);
go

alter table  EMPLOYEE
with nocheck add constraint fk_EMPLOYEE_BASESALARY
foreign key (IDBaseSalary) references BASESALARY(IDBaseSalary);
go

alter table  EMPLOYEE_SCHEDULE
with nocheck add constraint fk_EMPLOYEE_SCHEDULE_EMPLOYEE
foreign key (IDEmployee) references EMPLOYEE(IDEmployee);
go


--------------------------------------

----------------------------------


alter table  EMPLOYEE_SCHEDULE
with nocheck add constraint fk_EMPLOYEE_SCHEDULE_SCHEDULE
foreign key (Date) references SCHEDULE(Date);
go

alter table  FORMS
with nocheck add constraint fk_FORMS_EMPLOYEE
foreign key (IDEmployee) references EMPLOYEE(IDEmployee);
go


alter table  DETAILFORM
with nocheck add constraint fk_DETAILFORM_FORMS
foreign key (IDForm) references FORMS(IDForm);
go


alter table  REPORT
with nocheck add constraint fk_REPORT_EMPLOYEE
foreign key (IDEmployee) references EMPLOYEE(IDEmployee);
go



alter table  COMMENTS
with nocheck add constraint fk_COMMENTS_CUSTOMER
foreign key (IDCustomer) references CUSTOMER(IDCustomer);
go


alter table  BOOK_ROOM
with nocheck add constraint fk_BOOK_ROOM_ROOMS
foreign key (IDRoom) references ROOMS(IDRoom);
go


alter table  BOOK_ROOM
with nocheck add constraint fk_BOOK_ROOM_CUSTOMER
foreign key (IDCustomer) references CUSTOMER(IDCustomer);
go

alter table  ROOM_SERVICE
with nocheck add constraint fk_ROOM_SERVICE_ROOMS
foreign key (IDRoom) references ROOMS(IDRoom);
go

alter table  ROOM_SERVICE
with nocheck add constraint fk_ROOM_SERVICE_SERVICES
foreign key (IDService) references SERVICES(IDService);
go

alter table  BOOK_TABLE
with nocheck add constraint fk_BOOK_TABLE_CUSTOMER
foreign key (IDCustomer) references CUSTOMER(IDCustomer);
go

alter table  BOOK_TABLE
with nocheck add constraint fk_BOOK_TABLE_TABLES
foreign key (IDTable) references TABLES(IDTable);
go

alter table  INVOICE
with nocheck add constraint fk_INVOICE_EMPLOYEE
foreign key (IDEmployee) references EMPLOYEE(IDEmployee);
go

alter table  INVOICE
with nocheck add constraint fk_INVOICE_CUSTOMER
foreign key (IDCustomer) references CUSTOMER(IDCustomer);
go

alter table  ROOM_SERVICE
with nocheck add constraint fk_ROOM_SERVICE_INVOICE
foreign key (IDInvoice) references INVOICE(IDInvoice);
go

alter table  ORDER_FOOD
with nocheck add constraint fk_ORDER_FOOD_INVOICE
foreign key (IDInvoice) references INVOICE(IDInvoice);
go

alter table  ORDER_FOOD
with nocheck add constraint fk_ORDER_FOOD_TABLES
foreign key (IDTable) references TABLES(IDTable);
go

alter table  ORDER_FOOD
with nocheck add constraint fk_ORDER_FOOD_MENUFOOD
foreign key (IDFood) references MENUFOOD(IDFood);
go


alter table  DETAILINVOICESERVICES
with nocheck add constraint fk_DETAILINVOICESERVICES_INVOICE
foreign key (IDInvoice) references INVOICE(IDInvoice);
go

alter table  DETAILINVOICEROOM
with nocheck add constraint fk_DETAILINVOICEROOM_INVOICE
foreign key (IDInvoice) references INVOICE(IDInvoice);
go

alter table  DETAILINVOICEPARK
with nocheck add constraint fk_DETAILINVOICEPARK_INVOICE
foreign key (IDInvoice) references INVOICE(IDInvoice);
go

alter table  DETAILINVOICEFOOD
with nocheck add constraint fk_DETAILINVOICEFOOD_INVOICE
foreign key (IDInvoice) references INVOICE(IDInvoice);
go



alter table  INVOICE
with nocheck add constraint fk_INVOICE_VOUCHER
foreign key (IDVoucher) references VOUCHER(IDVoucher);
go


alter table  ACCOUNT_PERMISSION
with nocheck add constraint fk_ACCOUNT_PERMISSION_ACCOUNT
foreign key (Username) references ACCOUNT(Username);
go