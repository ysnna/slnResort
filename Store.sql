﻿use ManagementResort
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
	order by Name
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




--if OBJECT_ID('ADDPermissionUserName') is not null drop proc ADDPermissionUserName;
--go
--create proc ADDPermissionUserName
--@UserName nvarchar(50),
--@Permission int
--as
--begin
-------lưu giá trị Group_permission vào bảng tạm
--	If OBJECT_ID('tempđb..#Copy') is not null drop table #Copy;
--	select Group_Permission.Id_Permission, Name_Permission into #Copy
--	from	((	Account join GroupUser on Type_User = Id_Group)
--				join Group_Permission on GroupUser.Id_Group = Group_Permission.Id_Group
--				join Permission on Group_Permission.Id_Permission=Permission.Id_Permission
--				)
--	where  Account.UserName=@UserName;

--	declare @CheckPermission varchar(50)

-----Kiểm tra xem có tồn tại permission cần điền chưa
--	select @CheckPermission = 'True'
--	from  #Copy
--	where Id_Permission=@Permission

-------lưu giá trị user_permission vào bảng tạm
--	If OBJECT_ID('tempđb..#Copy1') is not null drop table #Copy1;
--	select  Id_Permission into #Copy1
--	from	Account join User_Permission on Account.UserName=User_Permission.UserName
--	where  Account.UserName=@UserName;
-----Kiểm tra xem có tồn tại permission cần điền chưa
--	select @CheckPermission = 'True'
--	from  #Copy1
--	where Id_Permission=@Permission

--	if (@CheckPermission='True')
--	begin
--		Update User_Permission set Id_Permission=@Permission where UserName=@UserName;
--	end;
--	else
--	begin
--		Insert dbo.User_Permission(UserName,Id_Permission) values (@UserName,@Permission)
--	end;
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


