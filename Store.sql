use ManagementResort
go
--Bảng Account--

--1. Kiểm tra đăng nhập khi login vào.
 if OBJECT_ID('CHECKLOGIN') is not null drop PROC CHECKLOGIN;
 go
create PROC CHECKLOGIN 
 @UserName varchar(50)
as
begin  
	declare @IDEm varchar(10)
	select @IDEm=IDEmployee
	from ACCOUNT
	where Username=@UserName

	select Password, State
	from dbo.Account join EMPLOYEE on ACCOUNT.IDEmployee = EMPLOYEE.IDEmployee
	where UserName=@UserName and EMPLOYEE.IDEmployee=@IDEm;
end
go

--2. Kiểm tra quyền đăng nhập của User
if OBJECT_ID('CHECKPERMISSION') is not null drop proc CHECKPERMISSION;
go
create proc CHECKPERMISSION
@UserName nvarchar(50)
as
begin
	select Group_Permission.IDPermission, PERMISSION.Name into #Group
	from	((	ACCOUNT join GROUPUSER on ACCOUNT.IDGroup = GROUPUSER.IDGroup)
				join GROUP_PERMISSION on GROUPUSER.IDGroup = GROUP_PERMISSION.IDGroup
				join PERMISSION on GROUP_PERMISSION.IDPermission=PERMISSION.IDPermission
				)
	where  Account.UserName=@UserName;
	select ACCOUNT_PERMISSION.IDPermission, Name into #Account
	from ((ACCOUNT	join ACCOUNT_PERMISSION on ACCOUNT.UserName=ACCOUNT_PERMISSION.UserName)
		join PERMISSION on PERMISSION.IDPermission=ACCOUNT_PERMISSION.IDPermission)
	Where Account.UserName=@UserName;
	select * from #Group union select * from #Account;
end;
go

--3. Đổi password
if OBJECT_ID('CHANGEPASSWORD') is not null drop PROC CHANGEPASSWORD
go

create PROC CHANGEPASSWORD
@username nvarchar(50),
@passwordCurrent varchar(50),
@passwordNew varchar(50)
as
begin
	declare @password varchar(50)
	select @password = Password
	from ACCOUNT
	where Username = @username

	 if (@username is not null and @password is not null)
		Update ACCOUNT set Password = @passwordNew where Username = @username and @passwordCurrent = @password
	else
		THROW 51000, 'The record does not exist.', 1;  
		return;	
end
go


--4. Load dữ liệu bảng Account vào datagridView.
if OBJECT_ID('LOADACCOUNT') is not null drop PROC LOADACCOUNT;
go

create PROC LOADACCOUNT 
as
begin
	select *
	from ACCOUNT
	order by Username asc
end
go

--5. Load dữ liệu bảng Permission vào datagridView.
if OBJECT_ID('LOADPERMISSION') is not null drop PROC LOADPERMISSION
go

create PROC LOADPERMISSION
as
begin
	select *
	from PERMISSION
	order by Name asc
end
go

--6. Load dữ liệu bảng GroupUser vào datagridView
if OBJECT_ID('LOADGROUPUSER') is not null drop PROC LOADGROUPUSER
go

create PROC LOADGROUPUSER
as
begin 
	select * 
	from GROUPUSER
	order by Name asc
end
go

--7. Load dữ liệu bảng Employee vào datagridView
if OBJECT_ID('LOADEMPLOYEE') is not null drop PROC LOADEMPLOYEE
go

create PROC LOADEMPLOYEE
as
begin 
	select *
	from EMPLOYEE
	order by Fullname asc
end
go

--8. Load dữ liệu bảng AREA vào datagridView
if OBJECT_ID('LOADAREA') is not null drop PROC LOADAREA
go
create PROC LOADAREA
as
begin
	select *
	from AREA
	order by Name asc
end
go

--9. Load dữ liệu bảng BASESALARY vào datagridView
if OBJECT_ID('LOADBASESALARY') is not null drop PROC LOADBASESALARY
go

create PROC LOADBASESALARY
as
begin
	select *
	from BASESALARY
end
go

--10. Load dữ liệu bảng Invoice vào datagridView
if OBJECT_ID('LOADINVOICE') is not null drop PROC LOADINVOICE
go

create PROC LOADINVOICE
as
begin
	select *
	from INVOICE
	order by  IDInvoice desc
end
go

--11. Load dữ liệu bảng Customer vào datagridView
if OBJECT_ID('LOADCUSTOMER') is not null drop PROC LOADCUSTOMER
go

create PROC LOADCUSTOMER
as
begin
	select *
	from CUSTOMER
	order by Name asc
end
go

--12. Load dữ liệu bảng ROOMS vào datagridView
if OBJECT_ID('LOADROOMS') is not null drop PROC LOADROOMS
go
create PROC LOADROOMS
as
begin 
	select IDRoom, Type, KindOf, Requirement , Price , State
	from ROOMS
	order by Type, KindOf
