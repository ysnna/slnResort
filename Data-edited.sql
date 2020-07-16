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

Insert into GROUPUSER(IDGroup,Name,Description)		--Nhân viên, quản lí
values
('GROUPAD',N'Quản Trị Viên',N'nhóm quyền dành cho Quản Trị Viên'),
('GROUPMR',N'Quản lý Nhà Hàng',N'nhóm quyền dành cho quản lý khu nhà hàng'),
('GROUPMH',N'Quản lý Khách Sạn',N'nhóm quyền dành cho quản lý khu khách sạn'),
('GROUPMP',N'Quản lý Vui Chơi',N'nhóm quyền dành cho quản lý khu vui chơi'),
('GROUPER',N'Nhân Viên Nhà Hàng',N'nhóm quyền dành cho nhân viên khu nhà hàng'),
('GROUPEH',N'Nhân Viên Khách Sạn',N'nhóm quyền dành cho nhân viên khu khách sạn'),
('GROUPEP',N'Nhân Viên Vui Chơi',N'nhóm quyền dành cho nhân viên khu vui chơi')
go

Insert into GROUP_PERMISSION(IDGroup,IDPermission)	--edit theo group user
values
('GROUPAD',1),
('GROUPAD',2),
('GROUPAD',3),
('GROUPAD',4),
('GROUPAD',5),
('GROUPAD',6),
('GROUPAD',7),


('GROUPMR',3),
('GROUPMR',5),
('GROUPMR',6),
('GROUPMR',7),
('GROUPMR',4),

('GROUPMH',3),
('GROUPMH',4),
('GROUPMH',5),
('GROUPMH',6),
('GROUPMH',7),

('GROUPMP',3),
('GROUPMP',4),
('GROUPMP',5),
('GROUPMP',6),
('GROUPMP',7),

('GROUPER',5),
('GROUPER',6),
('GROUPER',7),

('GROUPEH',5),
('GROUPEH',6),
('GROUPEH',7),

('GROUPEP',5),
('GROUPEP',6),
('GROUPEP',7)

Insert into BASESALARY(IDBaseSalary, Salary, TypeEmployee)	-- type là tên
values
('1',100000,N'Quản lý Khách sạn'),
('2',100000,N'Quản lý Nhà hàng'),
('3',100000,N'Quản lý Khu vui chơi'),
('4',80000,N'Nhân viên Khách sạn'),
('5',80000,N'Nhân viên Nhà hàng'),
('6',80000,N'Nhân viên Khu vui chơi')

