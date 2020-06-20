use ManagementResort
go


Insert into PERMISSION(IDPermission,Name,Description)
values
('1',N'Thêm Voucher',N'Thêm Voucher mới vào hệ thống'),
('2',N'Xếp lương',N'Xếp lương cho nhân viên trong hệ thống'),
('3',N'Thêm nhân viên',N'Thêm nhân viên mới đi làm vào hệ thống'),
('4',N'Xếp lịch nhân viên',N'Xếp lịch đi làm cho nhân viên'),
('5',N'Nhập hóa đơn',N'Tạo hóa đơn mới cho khách hàng và nhập thông tin'),
('6',N'Thanh toán hóa đơn',N'Thanh toán hóa đơn cho khách hàng và lưu vào hệ thống'),
('7',N'In hóa đơn',N'In hóa đơn vừa thanh toán cho khách hàng')
go

Insert into GROUPUSER(IDGroup,Name,Description)
values
('GROUPA',N'Quản Trị Viên',N'nhóm quyền dành cho Quản Trị Viên'),
('GROUPR',N'Nhân Viên Nhà Hàng',N'nhóm quyền dành cho quản lý khu nhà hàng'),
('GROUPH',N'Nhân Viên Khách Sạn',N'nhóm quyền dành cho quản lý khu khách sạn'),
('GROUPP',N'Nhân Viên Vui Chơi',N'nhóm quyền dành cho quản lý khu vui chơi')
go

Insert into GROUP_PERMISSION(IDGroup,IDPermission)
values
('GROUPA',1),
('GROUPA',2),
('GROUPA',3),
('GROUPA',4),
('GROUPA',5),
('GROUPA',6),
('GROUPA',7),

('GROUPR',3),

('GROUPH',4),

('GROUPP',4)

insert into BASESALARY(IDBaseSalary, Salary, TypeEmployee)
values
('1',100000,N'QLK1'),
('2',80000,N'QLK2'),
('3',40000,N'NV1')


insert into EMPLOYEE(IDEmployee,Fullname, Adress, IDCard,State)
values
('NV0001',N'Lê Hồng Danh',N'Hóc Môn, Thành Phố HCM',N'876383738',N'	'),
('NV0002',N'Nguyễn Lê Nguyên Anh', 'Bình Tân, Thành Phố HCM',N'9876272622',N'Đang làm việc'),
('NV0003',N'Lê Quốc Nguyên Vương', 'Thủ Đức, Thành Phố HCM',N'787678767',N'Đang làm việc'),
('NV0004',N'Ngô Trí Đức', 'Bến Cát , Thành Phố TDM',N'5627626653',N'Đã nghỉ việc'),
('NV0005',N'Lê Minh Tiến', 'Quận 2 Thảo Điền , Thành Phố HCM',N'2987282728',N'Đang làm việc'),
('NV0006',N'Bùi Quốc Cường', 'Bình Tân, Thành Phố HCM',N'0728272726',N'Đang làm việc'),
('NV0007',N'Võ Thành Văn', 'Bình Tân, Thành Phố HCM',N'0207262522',N'Đã nghỉ việc'),
('NV0008',N'Ngô Hoàng Minh Tâm', 'Bình Định, Thành Phố HCM',N'0002726252',N'Đã nghỉ việc'),
('NV0009',N'Võ Minh Hiếu', 'Phú Yên, Thành Phố HCM',N'0876543879',N'Đã nghỉ việc')

insert into ACCOUNT(Username,Password,IDGroup,IDEmployee)
values
('nguyenanh',N'nguyenanh',N'GROUPA',N'NV0002'),
('hongdanh',N'hongdanh',N'GROUPA',N'NV0001'),
('nguyenvuong',N'nguyenvuong',N'GROUPR',N'NV0003'),
('triduc',N'triduc',N'GROUPH',N'NV0004'),
('minhtien',N'minhtien',N'GROUPP',N'NV0005'),
('quoccuong',N'quoccuong',N'GROUPP',N'NV0005'),
('minhhieu',N'minhhieu',N'GROUPH',N'NV0009'),
('minhtam',N'minhtam',N'GROUPH',N'NV0008'),
('van',N'van',N'GROUPR',N'NV0007')


Insert into ACCOUNT_PERMISSION(Username,IDPermission)
values
('nguyenanh',N'1'),
('nguyenanh',N'5'),
('hongdanh',N'1'),
('hongdanh',N'2'),
('hongdanh',N'7'),
('nguyenvuong',N'3')


insert into AREA(IDArea,Name,IDManager)
values
('1',N'Khu vực nhà hàng',N'nguyenvuong'),
('2',N'Khu vực khách sạn',N'triduc'),
('3',N'Khu vực vui chơi',N'minhtien')

insert into SCHEDULE(Date,State)
values
('6/01/2020',N'đi làm'),
('6/02/2020',N'đi làm')


use ManagementResort
go

--Bảng Account--

 if OBJECT_ID('CHECKLOGIN') is not null drop PROC CHECKLOGIN;
 go
--1. Kiểm tra đăng nhập khi login vào.
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

exec CHECKPERMISSION 'nguyenanh'

if OBJECT_ID('CHECKPERGROUP') is not null drop proc CHECKGROUP;
go

create proc CHECKGROUP
@UserName nvarchar(50)
as
begin
	select GROUPUSER.IDGroup, Name
	from	((	ACCOUNT join GROUPUSER on ACCOUNT.IDGroup = GROUPUSER.IDGroup))
	where  Account.UserName=@UserName;
end

exec CHECKGROUP 'minhhieu'