end
go

if OBJECT_ID('LOADROOMSNOTREQUIMENT') is not null drop PROC LOADROOMSNOTREQUIMENT
go
create PROC LOADROOMSNOTREQUIMENT
as
begin 
	select IDRoom, Type, KindOf, Price , State
	from ROOMS
	order by Type, KindOf
end
go

if OBJECT_ID('SEARCHROOMREQUIMENTBYID') is not null drop PROC SEARCHROOMREQUIMENTBYID
go
create PROC SEARCHROOMREQUIMENTBYID
@id varchar(50)
as
begin 
	select *
	from ROOMS
	where IDRoom=@id
end
go

--13. Load dữ liệu bảng Service vào datagridView
if OBJECT_ID('LOADSERVICE') is not null drop PROC LOADSERVICE
go
create PROC LOADSERVICE
as
begin
	select *
	from SERVICES
	order by Name
end
go

--14. Load dữ liệu bảng Tables vào datagridView
if OBJECT_ID('LOADTABLES') is not null drop PROC LOADTABLES
go
create PROC LOADTABLES
as
begin
	select *
	from TABLES
end
go

--15. Load dữ liệu bảng MenuFood vào datagridView
if OBJECT_ID('LOADMENUFOOD') is not null drop PROC LOADMENUFOOD
go
create PROC LOADMENUFOOD
as
begin
	select *
	from MENUFOOD
	order by IDFood
end
go

if OBJECT_ID('LOADMENUFOODNOTDESCRIPTION') is not null drop PROC LOADMENUFOODNOTDESCRIPTION
go
create PROC LOADMENUFOODNOTDESCRIPTION
as
begin
	select IDFood, Name, Price, Available
	from MENUFOOD
	order by IDFood
end
go

if OBJECT_ID('SEARCHMENUFOODDESCRIPTIONBYID') is not null drop PROC SEARCHMENUFOODDESCRIPTIONBYID
go
create PROC SEARCHMENUFOODDESCRIPTIONBYID
@id int
as
begin 
	select Description
	from MENUFOOD
	where IDFood=@id
end
go

-- Load dữ liệu bảng Voucher vào datagridView


-- Insert Voucher input(*)
if OBJECT_ID('INSERTVOUCHER') is not null drop PROC INSERTVOUCHER
go

create PROC INSERTVOUCHER
@idvoucher int,
@area nvarchar(50),
@name varchar(50),
@startdate datetime,
@exptirationdate datetime,
@percents int
as
begin
	insert into VOUCHER(IDVoucher, Area, Name, StartDate, ExprirationDate, Percents)
	values (@idvoucher,@area,@name,@startdate,@exptirationdate,@percents)
end
go

--16. Load dữ liệu bảng Voucher vào datagridView
if OBJECT_ID('LOADVOUCHER') is not null drop PROC LOADVOUCHER
go
create PROC LOADVOUCHER
as
begin 
	select *
	from VOUCHER
	order by Area, Name
end
go
--16. Load dữ liệu bảng Voucher vào datagridView
if OBJECT_ID('LOADVOUCHERBYID') is not null drop PROC LOADVOUCHERBYID
go
create PROC LOADVOUCHERBYID
@id int
as
begin 
	select *
	from VOUCHER
	where IDVoucher=@id
	order by Area, Name	
end
go

--16.2. Delete Voucher
if OBJECT_ID('DELETEVOUCHER') is not null drop PROC DELETEVOUCHER
go 

create  PROC DELETEVOUCHER
@ID int
as
begin
	select @ID = IDVoucher
	from VOUCHER
	where IDVoucher = @ID
	if (@ID is not null)
		DELETE from VOUCHER where IDVoucher = @ID
	else
		throw 5000, 'Permission not exist', 1;
end
go

--16.3 update Voucher
if OBJECT_ID('UPDATEVOUCHER') is not null drop PROC UPDATEVOUCHER
go
create PROC UPDATEVOUCHER
@ID int,
@area nvarchar(50),
@name nvarchar(200),
@startDate datetime,
@expriration datetime,
@percents int
as
begin 
	UPDATE VOUCHER set Area = @area, Name = @startDate, ExprirationDate = @expriration, Percents = @percents where IDVoucher = @ID
end
go


--17. Load dữ liệu Employee theo nhóm Area.
if OBJECT_ID('LOADEMPOYEETOAREA') is not null drop PROC LOADEMPOYEETOAREA
go
--17
create PROC LOADEMPOYEETOAREA
@Area int
as
begin
	select  *
	from  EMPLOYEE
	where IDArea = @Area
end
go

--18.1 AUTO INCREMENT Field IDEmployee
if OBJECT_ID('AUTOINCREMENTEMPLOYEE') is not null drop PROC AUTOINCREMENTEMPLOYEE
go

