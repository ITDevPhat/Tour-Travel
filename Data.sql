USE [master]
GO
/****** Object:  Database [QUANLYDULICH]    Script Date: 2024-04-13 09:54:17 PM ******/
CREATE DATABASE [QUANLYDULICH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYDULICH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.THANHPHAT\MSSQL\DATA\QUANLYDULICH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYDULICH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.THANHPHAT\MSSQL\DATA\QUANLYDULICH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QUANLYDULICH] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYDULICH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYDULICH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYDULICH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYDULICH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYDULICH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYDULICH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLYDULICH] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYDULICH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYDULICH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYDULICH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYDULICH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYDULICH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYDULICH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANLYDULICH', N'ON'
GO
ALTER DATABASE [QUANLYDULICH] SET QUERY_STORE = ON
GO
ALTER DATABASE [QUANLYDULICH] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QUANLYDULICH]
GO
/****** Object:  Table [dbo].[CHITIETTOUR]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETTOUR](
	[TOUR_ID] [nvarchar](10) NULL,
	[DV_ID] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[DV_ID] [nvarchar](10) NOT NULL,
	[DV_Ten] [nvarchar](1000) NOT NULL,
	[DV_MoTa] [nvarchar](3000) NULL,
	[DV_PhuongTien] [nvarchar](100) NULL,
	[DV_DiaDiem] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DV_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HINHANHTOUR]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HINHANHTOUR](
	[HA_ID] [int] IDENTITY(1,1) NOT NULL,
	[HA_Ten] [nvarchar](100) NOT NULL,
	[HA_DuongDan] [nvarchar](100) NOT NULL,
	[HA_STT] [int] NOT NULL,
	[TOUR_ID] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[KH_ID] [nvarchar](10) NOT NULL,
	[KH_HoTen] [nvarchar](100) NOT NULL,
	[KH_GioiTinh] [nvarchar](3) NOT NULL,
	[KH_NgaySinh] [date] NOT NULL,
	[KH_SoDienThoai] [nvarchar](10) NOT NULL,
	[KH_DiaChi] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KH_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[NV_ID] [nvarchar](10) NOT NULL,
	[NV_Ten] [nvarchar](50) NOT NULL,
	[NV_GioiTinh] [nvarchar](3) NOT NULL,
	[NV_NgaySinh] [date] NOT NULL,
	[NV_SoDienThoai] [nvarchar](10) NOT NULL,
	[NV_DiaChi] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NV_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TK_TenDangNhap] [nvarchar](100) NOT NULL,
	[TK_MatKhau] [nvarchar](100) NOT NULL,
	[TK_Loai] [int] NULL,
	[NV_ID] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[TK_TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOUR]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOUR](
	[TOUR_ID] [nvarchar](10) NOT NULL,
	[TOUR_Ten] [nvarchar](1000) NOT NULL,
	[TOUR_NgayKhoiHanh] [date] NOT NULL,
	[TOUR_SoNgay] [int] NOT NULL,
	[TOUR_DonGia] [float] NOT NULL,
	[TOUR_TongSoVeTour] [int] NOT NULL,
	[TOUR_NoiKhoiHanh] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TOUR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VE]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VE](
	[VE_ID] [nvarchar](10) NOT NULL,
	[VE_SoLuongMua] [int] NOT NULL,
	[VE_TongTien] [int] NOT NULL,
	[VE_NgayLap] [date] NOT NULL,
	[KH_ID] [nvarchar](10) NULL,
	[TOUR_ID] [nvarchar](10) NULL,
	[NV_ID] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[VE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T2', N'DV8')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T4', N'DV9')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T6', N'DV11')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T7', N'DV12')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T7', N'DV13')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T7', N'DV14')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T9', N'DV9')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T10', N'DV15')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T10', N'DV16')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T10', N'DV17')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T10', N'DV18')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T10', N'DV9')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T10', N'DV19')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T1', N'DV1')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T1', N'DV2')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T1', N'DV3')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T2', N'DV4')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T2', N'DV5')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T2', N'DV6')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T5', N'DV7')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T5', N'DV8')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T5', N'DV9')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T5', N'DV10')
INSERT [dbo].[CHITIETTOUR] ([TOUR_ID], [DV_ID]) VALUES (N'T5', N'DV11')
GO
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV1', N'Ngày 1 - CẦN THƠ - RẠCH GIÁ - PHÚ QUỐC (Ăn sáng, trưa, chiều)', N'Xe và Hướng dẫn viên Vietravel Cần Thơ đón Quý khách tại Vietravel Cần Thơ, đoàn khởi hành đi bến tàu Rạch Giá. Đến Rạch Giá Quý khách dùng điểm tâm sáng. Xe đưa Quý khách ra bến tàu Rạch Giá, khởi hành đi Phú Quốc. Xe đón đoàn tại bến tàu, đưa đoàn đi ăn trưa, sau đó về nhận phòng khách sạn, Quý khách tự do nghỉ ngơi.

Buổi chiều, đoàn tham quan:

- Dinh Cậu: biểu tượng văn hoá và tín ngưỡng của đảo Phú Quốc. Nơi ngư dân địa phương gởi gắm niềm tin cho một chuyến ra khơi đánh bắt đầy ắp cá khi trở về.

- Chùa Sư Muôn (Hùng Long Tự): ngôi chùa có kiến trúc dân gian, nằm trên triền núi, mặt hướng ra biển, xung quanh cây cối xanh tốt. Đến đây du khách cảm nhận vẻ đẹp thanh tịnh, bình yên và cầu nguyện sự an lành và hạnh phúc đến với gia đình.

- Sunset Sanato Beach Club - sở hữu vị thế đắc địa nhất, khu vui chơi nằm ngay trung tâm của Bãi Trường. Nơi đây, sóng biển dịu êm như một dòng sông, bạn sẽ thấy mình được hưởng trọn vẹn hương vị mặn mòi của biển và mát lành của những hoang sơ còn vương vấn, đến đây du khách sẽ được thưởng ngoạn phong cảnh biển tuyệt đẹp, những góc ảnh check-in cực chất, tự do tắm biển, hòa nhịp trong những bản nhạc sôi động.

Ăn chiều. Buổi tối, Quý khách tự do dạo phố biển hoặc thưởng thức hải sản tại chợ Đêm Phú Quốc (chi phí tự túc).

Nghỉ đêm tại Phú Quốc', N'Xe du lịch', N'Phú Quốc')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV10', N'Ngày 4 - NÚI PHÚ SĨ - TOKYO (Ăn sáng, trưa, tối)', N'Quý khách ăn sáng tại khách sạn.

Sau đó đoàn bắt đầu hành trình tham quan:

- Núi Phú Sĩ: biểu tượng của đất nước mặt trời mọc, được công nhận là di sản văn hóa thế giới (tại thời điểm thực tế, đoàn sẽ tham quan trạm 5 (tùy theo tình hình thời tiết thực tế mà Chính phủ Nhật Bản cho phép lên trạm tham quan)…

- Giai đoạn tháng 1 - tháng 2: đoàn đi trải nghiệm trượt tuyết ở khu nghỉ dưỡng trượt tuyết Fujiten Snow Resort (giai đoạn tháng 1 – tháng 2) nằm dọc phía bắc núi Phú Sĩ. Quý khách tham quan, vui chơi và tận hưởng các hoạt động thú vị và ngắm ngọn núi huyền thoại của xứ sở Phù Tang. (Chưa bao gồm chi phí thuê dụng cụ trượt tuyết)

Ăn trưa tại nhà hàng, sau đó tiế tục tham quan:

- Đền Asakusa Kannon: Ngôi đền thờ cổ nhất tại Tokyo, nơi diễn ra các lễ hội lớn của quốc gia cùng với truyền thuyết ra đời ngôi đền bí ẩn. Từ đây đoàn có thể chụp ảnh Tháp Tokyo Sky Tree.

- Giai đoạn tháng 3 - tháng 4:

- Ngắm hoa anh đào tại Sumida River (Hoặc Ueno Park): Bạn có thể chụp những bức ảnh tuyệt đẹp về hoa anh đào ở đây với hơn 600 cây anh đào Nhật Bản và hình ảnh của Tokyo Skytree cao chót vót ở hậu cảnh

- Công viên Ueno - Công viên Ueno nổi tiếng với các bảo tàng, đặc biệt là bảo tàng nghệ thuật như Bảo tàng Quốc gia Tokyo, có đền và vườn thú trong đó có gấu trúc thu hút sự chú ý của khách đến thăm. Đặc biệt, nơi đây còn nổi tiếng với 1,000 cây Anh Đào, cũng là nơi người Nhật, nhất là các bạn trẻ, thường hẹn hò ngắm cảnh, chụp hình hay thưởng thức rượu sake bên gốc anh đào.

Đoàn tham quan, mua sắm tại khu mua sắm lớn nhất Tokyo Giza hoặc Akihabara

Ăn tối tại nhà hàng.

Nghỉ đêm tại khách sạn tại Tokyo', N'Xe du lịch', N'Tokyo')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV11', N'Ngày 5 - TOKYO – ODAIBA - HÀ NỘI (Ăn sáng, trưa)', N'Quý khách ăn sáng tại khách sạn. Quý  khách tham quan:

- Hoàng cung Nhật Bản được xây dựng trên nền cũ của Lâu dài Edo - một vùng công viên rộng lớn được bao bọc bởi những hồ nước và những bức tường đá ngay giữa trung tâm Tokyo. Đây cũng là nơi ở của Hoàng gia Nhật bản hiện tại (chụp hình bên ngoài)..

- Vịnh Odaiba: quý khách chụp ảnh với bản sao Tượng nữa thần tự do và shopping tại đây.

Ăn trưa tại nhà hàng.

Sau đó, Quý khách ra sân bay làm thủ tục đáp chuyến bay về Hà Nội. Về tới sân bay Nội Bài, xe của Vietravel đón Quý khách về thành phố. Chia tay và kết thúc chương trình tham quan.', N'Máy bay', N'Hà Nội')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV12', N'Ngày 1 - TP HỒ CHÍ MINH - PHÚ QUỐC - HÒN THƠM - THỊ TRẤN HOÀNG HÔN - GRAND WORLD (Ăn trưa, chiều)', N'Quý khách tập trung tại Sân bay Tân Sơn Nhất, ga đi Trong Nước, hướng dẫn viên hỗ trợ làm thủ tục đáp chuyến bay đi Phú Quốc. 

Xe đón đoàn tại sân bay đưa đến nhà ga cáp treo An Thới tham quan Sun World Hon Thom Nature Park với những hoạt động thú vị:
- Trải nghiệm cáp treo 3 dây vượt biển dài nhất thế giới - 7.899.9 mét.
- Phấn khích tột độ cùng thử thách "Mộc Xà thịnh nộ" - trò chơi tàu lượn bằng gỗ đầu tiên tại Việt Nam, có tốc độ tối đa 80km/h với nhiều góc lượn ngoạn mục; đài quan sát "Mắt đại bàng" cao 120m - du khách như được bay lên không trung, thưởng ngoạn đại dương xanh ngắt bao la, những cánh rừng nhiệt đới xanh mướt, những đảo nhỏ nhấp nhô giữa biển trời khoáng đạt (trò chơi có thể tạm dừng vì lịch bảo trì)
- Thỏa thích tắm biển Hòn Thơm: một trong những bãi biển “quyến rũ nhất hành tinh”, với bãi cát trắng mịn, hoang sơ, hàng dừa nghiêng soi bóng, màu nước biển xanh màu ngọc bích, phản chiếu long lanh dưới ánh nắng mặt trời.
- Tham gia các hoạt động giải trí trên biển: kayak, jetski, dù lượn, phao chuối (chi phí tự túc).
- Vui chơi tại công viên nước Aquatopia: một trong những công viên nước chủ đề hàng đầu Đông Nam Á, trải nghiệm 6 khu check-in chủ đề hấp dẫn mang phong cách thổ dân huyền bí.

Lãng du trên con đường Thị trấn Hoàng Hôn - được thiết kế với kiến trúc độc đáo, rực rỡ sắc màu của một thị trấn châu Âu cổ kính: check-in ‘1001’ kiểu bậc thang, Quảng trường La Mã, “kỳ quan” Khải Hoàn Môn, Tháp đồng hồ cao 75m - lấy ý tưởng từ tháp chuông St. Mark’s Campanile của Ý; chiêm ngưỡng Kiss Bridge - cây cầu nổi lên như một dải lụa giữa bờ biển trong xanh, với hai nhịp cầu vươn mình ôm trọn bờ cát trắng, hướng đến nhau, hợp vào làm một thể thống nhất nhưng không chạm nhau.

Buổi tối, Quý khách có thể tự do khám phá một số hạng mục nổi bật tại “thành phố không ngủ” Grand World như: 
- Công viên Nghệ Thuật Đương Đại: sự giao thoa đặc sắc giữa nghệ thuật đương đại và thiên nhiên Đảo Ngọc.
- Huyền thoại Tre: công trình tre lớn nhất Việt Nam.
- Tản bộ bên dòng “kênh đào Venice” và nhìn ngắm những chiếc thuyền Gondola, khu phố shophouse lộng lẫy sắc màu, cổng lâu đài tráng lệ, ba cây cầu vòm bán nguyệt mang đậm kiến trúc châu Âu ...
- Tham quan bảo tàng Gấu Teddy: lưu giữ nhiều hiện vật quý giá và tái hiện chuyến phiêu lưu hài hước của “nhà thám hiểm tài ba” Teddy Jones (chi phí tự túc)
- Mãn nhãn với show diễn thực cảnh “Tinh Hoa Việt Nam” quy tụ hơn 200 diễn viên (chi phí tự túc)
- Thưởng thức bữa tiệc ánh sáng đỉnh cao với show diễn “Sắc màu Venice”

Nghỉ đêm tại Phú Quốc.', N'Máy bay', N'Phú Quốc')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV13', N'Ngày 2 - VUI CHƠI THỎA THÍCH TẠI CÔNG VIÊN CHỦ ĐỀ VINWONDERS PHÚ QUỐC - KHU BẢO TỒN THIÊN NHIÊN SAFARI (Ăn sáng, trưa, chiều)', N'Quý khách bắt đầu hành trình trở về với thiên nhiên tại Vinpearl Safari Phú Quốc - Vườn thú bán hoang dã đầu tiên tại Việt Nam: với quy mô 180 ha, hơn 130 loài động vật quý hiếm, du khách thưởng thức các chương trình biểu diễn, chụp ảnh với động vật; trải nghiệm vườn thú mở trong rừng tự nhiên, gần gũi và thân thiện với con người.

Buổi chiều, Quý khách tham quan khám phá Khu vui chơi giải trí VinWonders - Công viên chủ đề lớn nhất Việt Nam, quy mô hàng đầu Châu Á, du khách sẽ được:
- Trải nghiệm 12 nền văn minh nhân loại từ cổ chí kim;
- Khám phá 06 phân khu với hơn 100 hoạt động giải trí siêu độc lạ;
- Cuồng nhiệt tại Công Viên Nước lớn nhất Đông Nam Á;
- Chinh phục 20 trò chơi mạo hiểm khủng nhất hành tinh như đường trượt nhanh nhất thế giới “Cơn thịnh nộ của Zeus”, đường trượt khô “Cuộc chiến Chằn tinh” cao 15m đầu tiên của Việt Nam, đường trượt trong nhà tối “Chiến binh Đại bàng” và “Lời nguyền Ác long” - trò chơi tương tác trong nhà tối đầu tiên của Việt Nam,…
- Ngỡ ngàng với show diễn triệu đô Once đẳng cấp thế giới;
- Choáng ngợp trước thế giới đại dương huyền ảo với tầm nhìn vô cực qua tấm kính acrylic khổng lồ 8x25m bên trong Cung điện Hải vương - thủy cung hình rùa lớn nhất thế giới.

Quý khách thưởng thức bữa tối tại VinWonders. 

Nghỉ đêm tại Phú Quốc.', N'Máy bay', N'Phú Quốc')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV14', N'Ngày 3 - PHÚ QUỐC - TP HỒ CHÍ MINH (Ăn sáng)', N'Quý khách dùng bữa sáng, thư giãn tại khách sạn đến giờ trả phòng. Sau đó, xe đưa đoàn tham quan và mua sắm đặc sản nổi tiếng tại Nhà thùng nước mắm Hồng Đức 1 / Khải Hoàn / Phụng Hưng, Đặc sản Đức Thạnh, Cơ sở sản xuất ngọc trai Phú Quốc - Trưng bày các trang sức bằng ngọc trai chính hiệu được nuôi cấy tại Phú Quốc.

Xe đưa Quý khách ra sân bay đáp chuyến bay trở về TP Hồ Chí Minh. Chia tay Quý khách và kết thúc chương trình du lịch tại sân bay Tân Sơn Nhất.

*Lưu ý: 
Khách có quốc tịch nước ngoài (tên nước ngoài & việt kiều đã đổi tên hoàn toàn) 
- Phụ thu 850,000 VNĐ/khách * 2 khách/phòng
- Trường hợp 1 khách quốc tịch Việt Nam + 1 khách quốc tịch nước ngoài vẫn phụ thu 850,000 VNĐ/khách * 2 khách/phòng
- Theo quy định resort khách check-in cần đặt cọc 1,000,000 đ/phòng/đêm. Số tiền này sẽ được hoàn trả khi khách check-out.

Phụ thu giá vé tham quan đối với trẻ em dưới 12 tuổi cao trên 1m4 
- Combo Hòn Thơm: phụ thu 300,000 VNĐ/khách
- Combo Vinwonder + Safari: phụ thu 300,000 VNĐ/khách
Đối với các khách không phụ thu khi mua tour, khi có phát sinh tại điểm tham quan, khách tự chịu chi phí phát sinh tại điểm tham quan.


- Giờ bay phụ thuộc vào hãng hàng không, số bữa ăn phụ thuộc vào giờ bay. Các bữa ăn có thể hoán đổi để phù hợp với chương trình.
- Hành trình có thể thay đổi thứ tự điểm đến tùy vào điều kiện thực tế
- Đây là chương trình du lịch trọn gói, Vietravel không có trách nhiệm hoàn trả chi phí chênh lệch cho các khách hàng thuộc diện miễn giảm hoặc đối tượng ưu tiên như trẻ nhỏ, người lớn tuổi, người có công với cách mạng… Chính sách miễn giảm, ưu tiên (nếu có) chỉ dành cho khách lẻ của các điểm tham quan', N'Máy bay', N'Hồ Chí Minh')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV15', N'Ngày 1 - TP. HỒ CHÍ MINH - PHAN THIẾT - NHA TRANG (Ăn sáng, trưa, chiều)', N'Quý khách tập trung tại Vietravel (190 Pasteur, Phường Võ Thị Sáu Quận 3, Tp.HCM). Đoàn khởi hành đi Phan Thiết, dùng cơm trưa và tham quan:

- Bảo tàng Làng Chài Xưa: Du khách sẽ được đi xuyên vào không gian tương tác tái hiện Làng Chài Xưa Mũi Né với lịch sử 300 năm cái nôi của nghề làm nước mắm, trải nghiệm cảm giác lao động trên đồng muối, đi trên con đường rạng xưa, thăm phố cổ Phan Thiết, vào xóm lò tĩn, thăm nhà lều của hàm hộ nước mắm xưa, đắm chìm cảm xúc trong biển 3D và thích thú khi đi chợ làng chài xưa với bàn tính tay, bàn cân xưa thú vị. 

Đoàn tiếp tục hành trình đến với thành phố biển Nha Trang. Trên cung đường đi, Quý khách sẽ dừng chân chụp ảnh kỷ niệm tại 

- Bãi biển Cà Ná: Một trong những bãi biển đẹp nhất miền Trung.
Sau khi ăn tối, đoàn về nhận phòng nghỉ ngơi. Buổi tối, Quý khách tự do dạo chợ đêm Nha Trang, sắm cho mình những món đồ thủ công mỹ nghệ hay tản bộ dọc công viên phố biển về đêm. 

Nghỉ đêm tại Nha Trang.', N'Xe du lịch', N'Nha Trang')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV16', N'Ngày 2 - NHA TRANG - THÁP BÀ - HÒN CHỒNG – VINWONDERS (Ăn sáng, trưa, tự túc ăn chiều)', N'Sau khi dùng buffet sáng tại khách sạn, xe đưa đoàn tham quan:

- Tháp Bà Ponagar: công trình tiêu biểu cho nghệ thuật kiến trúc và điêu khắc tín ngưỡng tôn giáo bậc nhất của dân tộc Chăm tại Nha Trang.

- Hòn Chồng: một thắng cảnh tự nhiên nằm ở bờ biển phía Bắc thành phố Nha Trang. Nơi đây du khách có thể di chuyển vài bước đã chạm đến sóng biển hoặc chân đồi. Nhiều người bảo, Hòn Chồng là nơi giao nhau giữa biển và núi. Quần thể đá Hòn Chồng từ lâu đã trở thành điểm du lịch giàu tính nhân văn. Điều kỳ thú là những tảng đá lớn nằm chồng chất lên nhau bao đời nay nhưng sóng biển và mưa gió không thể xô ngã.

Buổi chiều, Quý khách tự do khám phá thành phố Nha Trang hoặc tự túc lựa chọn tham quan 1 trong 2 chương trình: 

- Vinwonders Nha Trang đầy sắc màu: ngắm toàn cảnh Vịnh Nha Trang từ đỉnh vòng xoay mặt trời lớn nhất Việt Nam, tham quan bộ sưu tập “kỳ hoa, dị thảo” tại đồi Vạn Hoa, khu vườn thú mở - vườn Quý Vương, tham gia các trò chơi tương tác và liên hoàn tại Quảng trường Thần Thoại hay Vùng đất yêu thương, xem phim 4D tại lâu đài Đại Dương, khám phá khu trò chơi cảm giác mạnh, khu trò chơi trong nhà hay tắm biển, tắm hồ bơi lớn nhất Đông Nam Á… và thưởng thức chương trình biểu diễn Nhạc Nước hiện đại. Đoàn tự do dùng bữa tối tại đây và tiếp tục tham gia các hoạt động buổi tối tại Vinpearl đến giờ về lại đất liền. (VTV hỗ trợ xe chiều đi - chi phí vé tham quan và xe chiều về tự túc)

- Suối khoáng nóng I-Resort: với không gian yên tĩnh, cây cối xanh tươi, I-Resort sẽ hiện ra như một bức tranh thiên nhiên đậm chất Việt, Quý khách sẽ được trải nghiệm dịch vụ tắm khoáng thư giãn. Ngoài ra, Quý khách còn có thể tắm bùn khoáng hoặc massage cho làn da thêm tươi trẻ. (Quý khách tự túc chi phí vé tham quan và di chuyển)

Nghỉ đêm tại Nha Trang.', N'Du thuyền', N'Nha Trang')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV17', N'Ngày 3 - NHA TRANG - PHÚ YÊN – GÀNH ĐÁ ĐĨA – NHÀ THỜ MẰNG LĂNG (Ăn sáng, trưa, chiều)', N'Sau khi dùng buffet sáng tại khách sạn. Quý khách trả phòng, đoàn khởi hành đi Phú Yên sớm, tham quan:
- Bãi Xép: Một trong những bãi biển hoang sơ và đẹp nhất của Phú Yên. 
- Gành Ông: Cảnh quay đặc sắc trong bộ phim “Tôi Thấy Hoa Vàng Trên Cỏ Xanh” 
- Gành Đá Dĩa: Thắng cảnh độc nhất vô nhị của tỉnh Phú Yên và của Quốc Gia.
- Trên đường đi Quý khách còn được chiêm ngưỡng cảnh Đầm Ô Loan trông như đôi cánh Phượng Hoàng dang rộng giữa mây trời và núi ngàn.
- Nhà Thờ Mằng Lăng: Nơi còn lưu giữ cuốn kinh thánh bằng chữ Quốc Ngữ đầu tiên của Việt Nam.
- Tháp Nghinh Phong: một thiết kế đặc biệt ấn tượng lấy cảm hứng từ ghềnh đá đĩa mang tính biểu tượng của địa phương và truyền thuyết “Trăm trứng trăm con” của Lạc Long quân và Âu Cơ, là điểm đến hấp dẫn, thu hút sự chú ý của nhiều bạn trẻ hẹn nhau sẽ tới nơi này để check-in.

Nghỉ đêm tại Phú Yên.', N'Xe du lịch', N'Phú Yên')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV18', N'Ngày 4 - PHÚ YÊN – MŨI ĐIỆN - DỐC LẾT - NHA TRANG (Ăn sáng, trưa, chiều)', N'Sau khi dùng buffet sáng tại khách sạn. Quý khách trả phòng, đoàn khởi hành đi tham quan:

- Bến Tàu Không Số Vũng Rô: tìm hiểu và biết thêm về lịch sử con tàu huyền thoại, giúp vận chuyển vũ khí từ Bắc vào Nam, đoàn tàu cùng với sự chiến đấu anh dũng và kiên cường của những người lính thời chiến, ra sức bảo vệ cho hòa bình của dân tộc.

- Mũi Đại Lãnh: hay còn gọi là Mũi Điện (điểm cực đông của tổ quốc) ở độ cao 110m so với mặt nước biển. 

- Bãi Môn – Mũi Điện: một bãi biển vẫn còn khá hoang sơ, có hình vầng trăng khuyết, cát trắng mịn, nước trong veo như pha lê. Xa xa, Quý khách chụp hình Mũi Điện với ngọn hải đăng vươn ra biển, một trong những nơi đón ánh nắng đầu tiên của Tổ Quốc.

- KDL Dốc Lết: Được tạo dáng với bãi cỏ xanh ngát và hàng dừa đặc trưng của vùng biển, nơi mà ánh nắng mặt trời, cát trắng và phong cảnh đã hòa quyện vào nhau để làm nên một khung cảnh thơ mộng cho khu du lịch cao cấp này 

Nghỉ đêm tại Nha Trang.', N'Xe du lịch', N'Nha Trang.')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV19', N'Ngày 5 - NHA TRANG – TP. HỒ CHÍ MINH (Ăn sáng, trưa)', N'Sau khi dùng buffet sáng tại khách sạn, xe đưa đoàn khởi hành về Tp. Hồ Chí Minh. Trên đường về Quý khách dừng tham quan:
 
- Mua sắm đặc sản Phan Rang tại Vườn nho Cường 2: trải nghiệm cảm giác “hái tận tay” những chùm nho tươi ngon, mọng nước của miền nắng gió.

Chiều về đến Tp.HCM, đưa khách về điểm đón ban đầu. Chia tay Quý khách và kết thúc chương trình du lịch', N'Xe du lịch', N'TP. HỒ CHÍ MINH')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV2', N'Ngày 2 - BÃI SAO - KHÁM PHÁ KHU VUI CHƠI GIẢI TRÍ VINWONDERS - VƯỜN THÚ HOANG DÃ SAFARI - GRAND WORLD (Ăn sáng & trưa; riêng buổi chiều Quý khách tự túc)', N'Sau khi ăn sáng tại khách sạn, xe đưa Quý khách lên thuyền du ngoạn: 
- Nam Đảo (giai đoạn tháng 5 - tháng 09): Đoàn sẽ được cùng nhau thử tài câu cá, thật là thú vị khi tự tay Quý khách câu được những chú cá Mú hay Tràm... và đây cũng là dịp được trải nghiệm cuộc sống cần mẫn của người dân nơi hải đảo. Khách câu cá và tắm biển tại Bãi Sao - một bãi biển dịu êm với bãi cát dài tĩnh lặng và nguyên sơ, được độc giả CN Traveler bình chọn vào danh sách 10 bãi biển hoang sơ nhất thế giới… Ngoài tắm biển, du khách có thể tham gia những trò chơi cảm giác mạnh trên biển như: Jetky, ca nô dù kéo, môtô nước… (chi phí tự túc). 
- Bắc Đảo (giai đoạn tháng 10 - tháng 4): Quý khách hách thử tài câu cá và tắm biển tại Bãi Ông Lang.
Lưu ý: Đoàn câu cá và lặn ngắm san hô còn phụ thuộc vào điều kiện thực tế tại thời điểm đoàn tham quan
 
Sau khi ăn trưa tại nhà hàng địa phương, đoàn khởi hành về lại khách sạn. Buổi chiều, Quý khách tự do khám phá Phú Quốc hoặc có thể đặt các chương trình tham quan (chi phí tự túc)
 
Quý khách có thể lựa chương trình theo gợi ý sau (tự túc phương tiện di chuyển)
 
- Tham quan Công Viên Chủ Đề VinWonders Phú Quốc - du khách sẽ lạc vào “Thế Giới Cổ Tích” thông qua những trò chơi tương tác lần đầu tiên xuất hiện tại Việt Nam với 6 chủ đề khác nhau: Khu Cảm Giác Mạnh - Thế Giới Phiêu Lưu; Khu Công Viên Nước - Thế Giới Lốc Xoáy; Khu Lâu Đài Trung Tâm - Châu Âu Trung Cổ; Khu Cổ Tích - Thế Giới Diệu Kỳ; Khu Viking - Ngôi Làng Bí Mật.
 
- Khám phá Vinpearl Safari Phú Quốc - Vườn thú  bánhoang dã lớn nhất tại Việt Nam (chi phí tự túc) với quy mô 180 ha và hơn 130 loài động vật quý hiếm, du khách thưởng thức các chương trình biểu diễn, chụp ảnh với động vật; trải nghiệm vườn thú mở trong rừng tự nhiên, gần gũi và thân thiện với con người.
 
- Thỏa sức check-in tại Grand World với các hạng mục như: công trình tre, công viên nghệ thuật đương đại…; tản bộ bên dòng “kênh đào Venice” và nhìn ngắm những chiếc thuyền Gondola, khu phố shophouse lộng lẫy sắc màu, cổng lâu đài tráng lệ, ba cây cầu vòm bán nguyệt...', N'Xe du lịch', N'Phú Quốc')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV3', N'Ngày 3 - PHÚ QUỐC - RẠCH GIÁ - CẦN THƠ (Ăn sáng, trưa; riêng buổi chiều ăn nhẹ)', N'Quý khách tự do tắm biển. Sau khi làm thủ tục trả phòng, đoàn Tham quan và mua sắm đặc sản nổi tiếng tại nhà thùng nước mắm Hồng Đức 1, đặc sản Đức Thạnh, cơ sở sản xuất ngọc trai Phú Quốc - trưng  bày các trang sức bằng ngọc trai chính hiệu được nuôi cấy tại Phú Quốc.

Đoàn ăn trưa tại Phú Quốc. Xe đưa Quý khách ra bến tàu Phú Quốc trở về Rạch Giá. Xe Vietravel đón đoàn tại Rạch Giá đưa khách về Cần Thơ. Ăn nhẹ trên đường về. Tối về đến Cần Thơ, hướng dẫn viên chia tay đoàn và kết thúc chương trình du lịch', N'Xe du lịch', N'Rạch Giá - Cần Thơ')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV4', N'Ngày 1 - TP HỒ CHÍ MINH - PHÚ QUỐC (Ăn chiều)', N'Quý khách tập trung tại Sân bay Tân Sơn Nhất, ga đi Trong Nước, hướng dẫn viên hỗ trợ làm thủ tục đáp chuyến bay đi Phú Quốc. Xe đón đoàn tại sân bay đưa Quý khách về nhận phòng tại khách sạn.

Buổi tối, Quý khách tự do dạo chợ Đêm Phú Quốc thưởng thức hải sản (chi phí tự túc).
Nghỉ đêm tại Phú Quốc.', N'Máy bay', N'Phú Quốc')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV5', N'Ngày 2 - PHÚ QUỐC - HÒN THƠM - TRẢI NGHIỆM CÁP TREO VƯỢT BIỂN - CÔNG VIÊN NƯỚC AQUATOPIA - THỊ TRẤN HOÀNG HÔN (Ăn sáng, trưa, chiều)', N'Sau khi ăn sáng, xe đưa đoàn đến đến nhà ga cáp treo An Thới tham quan Sun World Hon Thom Nature Park với những hoạt động thú vị:

- Trải nghiệm cáp treo 3 dây vượt biển dài nhất thế giới - 7.899.9 mét.

- Phấn khích tột độ cùng thử thách "Mộc Xà thịnh nộ" - trò chơi tàu lượn bằng gỗ đầu tiên tại Việt Nam, có tốc độ tối đa 80km/h với nhiều góc lượn ngoạn mục; đài quan sát "Mắt đại bàng" cao 120m - du khách như được bay lên không trung, thưởng ngoạn đại dương xanh ngắt bao la, những cánh rừng nhiệt đới xanh mướt, những đảo nhỏ nhấp nhô giữa biển trời khoáng đạt (trò chơi có thể tạm dừng vì lịch bảo trì)

- Thỏa thích tắm biển hòn Thơm: một trong những bãi biển “quyến rũ nhất hành tinh”, với bãi cát trắng mịn, hoang sơ, hàng dừa nghiêng soi bóng, màu nước biển xanh màu ngọc bích, phản chiếu long lanh dưới ánh nắng mặt trời.

- Tham gia các hoạt động giải trí trên biển: kayak, jetski, dù lượn, phao chuối (chi phí tự túc).

- Vui chơi tại công viên nước Aquatopia: một trong những công viên nước chủ đề hàng đầu Đông Nam Á, trải nghiệm 6 khu check-in chủ đề hấp dẫn mang phong cách thổ dân huyền bí.

Tìm bình yên trong hành trình ‘Đi Theo Ánh Mặt Trời’ tại Thị trấn Hoàng Hôn - được thiết kế với kiến trúc độc đáo, rực rỡ sắc màu của một thị trấn châu Âu cổ kính:

- Lãng du trên con đường thị trấn, check-in ‘1001’ kiểu bậc thang, ngắm nhìn Quảng trường La Mã lấp lánh dưới ánh mai.

- Say đắp giữa nghệ thuật tại Tháp đồng hồ cao 75m: lấy ý tưởng từ tháp chuông St. Mark’s Campanile của Ý.

- Lắng đọng với “kỳ quan” Khải Hoàn Môn nhuốm ánh chiều tà.

- Chiêm ngưỡng Kiss Bridge: cây cầu nổi lên như một dải lụa giữa bờ biển trong xanh, với hai nhịp cầu vươn mình ôm trọn bờ cát trắng, hướng đến nhau, hợp vào làm một thể thống nhất nhưng không chạm nhau. Ngắm nhìn bức tranh hoàng hôn tuyệt diệu đang dần buông xuống đường chân trời nơi đại dương xanh thẳm, đầy lãng mạn.

Nghỉ đêm tại Phú Quốc.', N'Xe du lịch', N'Phú Quốc')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV6', N'Ngày 3 - PHÚ QUỐC - BÃI SAO - TP HỒ CHÍ MINH (Ăn sáng, trưa)', N'Sau khi dùng bữa sáng tại, Quý khách trả phòng và khởi hành tham quan 

- Dinh Cậu: biểu tượng văn hoá và tín ngưỡng của đảo Phú Quốc. Nơi ngư dân địa phương gởi gắm niềm tin cho một chuyến ra khơi đánh bắt đầy ắp cá khi trở về. 

- Chùa Sư Muôn (Hùng Long Tự): ngôi chùa có kiến trúc dân gian, nằm trên triền núi, mặt hướng ra biển, xung quanh cây cối xanh tốt. Đến đây du khách cảm nhận vẻ đẹp thanh tịnh, bình yên và cầu nguyện sự an lành và hạnh phúc đến với gia đình.

- Tắm biển Bãi Sao: nằm ở phía Nam Đảo - một bãi biển dịu êm, bãi cát dài tĩnh lặng và nguyên sơ nơi đảo xanh. Tại đây Quý khách sẽ thật sự cảm thấy yên bình, thư thái và dường như cuộc sống chậm lại khi hòa mình cùng thiên nhiên. 

- Quần Thể Đảo Yến Phú Quốc: hòa vào không gian xanh, du khách nghe giới thiệu quy trình sơ chế sản phẩm và mua sắm đặc sản yến sào bổ dưỡng.

- Tham quan và mua sắm đặc sản nổi tiếng tại Nhà thùng nước mắm Hồng Đức 1 / Khải Hoàn / Phụng Hưng, Đặc sản Đức Thạnh, Cơ sở sản xuất ngọc trai Phú Quốc - Trưng bày các trang sức bằng ngọc trai chính hiệu được nuôi cấy tại Phú Quốc.

Xe đưa đoàn ra sân bay Phú Quốc đáp chuyến bay trở về TP Hồ Chí Minh. Chia tay Quý khách và kết thúc chương trình du lịch tại sân bay Tân Sơn Nhất.

Lưu ý: 
Phụ thu giá vé tham quan đối với trẻ em dưới 12 tuổi cao trên 1m4 
- Combo Hòn Thơm: phụ thu 300,000 VNĐ/khách
Đối với các khách không phụ thu khi mua tour, khi có phát sinh tại điểm tham quan, khách tự chịu chi phí phát sinh tại điểm tham quan.

Quý khách lưu ý: 
- Giờ bay phụ thuộc vào hãng hàng không, số bữa ăn phụ thuộc vào giờ bay
- Nếu chuyến bay ngày thứ 3 trong chương trình về chuyến sáng hoặc trưa thì bữa ăn trưa ngày thứ 3 sẽ được chuyển sang ngày thứ 1.
- Hành trình có thể thay đổi thứ tự điểm đến tùy vào điều kiện thực tế
- Đây là chương trình du lịch trọn gói, Vietravel không có trách nhiệm hoàn trả chi phí chênh lệch cho các khách hàng thuộc diện miễn giảm hoặc đối tượng ưu tiên như trẻ nhỏ, người lớn tuổi, người có công với cách mạng… Chính sách miễn giảm, ưu tiên (nếu có) chỉ dành cho khách lẻ của các điểm tham quan.', N'Máy bay', N'Hồ Chí Minh')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV7', N'Ngày 1 - HÀ NỘI – NAGOYA - KYOTO - GIFU (Ăn trưa, tối)', N'ĐÊM TRƯỚC NGÀY 01

Quý khách tập trung tại công ty Vietravel (03 Hai Bà Trưng, Hoàn Kiếm). Xe và Hướng dẫn viên đón Quý khách đến sân bay Nội Bài để làm thủ tục đáp chuyến bay đi Nagoya - Nhật Bản.

Quý khách nghỉ đêm trên máy bay.

 

NGÀY 01: NAGOYA – KYOTO - GIFU                                                                     

Đoàn đáp sân bay Nagoya, làm thủ tục nhập cảnh và ăn sáng tự túc tại sân bay.

Sau đó, đoàn di chuyển đến thành phố Kyoto tham quan:

- Chùa vàng - Golden Pavillion Temple – toàn bộ ngôi chùa được dát bằng vàng lá tuyệt đẹp

- “Chùa Thanh Thuỷ - Kiyomizu Dera” với lối kiến trúc độc đáo toàn bằng gỗ, nằm trên vùng cao ngọn đồi Higashiyama

Sau chuyến tham quan Quý khách dùng bữa tối, di chuyển về khu vực Gifu và nhận phòng khách sạn.

Nghỉ tại khách sạn ở Seki – Gifu', N'Máy bay', N'Seki – Gifu')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV8', N'Ngày 2 - GIFU- SHIRAKAWAGO- KAMAKOCHI- MATSUMOTO (Ăn sáng, trưa, tối)', N'Ăn sáng tại khách sạn. Đoàn tiến hành tham quan, khám phá:
- Tham quan Shirakawa-go, ngôi làng đẹp như bước ra từ cổ tích, nằm ở chân núi Haku-san, tỉnh Gifu. Điểm đặc biệt của ngôi làng này là những ngôi nhà gỗ mang kiến trúc gasshō-zukuri có phần mái nhà dốc lợp bằng cỏ tranh, nhìn giống như các bàn tay cầu nguyện, ngôi làng được UNESCO công nhận là di sản thế giới từ năm 1995 và là nơi hoạ sĩ Fujiko Fujio thai nghén và cho ra đời bộ truyện tranh kinh điển Doraemon.

Sau đó, Quý khách sẽ được tham quan 1 trong 2 option sau tùy thuộc vào mùa:

- Option 1 (tháng 9 – giữa tháng 11):

+ Đi tham quan Thung lũng Kamikochi: là thung lũng dài 15km ở độ cao 1.500m phía Bắc của dãy núi Alps, trong Công viên quốc gia Chubu Sangaku của tỉnh Nagano và được bao quanh bởi 4 ngọn núi

-  Option 2 (cuối tháng 11 – tháng 4 năm sau):

+ Ghé thăm làng cổ Takayama: Ngôi làng cổ Takayama được xây dựng từ thời Edo Nhật Bản, đến nay ngôi làng này vẫn còn lưu giữ nhiều nét kiến trúc mang phong cách thời bấy giờ một cách đậm nét và đặc trưng nhất.
Đến với ngôi làng cổ này du khách sẽ được chiêm ngưỡng hình ảnh của những ngôi nhà, chùa,… được xây dựng theo lối kiến trúc cổ, nông thôn Edo thời xưa. Bên cạnh đó quan cảnh thiên nhiên vô cùng yên tĩnh với nhiều cây rẻ quạt có tuổi đời lên đến hàng nghìn năm giúp du khách có thể hòa mình vào không khí và thiên nhiên vùng nông thôn Nhật Bản một cách chân thực nhất.

+ Trang trại Daio Wasabi Farm: Nông trại Wasabi là sự kết hợp giữa cánh đồng Wasabi rộng hơn 500.000 mét vuông với những khu vườn cây, hoa, những con đường uốn lượn màu xanh mướt làm du khách say mê cứ muốn đi mãi để chụp ảnh mà quên cả thời gian.

Ăn trưa tại nhà hàng, thưởng thức món thịt bò Hida nổi tiếng

Quý khách tham quan mua sắm tại Aeon Mall Matsumoto

Ăn tối tại nhà hàng

Đoàn nhận phòng khách sạn ở Matsumoto', N'Xe du lịch', N'Matsumoto')
INSERT [dbo].[DICHVU] ([DV_ID], [DV_Ten], [DV_MoTa], [DV_PhuongTien], [DV_DiaDiem]) VALUES (N'DV9', N'Ngày 3 - MATSUMOTO – KAWAGUCHIKO (Ăn sáng, trưa, tối)', N'Quý khách ăn sáng tại khách sạn.

- Đoàn chụp ảnh bên ngoài Lâu đài Matsumoto - được mệnh danh là lâu đài đẹp nhất thời trung cổ.

- Tham quan nhà máy rượu - trải nghiệm xem cách sản xuất rượu của người dân Nhật Bản.

Ăn trưa tại nhà hàng

- Đoàn shopping tại khu mua sắm miễn thuế Karuizawa Outlet

Buổi chiều đoàn di chuyển về Kawaguchiko.

Đoàn nhận phòng khách sạn, thư giãn và thoả sức Sauna tại bồn nước suối khoáng nóng thiên nhiên trong quần thể khu du lịch.                                       

Nghỉ đêm tại khách sạn tại khu vực Kawaguchiko. (Tominoko hoặc tương đương)', N'Xe du lịch', N'Kawaguchiko')
GO
SET IDENTITY_INSERT [dbo].[HINHANHTOUR] ON 

INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (31, N'T1_1.jpg', N'HinhAnhTour\T1_1.jpg', 1, N'T1')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (32, N'T1_2.jpg', N'HinhAnhTour\T1_2.jpg', 2, N'T1')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (33, N'T1_3.jpeg', N'HinhAnhTour\T1_3.jpeg', 3, N'T1')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (34, N'T1_4.jpg', N'HinhAnhTour\T1_4.jpg', 4, N'T1')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (36, N'T2_1.jpg', N'HinhAnhTour\T2_1.jpg', 1, N'T2')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (37, N'T2_2.jpg', N'HinhAnhTour\T2_2.jpg', 2, N'T2')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (38, N'T2_3.jpg', N'HinhAnhTour\T2_3.jpg', 3, N'T2')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (39, N'T2_4.jpg', N'HinhAnhTour\T2_4.jpg', 4, N'T2')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (40, N'T4_1.jpg', N'HinhAnhTour\T4_1.jpg', 1, N'T4')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (41, N'T4_2.jpg', N'HinhAnhTour\T4_2.jpg', 2, N'T4')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (42, N'T4_3.jpg', N'HinhAnhTour\T4_3.jpg', 3, N'T4')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (43, N'T4_4.jpg', N'HinhAnhTour\T4_4.jpg', 4, N'T4')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (44, N'T5_1.jpg', N'HinhAnhTour\T5_1.jpg', 1, N'T5')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (45, N'T5_2.jpg', N'HinhAnhTour\T5_2.jpg', 2, N'T5')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (46, N'T5_3.jpg', N'HinhAnhTour\T5_3.jpg', 3, N'T5')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (47, N'T5_4.jpg', N'HinhAnhTour\T5_4.jpg', 4, N'T5')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (48, N'T7_1.jpg', N'HinhAnhTour\T7_1.jpg', 1, N'T7')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (49, N'T7_2.jpg', N'HinhAnhTour\T7_2.jpg', 2, N'T7')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (50, N'T7_3.jpg', N'HinhAnhTour\T7_3.jpg', 3, N'T7')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (51, N'T7_4.jpg', N'HinhAnhTour\T7_4.jpg', 4, N'T7')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (52, N'T10_1.jpg', N'HinhAnhTour\T10_1.jpg', 1, N'T10')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (53, N'T10_2.jpg', N'HinhAnhTour\T10_2.jpg', 2, N'T10')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (54, N'T10_3.jpg', N'HinhAnhTour\T10_3.jpg', 3, N'T10')
INSERT [dbo].[HINHANHTOUR] ([HA_ID], [HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID]) VALUES (55, N'T10_4.jpg', N'HinhAnhTour\T10_4.jpg', 4, N'T10')
SET IDENTITY_INSERT [dbo].[HINHANHTOUR] OFF
GO
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH1', N'Nguyễn Văn A', N'Nam', CAST(N'1990-01-01' AS Date), N'0123456789', N'123 Đường ABC, Quận XYZ, Thành phố Hồ Chí Minh')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH13', N'Nguyễn Văn Đạt', N'Nam', CAST(N'2000-01-01' AS Date), N'0978945612', N'Hồ Chí Minh')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH14', N'sdjaihfaisdufhs', N'Nam', CAST(N'2000-01-01' AS Date), N'5235762364', N'sdafsadofuhsaduife')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH15', N'zdfsdfsd', N'Nam', CAST(N'2000-01-01' AS Date), N'265436', N'sdfsafsafsagsfafds')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH16', N'Nguyễn Văn A', N'Nam', CAST(N'2000-01-01' AS Date), N'0912345678', N'Cần Thơ')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH2', N'Trần Thị B', N'Nữ', CAST(N'1992-03-15' AS Date), N'0987654321', N'456 Đường XYZ, Quận ABC, Thành phố Hà Nội')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH3', N'Lê Văn C', N'Nam', CAST(N'1985-07-20' AS Date), N'0369874521', N'789 Đường XYZ, Quận DEF, Thành phố Cần Thơ')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH4', N'Phạm Thị D', N'Nữ', CAST(N'1998-12-05' AS Date), N'0912345678', N'321 Đường DEF, Quận XYZ, Thành phố Đà Nẵng')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH5', N'Hoàng Văn F', N'Nam', CAST(N'2024-03-21' AS Date), N'0654789213', N'555 Đường MNO, Quận KLM, Thành phố Hải Phòng')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH6', N'Nguyễn Văn Tèo', N'Nam', CAST(N'2000-01-01' AS Date), N'0913123456', N'Cần Thơ ')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH7', N'Nguyễn Văn Tí', N'Nam', CAST(N'2000-01-01' AS Date), N'0913234789', N'Cần Thơ')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH8', N'hjasdbfjksad', N'Nam', CAST(N'2000-01-01' AS Date), N'5469685126', N'Cần Thơ')
INSERT [dbo].[KHACHHANG] ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi]) VALUES (N'KH9', N'sfd', N'Nam', CAST(N'2000-01-01' AS Date), N'45644165', N'dsaffasdfsadf')
GO
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV1', N'Người quản trị', N'Nam', CAST(N'2000-01-01' AS Date), N'0913123456', N'Cần Thơ')
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV10', N'Nguyễn Văn A', N'Nam', CAST(N'2024-04-13' AS Date), N'098123743', N'Cần Thơ')
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV2', N'Nguyễn Thành Phát', N'Nam', CAST(N'2000-01-01' AS Date), N'0913999999', N'Cần Thơ')
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV3', N'Phạm Trí Đạt', N'Nam', CAST(N'2000-01-01' AS Date), N'0913123456', N'Cần Thơ')
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV4', N'Nguyễn Tiền Phương', N'Nam', CAST(N'2000-01-01' AS Date), N'0913999999', N'Cần Thơ')
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV5', N'Nguyễn Văn A', N'Nam', CAST(N'2000-01-01' AS Date), N'0913999999', N'Cần Thơ')
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV6', N'Nguyễn Văn Tí', N'Nam', CAST(N'1999-07-21' AS Date), N'0913123456', N'Cần Thơ')
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV7', N'Trần Thi B', N'Nữ', CAST(N'2000-01-05' AS Date), N'0912345678', N'Cần Thơ')
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV8', N'Trần Thị Z', N'Nữ', CAST(N'2024-04-08' AS Date), N'091323499', N'Cần Thơ')
INSERT [dbo].[NHANVIEN] ([NV_ID], [NV_Ten], [NV_GioiTinh], [NV_NgaySinh], [NV_SoDienThoai], [NV_DiaChi]) VALUES (N'NV9', N'Trần Bích Liên', N'Nữ', CAST(N'2000-04-11' AS Date), N'0913123456', N'Hồ Chí Minh')
GO
INSERT [dbo].[TAIKHOAN] ([TK_TenDangNhap], [TK_MatKhau], [TK_Loai], [NV_ID]) VALUES (N'abc', N'123', 1, N'NV10')
INSERT [dbo].[TAIKHOAN] ([TK_TenDangNhap], [TK_MatKhau], [TK_Loai], [NV_ID]) VALUES (N'admin', N'123', 1, N'NV1')
INSERT [dbo].[TAIKHOAN] ([TK_TenDangNhap], [TK_MatKhau], [TK_Loai], [NV_ID]) VALUES (N'Dat', N'123', 1, N'NV3')
INSERT [dbo].[TAIKHOAN] ([TK_TenDangNhap], [TK_MatKhau], [TK_Loai], [NV_ID]) VALUES (N'lien', N'123456', 0, N'NV9')
INSERT [dbo].[TAIKHOAN] ([TK_TenDangNhap], [TK_MatKhau], [TK_Loai], [NV_ID]) VALUES (N'NV5', N'1', 0, N'NV5')
INSERT [dbo].[TAIKHOAN] ([TK_TenDangNhap], [TK_MatKhau], [TK_Loai], [NV_ID]) VALUES (N'Phat', N'123', 1, N'NV2')
INSERT [dbo].[TAIKHOAN] ([TK_TenDangNhap], [TK_MatKhau], [TK_Loai], [NV_ID]) VALUES (N'Phuong', N'123', 1, N'NV4')
INSERT [dbo].[TAIKHOAN] ([TK_TenDangNhap], [TK_MatKhau], [TK_Loai], [NV_ID]) VALUES (N'QWE', N'qwert', 0, N'NV7')
INSERT [dbo].[TAIKHOAN] ([TK_TenDangNhap], [TK_MatKhau], [TK_Loai], [NV_ID]) VALUES (N'XYZ', N'123', 1, N'NV7')
GO
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T1', N'Cần Thơ - Phú Quốc - Ngắm Hoàng Hôn Tại Sunset Sanato - Thử Tài Câu Cá - Thỏa Thích Vui Chơi Tại Vinwonders & Safari', CAST(N'2024-03-22' AS Date), 3, 3890000, 2, N'Cần Thơ')
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T10', N'Nha Trang - Phú Yên: Khu Du Lịch Dốc Lết - Gành Đá Dĩa - Mũi Điện - Tháp Nghinh Phong - Vinwonders Nha Trang', CAST(N'2024-04-13' AS Date), 5, 4790000, 3, N'TP. Hồ Chí Minh')
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T2', N'Phú Quốc: Hòn Thơm Nature Park - Thị Trấn Hoàng Hôn - Kiss Birdge (Tặng Vé Cáp Treo 3 Dây Vượt Biển Dài Nhất Thế Giới)', CAST(N'2024-03-22' AS Date), 3, 5490000, 1, N'5.490.000')
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T3', N'Miền Tây: Cần Thơ - Cà Mau - Đất Mũi - Bạc Liêu - Sóc Trăng - Trải Nghiệm Tuyến Cao Tốc Mới Nhất Của Miền Tây (Tham quan vườn trái cây)', CAST(N'2024-03-23' AS Date), 4, 4590000, 3, N'TP. Hồ Chí Minh')
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T4', N'Liên tuyến Miền Tây - TP.HCM: Cà Mau - Bạc Liêu - Sóc Trăng - Cần Thơ - Vĩnh Long - Bến Tre - TP.Hồ Chi Minh - Một hành trình - 7 điểm đến - Sắc xanh trên dòng sông MêKông - Bay Vietnam Airlines - Khách sạn 4*', CAST(N'2024-03-21' AS Date), 6, 9990000, 9, N'Hà Nội')
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T5', N'Nhật Bản: Nagoya-Kyoto- Làng cổ Shirakawago-Takayama- Núi Phú Sĩ-Tokyo Thưởng thức thịt bò Hida Mùa hoa anh đào 2024', CAST(N'2024-03-25' AS Date), 5, 38900000, 1, N'Hà Nội')
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T6', N'Miền Tây: Châu Đốc - Rừng Tràm Trà Sư - Hà Tiên - Rạch Giá - Cần Thơ - Trải Nghiệm Tuyến Cao Tốc Mới Nhất Của Miền Tây', CAST(N'2024-04-08' AS Date), 4, 4190000, 10, N'TP. Hồ Chí Minh')
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T7', N'Phú Quốc - Thiên đường giải trí Vinwonder - Safari World - Hòn Thơm Nature Park - Cáp Treo Vượt Biển - Công Viên Nước Aquatopia', CAST(N'2024-04-10' AS Date), 3, 7590000, 4, N'TP. Hồ Chí Minh')
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T8', N'Biển Nắng Nha Trang - Sắc Hoa Đà Lạt: Hòn Lao - Vinwonders - Langbiang - Mê Linh Coffee', CAST(N'2024-04-10' AS Date), 5, 4590000, 9, N'TP. Hồ Chí Minh')
INSERT [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia], [TOUR_TongSoVeTour], [TOUR_NoiKhoiHanh]) VALUES (N'T9', N'Du lịch Hòn Sơn', CAST(N'2024-05-01' AS Date), 2, 5000000, 10, N'TP HỒ Chí Minh')
GO
INSERT [dbo].[VE] ([VE_ID], [VE_SoLuongMua], [VE_TongTien], [VE_NgayLap], [KH_ID], [TOUR_ID], [NV_ID]) VALUES (N'VE4', 6, 27540000, CAST(N'2024-03-27' AS Date), N'KH13', N'T3', N'NV5')
INSERT [dbo].[VE] ([VE_ID], [VE_SoLuongMua], [VE_TongTien], [VE_NgayLap], [KH_ID], [TOUR_ID], [NV_ID]) VALUES (N'VE5', 2, 7780000, CAST(N'2024-04-05' AS Date), N'KH14', N'T1', N'NV5')
INSERT [dbo].[VE] ([VE_ID], [VE_SoLuongMua], [VE_TongTien], [VE_NgayLap], [KH_ID], [TOUR_ID], [NV_ID]) VALUES (N'VE6', 2, 7780000, CAST(N'2024-04-08' AS Date), N'KH15', N'T1', N'NV5')
INSERT [dbo].[VE] ([VE_ID], [VE_SoLuongMua], [VE_TongTien], [VE_NgayLap], [KH_ID], [TOUR_ID], [NV_ID]) VALUES (N'VE7', 6, 28740000, CAST(N'2024-04-11' AS Date), N'KH16', N'T10', N'NV5')
GO
ALTER TABLE [dbo].[TAIKHOAN] ADD  DEFAULT ((0)) FOR [TK_Loai]
GO
ALTER TABLE [dbo].[CHITIETTOUR]  WITH CHECK ADD FOREIGN KEY([DV_ID])
REFERENCES [dbo].[DICHVU] ([DV_ID])
GO
ALTER TABLE [dbo].[CHITIETTOUR]  WITH CHECK ADD FOREIGN KEY([TOUR_ID])
REFERENCES [dbo].[TOUR] ([TOUR_ID])
GO
ALTER TABLE [dbo].[HINHANHTOUR]  WITH CHECK ADD FOREIGN KEY([TOUR_ID])
REFERENCES [dbo].[TOUR] ([TOUR_ID])
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD FOREIGN KEY([NV_ID])
REFERENCES [dbo].[NHANVIEN] ([NV_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD FOREIGN KEY([KH_ID])
REFERENCES [dbo].[KHACHHANG] ([KH_ID])
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD FOREIGN KEY([NV_ID])
REFERENCES [dbo].[NHANVIEN] ([NV_ID])
GO
ALTER TABLE [dbo].[VE]  WITH CHECK ADD FOREIGN KEY([TOUR_ID])
REFERENCES [dbo].[TOUR] ([TOUR_ID])
GO
/****** Object:  StoredProcedure [dbo].[Proc_CapNhatSoLuongTour]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_CapNhatSoLuongTour] 
(
	@idTour  NVARCHAR(10),
	@soluong int
)
AS
BEGIN
    Declare @SoluongTourBanDau INT
	SELECT @SoluongTourBanDau = TOUR_TongSoVeTour FROM TOUR WHERE TOUR_ID = @idtour

	UPDATE TOUR
	SET TOUR_TongSoVeTour = @SoluongTourBanDau - @soluong
	WHERE TOUR_ID = @idtour
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_DangNhap]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_DangNhap]
@userName NVARCHAR(100),
@passWord NVARCHAR(100)
AS
BEGIN 
	SELECT * FROM dbo.TAIKHOAN WHERE TK_TenDangNhap = @userName AND TK_MatKhau = @password;
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_DV_Sua]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_DV_Sua]
@DV_ID			NVARCHAR(10),	
@DV_Ten			NVARCHAR(1000),
@DV_PhuongTien	NVARCHAR(100),
@DV_DiaDiem		NVARCHAR(100),
@DV_MoTa		NVARCHAR(3000)
AS
BEGIN
	UPDATE dbo.DICHVU
	SET DV_Ten = @DV_Ten
	,[DV_PhuongTien] = @DV_PhuongTien
	, [DV_DiaDiem] = @DV_DiaDiem	
	, [DV_MoTa] = @DV_MoTa
	WHERE DV_ID = @DV_ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_DV_Them]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_DV_Them]
@DV_ID			NVARCHAR(10),	
@DV_Ten			NVARCHAR(1000),
@DV_PhuongTien	NVARCHAR(100),
@DV_DiaDiem		NVARCHAR(100),
@DV_MoTa		NVARCHAR(3000)
AS
BEGIN
	INSERT INTO dbo.DICHVU ([DV_ID], [DV_Ten], [DV_PhuongTien], [DV_DiaDiem], [DV_MoTa])
	VALUES (@DV_ID, @DV_Ten, @DV_PhuongTien, @DV_DiaDiem	, @DV_MoTa);
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_DV_Xoa]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_DV_Xoa]
@DV_ID			NVARCHAR(10)	
AS
BEGIN
	DELETE FROM DICHVU WHERE DV_ID = @DV_ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_KH_Sua]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_KH_Sua]
@id				NVARCHAR(100),	
@ten			NVARCHAR(100),
@gioitinh		NVARCHAR(3),
@NgaySinh		Date,
@sdt			NVARCHAR(10),	
@diachi			NVARCHAR(100)
AS
BEGIN
	UPDATE KHACHHANG
	SET
		[KH_HoTen] = @ten,
		[KH_GioiTinh] = @gioitinh,
		[KH_NgaySinh] = @NgaySinh,
		[KH_SoDienThoai] = @sdt,
		[KH_DiaChi] = @diachi
	WHERE [KH_ID] = @id
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_KH_Them]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_KH_Them]
@id				NVARCHAR(100),	
@ten			NVARCHAR(100),
@gioitinh		NVARCHAR(3),
@NgaySinh		Date,
@sdt			NVARCHAR(10),	
@diachi			NVARCHAR(100)
AS
BEGIN
	INSERT INTO KHACHHANG ([KH_ID], [KH_HoTen], [KH_GioiTinh], [KH_NgaySinh], [KH_SoDienThoai], [KH_DiaChi])
	VALUES (@id, @ten, @gioitinh, @NgaySinh, @sdt, @diachi)
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_KH_Xoa]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_KH_Xoa]
@id				NVARCHAR(100)
AS
BEGIN
	DELETE FROM KHACHHANG WHERE [KH_ID] = @id
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_NV_Sua]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_NV_Sua]
@id				NVARCHAR(100),	
@ten			NVARCHAR(1000),
@gioitinh		NVARCHAR(3),
@NgaySinh		Date,
@sdt			NVARCHAR(100),	
@diachi			NVARCHAR(300)
AS
BEGIN
	UPDATE NHANVIEN
	SET
		[NV_Ten] = @ten	,
		[NV_GioiTinh] = @gioitinh,
		[NV_NgaySinh] = @NgaySinh,
		[NV_SoDienThoai] = @sdt	,
		[NV_DiaChi] = @diachi	
	WHERE [NV_ID] = @id
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_NV_Them]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_NV_Them]
@id				NVARCHAR(100),	
@ten			NVARCHAR(1000),
@gioitinh		NVARCHAR(3),
@NgaySinh		Date,
@sdt			NVARCHAR(100),	
@diachi			NVARCHAR(300)
AS
BEGIN
	INSERT INTO [dbo].[NHANVIEN] 
				([NV_ID],
				[NV_Ten],
				[NV_GioiTinh],
				[NV_NgaySinh],
				[NV_SoDienThoai],
				[NV_DiaChi])
	VALUES (
				@id	,
				@ten,
				@gioitinh,
				@NgaySinh,
				@sdt,	
				@diachi
	)
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_NV_Xoa]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Proc_NV_Xoa]
@id				NVARCHAR(100)
AS
BEGIN
	DELETE [dbo].[NHANVIEN] WHERE [NV_ID] = @id	;
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_SuaTaiKhoan]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_SuaTaiKhoan]
(
	@TK_TenDangNhapCu NVARCHAR(100),
    @TK_TenDangNhapMoi NVARCHAR(100),
    @TK_MatKhau NVARCHAR(100),
    @TK_Loai INT,
    @NV_ID NVARCHAR(100)
)
AS
BEGIN
	DECLARE @ktra NVARCHAR(1000)
	SELECT @ktra = TK_TenDangNhap FROM TAIKHOAN WHERE [TK_TenDangNhap] = @TK_TenDangNhapCu AND NV_ID = @NV_ID

	IF @ktra IS NOT NULL 
    BEGIN
        UPDATE TAIKHOAN
        SET 
			TK_TenDangNhap = @TK_TenDangNhapMoi,
            TK_MatKhau = @TK_MatKhau,
            TK_Loai = @TK_Loai
        WHERE NV_ID = @NV_ID
		AND TK_TenDangNhap = @TK_TenDangNhapCu;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[PROC_TAOVE]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_TAOVE]
    @ID NVARCHAR(10),
    @SoLuongMua INT,
    @TongTien INT,
    @NgayLap DATE,
    @KH_ID NVARCHAR(10),
    @TOUR_ID NVARCHAR(10),
    @NV_ID NVARCHAR(10)
AS
BEGIN
    -- Thêm bản ghi mới vào bảng VE
    INSERT INTO VE (VE_ID, VE_SoLuongMua, VE_TongTien, VE_NgayLap, KH_ID, TOUR_ID, NV_ID)
    VALUES (@ID, @SoLuongMua, @TongTien, @NgayLap, @KH_ID, @TOUR_ID, @NV_ID)
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemChiTietTour]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_ThemChiTietTour]
(
    @idTour NVARCHAR(10),
    @idDichVu NVARCHAR(10)
)
AS
BEGIN
    -- Kiểm tra xem TOUR_ID và DV_ID đã tồn tại trong bảng TOUR và DICHVU không
    IF EXISTS (SELECT 1 FROM TOUR WHERE TOUR_ID = @idTour) AND
       EXISTS (SELECT 1 FROM DICHVU WHERE DV_ID = @idDichVu)
    BEGIN
        -- Kiểm tra xem chi tiết tour đã tồn tại trong bảng CHITIETTOUR chưa
        IF NOT EXISTS (SELECT 1 FROM CHITIETTOUR WHERE TOUR_ID = @idTour AND DV_ID = @idDichVu)
        BEGIN
            -- Thêm chi tiết tour mới vào bảng CHITIETTOUR
            INSERT INTO CHITIETTOUR (TOUR_ID, DV_ID) VALUES (@idTour, @idDichVu);
        END
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemTaiKhoan]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_ThemTaiKhoan]
(
	@TK_TenDangNhap      NVARCHAR(100),
    @TK_MatKhau          NVARCHAR(100),
    @TK_Loai             INT,
    @NV_ID NVARCHAR(100)
)
AS
BEGIN
	DECLARE @ktra NVARCHAR(10)
	SELECT @ktra = @TK_TenDangNhap FROM TAIKHOAN WHERE [TK_TenDangNhap] = @TK_TenDangNhap

	IF @ktra IS NULL 
		INSERT INTO TAIKHOAN
		VALUES (@TK_TenDangNhap, @TK_MatKhau, @TK_Loai, @NV_ID);
END;
GO
/****** Object:  StoredProcedure [dbo].[PROC_Tour_LoadHinhAnH]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_Tour_LoadHinhAnH]
    @HA_STT         INT,
	@TOUR_ID		NVARCHAR(10)
AS
BEGIN
	SELECT [HA_DuongDan]
	FROM [dbo].[HINHANHTOUR]
	WHERE [HA_STT] = @HA_STT AND [TOUR_ID] = @TOUR_ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_Tour_Sua]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_Tour_Sua]
@id				NVARCHAR(100),	
@ten			NVARCHAR(1000),
@ngayKhoiHanh	Date,
@soNgay			int,
@donGia			float,
@noiKH			NVARCHAR(3000),
@tongSoVe		int
AS
BEGIN
	UPDATE TOUR
	SET
		[TOUR_Ten] = @ten,
		[TOUR_NgayKhoiHanh] = @ngayKhoiHanh,
		[TOUR_SoNgay] = @soNgay	,
		[TOUR_DonGia] = @donGia,
		[TOUR_TongSoVeTour] = @tongSoVe,
		[TOUR_NoiKhoiHanh] = @noiKH
	WHERE [TOUR_ID] = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_Tour_Them]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_Tour_Them]
@id				NVARCHAR(100),	
@ten			NVARCHAR(1000),
@ngayKhoiHanh	Date,
@soNgay			int,
@donGia			float,
@noiKH			NVARCHAR(3000),
@tongSoVe		int
AS
BEGIN
	INSERT INTO [dbo].[TOUR] ([TOUR_ID], [TOUR_Ten], [TOUR_NgayKhoiHanh], [TOUR_SoNgay], [TOUR_DonGia],[TOUR_NoiKhoiHanh], [TOUR_TongSoVeTour])
	VALUES (@id, @ten, @ngayKhoiHanh, @soNgay, @donGia, @noiKH, @tongSoVe);
END;
GO
/****** Object:  StoredProcedure [dbo].[PROC_Tour_ThemHinhANH]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PROC_Tour_ThemHinhANH] (
    @HA_Ten         NVARCHAR(100),
    @HA_DuongDan    NVARCHAR(100),
    @HA_STT         INT,
    @TOUR_ID        NVARCHAR(10)
)
AS
BEGIN
    DECLARE @id INT
    DECLARE @result NVARCHAR(10)
    SELECT  @id = [HA_ID] FROM [dbo].[HINHANHTOUR] WHERE [HA_STT] = @HA_STT AND [TOUR_ID] = @TOUR_ID
    IF @id IS NOT NULL
    BEGIN
        UPDATE [dbo].[HINHANHTOUR] 
        SET [HA_DuongDan] = @HA_DuongDan
        WHERE [HA_ID] = @id
    END
    ELSE
		BEGIN
			INSERT INTO [dbo].[HINHANHTOUR] ([HA_Ten], [HA_DuongDan], [HA_STT], [TOUR_ID])
			VALUES (@HA_Ten, @HA_DuongDan , @HA_STT , @TOUR_ID);
		END
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_Tour_Xoa]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_Tour_Xoa]
@id				NVARCHAR(100)
AS
BEGIN
	DELETE [dbo].[TOUR] WHERE [TOUR_ID] = @id	;
END;
GO
/****** Object:  StoredProcedure [dbo].[PROC_Tour_XoaHinhAnH]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_Tour_XoaHinhAnH]
	@TOUR_ID		NVARCHAR(10)
AS
BEGIN
	DELETE [dbo].[HINHANHTOUR]
	WHERE [TOUR_ID] = @TOUR_ID
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_XoaChiTietTour]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_XoaChiTietTour]
(
    @idTour NVARCHAR(10),
    @idDichVu NVARCHAR(10)
)
AS
BEGIN
    -- Kiểm tra xem chi tiết tour tồn tại trong bảng CHITIETTOUR hay không
    IF EXISTS (SELECT 1 FROM CHITIETTOUR WHERE TOUR_ID = @idTour AND DV_ID = @idDichVu)
    BEGIN
        -- Xóa chi tiết tour khỏi bảng CHITIETTOUR
        DELETE CHITIETTOUR WHERE TOUR_ID = @idTour AND DV_ID = @idDichVu;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[Proc_XoaTaiKhoan]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_XoaTaiKhoan]
(
	@TK_TenDangNhap NVARCHAR(100),
    @NV_ID NVARCHAR(100)
)
AS
BEGIN
	IF @TK_TenDangNhap <> 'admin'
		DELETE TAIKHOAN WHERE TK_TenDangNhap = @TK_TenDangNhap AND NV_ID = @NV_ID
END;
GO
/****** Object:  StoredProcedure [dbo].[PROC_XoaVE]    Script Date: 2024-04-13 09:54:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_XoaVE]
	@idVe NVARCHAR(100),
	@idNV NVARCHAR(100),
	@idTour NVARCHAR(100),
	@idKH NVARCHAR(100),
	@soluongtra int
AS
BEGIN
	--Xóa vé
	DELETE [dbo].[VE]
	WHERE [VE_ID] = @idVe 
	AND [NV_ID] = @idNV
	AND [TOUR_ID] = @idTour
	AND [KH_ID] = @idKH

	--trả số lượng vé lại
	UPDATE TOUR
	SET TOUR_TongSoVeTour = TOUR_TongSoVeTour + @soluongtra
	WHERE TOUR_ID = @idTour

	--Xóa khách hàng 
    EXEC Proc_KH_Xoa @idKH
END
GO
USE [master]
GO
ALTER DATABASE [QUANLYDULICH] SET  READ_WRITE 
GO