insert into EMPLOYEE(IDEmployee,Fullname, Adress, IDCard,State)			---sửa state
values
('NV0001',N'Lê Hồng Danh',N'Hóc Môn',N'9876383738',N'Working'),
('NV0002',N'Nguyễn Lê Nguyên Anh','Bình Tân',N'9876272622',N'Working'),
('NV0003',N'Lê Quốc Nguyên Vương','Thủ Đức, Thành Phố HCM',N'7876787676',N'Working'),
('NV0004',N'Ngô Trí Đức','Bến Cát , Thành Phố TDM',N'5627626653',N'Resign'),
('NV0005',N'Lê Minh Tiến','Quận 2 Thảo Điền , Thành Phố HCM',N'2987282728',N'Working'),
('NV0006',N'Bùi Quốc Cường','Bình Tân, Thành Phố HCM',N'0728272726',N'Working'),
('NV0007',N'Võ Thành Văn','Bình Tân, Thành Phố HCM',N'0207262522',N'Working'),
('NV0008',N'Ngô Hoàng Minh Tâm','Bình Định, Thành Phố HCM',N'0002726252',N'Resign'),
('NV0009',N'Võ Minh Hiếu','Phú Yên, Thành Phố HCM',N'0876543879',N'Working'),
('NV0010',N'Lê Trọng Tuấn','Tây Ninh, Bình Dương',N'0122222287',N'Working'),
('NV0011',N'Trọng Hiếu','Tây Ninh, Bình Dương',N'0656565276',N'Working'),
('NV0012',N'Minh Hương','Gia Lai',N'0909090707',N'Working'),
('NV0013',N'Lưu Đình Chuẩn','Bình Thạnh, Thành phố HCM',N'0987777622',N'Working'),
('NV0014',N'Nguyễn Thành Công','Tân Phú,Hồ Chí Minh',N'0504048474',N'Working'),
('NV0015',N'Nguyễn Dương Đạt','Thủ Đức,Hồ Chí Minh',N'0625252625',N'Working'),
('NV0016',N'Nguyễn Minh Tiến','ĐakLak',N'0987654567',N'Working'),
('NV0017',N'Võ Phú Đức','Điện Biên',N'0876787652',N'Working'),
('NV0018',N'Nguyễn Nhật Hào','Biên hòa, Đồng Nai',N'0987876762',N'Working'),
('NV0019',N'Nguyễn Hữu Huân','Tây Ninh, Bình Dương',N'0655552625',N'Working'),
('NV0020',N'Bùi Đức Huy','Bình Phước',N'0123425262',N'Working'),
('NV0021',N'Võ Anh Huy','Thành Phố Mới, Bình Dương',N'0909090272',N'Working'),
('NV0022',N'Nguyễn Lâm Gia Khang','Bình Định',N'2020204040',N'Working'),
('NV0023',N'Đinh Bách Thông','Phú Quốc',N'0606060677',N'Working'),
('NV0024',N'Nguyễn Ngọc Minh Thư','Đà Nẵng',N'0422222262',N'Working'),
('NV0025',N'Trương Hoàng Xuân Thy','Cần Thơ',N'0222228272',N'Working'),
('NV0026',N'Nguyễn Đức Tính','Tây Ninh, Bình Dương',N'0122222287',N'Working'),
('NV0027',N'Phan Thị Thu Trang','Đà Nẵng',N'0707070707',N'Working'),
('NV0028',N'Huỳnh Minh Trí','Tây Ninh, Bình Dương',N'0020202050',N'Working'),
('NV0029',N'Nguyễn Văn Trung ','Tây Ninh, Bình Dương',N'0727272722',N'Working'),
('NV0030',N'Võ Hùng Tú ','Đồng Nai, Xuân lộc',N'0606060606',N'Working'),
('NV0031',N'Lê Nhật Tường','Tây Ninh, Bình Dương',N'0761616171',N'Working')

insert into ACCOUNT(Username,Password,IDGroup,IDEmployee)
values
('nguyenanh','nguyenanh','GROUPAD','NV0002'),
('hongdanh','hongdanh','GROUPAD','NV0001'),
('nguyenvuong','nguyenvuong','GROUPMR','NV0003'),
('triduc','triduc','GROUPMH','NV0004'),
('minhtien','minhtien','GROUPMP','NV0005'),
('quoccuong','quoccuong','GROUPEP','NV0006'),
('minhhieu','minhhieu','GROUPEH','NV0009'),
('minhtam','minhtam','GROUPEH','NV0008'),
('van','van','GROUPER','NV0007'),
('tuan','tuan','GROUPER','NV0010'),
('hieu','hieu','GROUPER','NV0011'),
('minhuong','minhhuong','GROUPER','NV0012'),
('dinhchuan','dinhchuan','GROUPER','NV0013'),
('thanhcong','thanhcong','GROUPER','NV0014'),
('duongdat','duongdat','GROUPER','NV0015'),
('tien','tien','GROUPEH','NV0016'),
('phuduc','phuduc','GROUPEH','NV0017'),
('nhathao','nhathao','GROUPEH','NV0018'),
('huuhuan','huuhuan','GROUPEH','NV0019'),
('duchuy','duchuy','GROUPEH','NV0020'),
('anhhuy','anhhuy','GROUPEH','NV0021'),
('giakhang','giakhang','GROUPEH','NV0022'),
('bachthong','bachthong','GROUPEP','NV0023'),
('minhthu','minhthu','GROUPEP','NV0024'),
('xuanhuy','xuanhuy','GROUPEP','NV0025'),
('ductinh','ductinh','GROUPEP','NV0026'),
('thutrang','thutrang','GROUPEP','NV0027'),
('minhtri','minhtri','GROUPEP','NV0028'),
('vantrung','vantrung','GROUPER','NV0029'),
('hungtu','hungtu','GROUPEP','NV0030'),
('nhattuong','nhattuong','GROUPEP','NV0031')

Insert into ACCOUNT_PERMISSION(Username,IDPermission)
values
('nguyenvuong','7')

insert into AREA(IDArea,Name,IDManager)			--update IDManager = IDEmployee
values
('1',N'Khu vực nhà hàng','NV0003'),
('2',N'Khu vực khách sạn','NV0004'),
('3',N'Khu vực vui chơi','NV0005'),
('4',N'Khu vực Resort','NV0002')

