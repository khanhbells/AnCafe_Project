create database quanly_toi1
use  quanly_toi1
/*bang ban*/
create table ban
(BanID nvarchar(10) primary key,TenBan nvarchar(10) not null)
/*bang thuc don*/
create table thucdon
(IDdouong nvarchar(10) primary key,TenDoUong nvarchar(50),dongia float)
/*tai khoản */
create table Tai_Khoan (tai_Khoan  nvarchar(20)  primary key, Mat_Khau nvarchar(20) ,  Phan_Quyen nvarchar(20))
/*nhân viên */
create table Nhan_vien (Ma_NV nvarchar(20)  primary key, Ho_Ten nvarchar(20) , Đia_Chi nvarchar(30) , 
SDT nvarchar(20), chuc_vu nvarchar(20),So_CCCD nvarchar(20),Ngay_Cong  nvarchar(20) , He_So_Lương  nvarchar(20) , Tien_Lương  int )
/*bang goi mon*/
create table hoadon
(idHoaDon nvarchar(10) primary key,IDdouong nvarchar(10),
BanID nvarchar(10),SoLuong int,NgayInHD datetime ,
Ma_NV nvarchar(20) , thanh_tien int ,
constraint n2 foreign key (IDdouong)references thucdon(IDdouong),
constraint n3 foreign key (BanID)references ban(BanID),
constraint n5 foreign key (Ma_NV)references  Nhan_vien(Ma_NV)
)
/*Nhập hàng*/
create table NhapHang (MaHang nvarchar(10) primary key, Ten_Mat_Hang  nvarchar(50)
, So_Luongnhap int  , Gia_Nhap nvarchar(20) , Ngay_Nhap datetime  , Tong_Tien int )
--constraint a55 primary key (MaHang ,TenDoUong) )
--constraint a822 foreign key (TenDoUong)references thucdon(TenDoUong))
--constraint n2 foreign key (IDdouong)references thucdon(IDdouong),

/* doanh thu */
--create table doanh_thu (idHoaDon nvarchar(10) primary key , IDBan nvarchar(10),
--TenDoUong nvarchar(50), SoLuong int,  thanh_tien nvarchar(20) ,NgayInHD nvarchar(20) ,
--Ma_NV nvarchar(20) ,
--constraint n8 foreign key (idHoaDon)references hoadon(idHoaDon),
--constraint n9 foreign key (Ma_NV)references  Nhan_vien(Ma_NV)
--)

/* Hệ luong */
create table HeLuong (HeLuong int )
insert into HeLuong 
values ('12000'),
      ('15000'),
	  ('20000')
create table chucvu( chuc_vu nvarchar(20))
insert into chucvu
values (N'Thử việc'),
      (N'Chính thức ')

create table quyen ( quyen_a nvarchar(20))
insert into quyen 
values (N'QuanLy'),
       (N'Nhân Viên')
/*du lieu demo bang thuc don*/
insert into thucdon 
values('CF001',N'Cà phê đen','20000'),
      ('CF002',N'Cà Phê sữa','15000'),
	  ('A01',N'Bia 333' ,'15000'), 
	     ('B02',N'Trà Đào' ,'10000'),
	    ('B01',N'Trà Chanh' ,'10000'),
	  ('C01',N'Xúc Xích' ,'10000'),
	  ('CF003',N'Cà phê đá','12000');
 --bảng hoadon
insert into hoadon
values ('HD001','CF001','B01','3' , '2022/10/25','NV001','60000 '),  
      ('HD002','B02','B05','3' , '2022/11/05','NV003','30000 '),
      ('HD003','CF002','B02','2','2022/10/15','NV002','30000 '),
	   ('HD004','A01','B03','5','2022/10/15','NV002','75000 '),
	  ('HD005','B01','B06','3' , '2022/10/25','NV001','30000 '),   
      ('HD006','C01','B05','3' , '2022/11/05','NV003','30000 '),
      ('HD007','CF003','B02','5','2022/10/15','NV002','60000 ');
             
insert into NhapHang		
values ('MH001',N'Bia 333','10','15000','2022/11/02','120000'),
       ('MH002',N'Trà Đào','10','8000','2022/11/05','80000'),
	   ('MH003',N'Trà Chanh','10','8000','2022/11/07','80000'),
	   ('MH004',N'Xúc Xích','10','7000','2022/11/02','70000'),
	   ('MH005',N'Cà phê đá','10','10000','2022/11/02','100000'),
	   ('MH006',N'Cà phê đen','10','17000','2022/11/12','170000'),
	   ('MH007',N'Cà Phê sữa','10','12000','2022/11/15','120000')
	   