create PROC AUTOINCREMENTEMPLOYEE
as
begin
	--declare @idEmployeenew varchar(50)
	
	select top 1 ('NV' + Cast(Cast(SUBSTRING((IDEmployee), 3, 47) as int) + 1 as varchar)) as IDNewEmployee
	from EMPLOYEE
	order by IDEmployee desc
end
go

--18.2 Insert Employee input(*)
if OBJECT_ID('INSERTEMPLOYEE') is not null drop PROC INSERTEMPLOYEE
go

create PROC INSERTEMPLOYEE
@idEmployee varchar(50),
@fullname nvarchar(50),
@avatar image,
@birthday date,
@gender bit,
@adress nvarchar(200),
@idCard varchar(10),
@phone varchar(10),
@idBaseSalary int,
@idArea int,
@state nvarchar(200)
as
begin
	insert into EMPLOYEE(IDEmployee, Fullname, Avatar, Birthday, Gender, Adress, IDCard, Phone, IDBaseSalary, IDArea, State)
	values (@idEmployee, @fullname, @avatar, @birthday, @gender, @adress, @idCard, @phone, @idBaseSalary, @idArea, @state)
end
go


--19. Update Employyee input (*)
if OBJECT_ID('UPDATEEMPLOYEE') is not null drop PROC UPDATEEMPLOYEE
go

create PROC UPDATEEMPLOYEE
@idEmployee nvarchar(50),
@fullname nvarchar(50),
@avatar image,
@birthday date,
@gender bit,
@adress nvarchar(200),
@idCard varchar(10),
@phone varchar(10),
@idBaseSalary int,
@idArea int,
@state nvarchar(200)
as
begin 
	UPDATE EMPLOYEE set Fullname = @fullname, Avatar = @avatar, Birthday = @birthday, Gender = @gender
	, Adress = @adress, IDCard = @idCard, Phone = @phone, IDBaseSalary = @idBaseSalary, IDArea = @idArea, State = @state where IDEmployee = @idEmployee
end
go

--20. Delete Employee input (IDEmployee)
if OBJECT_ID('DELETEEMPLOYEE') is not null drop PROC DELETEEMPLOYEE
go
create PROC DELETEEMPLOYEE
@idEmployee nvarchar(50)
as 
begin
	DELETE from EMPLOYEE where IDEmployee = @idEmployee
end
go


--21. Insert Permission vào Account input(username, permission)
if OBJECT_ID('ADDPERMISSIONTOACCOUNT') is not null drop proc ADDPERMISSIONTOACCOUNT;
go
create proc ADDPERMISSIONTOACCOUNT
@username varchar(50),
@permission int
as
begin
-----lưu giá trị Group_permission vào bảng tạm
	If OBJECT_ID('tempđb..#Copy') is not null drop table #Copy;
	select GROUP_PERMISSION.IDPermission, PERMISSION.Name into #Copy
	from	((	ACCOUNT join GROUPUSER on ACCOUNT.IDGroup = GROUPUSER.IDGroup)
				join GROUP_PERMISSION on GROUPUSER.IDGroup = GROUP_PERMISSION.IDGroup
				join Permission on Group_Permission.IDPermission=Permission.IDPermission
				)
	where  Account.UserName= @username;

	declare @checkPermission varchar(50)

---Kiểm tra xem có tồn tại permission cần điền chưa
	select @checkPermission = 'True'
	from  #Copy
	where IDPermission = @Permission

-----lưu giá trị user_permission vào bảng tạm
	If OBJECT_ID('tempđb..#Copy1') is not null drop table #Copy1;
	select  IDPermission into #Copy1
	from	ACCOUNT join ACCOUNT_PERMISSION on ACCOUNT.Username =  ACCOUNT_PERMISSION.Username
	where  ACCOUNT.Username = @username;
---Kiểm tra xem có tồn tại permission cần điền chưa
	select @checkPermission = 'True'
	from  #Copy1
	where @checkPermission = @Permission

	if (@CheckPermission='True')
	begin
		Update ACCOUNT_PERMISSION set IDPermission = @Permission where Username = @username;
	end;
	else
	begin
		Insert dbo.ACCOUNT_PERMISSION(UserName,IDPermission) values (@username,@permission)
	end;
end;
go

--22. Delete Permission cho Account intput(username, Permission)
if OBJECT_ID('DELETEPERMISSIONTOACCOUNT') is not null drop PROC DELETEPERMISSIONTOACCOUNT
go 

create  PROC DELETEPERMISSIONTOACCOUNT
@username varchar(100),
@permission nvarchar(200)
as
begin
	declare @idPermission int
	select @idPermission = IDPermission
	from PERMISSION
	where Name = @permission 
	if (@idPermission is not null)
		DELETE from ACCOUNT_PERMISSION where Username = @username and IDPermission = @idPermission
	else
		throw 5000, 'Permission not exist', 1;
end
go