insert into SCHEDULE(Date,State)		--ngày nào off thì không có ngày đó trong Employee_Schedule
values
('05/01/2020','Active'),
('05/02/2020','Active'),
('05/03/2020','Active'),
('05/04/2020','Active'),
('05/05/2020','Active'),
('05/06/2020','Active'),
('05/07/2020','Active'),
('05/08/2020','Active'),
('05/09/2020','Active'),
('05/10/2020','Active'),
('05/11/2020','Active'),
('05/12/2020','Off'),
('05/13/2020','Active'),
('05/14/2020','Active'),
('05/15/2020','Active'),
('05/16/2020','Active'),
('05/17/2020','Active'),
('05/18/2020','Active'),
('05/19/2020','Active'),
('05/20/2020','Active'),
('05/21/2020','Active'),
('05/22/2020','Active'),
('05/23/2020','Active'),
('05/24/2020','Active'),
('05/25/2020','Active'),
('05/26/2020','Active'),
('05/27/2020','Active'),
('05/28/2020','Active'),
('05/29/2020','Active'),
('05/30/2020','Active'),
('05/31/2020','Off')

insert into EMPLOYEE_SCHEDULE(IDEmployee,Date,State)	--State: Đã làm việc (Worked), nghỉ có phép (Leave), nghỉ không phép (Awol)
values
('NV0001','05/01/2020','Worked'),
('NV0001','05/02/2020','Worked'),
('NV0001','05/03/2020','Worked'),
('NV0001','05/04/2020','Worked'),
('NV0001','05/05/2020','Worked'),
('NV0001','05/06/2020','Worked'),
('NV0001','05/07/2020','Worked'),
('NV0001','05/08/2020','Worked'),
('NV0001','05/09/2020','Worked'),
('NV0001','05/10/2020','Worked'),
('NV0001','05/11/2020','Worked'),
('NV0001','05/13/2020','Worked'),
('NV0001','05/14/2020','Worked'),
('NV0001','05/15/2020','Worked'),
('NV0001','05/16/2020','Worked'),
('NV0001','05/17/2020','Worked'),
('NV0001','05/18/2020','Worked'),
('NV0001','05/19/2020','Worked'),
('NV0001','05/20/2020','Worked'),
('NV0001','05/21/2020','Worked'),
('NV0001','05/22/2020','Worked'),
('NV0001','05/23/2020','Worked'),
('NV0001','05/24/2020','Worked'),
('NV0001','05/25/2020','Worked'),
('NV0001','05/26/2020','Worked'),
('NV0001','05/27/2020','Worked'),
('NV0001','05/28/2020','Worked'),
('NV0001','05/29/2020','Worked'),
('NV0001','05/30/2020','Worked'),
('NV0005','05/01/2020','Worked'),
('NV0005','05/02/2020','Leave'),
('NV0005','05/03/2020','Leave'),
('NV0005','05/04/2020','Worked'),
('NV0005','05/05/2020','Worked'),
('NV0005','05/06/2020','Worked'),
('NV0007','05/01/2020','Worked'),
('NV0007','05/02/2020','Worked'),
('NV0007','05/03/2020','Worked '),
('NV0007','05/04/2020','Worked'),
('NV0007','05/05/2020','Worked'),
('NV0007','05/06/2020','Worked'),
('NV0007','05/07/2020','Awol'),
('NV0007','05/08/2020','Worked'),
('NV0007','05/20/2020','Worked'),
('NV0007','05/16/2020','Worked'),
('NV0007','05/22/2020','Worked'),

('NV0008','05/20/2020','Worked'),
('NV0008','05/21/2020','Worked'),

('NV0010','05/01/2020','Worked'),
('NV0010','05/02/2020','Worked'),

('NV0012','05/01/2020','Worked'),

('NV0015','05/05/2020','Worked'),
('NV0015','05/06/2020','Worked'),

('NV0017','05/16/2020','Worked'),
('NV0017','05/20/2020','Worked'),


