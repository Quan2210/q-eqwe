use master
go

create database HocSinhTrungHoc
go

use HocSinhTrungHoc
go

--Giáo Viên
create table GiaoVien(
   MaGV    varchar(20)  primary key,
   TenGV   nvarchar(50),
   DiaChi  nvarchar(100),
   SoDT    nvarchar(10),
   Email   nvarchar(30),
   MatKhau  nvarchar(20)
)

-- Lớp học
go
create table Lop(
  MaLop   varchar(20)  primary key,
  MaGV   varchar(20)   foreign key (MaGV) references GiaoVien (MaGV)  on update cascade on delete cascade,
  SiSo  int
)
go

-- Học sinh
create table HocSinh(
  MaHS     varchar(20)   primary key,
  TenHS    nvarchar(50),
  NgaySinh   date,
  GioiTinh    bit,
  DiaChi   nvarchar(100),
  SoDT     nvarchar(10),
  HoTenBo    nvarchar(30),
  SoDTBo  nvarchar(10),
  HoTenMe    nvarchar(30),
  SoDTMe  nvarchar(10),
  MienGiam   bit,
  MatKhau   nvarchar(10),
  MaLop     varchar(20)  foreign key (MaLop) references Lop (MaLop)  on update cascade on delete cascade
)

-- Ket Qua
create table KetQua(
  NamHoc   int ,
  MaHS  varchar(20 ) foreign key (MaHS) references HocSinh (MaHS)  on update cascade on delete cascade,
  Ky   bit ,
  primary key(NamHoc, MaHS, Ky),
  Toan    float,
  Ly    float,
  Hoa    float,
  Van    float,
  Anh    float,
  Lichsu    float,
  DiaLy    float,
  GDCD    float,
  TheDuc    float,
  CongNghe    float,
  SinhHoc    float,
  HanhKiem  varchar(10),
  NhanXetGV     nvarchar(200)
)select* from KetQua
------ Themm bot diem
-- Học sinh(MK), Giáo viên(MK), admin
-- Lop
-- Ket Qua(NamHoc, MaHS, Ky)
go
create trigger ThemHocSinh
on HocSinh
for insert
as
   begin
        declare @maLop  varchar(20)
		declare @siso  int
		select @maLop = MaLop from inserted
		select @siso = SiSo from Lop where MaLop = @maLop
		update Lop
		set Lop.SiSo = Lop.SiSo + 1
		where Lop.MaLop = @maLop
   end
go
-- insert into
insert into GiaoVien
values ('GV01', N'Nguyễn Thị A', N'Hải Dương', '0361549758', 'NguyenThiA@gmail.com', 'abc123'),
       ('GV02', N'Nguyễn Thị B', N'Tái Sơn', '0361549758', 'NguyenThiB@gmail.com', 'abc123'),
	   ('GV03', N'Nguyễn Thị C', N'Kỳ Sơn', '0361549758', 'NguyenThiC@gmail.com', 'abc123'),
	   ('GV04', N'Nguyễn Thị D', N'Quang Phục', '0361549758', 'NguyenThiD@gmail.com', 'abc123'),
	   ('GV05', N'Nguyễn Thị E', N'Bình Lãng', '0361549758', 'NguyenThiE@gmail.com', 'abc123')
	   select * from GiaoVien

insert into Lop
values ('Lop10A', 'GV01', 0),
       ('Lop10B', 'GV02', 0),
	   ('Lop10C', 'GV03', 0),
	   ('Lop10D', 'GV04', 0),
	   ('Lop10E', 'GV05', 0)
	   select * from Lop
	   update Lop set MaGV = 'GV01' where MaLop = 'Lop10A'
insert into HocSinh
values ('HS01', N'Nguyễn Sách Linh', '08-28-2000', 1,N'Bình Lãng','0123658468' ,N'Nguyễn Sách A','0254923155', N'Nguyễn Thị B','0154268322',0, 'abc123', 'Lop10A' )