--23. Checkout customer cho bảng booktable input(customer)
/*if OBJECT_ID('CHECKCUSTOMERBOOKTABLE') is not null drop PROC CHECKCUSTOMERBOOKTABLE
go

create PROC CHECKCUSTOMERBOOKTABLE
@customer nvarchar(100)
as
begin
	declare @idCustomer varchar(100)
	select @idCustomer = IDCustomer
	from CUSTOMER
	where Name = @customer

	if (@idCustomer is not null)
		select *
		from BOOK_TABLE										--phone chứ không phải idcustomer
		where IDCustomer = @idCustomer
	else
		throw 5000,  'Customer not exist', 1;
end
go*/

--==============================================================================================================================
if OBJECT_ID('CHECKCUSTOMERBOOKTABLES') is not null drop PROC CHECKCUSTOMERBOOKTABLES
go
create PROC CHECKCUSTOMERBOOKTABLES
@customer nvarchar(100)
as
begin
	declare @phoneCustomer varchar(100)
	select @phoneCustomer = Phone
	from CUSTOMER
	where Name = @customer

	if (@phoneCustomer is not null)
		select *
		from BOOK_TABLE
		where Phone = @phoneCustomer
	else
		throw 5000,  'Customer not exist', 1;
end
go

--24.Load food

if OBJECT_ID('LOADMENUFOOD') is not null drop PROC LOADMENUFOOD
go
create PROC LOADMENUFOOD
as
begin
	select *
	from MENUFOOD
	order by Name
end
go

--24.1 InsertFood
if OBJECT_ID('INSERTFOOD') is not null drop PROC INSERTFOOD
go

create PROC INSERTFOOD
@idFood int,
@name nvarchar(200),
@price float,
@description nvarchar(200),
@picture image,
@available int
as
begin
	insert into MENUFOOD(IDFood, Name, Price, Description,Picture, Available)
	values (@idFood,@name,@price,@description,@picture,@available)
end
go

--24.2 DeleteFood
if OBJECT_ID('DELETEFOOD') is not null drop PROC DELETEFOOD
go 

create  PROC DELETEFOOD
@ID int
as
begin
	select @ID = IDFood
	from MENUFOOD
	where IDFood = @ID
	if (@ID is not null)
		DELETE from MENUFOOD where IDFood= @ID
	else
		throw 5000, 'Permission not exist', 1;
end
go

--24.3 updateFood
if OBJECT_ID('UPDATEFOOD') is not null drop PROC UPDATEFOOD
go

create PROC UPDATEFOOD
@idFood int,
@name nvarchar(50),
@price float,
@description nvarchar(200),
@picture image,
@available int
as
begin 
	UPDATE MENUFOOD set Name = @name, Price = @price, Description = @description, Picture = @picture ,Available=@available where IDFood = @idFood
end
go
--16.5 Load dữ liệu bảng Voucher vào datagridView
if OBJECT_ID('LOADFOODBYID') is not null drop PROC LOADFOODBYID
go
create PROC LOADFOODBYID
@id int
as
begin 
	select *
	from MENUFOOD
	where IDFood=@id
	order by IDFood, Name	
end
go


--24.1 AUTO INCREMENT Field Customer
if OBJECT_ID('AUTOINCREMENTCUSTOMER') is not null drop PROC AUTOINCREMENTCUSTOMER
go

create PROC AUTOINCREMENTCUSTOMER
as
begin
	select top 1 ('C' + Cast(Cast(SUBSTRING((IDCustomer), 2, 47) as int) + 1 as varchar)) as IDNewCustomer
	from CUSTOMER
	order by IDCustomer desc
end
go
	
--25.1 AUTO INCREMENT Field Invoice
if OBJECT_ID('AUTOINCREMENTINVOICE') is not null drop PROC AUTOINCREMENTINVOICE
go

create PROC AUTOINCREMENTINVOICE
as
begin
	select top 1 ('IV' + Cast(Cast(SUBSTRING((IDInvoice), 3, 47) as int) + 1 as varchar)) as IDNewInvoice
	from INVOICE
	order by IDInvoice desc
end
go

--26. Select Invoice theo type = Park
if OBJECT_ID('SELECTINVOICEPARK') is not null drop PROC SELECTINVOICEPARK
go

create PROC SELECTINVOICEPARK
as
begin
	select *
	from INVOICE
	where Type = 'Park'
end
go
--27. Select Invoice theo Type = Room
if OBJECT_ID('SELECTINVOICEROOM') is not null drop PROC SELECTINVOICEROOM
go

create PROC SELECTINVOICEROOM
as
begin
	select *
	from INVOICE
	where Type = 'Room'
end
go
--28. Select Invoice theo Type = Service
if OBJECT_ID('SELECTINVOICESERVICE') is not null drop PROC SELECTINVOICESERVICE
go
create PROC SELECTINVOICESERVICE
as
begin
	select *
	from INVOICE
	where Type = 'Service'
end
go

--29. Select Invoice theo Type = Food
if OBJECT_ID('SELECTINVOICEFOOD') is not null drop PROC SELECTINVOICEFOOD
go
create PROC SELECTINVOICEFOOD
as
begin
	select *
	from INVOICE
	where Type = 'Food'