('NV0019','05/01/2020','Worked'),
('NV0019','05/21/2020','Worked'),
('NV0019','05/25/2020','Worked'),
('NV0019','05/02/2020','Worked'),
('NV0019','05/03/2020','Worked'),
('NV0019','05/04/2020','Worked'),
('NV0019','05/05/2020','Worked'),
('NV0019','05/06/2020','Worked'),
('NV0019','05/07/2020','Worked'),
('NV0019','05/08/2020','Worked'),
('NV0018','05/01/2020','Worked'),
('NV0018','05/02/2020','Leave'),
('NV0018','05/03/2020','Awol'),
('NV0018','05/04/2020','Worked'),
('NV0018','05/05/2020','Worked'),
('NV0018','05/06/2020','Worked'),
('NV0018','05/07/2020','Worked'),
('NV0018','05/08/2020','Worked'),
('NV0018','05/22/2020','Worked'),
('NV0018','05/25/2020','Worked'),

('NV0023','05/03/2020','Worked'),
('NV0023','05/04/2020','Worked'),

('NV0025','05/10/2020','Worked'),
('NV0025','05/01/2020','Worked'),
('NV0025','05/11/2020','Leave'),
('NV0025','05/13/2020','Worked'),
('NV0025','05/14/2020','Worked'),
('NV0025','05/15/2020','Worked'),
('NV0025','05/16/2020','Worked'),
('NV0025','05/17/2020','Worked'),
('NV0026','05/10/2020','Worked'),
('NV0026','05/11/2020','Worked'),
('NV0026','05/13/2020','Worked'),
('NV0026','05/14/2020','Worked'),
('NV0026','05/15/2020','Worked'),
('NV0026','05/16/2020','Worked'),
('NV0026','05/17/2020','Worked'),
('NV0026','05/01/2020','Worked'),
('NV0026','05/22/2020','Worked'),

('NV0029','05/01/2020','Worked'),
('NV0029','05/02/2020','Worked'),
('NV0029','05/03/2020','Worked')

insert into FORMS(IDForm,Date,IDEmployee)			--những nhân viên nghỉ có phép thì phải có đơn; date là ngày viết đơn
values
('1','05/29/2020 20:30','NV0005'),		--bổ sung thêm thời gian
('2','05/01/2020 08:56','NV0018'),
('3','05/29/2020 14:45','NV0025')

insert into DETAILFORM(IDForm,DateOff)			--dateOFF là xin nghỉ ngày nào, ngày xin nghỉ xuất hiện ở bảng này thì bảng EMPLOYEE_SCHEDULE sẽ hiển thị  state là Leave
values
('1','05/02/2020'),	--NV0005 xin nghỉ 2 ngày
('1','05/03/2020'),
('2','05/02/2020'),
('3','05/11/2020')

insert into REPORT(IDReport,IDEmployee,Date,Contents,Week,Total)		--datetime (bổ sung thêm thời gian), sửa lại total (vô lí)
values
('1','NV0004','05/05/2020 20:30',N'Doanh thu số 2',N'1',N'45500'),
('2','NV0003','05/06/2020 21:00',N'Doanh thu sô 3',N'1',N'55500'),
('3','NV0005','05/05/2020 07:30',N'Doanh thu số 4',N'1',N'60000'),
('4','NV0005','05/06/2020 05:09',N'Doanh thu số 5',N'2',N'60000'),
('5','NV0005','05/06/2020 08:40',N'Doanh thu số 6',N'7',N'60000')