insert into HocSinh
values ('HS02', N'Nguyễn Hữu Tài', '01-01-2000', 1,N'Hà Nội','0123658468' ,N'Nguyễn Hữu A','0254185694', N'Nguyễn Thị B','0254168325',0, 'abc123', 'Lop10B' )

insert into HocSinh
values ('HS03', N'Nguyễn Văn Tân', '01-01-2000', 1,N'Hà Nội','0123658468' ,N'Nguyễn Văn A','0487965223', N'Nguyễn Thị B','0645865523',0, 'abc123', 'Lop10C' )
---
insert into HocSinh
values ('HS05', N'Nguyễn Thi Huong', '01-01-2000', 0,N'Hà Nội','0123658468' ,N'Nguyễn Văn A','0487965223', N'Nguyễn Thị B','0645865523',1, 'abc123', 'Lop10C' )
---
select * from HocSinh

insert into KetQua
values (2021, 'HS01', 1, 8,8,8,8,8,8,8,8,8,8,8,N'Khá', N'Có sự cố gắng, chăm học')
insert into KetQua
values (2021, 'HS02', 1, 8,8,8,8,8,8,8,8,8,8,8,N'Khá', N'Có sự cố gắng, chăm học')
insert into KetQua
values (2021, 'HS03', 1, 8,8,8,8,8,8,8,8,8,8,8,N'Khá', N'Có sự cố gắng, chăm học')
insert into KetQua
values (2021, 'HS05', 0, 8,8,8,8,8,8,8,8,8,8,8,N'Khá', N'Có sự cố gắng, chăm học')
select * from KetQua
delete KetQua where MaHS = 'HS04'
-- trigger xóa Học Sinh
go
create trigger Delete_HocSinh
on HocSinh
for delete
as
  begin
       declare @MaLop  varchar(10)
	   declare @SiSo  int
	   select @MaLop = MaLop from deleted
	   select @SiSo = SiSo from Lop where MaLop = @MaLop
	   update Lop
	   set Lop.SiSo = Lop.SiSo - 1
	   from Lop inner join deleted on Lop.MaLop = deleted.MaLop	   
  end
go
insert into HocSinh
values ('HS04', N'Nguyễn Sách Linh2', '08-28-2000', 1,N'Bình Lãng','0123658468' ,N'Nguyễn Sách A','0254923155', N'Nguyễn Thị B','0154268322',0, 'abc123', 'Lop10A' )
go
delete HocSinh where MaHS = 'HS04'
select * from HocSinh
select * from Lop
---- trigger update Mã Lớp của Học Sinh
----- Chuyển lớp
go
create trigger Update_MaLop
on HocSinh
for update
as
  begin
      declare @MaLopMoi   varchar(20)
	  select @MaLopMoi = MaLop from inserted 
	  declare @MaLopCu varchar(20)
	  select @MaLopCu = MaLop from deleted
	  update Lop
	  set Lop.SiSo = Lop.SiSo + 1
	  from Lop where MaLop = @MaLopMoi
	  update Lop 
	  set Lop.SiSo = Lop.SiSo - 1
	  from Lop where MaLop = @MaLopCu
  end
go
update HocSinh set MaLop = 'Lop10G' where MaHS = 'HS04'
select * from HocSinh
select * from Lop
select * from KetQua
go
select NamHoc, KetQua.MaHS, Ky, Toan, Ly, Hoa, Van, Anh, Lichsu, DiaLy, GDCD, TheDuc, CongNghe, SinhHoc, HanhKiem, NhanXetGV
from KetQua
inner join HocSinh on HocSinh.MaHS = KetQua.MaHS 
inner join Lop on HocSinh.MaLop = Lop.MaLop
inner join GiaoVien on GiaoVien.MaGV = Lop.MaGV
where GiaoVien.MaGV = 'GV01'

select MaHS from HocSinh
inner join Lop on Lop.MaLop = HocSinh.MaLop
inner join GiaoVien on Lop.MaGV = GiaoVien.MaGV
where GiaoVien.MaGV = 'GV01'