end
go
--30 Select Details Invoice theo IdInvoice input(IDInvoice)
if OBJECT_ID('SELECTDETAILSFROMIDINVOICE') is not null drop PROC SELECTDETAILSFROMIDINVOICE
go

create PROC SELECTDETAILSFROMIDINVOICE
@idInvoice varchar(50)
as
begin
	declare @type nvarchar(200)
	select @type = Type
	from INVOICE
	where IDInvoice = @idInvoice
	if (@type = 'Room')
		select *
		from DETAILINVOICEROOM
		where IDInvoice = @idInvoice
	if (@type = 'Food')
		select *
		from DETAILINVOICEFOOD
		where IDInvoice = @idInvoice
	if (@type = 'Service')
		select *
		from DETAILINVOICESERVICES
		where IDInvoice = @idInvoice
	if (@type = 'Park')
		select *
		from DETAILINVOICEPARK
		where IDInvoice = @idInvoice
end
go

--31. CHECK Customer đã sài Voucher chưa input(IDVoucher)
if OBJECT_ID('CHECKVOUCHERFORCUSTOMER') is not null drop PROC CHECKVOUCHERFORCUSTOMER
go

create PROC CHECKVOUCHERFORCUSTOMER
@idCustomer varchar(50),
@idVoucher int
as
begin 
	declare @checkInvoice bit
	select @checkInvoice = 1
	from INVOICE
	where IDCustomer = @idCustomer and IDVoucher = @idVoucher
	if (@checkInvoice is not null)
		select 'true' as exist
	else
		select 'false' as exist
end
go

--32. Check Area theo IDInvoice input(IdInvoice)
if OBJECT_ID('CHECKAREAOFIDVOUCHER') is not null drop PROC CHECKAREAOFIDVOUCHER
go

create PROC CHECKAREAOFIDVOUCHER
@idVoucher int
as
begin
	select Area
	from VOUCHER
	where IDVoucher = @idVoucher
end
go

--33. Search Employee theo ID, Name
if OBJECT_ID('SEARCHEMPLOYEE') is not null drop PROC SEARCHEMPLOYEE
go

create PROC SEARCHEMPLOYEE
@idEmployee varchar(50),
@name nvarchar(50)
as
begin
	select *
	from EMPLOYEE
	where IDEmployee like '%'+ @idEmployee +'%' or Fullname like '%'+ @name +'%'
end
go

--34. Search Voucher theo ID, Name
if OBJECT_ID('SEARCHVOUCHER') is not null drop PROC SEARCHVOUCHER
go

create PROC SEARCHVOUCHER
@idVoucher varchar(50),
@name nvarchar(50)
as
begin
	select *
	from VOUCHER
	where IDVoucher like '%'+ @idVoucher +'%' or Name like '%'+ @name +'%'
end
go

--35. Search Food theo ID, Name
if OBJECT_ID('SEARCHFOOD') is not null drop PROC SEARCHFOOD
go

create PROC SEARCHFOOD
@idFood varchar(50),
@name nvarchar(50)
as
begin
	select *
	from MENUFOOD
	where IDFood like '%'+ @idFood +'%' or Name like '%'+ @name +'%'
end
go


--36. Search IdCustomer trong bảng BookRoom

if OBJECT_ID('SEARCHCUSTOMERBOOKROOM') is not null drop PROC SEARCHCUSTOMERBOOKROOM
go

create PROC SEARCHCUSTOMERBOOKROOM
@idCard varchar(10)
as
begin
	select *
	From BOOK_ROOM
	where IDCard like @idCard + '%'
end
go


if OBJECT_ID('LOADBOOKROOM') is not null drop PROC LOADBOOKROOM
go
create PROC LOADBOOKROOM
as
begin 
	select *
	from BOOK_ROOM
	order by IDRoom
end
go

if OBJECT_ID('LOADBOOKTABLE') is not null drop PROC LOADBOOKTABLE
go
create PROC LOADBOOKTABLE
as
begin 
	select *
	from BOOK_TABLE
	order by IDTable
end
go

if OBJECT_ID('SEARCHCHECKINBOOKTABLE') is not null drop PROC SEARCHCHECKINBOOKTABLE
go
create PROC SEARCHCHECKINBOOKTABLE
@idtable int
as
begin 
	select *
	from BOOK_TABLE
	where @idtable = IDTable
end
go

--37. Check Room trống trong bảng Book_Room input(DateCheckin, Datecheckout)
if OBJECT_ID('CHECKTIMEROOM') is not null drop PROC CHECKTIMEROOM
go