--bảng bàn
insert into ban
values('B01',N'Bàn 1'),
      ('B02',N'Bàn 2'),
	  ('B03',N'Bàn 3'),
	  ('B04',N'Bàn 4'),
	  ('B05',N'Bàn 5'),
	  ('B06',N'Bàn 6');
-- Bảng nhân viên 
insert into Nhan_vien
values ('NV001' ,N'Bùi Hữu Huy',N'Tuyên Quang','0983466052',N'Chính thức','0084987256','10','12000','120000 '),
       ('NV002' ,N'Lường Ngọc Dương',N'Bắc Cạn','098558522',N'Thử việc','00825809744','15','15000','225000 '),
	   ('NV003',N'Vi Văn Lượng',N'Thái Nguyên ','287624548',N'Chính thức','003539266','20','20000','400000 ')

 --Bảng tài khoản
insert into Tai_Khoan
values ('admin','1',N'QuanLy'),
        ('NV1','123',N'Nhân Viên'),
		 ('NV2','123',N'Nhân Viên'),
		  ('NV3','123',N'Nhân Viên');
		
--		create table hoadon4
--(idHoaDon nvarchar(10) primary key,IDdouong nvarchar(10),
--BanID nvarchar(10),SoLuong int,NgayInHD datetime ,
--Ma_NV nvarchar(20) , thanh_tien int)
--constraint n2 foreign key (IDdouong)references thucdon(IDdouong),
--constraint n3 foreign key (BanID)references ban(BanID),
--constraint n5 foreign key (Ma_NV)references  Nhan_vien(Ma_NV)
--)
go 
select *  from hoadon WHERE Month(NgayInHD)= '10'
SELECT  BanID='B01' , SUM( thanh_tien) AS ' tong tien 'FROM hoadon , thucdon GROUP BY BanID ;Result:     ;
SELECT    SUM( Tien_Lương)AS 'Tổng số tiền phải trả cho nv '  from  Nhan_vien;Result:  
SELECT    SUM(  Tong_Tien)AS 'Tổng số tiền nhập hàng '  from  NhapHang;Result:  

SELECT    SUM(So_Luongnhap) from  NhapHang  b  WHERE a.SoLuong-b.So_Luong ;Result:  

SELECT SUM(thanh_tien) AS 'Tổng số tiền' FROM hoadon  WHERE   IDdouong ='CF001' ;Result:  

SELECT   So_Luong,SoLuong  , So_Luong-SoLuong  as 'SL' from thucdon c, hoadon a , NhapHang b where a.SoLuong-b.So_Luong=SL   and b.TenDoUong=c.TenDoUong ;

SELECT SUM(thanh_tien) AS 'Tổng số tiền' from  hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong and TenDoUong ='Cà phê đen' ;Result:
select *   from  hoadon WHERE  NgayInHD  BETWEEN '2022/10/15'   AND'2022/10/25'
SELECT SUM(thanh_tien) AS 'Tổng số tiền  ' FROM hoadon WHERE  NgayInHD  BETWEEN '2022/10/15'   AND'2022/10/25'
select  DISTINCT TenDoUong, Gia_Nhap,TenBan, So_Luongnhap, SoLuong, So_Luongnhap -  SoLuong as 'so luong con ' 
from  hoadon ,NhapHang  ,ban  where ban.BanID=hoadon.BanID  

select   DISTINCT  SUM(So_Luongnhap) -  SUM(SoLuong) as 'so luong con ' from  hoadon ,NhapHang WHERE   IDdouong ='CF001' ;Result:  

select   DISTINCT TenDoUong,thanh_tien- Tong_Tien as 'Lợi nhuận ' from  hoadon ,NhapHang,ban
WHERE  NgayInHD  BETWEEN '2022/10/15'   AND'2022/10/25' and Ngay_Nhap BETWEEN '2022/10/15'   AND'2022/11/25'

select   SUM(Tong_Tien) from  NhapHang  
select    SUM(thanh_tien) from  hoadon 
select    DISTINCT Ten_Mat_Hang, Gia_Nhap, So_Luongnhap , TenBan ,SoLuong  , So_Luongnhap -  SoLuong as 'so luong con lai  ' from  NhapHang ,hoadon a, ban b, thucdon c where a.BanID=b.BanID and a.IDdouong=c.IDdouong
SELECT nhap.thuoc, (nhapsoluong - IFNULL(xuatsoluong,0)) as count FROM
(SELECT nhap.thuoc, SUM(nhap.soluong) as nhapsoluong FROM nhap GROUP BY nhap.thuoc) as nhap LEFT JOIN
(SELECT xuat.thuoc, SUM(xuat.soluong) as xuatsoluong FROM xuat GROUP BY xuat.thuoc) as xuat ON
nhap.thuoc = xuat.thuoc