insert into ROOMS(IDRoom,Requirement,KindOf,Type,Price,State)
values
('R0001',N'Phòng thuộc hạng vip vip',N'Phòng đơn',N'Phòng Suite (SUT)','25000000','Empty'),
('R0002',N'Phòng thuộc hạng vip vip',N'Phòng đôi',N'Phòng Deluxe (DLX)','40000000','Booked'),
('R0003',N'Phòng thuộc hạng vip vip',N'Phòng đơn',N'Phòng Suite (SUT)','25000000','Booked'),
('R0004',N'Phòng thuộc hạng vip vip',N'Phòng đơn',N'Phòng Suite (SUT)','25000000','Empty'),
('R0005',N'Phòng thuộc hạng vip vip',N'Phòng đơn',N'Phòng Suite (SUT)','25000000','Full'),
('R0006',N'Phòng thuộc hạng dành cho doanh nghiệp',N'Phòng tập thể (8 giường)',N'Phòng Suite (SUT)','55000000','Empty'),
('R0007',N'Phòng thuộc hạng dành cho doanh nghiệp',N'Phòng tập thể (8 giường)',N'Phòng Suite (SUT)','55000000','Full'),
('R0008',N'Phòng thuộc hạng dành cho doanh nghiệp',N'Phòng tập thể (8 giường)',N'Phòng Suite (SUT)','55000000','Empty'),
('R0009',N'Phòng thuộc hạng dành cho doanh nghiệp',N'Phòng tập thể (8 giường)',N'Phòng Suite (SUT)','55000000','Empty'),
('R0010',N'Phòng thuộc hạng dành cho doanh nghiệp',N'Phòng tập thể (8 giường)',N'Phòng Suite (SUT)','55000000','Full'),
('R0011',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Suite (SUT)','5000000','Full'),
('R0012',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Suite (SUT)','5000000','Empty'),
('R0013',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Standard (STD)','2500000','Full'),
('R0014',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Suite (SUT)','5000000','Full'),
('R0015',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Suite (SUT)','5000000','Empty'),
('R0016',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Standard (STD)','2500000','Empty'),
('R0017',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Standard (STD)','2500000','Empty'),
('R0018',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Suite (SUT)','5000000','Empty'),
('R0019',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Suite (SUT)','5000000','Full'),
('R0020',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Standard (STD)','2500000','Full'),
('R0021',N'Phòng dành cho khách du lịch',N'Phòng đơn',N'Phòng Standard (STD)','2500000','Empty'),
('R0022',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Standard (STD)','3500000','Empty'),
('R0023',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Standard (STD)','3500000','Empty'),
('R0024',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Standard (STD)','3500000','Full'),
('R0025',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Standard (STD)','3500000','Empty'),
('R0026',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Suite (SUT)','4500000','Empty'),
('R0027',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Suite (SUT)','4500000','Empty'),
('R0028',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Suite (SUT)','4500000','Full'),
('R0029',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Suite (SUT)','4500000','Full'),
('R0030',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Suite (SUT)','4500000','Empty'),
('R0031',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Suite (SUT)','4500000','Full'),
('R0032',N'Phòng dành cho khách du lịch',N'Phòng đôi',N'Phòng Suite (SUT)','4500000','Empty')

insert into CUSTOMER(IDCustomer,Name,Gender,IDCard,IDRoom)
values
('C0001',N'Hoàng Hiệp','0','0988876567','R0005'),
('C0002',N'Tấn Vỹ','0','9898272625','R00024'),
('C0003',N'Quốc Cường','0','8737363533','R0031'),
('C0004',N'Mỹ Dung','1','0980989878','R0028'),
('C0005',N'Uyên','1','8766543456','R0010'),
('C0006',N'Hồng Nhung','1','8871616151','R0020'),
('C0007',N'Xuân Mai','1','5465555656','R0007'),
('C0008',N'Tấn Dũng','0','8762726252','R00011'),
('C0009',N'Cao Anh','0','8777272727','R00019'),
('C0010',N'Tình Mai','0','8787878787','R0013'),
('C0011',N'Thiên Tài','0','7654333456','R0014'),
('C0012',N'Minh Thiên','0','0278766272','R0029')

insert into BOOK_ROOM(IDCard,IDRoom,DateBooked,DateCheckin,DateCheckout)
values
('0988876567','R0001','05/05/2020 12:00','05/06/2020 12:00','05/16/2020 13:00'),
('9898272625','R0003','05/15/2020 15:20','05/16/2020 18:00','05/20/2020 12:00'),
('8737363533','R0006','05/05/2020 08:20','05/05/2020 08:00','05/25/2020 15:30'),
('0980989878','R0009','05/05/2020 09:00','05/05/2020 09:00','05/20/2020 16:00'),
('8766543456','R0010','05/05/2020 07:45','05/06/2020 08:00','05/21/2020 20:00'),
('8871616151','R0011','05/05/2020 06:30','05/05/2020 06:35','05/22/2020 11:30'),
('7654333456','R0002','05/05/2020 06:30','05/07/2020 06:35','05/22/2020 11:30'),
('0278766272','R0031','05/05/2020 06:30','05/08/2020 06:35','05/22/2020 11:30')

insert into COMMENTS(IDComment,Comment,IDCustomer,Rating)
values
('1',N'Cảm thấy khu Resort nên một lần trải nghiệm, mọi dịch vụ ở đây rất tốt','C0001','1'),
('2',N'Tôi cảm thấy nhân viên ở đây còn thiếu chuyên nghiệp','C0002','1'),
('3',N'Chất lượng dịch vụ ở đây khá là OK!! nhưng giá hơi đắt so với tôi','C0003','1'),
('4',N'Mọi người nên đi thử khu Resort cảm thấy tuyệt nếu được ở đây free :))','C0004','1'),
('5',N'OK!! Tốt','C0005','1')

insert into SERVICES(IDService,Name,Description,Price,Available)			--sửa lại bảng này + available (available là số lượng có sẵn)
values
('1',N'Máy lạnh',N'Máy lạnh được lắp đặt sẵn trong mỗi phòng','2500000','100'),
('2',N'Quạt máy',N'Mỗi phòng được bổ sung thêm quạt máy','200000','100'),
('3',N'Tủ lạnh',N'Tủ lạnh chưa đựng thức ăn nhanh và đồ uống','3000000','100'),
('4',N'Pesi',N'Nước ngọt giải khác','10000','100'),
('5',N'Coca',N'Nước ngọt giải khác','10000','100'),
('6',N'Nước suối',N'Nước ngọt giải khác','80000','100'),
('7',N'Beer',N'Nước  giải khác','20000','100'),
('8',N'Khăn tắm',N'Khăn tắm 20cm x 40cm','400000','20')

insert into TABLES(IDTable,Slot,State)
values
('1','2','Pre order'),
('2','2','Pre order'),
('3','2','Pre order'),
('4','2','Pre order'),
('5','2','Pre order'),
('6','2','Pre order'),
('7','2','Empty'),
('8','2','Empty'),
('9','2','Full'),
('10','2','Full'),
('11','4','Full'),
('12','4','Empty'),
('13','4','Empty'),
('14','4','Empty'),
('15','4','Empty'),
('16','4','Pre order'),
('17','4','Pre order'),
('18','4','Pre order'),
('19','4','Empty'),
('20','4','Empty'),
('21','6','Empty'),
('22','6','Empty'),
('23','6','Full'),
('24','6','Full'),
('25','6','Pre order'),
('26','6','Empty'),
('27','6','Empty'),
('28','6','Empty'),
('29','6','Empty'),
('30','8','Empty'),
('31','8','Empty'),
('32','8','Full'),
('33','8','Full'),
('34','8','Empty'),
('35','8','Empty'),
('36','8','Empty'),
('37','8','Empty'),
('38','8','Empty'),
('39','8','Empty'),
('40','8','Empty'),
('41','16','Empty'),
('42','16','Pre order'),
('43','16','Pre order'),
('44','16','Empty'),
('45','16','Empty'),
('46','16','Empty'),
('47','16','Empty'),
('48','16','Empty'),
('49','16','Full'),
('50','16','Full')

insert into BOOK_TABLE(IDTable,Phone,DateBooked,Timeline,State)			----------------------------------------------------
values
('1','0988876567','05/22/2020 20:00','05/22/2020 21:30','off'),
('2','9898272625','05/01/2020 19:30','05/01/2020 20:30','off'),
('3','8737363533','05/01/2020 18:00','05/01/2020 19:00','off'),
('4','0980989878','05/01/2020 18:00','05/01/2020 19:00','off'),
('5','8766543456','05/05/2020 16:00','05/05/2020 17:00','off'),
('6','8871616151','05/05/2020 16:00','05/05/2020 17:00','off'),
('16','5465555656','05/05/2020 16:00','05/05/2020 17:00','off'),
('17','8762726252','05/01/2020 19:30','05/01/2020 20:30','off'),
('18','8777272727','05/01/2020 19:30','05/01/2020 20:30','off'),
('42','8787878787','05/22/2020 20:00','05/22/2020 21:30','off'),
('43','7654333456','05/22/2020 20:00','05/22/2020 21:30','off'),
('25','0278766272','05/22/2020 20:00','05/22/2020 21:30','off')

insert into VOUCHER(IDVoucher,Area,Name,StartDate,ExprirationDate,Percents)		---bổ sung thêm thời gian. tạo mã code cho ID Voucher
values
(1,'2',N'Giảm giá combo hải sản','05/01/2020 07:00','05/05/2020 07:00','10'),
(2,'4',N'Giảm 20% cho tất cả hóa đơn','05/01/2020 08:00','05/05/2020 09:00','20'),
(3,'1',N'Hóa đơn trên 5000000 giảm 500000','05/01/2020 15:30','05/05/2020 18:30','15'),
(4,'1',N'Giảm giá thuê phòng','05/01/2020 07:00','05/05/2020 07:00','25'),
(5,'2',N'Các loại nước uống giảm 50%','05/01/2020 09:00','05/05/2020 09:00','50'),
(6,'3',N'Trẻ em dưới 1m5 giảm 80%','05/01/2020 12:00','05/05/2020 12:00','80'),
(7,'3',N'Trò chơi cảm giác mạnh giảm 25% trên 1 vé','05/01/2020 13:00','05/05/2020 13:00','25'),
(8,'4',N'Áp dụng giảm giá 40% cho bất kì khu vực nào thuộc Resort','05/01/2020 16:30','05/05/2020 16:30','40')

insert into INVOICE(IDInvoice,IDCustomer,IDEmployee,Type,DatePayment,State) --state: payment, not payment, renew
values
('IV0001','C0001','NV0026','Park','05/16/2020','Payment'),
('IV0002','C0001','NV0017','Room','05/16/2020','Payment'),
('IV0003','C0001','NV0017','Service','05/16/2020','Payment'),
('IV0004','C0001','NV0007','Food','05/22/2020','Payment'),
('IV0005','C0002','NV0017','Service','05/20/2020','Payment'),
('IV0006','C0002','NV0017','Room','05/20/2020','Payment'),
('IV0007','C0002','NV0007','Food','05/01/2020','Payment'),
('IV0008','C0002','NV0026','Park','05/01/2020','Payment'),
	--ví dụ: hóa đơn thanh toán tiền phòng: Hotel, vui chơi: Park, ăn uống: Food, dịch vụ: Service
	--xem lại logic invoice với những detailInvoice khác (nếu IDInvoice trong bảng Invoice có type là Food thì bảng DetailInvoiceFood phải lưu ID này, Không lưu linh tinh qua những bảng detail khác)
('IV0009','C0003','NV0018','Service','05/25/2020','NotPayment'),
('IV0010','C0003','NV0018','Room','05/25/2020','NotPayment'),
('IV0011','C0003','NV0019','Food','05/01/2020','NotPayment'),
('IV0012','C0003','NV0019','Park','05/03/2020','NotPayment'),

('IV0013','C0004','NV0012','Food','05/01/2020','Renew'),
('IV0014','C0004','NV0008','Room','05/20/2020','Renew'),
('IV0015','C0004','NV0008','Service','05/20/2020','Renew'),

('IV0016','C0005','NV0026','Service','05/21/2020','Payment'),
('IV0017','C0005','NV0015','Food','05/05/2020','Payment'),
('IV0018','C0005','NV0026','Room','05/21/2020','Payment'),

('IV0019','C0006','NV0015','Food','05/05/2020','Payment'),
('IV0020','C0006','NV0026','Service','05/22/2020','Payment'),
('IV0021','C0006','NV0026','Room','05/22/2020','Payment')

insert into MENUFOOD(IDFood,Name,Price,Description,Available)
values 
('1',N'Cá ngừ sốt đại dương','200000',N'Cá ngừ được tươi sống được rướt nước sốt đặt biệt tại cửa hàng','100'),
('2',N'Vy cá mập hấp','1500000',N'Vy cá mập được hấp với các loại nhân sâm biển','50'),
('3',N'Tôm hùm hấp rượu van','2000000',N'Rượu van hảo hạn được hấp với tôm hùm bắc cực ','78'),
('4',N'Bào ngư lướt sóng','1500000',N'Trên đĩa sẽ được trang trí như một cơn sóng cuống trôi bào ngư hương vị của biển','100'),
('5',N'Mì ý Tomyum phủ phô mai','300000',N'sốt đặc biệt được chiếc xuất từ miếng bọt của cá heo','100'),
('6',N'Phở','100000',N'Đặc sản của Việt Nam ','100'),
('7',N'Cao lầu','100000',N'Đặc sản Việt Nam','100'),
('8',N'Bún bò Nam bộ','100000',N'Đặc sản Việt Nam','100'),
('9',N'Hoa quả dầm','30000',N'Hoa quả dầm','100'),
('10',N'Cà phê trứng','300000',N'Đặc sản Việt Nam','100'),
('11',N'Bánh donut vàng 24K','30000000',N'dát vàng','30'),
('12',N'Bánh Twinkie với trứng cá tầm','300000',N'Trứng cá tầm được làm thành bánh với hương vị khó tả','100'),
('13',N'Pizza nấm truffle','40000000',N'nấm truffle loại nấm đắt nhất được làm với pizza hòa quyện','100'),
('14',N'Bánh phượng hoàng','30000000',N'Hãy thử đi rồi biết cảm giác thật tuyệt với loại bánh đặc biệt của nhà hàng','100'),
('15',N'Sushi làm bởi Angelito Araneta (con)','50000000',N'đường Muscovado, cá hồi hồng Na Uy, cá trứng hồng, dưa chuột, xoài, gan ngỗng, hải sâm (hun khói rồi ngâm rượu và hấp), thịt cua nguyên chất, nghệ tây dại,','100')

insert into ORDER_FOOD(IDFood,IDInvoice,IDTable,Quantity)
values
(1,'IV0004','1','2'),
(2,'IV0004','1','3'),
(2,'IV0007','3','3'),
(10,'IV0007','3','3'),
(4,'IV0007','3','2'),
(14,'IV0007','4','3'),
(11,'IV0007','4','2'),
(14,'IV0011','17','2'),
(8,'IV0011','17','3'),
(5,'IV0013','2','1'),
(14,'IV0013','2','2'),
(8,'IV0017','5','3'),
(10,'IV0019','6','1'),
(14,'IV0019','6','2')

insert into  TICKETBOOKING(IDTicketBooking,Name,Price,Available)
values
(1,N'vé tàu lượn siu tốc','50000',200),
(2,N'vé công viên','100000',200),
(3,N'vé công viên nước','100000',200),
(4,N'vé tàu điện ngầm','100000',200),
(5,N'vé công viên khô','100000',200),
(6,N'vé tàu lượn siêu tốc','50000',200)

insert into DETAILINVOICESERVICES(IDInvoice,Name,Quantity,Price)
values
('IV0003',8,'3','120000'),
('IV0003',2,'2','60000'),
('IV0003',1,'2','240000'),
('IV0005',8,'3','120000'),
('IV0005',5,'2','100000'),
('IV0009',7,'3','150000'),
('IV0015',2,'2','200000'),
('IV0015',5,'2','100000'),
('IV0016',8,'1','40000'),
('IV0016',5,'3','150000'),
('IV0020',4,'1','120000'),
('IV0020',5,'3','150000')

insert into DETAILINVOICEROOM(IDInvoice,IDRoom,DateBooked,DateCheckOut,CheckedOut,Price)
values
('IV0002','R0001','05/05/2020 12:00','05/06/2020 12:00','05/16/2020 13:00','25000000'),
('IV0014','R0003','05/15/2020 15:20','05/16/2020 18:00','05/25/2020 12:00','25000000'),
('IV0006','R0006','05/05/2020 08:20','05/05/2020 08:00','05/25/2020 15:30','55000000'),
('IV0010','R0009','05/05/2020 09:00','05/05/2020 09:00','05/20/2020 16:00','55000000'),
('IV0018','R0010','05/05/2020 07:45','05/06/2020 08:00','05/21/2020 20:00','55000000'),
('IV0021','R0011','05/05/2020 06:30','05/05/2020 06:35','05/22/2020 11:30','5000000')

insert into DETAILINVOICEFOOD(IDInvoice,Food,Quantity,Price)
values 
('IV0004',1,'2','400000'),
('IV0004',2,'3','4500000'),
('IV0007',2,'3','4500000'),
('IV0007',10,'3','900000'),
('IV0007',4,'2','3000000'),
('IV0007',14,'3','900000'),
('IV0007',11,'2','600000'),
('IV0011',14,'2','600000'),
('IV0011',8,'3','300000'),
('IV0013',5,'1','300000'),
('IV0013',14,'2','300000'),
('IV0017',8,'3','300000'),
('IV0019',10,'1','300000'),
('IV0019',14,'2','30000000')

insert into DETAILINVOICEPARK(IDInvoice,Ticket,Quantity,Price)
values
('IV0001',1,'3','150000'),		----cột ticket là lấy ID, không lấy name
('IV0001',2,'3','300000'),
('IV0001',3,'3','300000'),
('IV0008',4,'3','300000'),
('IV0008',5,'3','300000'),
('IV0008',6,'3','150000'),
('IV0008',2,'3','300000'),
('IV0008',3,'3','300000'),
('IV0012',5,'3','300000'),
('IV0012',4,'3','300000')