create PROC CHECKTIMEROOM
@dateCheckin datetime,
@dateCheckout datetime
as
begin
	If OBJECT_ID('tempđb..#Copy') is not null drop table #Copy;
	select * into #Copy
	from  BOOK_ROOM 
	where (DateCheckin <= @dateCheckin and DateCheckout >= @dateCheckout) 
	or (@dateCheckin <= DateCheckout)
	or (DateCheckin <= @dateCheckout)

	select ROOMS.IDRoom
	from ROOMS FULL OUTER JOIN #Copy on ROOMS.IDRoom = #Copy.IDRoom
	where #Copy.IDRoom is null and ROOMS.IDRoom is not null
end
go

--38. Load State Room.
if OBJECT_ID('SELETESTATEROOM') is not null drop PROC SELETESTATEROOM
go

create PROC SELETESTATEROOM
@state nvarchar(200)
as
begin
	select IDRoom, Type, KindOf, Price , State
	from ROOMS
	where State like '%' + @state + '%'
end
go

--Search Customer trong bảng BookTable
if OBJECT_ID('SEARCHCUSTOMERBOOKTABLES') is not null drop PROC SEARCHCUSTOMERBOOKTABLES
go

create PROC SEARCHCUSTOMERBOOKTABLES
@phone varchar(10)
as
begin
	select *
	From BOOK_Table
	where Phone like @phone + '%'
end
go

if OBJECT_ID('SEARCHPHONEBOOKTABLES') is not null drop PROC SEARCHPHONEBOOKTABLES
go

create PROC SEARCHPHONEBOOKTABLES
@id varchar(10)
as
begin
	select *
	From BOOK_TABLE
	where IDTable =@id
end
go

if OBJECT_ID('SEARCHIDTABLES') is not null drop PROC SEARCHIDTABLES
go

create PROC SEARCHIDTABLES
@id varchar(10)
as
begin
	select *
	From TABLES
	where IDTable =@id
end
go

--42. Insert BookTable
If OBJECT_ID('INSERTBOOKTABLE') is not null drop PROC INSERTBOOKTABLE
go

create PROC INSERTBOOKTABLE
@idTable int,
@Phone varchar(10),
@dateBooked datetime,
@timeLine datetime,
@State nvarchar(200)
as
begin
	declare @checkStateRoom bit
	select @checkStateRoom = 1
	from TABLES
	where State = 'Empty' and IDTable = @idTable

	if (@checkStateRoom is not null)
		Insert into BOOK_TABLE (IDTable, Phone, DateBooked, Timeline, State)
		values (@idTable, @Phone, @dateBooked, @timeLine, @State)
	else
		throw 50000, 'State table diffrent Empty' , 0;
end
go

--43. update state trong bảng Tables
if OBJECT_ID('UPDATESTATETABLES') is not null drop PROC UPDATESTATETABLES
go

create PROC UPDATESTATETABLES
@idTable int,
@state nvarchar(200)
as
begin
	UPDATE TABLES SET State = @state where IDTable = @idTable
end
go

--41. Search Customer đang ở trong Table và hóa đơn của khách đó.
If OBJECT_ID('SEARCHCUSTOMERANDINVOICEINTABLE') is not null drop PROC SEARCHCUSTOMERANDINVOICEINTABLE
go

create PROC SEARCHCUSTOMERANDINVOICEINTABLE
@idTable int
as
begin
	declare @customer nvarchar(50),
	@idInvoice varchar(50),
	@state nvarchar(200),
	@idCustomer varchar(50)

	select @idCustomer = IDCustomer , @state = State
	from TABLES join CUSTOMER_TABLE on TABLES.IDTable = CUSTOMER_TABLE.IDTable
	where TABLES.IDTable = @idTable and State = 'Full'

	select @customer = Name
	from CUSTOMER
	where IDCustomer = @idCustomer


	select top 1 @idInvoice = IDInvoice
	from INVOICE
	where IDCustomer = @idCustomer and Payment is null and Type = 'Food'
	order by IDInvoice desc

	select @idTable as IDTable, @state as State, @idCustomer as IDCustomer, @customer as NameCustomer, * 
	from DETAILINVOICEFOOD
	where IDInvoice = @idInvoice
end
go

--56. Select Service room. input(idRoom)
if OBJECT_ID('SELECTSERVICEAVAILABLE') is not null drop PROC SELECTSERVICEAVAILABLE
go

create PROC SELECTSERVICEAVAILABLE
@idRoom varchar(50)
as
begin
	select SERVICES.IDService, Name, SERVICE_AVAILABLE.State
	from SERVICE_AVAILABLE join SERVICES on SERVICE_AVAILABLE.IDService = SERVICES.IDService
	where IDRoom = @idRoom
end
go

--57. Update State Service Room input(idRoom, idService, state)
if OBJECT_ID('UPDATESTATESERVICEROOM') is not null drop PROC UPDATESTATESERVICEROOM
go

create PROC UPDATESTATESERVICEROOM
@idRoom varchar(50),
@idService int,
@state nvarchar(200)
as
begin
	declare @checkUpdateService bit,
	@checkIdCustomer varchar(50),
	@checkInvoice varchar(50),
	@checkDetailService bit
		UPDATE SERVICE_AVAILABLE SET State = @state  where IDRoom = @idRoom and IDService = @idService
		select @checkUpdateService = 1
		from SERVICE_AVAILABLE
		where IDRoom = @idRoom and IDService = @idService and State = 'Failed'
	
	if (@checkUpdateService is not null)
	begin
		select @checkIdCustomer = IDCustomer
		from CUSTOMER_ROOM
		where IDRoom = @idRoom

		select top 1 @checkInvoice = IDInvoice
		from INVOICE
		where IDCustomer = @checkIdCustomer and Payment is null and Type = 'Service'

		declare @priceService float
		select  @priceService = Price 
		from SERVICES
		where IDService = @idService

		select @checkDetailService = 1
		from DETAILINVOICESERVICES
		where IDInvoice = @checkInvoice
			if (@checkDetailService is not null)
				Insert into DETAILINVOICESERVICES (IDInvoice, Name, Quantity, Price)
				values (@checkInvoice, @idService, 1, @priceService)
			else
				throw 5000, 'Not find Invoice of customer',0;
	end
end
go




--exec LOADACCOUNT 
--exec LOADAREA
--exec LOADBASESALARY
--exec LOADCUSTOMER
--exec LOADEMPLOYEE
--exec LOADGROUPUSER
--exec LOADINVOICE
--exec LOADMENUFOOD
--exec LOADPERMISSION
--exec LOADROOMS
--exec LOADSERVICE
--exec LOADTABLES
--exec LOADVOUCHER
--exec INSERTEMPLOYEE N'LQNVuong', null, null, null, N'Quận 1' , '261548432', '0823048409', null, null, N'Tốt'
--exec UPDATEEMPLOYEE 'NV1000' , N'Vuong', null, null, null, N'Quận 1' , '261548432', null, null, null, N'Tốt'
--exec DELETEEMPLOYEE 'NV1000'
--exec DELETEPERMISSIONTOACCOUNT 'nguyenvuong' , N'In hóa đơn'
--exec CHECKCUSTOMER N'Hoàng Hiệp'
--exec AUTOINCREMENTEMPLOYEE
--exec AUTOINCREMENTCUSTOMER
--exec AUTOINCREMENTINVOICE
--exec SELECTINVOICEROOM
--exec SELECTINVOICEFOOD
--exec SELECTINVOICEPARK
--exec SELECTINVOICESERVICE
--exec SELECTDETAILSFROMIDINVOICE 'IV0004'
--EXEC INSERTVOUCHER '22', '2',' sadsa  ','20130128','20130128','2'
--exec CHECKVOUCHERFORCUSTOMER 'C0001', 1
--exec CHECKAREAOFIDVOUCHER 2
--exec SEARCHEMPLOYEE null , N'Vu'
--exec SEARCHVOUCHER null, N'hải sản'
--exec SEARCHFOOD null, N'ngừ'
--exec SEARCHCUSTOMERBOOKROOM '9898272625'
--exec CHECKTIMEROOM '05/06/2020 08:00' , '05/21/2020 20:00'
---------------------------------------------------------------------------------------------------------------------------------------
----3. Thêm Account vào bảng Account.
--if OBJECT_ID('INSERTAccount') is not null drop proc INSERTAccount;
--go

--create proc INSERTAccount
--@UserName varchar(50),
--@Password_new varchar(50),
--@Ho_Ten varchar(50),
--@Type_User int,
--@Description_User varchar (50)
--as
--begin
--	declare @CheckUser varchar(50)
--	select @CheckUser=UserName
--	from Account
--	where @UserName=UserName;

--	if @UserName=@CheckUser or @UserName is null
--		Throw 50001,'Not insert Account.',1;
--	else
--		Insert Account (UserName,Password_new,Password_old,Ho_Ten,Type_User,Description_User)
--		values (@UserName,@Password_new,'0',@Ho_Ten,@Type_User,@Description_User)
--end
--go


--if OBJECT_ID('UPDATEAccount') is not null drop proc UPDATEAccount
--go
----4. Thay Đổi PassWord của Account đã chọn trong bảng Account.
--create proc UPDATEAccount
--@UseName varchar(50),
--@Password_new varchar(50)
--as
--begin
--	declare @CheckPassword varchar(50)
--	select @CheckPassword=Password_new
--	from Account
--	where @UseName=UserName

--	UPDATE Account Set Password_new=@Password_new, Password_old=@CheckPassword where UserName=@UseName;
--end;
--go


--if OBJECT_ID('DELETEAccount') is not null drop proc DELETEAccount;
--go
----5. Xóa Account đã chọn trong bảng Account.
--create proc DELETEAccount
--@UserName varchar(50)
--as
--begin
--	Delete Account where UserName=@UserName;
--end
--go



----Bảng Group--

--if OBJECT_ID('LOADGroupUser') is not null drop PROC LOADGroupUser;
--go
----6. Load dữ liệu bảng GroupUser vào datagridView.
--create PROC LOADGroupUser 
--as
--begin 
--	select Id_Group,Group_Name,Description_Group
--	from GroupUser
--	order by Id_Group asc
--end
--go

--if OBJECT_ID('INSERTGroupUser') is not null drop proc INSERTGroupUser;
--go
----7. Thêm GroupUser vào bảng GroupUser.
--create proc INSERTGroupUser
--@Name varchar(50),
--@Description_Group varchar(50)
--as
--begin
--	declare @CheckNameGroup varchar(50)
--	select @CheckNameGroup=Group_Name
--	from GroupUser
--	where @Name=Group_Name;

--	if @Name=@CheckNameGroup or @Name is null
--		Throw 50001,'Not insert Account.',1;
--	else
--		Insert GroupUser(Group_Name,Description_Group)
--		values (@Name,@Description_Group)
--end
--go


--if OBJECT_ID('UPDATEGroupUser') is not null drop proc UPDATEGroupUser
--go
----8. Thay Đổi PassWord của GroupUser đã chọn trong bảng GroupUser.
--create proc UPDATEGroupUser
--@Id int,
--@Name varchar(50),
--@Description_Group varchar (50)
--as
--begin
	
--	UPDATE GroupUser Set Group_Name=@Name, Description_Group=@Description_Group where Id_Group=@Id;
--end;
--go


--if OBJECT_ID('DELETEGroupUser') is not null drop proc DELETEGroupUser;
--go
----9. Xóa Account đã chọn trong bảng Account.
--create proc DELETEGroupUser
--@Name varchar(50)
--as
--begin
--	Delete GroupUser where Group_Name=@Name;
--end
--go



----Bảng Permission--

--if OBJECT_ID('LOADPermission') is not null drop PROC LOADPermission;
--go
----6. Load dữ liệu bảng GroupUser vào datagridView.
--create PROC LOADPermission 
--as
--begin 
--	select Id_Permission,Name_Permission,Description_Permission
--	from Permission
--	order by Name_Permission asc
--end
--go

--if OBJECT_ID('INSERTPermission') is not null drop proc INSERTPermission;
--go

----7. Thêm Permission vào bảng Permission.
--create proc INSERTPermission
--@Name varchar(50),
--@Description_Permission varchar(50)
--as
--begin
--	declare @CheckNamePermission varchar(50)
--	select @CheckNamePermission=Name_Permission
--	from Permission
--	where @Name=Name_Permission;

--	if @Name=@CheckNamePermission or @Name is null
--		Throw 50001,'Not insert Account.',1;
--	else
--		Insert Permission(Name_Permission,Description_Permission)
--		values (@Name,@Description_Permission)
--end
--go


--if OBJECT_ID('UPDATEPermission') is not null drop proc UPDATEPermission
--go
----8. Thay Đổi PassWord của GroupUser đã chọn trong bảng GroupUser.
--create proc UPDATEPermission
--@Id int,
--@Name varchar(50),
--@Description_Permission varchar (50)
--as
--begin
--	UPDATE Permission Set Name_Permission=@Name, Description_Permission=@Description_Permission where Id_Permission=@Id;
--end;
--go


--if OBJECT_ID('DELETEPermission') is not null drop proc DELETEPermission;
--go
----9. Xóa Account đã chọn trong bảng Account.
--create proc DELETEPermission
--@Name varchar(50)
--as
--begin
--	Delete Permission where Name_Permission=@Name;
--end;
--go

--if OBJECT_ID('SEARCHGroup') is not null drop proc SEARCHGroup;
--go
----10
--create proc SEARCHGroup
--@Type_User int
--as
--begin
--	select *
--	from Account
--	where Type_User=@Type_User;
--end;
--go

--if OBJECT_ID('CHECKGROUP') is not null drop proc CHECKGROUP;
--go

--create proc CHECKGROUP
--@UserName nvarchar(50)
--as
--begin
--	select Type_User
--	from Account
--	where UserName=@UserName
--end;
--go


--if OBJECT_ID('DETAILUserName') is not null drop proc DETAILUserName;
--go

--create proc DETAILUserName
--@UserName nvarchar(50)
--as
--begin
--	select Ho_Ten,UserName, Password_new, Type_User, Group_Name, Description_User
--	from Account join GroupUser on Type_User = Id_Group
--	where UserName = @UserName;
--end;
--go






--if OBJECT_ID('SEARCHNameGroup') is not null drop proc SEARCHNameGroup;
--go
--create proc SEARCHNameGroup
--@id int
--as
--begin
--	select Group_Name
--	from GroupUser
--	where Id_Group=@id
--end;
--go


--If OBJECT_ID('LOADListAccount') is not null drop proc LOADListAccount;
--go

--create proc LOADListAccount
--as
--begin
--	select UserName, Ho_Ten, Description_User
--	from Account
--	order by Ho_Ten asc;
--end;
--go
