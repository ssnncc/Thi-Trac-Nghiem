USE [TRACNGHIEM]
GO
/****** Object:  Table [dbo].[CAUHOI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CAUHOI](
	[MACH] [nchar](8) NOT NULL,
	[NOIDUNG] [ntext] NOT NULL,
	[LOAICH] [nchar](3) NULL,
	[DAPAN] [char](1) NOT NULL,
	[MAMH] [nchar](8) NULL,
	[MATD] [nchar](8) NULL,
	[MAGV] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_A949BE9F92F1425F9DE9B367B92B9319]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CAUHOI] PRIMARY KEY CLUSTERED 
(
	[MACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COSO]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COSO](
	[MACS] [nchar](8) NOT NULL,
	[TENCS] [nvarchar](50) NOT NULL,
	[DIACHI] [nvarchar](80) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_B96FEE858B4A423C8B81B8A58283CB8E]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_COSO] PRIMARY KEY CLUSTERED 
(
	[MACS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTBAITHI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTBAITHI](
	[IDTHI] [int] NOT NULL,
	[IDLBT] [int] NOT NULL,
	[DACHON] [char](1) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_95239B04BA5A40F4AB0E1E4E901E9B64]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CTBAITHI] PRIMARY KEY CLUSTERED 
(
	[IDTHI] ASC,
	[IDLBT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANGKY]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGKY](
	[MAMH] [nchar](8) NOT NULL,
	[MALOP] [nchar](8) NOT NULL,
	[NGAYTHI] [datetime] NOT NULL,
	[MANV] [nchar](8) NULL,
	[TRINHDO] [nvarchar](20) NOT NULL,
	[THOIGIAN] [int] NOT NULL,
	[SOCAU] [int] NULL,
	[IDDK] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_569B835A2D074025BB5EC53B0EB85673]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_DANGKY] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC,
	[MALOP] ASC,
	[NGAYTHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [nchar](8) NOT NULL,
	[HO] [nvarchar](20) NOT NULL,
	[TEN] [nvarchar](20) NOT NULL,
	[DIACHI] [nvarchar](80) NULL,
	[MAKH] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_B28EBE6E5EFA46079D1224534D35F304]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GV_DAY]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GV_DAY](
	[MAMH] [nchar](8) NOT NULL,
	[MALOP] [nchar](8) NOT NULL,
	[MAGV] [nchar](8) NULL,
	[SOTIET] [int] NULL,
	[NGAYBD] [datetime] NULL,
	[NGAYKT] [datetime] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_9E155B6B8ADD44078B98D3B9D634F2DA]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_GV_DAY] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC,
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKH] [nchar](8) NOT NULL,
	[TENKH] [nvarchar](50) NOT NULL,
	[MACS] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_35AC67D2597C452AA5B6A5F8D57C0E9B]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LAYBAITHI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAYBAITHI](
	[IDDK] [int] NOT NULL,
	[MACH] [nchar](8) NOT NULL,
	[IDLBT] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_6B6D5CCF96AD4691A27AB77FCFC55E47]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LAYBAITHI] PRIMARY KEY CLUSTERED 
(
	[IDDK] ASC,
	[MACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOPHOC]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPHOC](
	[MALOP] [nchar](8) NOT NULL,
	[TENLOP] [nvarchar](40) NULL,
	[MAKH] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_E73BE9CE073842D3AD82DB8CA87E3750]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LOPHOC] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LUACHON]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LUACHON](
	[MALC] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[TENLC] [char](1) NULL,
	[MACH] [nchar](8) NULL,
	[NOIDUNG] [ntext] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_97F95ED1C0C4444BAF36F9A67337A091]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LUACHON] PRIMARY KEY CLUSTERED 
(
	[MALC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [nchar](8) NOT NULL,
	[TENMH] [nvarchar](40) NOT NULL,
	[MAKH] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_068E46B07A8E42D59B201AD1A866BEC6]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIENPGV]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIENPGV](
	[MANV] [nchar](8) NOT NULL,
	[HO] [nvarchar](20) NOT NULL,
	[TEN] [nvarchar](20) NOT NULL,
	[DIACHI] [nvarchar](80) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_3E50445F7161402692C89633334DFD5B]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_NHANVIENPGV] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nchar](8) NOT NULL,
	[HO] [nvarchar](20) NOT NULL,
	[TEN] [nvarchar](20) NOT NULL,
	[GIOITINH] [bit] NULL,
	[NGAYSINH] [datetime] NULL,
	[NOISINH] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](80) NULL,
	[MALOP] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_E512914848E24208A812C912C06BA02B]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THI](
	[MASV] [nchar](8) NOT NULL,
	[IDDK] [int] NOT NULL,
	[DIEM] [float] NULL,
	[IDTHI] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_7118E22B64944D948879B5EA967C8485]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_THI] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[IDDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRINHDO]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRINHDO](
	[MATD] [nchar](8) NOT NULL,
	[TENTD] [nvarchar](20) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_82585333E1F14E7AAEEDDB02C8D021C1]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_TRINHDO] PRIMARY KEY CLUSTERED 
(
	[MATD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT PUBS.description AS TENCN, SUBS.subscriber_server AS TENSERVER
FROM   dbo.sysmergepublications AS PUBS INNER JOIN
          dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server

GO
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A1      ', N'Phương pháp tìm đường có tính đến thời gian trễ', N'LC ', N'D', N'MMT     ', N'DHCQ    ', N'GV01    ', N'12173c92-e228-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A10     ', N'Luật 5-4-3 cho phép tối đa', N'LC ', N'A', N'MMT     ', N'DHCQ    ', N'GV01    ', N'6bd9c29c-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A11     ', N'Thiết bị nào có thể thêm vào mạng LAN mà không sợ vi phạm luật 5-4-3', N'LC ', N'A', N'MMT     ', N'DHCQ    ', N'GV01    ', N'a71392a6-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A12     ', N'Thêm thiết bị nào vào mạng có thể qui phạm luật 5-4-3', N'LC ', N'B', N'MMT     ', N'DHCQ    ', N'GV01    ', N'713712ad-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A13     ', N'Mạng nào cóxảy ra xung đột (collision) trên đường truyền', N'LC ', N'A', N'MMT     ', N'DHCQ    ', N'GV01    ', N'd64b8bba-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A14     ', N'Từ "Broad" trong tên cáp 10Broad36 viết tắt bởi', N'LC ', N'c', N'MMT     ', N'DHCQ    ', N'GV01    ', N'554fcbc7-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A15     ', N'Protocol nào sử dụng trong cấp Network', N'LC ', N'A', N'MMT     ', N'DHCQ    ', N'GV01    ', N'923f31d0-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A2      ', N'Chuẩn mạng nào khi có dữ liệu không truyền ngay mà chờ 1 thời gian ngẫu nhiên?', N'LC ', N'C', N'MMT     ', N'DHCQ    ', N'GV01    ', N'7c43c6a3-e228-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A3      ', N'Phương pháp chèn bit (bit stuffing) được dùng để', N'LC ', N'A', N'MMT     ', N'DHCQ    ', N'GV01    ', N'4cd93eb3-e228-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A4      ', N'Để chống nhiễu trên đường truyền tốt nhất, nên dùng loại cáp:', N'LC ', N'C', N'MMT     ', N'DHCQ    ', N'GV01    ', N'ee2dcac3-e228-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A5      ', N'Phần mềm gửi/nhận thư điện tử thuộc cấp nào trong mô hình OSI', N'LC ', N'C', N'MMT     ', N'DHCQ    ', N'GV01    ', N'a14b0b69-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A6      ', N'Chức năng của thiết bị Hub trong mạng LAN', N'LC ', N'C', N'MMT     ', N'DHCQ    ', N'GV01    ', N'3dea5471-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A7      ', N'Switch là thiết bị mạng làm việc tương tự như', N'LC ', N'D', N'MMT     ', N'DHCQ    ', N'GV01    ', N'91ac837b-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A8      ', N'Thiết bị nào làm việc trong cấp Network', N'LC ', N'C', N'MMT     ', N'DHCQ    ', N'GV01    ', N'8dd82988-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'A9      ', N'Thiết bị nào cần có bộ nhớ làm buffer', N'LC ', N'D', N'MMT     ', N'DHCQ    ', N'GV01    ', N'8e5d2f90-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'B1      ', N'Đây là câu mới thêm', N'LC ', N'A', N'LTW     ', N'DHCQ    ', N'GV03    ', N'b294f1c8-6e42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C1      ', N'Mô hình cơ sở dữ liệu phân cấp là?', N'LC ', N'D', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'2b151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C10     ', N'Mục tiêu của CSDL là', N'LC ', N'B', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'52e11614-f627-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C11     ', N'Ràng buộc giải thích', N'LC ', N'B', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'408cbfa3-f627-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C12     ', N'Trong các phần mềm sau đây, phần mềm nào không phải là hệ quản trị CSDL quan hệ?', N'LC ', N'A', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'378d367a-f727-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C13     ', N'Đâu không phải là các bước xây dựng cơ sở dữ liệu?', N'LC ', N'D', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'6997f2d2-f727-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C14     ', N'SQL là tên viết tắt của:', N'LC ', N'A', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'd644851f-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C15     ', N'Đặc trưng cấu trúc mô hình mạng', N'LC ', N'A', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'67fc3792-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C2      ', N'Trong mô hình cơ sở dữ liệu quan hệ', N'LC ', N'B', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'2c151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C3      ', N'Thực thể là', N'LC ', N'A', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'2d151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C4      ', N'Đâu là trường khóa chính', N'LC ', N'A', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'4df8ac02-4513-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C5      ', N'Tiêu chí nào được chọn làm khóa chính', N'LC ', N'A', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'896ee3b7-4613-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C6      ', N'Liên kết giữa các bảng được dựa trên', N'LC ', N'C', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'c1edcde5-4613-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C7      ', N'Khăng định nào sau đây về CSDL là đúng', N'LC ', N'D', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'970fc5f6-4713-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C8      ', N'Với 1 bảng dữ liệu, hệ QTCSDL cho phép', N'LC ', N'D', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'88179b76-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'C9      ', N'Ngôn ngữ thao tác dữ liệu quan hệ', N'LC ', N'B', N'CSDL1   ', N'DHCQ    ', N'GV05    ', N'e88d20f7-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [LOAICH], [DAPAN], [MAMH], [MATD], [MAGV], [rowguid]) VALUES (N'CC2     ', N'Đáp án nào dưới đây là đúng?', N'LC ', N'A', N'LTW     ', N'VB2     ', N'GV03    ', N'fa4716d7-683d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[COSO] ([MACS], [TENCS], [DIACHI], [rowguid]) VALUES (N'CS01    ', N'Cơ sở 1', N'Hà Nội', N'fb141bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[COSO] ([MACS], [TENCS], [DIACHI], [rowguid]) VALUES (N'CS02    ', N'Cơ sở 2', N'TP HCM', N'fc141bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222088, N'A', N'1ba9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222089, N'B', N'1ca9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222090, N'C', N'1da9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222091, N'D', N'1ea9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222092, N'A', N'1fa9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222093, N'A', N'20a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222094, N'D', N'21a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222095, N'B', N'22a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222096, N'D', N'23a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222097, N'D', N'24a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222098, N'A', N'25a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222099, N'D', N'26a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222100, N'A', N'27a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222101, N'B', N'28a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222011, 222102, N'B', N'29a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222116, N'B', N'08f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222117, N'D', N'09f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222118, N'D', N'0af60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222119, N'C', N'0bf60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222120, N'A', N'0cf60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222121, N'B', N'0df60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222122, N'D', N'0ef60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222123, N'B', N'0ff60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222124, N'B', N'10f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222014, 222125, N'C', N'11f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222088, N'A', N'5b2a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222089, N' ', N'5e2a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222090, N'C', N'582a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222091, N'D', N'5d2a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222092, N'A', N'592a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222093, N' ', N'5f2a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222094, N' ', N'602a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222095, N'A', N'552a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222096, N'B', N'572a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222097, N' ', N'612a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222098, N'A', N'562a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222099, N' ', N'622a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222100, N' ', N'632a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222101, N'B', N'5a2a7273-3743-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[CTBAITHI] ([IDTHI], [IDLBT], [DACHON], [rowguid]) VALUES (222016, 222102, N'B', N'5c2a7273-3743-eb11-be50-982cbcfa2d6d')
SET IDENTITY_INSERT [dbo].[DANGKY] ON 

INSERT [dbo].[DANGKY] ([MAMH], [MALOP], [NGAYTHI], [MANV], [TRINHDO], [THOIGIAN], [SOCAU], [IDDK], [rowguid]) VALUES (N'CSDL1   ', N'D16CN1B ', CAST(N'2020-11-12 00:00:00.000' AS DateTime), N'NV01    ', N'DHCQ', 2, 15, 1, N'70d0af3e-b220-eb11-be4a-982cbcfa2d6d')
INSERT [dbo].[DANGKY] ([MAMH], [MALOP], [NGAYTHI], [MANV], [TRINHDO], [THOIGIAN], [SOCAU], [IDDK], [rowguid]) VALUES (N'CSDL1   ', N'D16CN1N ', CAST(N'2020-11-20 00:00:00.000' AS DateTime), N'NV01    ', N'DHCQ', 15, 15, 5, N'9d2072e8-d221-eb11-be4a-982cbcfa2d6d')
INSERT [dbo].[DANGKY] ([MAMH], [MALOP], [NGAYTHI], [MANV], [TRINHDO], [THOIGIAN], [SOCAU], [IDDK], [rowguid]) VALUES (N'MMT     ', N'D16CN1B ', CAST(N'2020-12-22 00:00:00.000' AS DateTime), N'NV01    ', N'DHCQ', 5, 10, 6, N'2f40bf81-d225-eb11-be4c-982cbcfa2d6d')
SET IDENTITY_INSERT [dbo].[DANGKY] OFF
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV01    ', N'Nguyễn Hồng', N'Sơn', N'Tp HCM', N'CNTT1   ', N'06151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV02    ', N'Trương Đình', N'Huy', N'Tp HCM', N'CNTT1   ', N'07151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV03    ', N'Nguyễn Xuân', N'Khanh', N'TP HCM', N'VT1     ', N'08151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV04    ', N'Trần Đình', N'Thuận', N'TP HCM', N'VT1     ', N'09151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV05    ', N'Huỳnh Trung', N'Trụ', N'Hà Nội', N'CNTT1   ', N'0a151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV06    ', N'Nguyễn Anh ', N'Hào', N'Hà Nội', N'CNTT2   ', N'0b151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV07    ', N'Nguyễn Ngọc', N'Duy', N'Hà Nội', N'VT2     ', N'0c151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV08    ', N'Nguyễn Văn', N'Sáu', N'Hà Nội ', N'VT2     ', N'0d151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV09    ', N'Trần Văn', N'Bình', N'Hà Nội', N'CNTT2   ', N'3f9ffedf-9219-eb11-be4a-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV10    ', N'Nguyễn Văn ', N'A', N'Tp HCM', N'CNTT1   ', N'df8d5a55-c53a-eb11-be4e-982cbcfa2d6d')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'GV11    ', N'Nguyễn Văn', N'Bình', N'Tp HCM', N'VT1     ', N'c3798662-c53a-eb11-be4e-982cbcfa2d6d')
INSERT [dbo].[GV_DAY] ([MAMH], [MALOP], [MAGV], [SOTIET], [NGAYBD], [NGAYKT], [rowguid]) VALUES (N'CSDL1   ', N'D16CN1B ', N'GV05    ', 30, CAST(N'2020-08-20 00:00:00.000' AS DateTime), CAST(N'2020-11-20 00:00:00.000' AS DateTime), N'2e151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GV_DAY] ([MAMH], [MALOP], [MAGV], [SOTIET], [NGAYBD], [NGAYKT], [rowguid]) VALUES (N'CSDL1   ', N'D16CN1N ', N'GV01    ', 30, CAST(N'2020-08-20 00:00:00.000' AS DateTime), CAST(N'2020-11-20 00:00:00.000' AS DateTime), N'2f151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GV_DAY] ([MAMH], [MALOP], [MAGV], [SOTIET], [NGAYBD], [NGAYKT], [rowguid]) VALUES (N'QLMVT1  ', N'D16VT1B ', N'GV07    ', 30, CAST(N'2020-08-20 00:00:00.000' AS DateTime), CAST(N'2020-11-20 00:00:00.000' AS DateTime), N'30151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[GV_DAY] ([MAMH], [MALOP], [MAGV], [SOTIET], [NGAYBD], [NGAYKT], [rowguid]) VALUES (N'QLMVT2  ', N'D16VT1N ', N'GV03    ', 30, CAST(N'2020-08-20 00:00:00.000' AS DateTime), CAST(N'2020-11-20 00:00:00.000' AS DateTime), N'31151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'CNTT1   ', N'Công nghệ thông tin', N'CS01    ', N'02151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'CNTT2   ', N'Công nghệ thông tin', N'CS02    ', N'03151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'VT1     ', N'Viễn thông 1', N'CS01    ', N'04151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'VT2     ', N'Viễn thông', N'CS02    ', N'05151bb9-3f13-eb11-be49-982cbcfa2d6d')
SET IDENTITY_INSERT [dbo].[LAYBAITHI] ON 

INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C1      ', 222094, N'12a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C10     ', 222097, N'15a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C11     ', 222089, N'0da9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C12     ', 222100, N'18a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C13     ', 222091, N'0fa9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C14     ', 222098, N'16a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C15     ', 222101, N'19a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C2      ', 222095, N'13a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C3      ', 222092, N'10a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C4      ', 222093, N'11a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C5      ', 222088, N'0ca9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C6      ', 222090, N'0ea9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C7      ', 222096, N'14a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C8      ', 222099, N'17a9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (1, N'C9      ', 222102, N'1aa9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A1      ', 222119, N'01f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A10     ', 222125, N'07f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A11     ', 222117, N'fff50659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A12     ', 222122, N'04f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A2      ', 222121, N'03f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A3      ', 222124, N'06f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A5      ', 222123, N'05f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A6      ', 222120, N'02f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A7      ', 222118, N'00f60659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LAYBAITHI] ([IDDK], [MACH], [IDLBT], [rowguid]) VALUES (6, N'A8      ', 222116, N'fef50659-2a42-eb11-be50-982cbcfa2d6d')
SET IDENTITY_INSERT [dbo].[LAYBAITHI] OFF
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D15CN1B ', N'Đại học chính quy 1 CNTT khóa 2015', N'CNTT1   ', N'0f151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D15CN1N ', N'Đại học chính quy 1 CNTT khóa 2015', N'CNTT2   ', N'10151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D15VT1  ', N'Lớp viễn thống ', N'VT1     ', N'b3ddf0bc-9319-eb11-be4a-982cbcfa2d6d')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D16CN1B ', N'Đại học chính quy 1 CNTT khóa 2016', N'CNTT1   ', N'11151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D16CN1N ', N'Đại học chính quy 1 CNTT khóa 2016', N'CNTT2   ', N'12151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D16CN2B ', N'Đại học chính quy 2 CNTT khóa 2016', N'CNTT1   ', N'13151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D16VT1B ', N'Đại học chính quy 1 VT khóa 2016', N'VT1     ', N'14151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D16VT1N ', N'Đại học chính quy 1 VT khóa 2016', N'VT2     ', N'15151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LOPHOC] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'N16     ', N'Công nghệ', N'CNTT1   ', N'1e6e1fc2-083b-eb11-be4f-982cbcfa2d6d')
SET IDENTITY_INSERT [dbo].[LUACHON] ON 

INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (1, N'A', N'C1      ', N'Dữ liệu được biểu diễn bằng con trỏ', N'32151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (2, N'B', N'C1      ', N'Dữ liệu được biểu diễn bằng mối quan hệ thực thể', N'33151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (3, N'C', N'C1      ', N'Dữ liệu được biểu diễn bằng bảng', N'34151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (4, N'D', N'C1      ', N'Dữ liệu được biểu diễn bằng cấu trúc cây', N'35151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (5, N'A', N'C2      ', N'Thứ tự các cột là quan trọng', N'36151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (6, N'B', N'C2      ', N'Thứ tự các cột là không quan trọng', N'37151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (7, N'C', N'C2      ', N'Thứ tự các hàng là quan trọng', N'38151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (8, N'D', N'C2      ', N'Thứ tự các hàng là không quan trọng', N'39151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (9, N'A', N'C3      ', N'Các đối tượng dữ liệu', N'3a151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (10, N'B', N'C3      ', N'Các quan hệ', N'3b151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (11, N'C', N'C3      ', N'Các mối liên kết giữa các đối tượng', N'3c151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (12, N'D', N'C3      ', N'Các đối tượng và mối liên kết giữa các đối tượng', N'3d151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (13, N'A', N'C4      ', N'Primary key', N'becddf12-4513-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (14, N'B', N'C4      ', N'Unique key', N'2ef8ed2f-4513-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (15, N'C', N'C4      ', N'Single key', N'd131c845-4513-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (16, N'D', N'C4      ', N'First key', N'3b059a4f-4513-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (17, N'A', N'C5      ', N'Khóa có ít thuộc tính nhất', N'f4aa07f4-4613-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (18, N'B', N'C5      ', N'Khóa bất kỳ', N'774c80fc-4613-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (19, N'C', N'C5      ', N'Khóa chứa thuộc tính thay đổi theo thời gian', N'3b63c80b-4713-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (20, N'D', N'C5      ', N'CHỉ là khóa có 1 thuộc tính', N'40e35e1d-4713-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (21, N'A', N'C6      ', N'Thuộc tính tên trùng nhau giữa các bảng', N'b1bbe032-4713-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (22, N'B', N'C6      ', N'Ý định của người quản trị', N'c162153e-4713-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (23, N'C', N'C6      ', N'Thuộc tính khóa', N'69da1e48-4713-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (24, N'D', N'C6      ', N'Ý định ghép bảng thành nhiều thành phần', N'2314cc55-4713-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (25, N'A', N'C7      ', N'Tập hợp các bảng dữ liệu', N'a039f915-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (26, N'B', N'C7      ', N'Cơ sở dữ liệu mà các bảng quan hệ với nhau', N'adf4f12c-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (27, N'C', N'C7      ', N'Được tạo ra từ Access', N'77497341-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (28, N'D', N'C7      ', N'Được xây dựng trên mô hình dữ liệu quan hệ', N'd7461f50-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (29, N'A', N'C8      ', N'Xem nội dung bản ghi', N'6da70982-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (30, N'B', N'C8      ', N'Xem mối liên kết giữa các bảng', N'd04f6393-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (31, N'C', N'C8      ', N'Xem một số trường bản ghi', N'dab1839f-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (32, N'D', N'C8      ', N'Tất cả đều đúng', N'b7c06ea7-4813-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (33, N'A', N'C9      ', N'Phức tạp', N'a42c9a01-4913-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (34, N'B', N'C9      ', N'Đơn giản thuật tiện cho người dùng', N'ba678d0f-4913-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (35, N'C', N'C9      ', N'Không toàn vẹn', N'f9418718-4913-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (38, N'D', N'C9      ', N'Đơn giản nhưng không thuận tiện cho người dùng', N'87c11e02-d214-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (39, N'A', N'C11     ', N'Mối quan hệ giữa các thuộc tính được biểu diễn bằng phụ thuộc hàm', N'8f99b2d3-f627-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (41, N'B', N'C11     ', N'Mối quan hệ giữa các thuộc tính được biểu diễn bằng biểu thức toán học', N'3559cbf2-f627-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (42, N'C', N'C11     ', N'Các phép so sánh', N'afac5efa-f627-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (43, N'A', N'C12     ', N'Microsoft Excel ', N'4ae24990-f727-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (44, N'B', N'C12     ', N'Microsoft Access ', N'0a1366a9-f727-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (45, N'C', N'C12     ', N'Microsoft SQL server ', N'00803fb7-f727-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (46, N'A', N'C13     ', N'Thiết kế', N'9b85c5de-f727-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (47, N'B', N'C13     ', N'Khảo sát', N'9c85c5de-f727-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (48, N'C', N'C13     ', N'Chạy thử', N'1e52dde8-f727-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (49, N'D', N'C13     ', N'Ký hợp đồng', N'f81b1aef-f727-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (50, N'A', N'C14     ', N'Structure Query Language ', N'3e264127-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (51, N'B', N'C14     ', N'Query Structure Language ', N'a4c40c2f-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (52, N'C', N'C14     ', N'Structure Question Language ', N'ccc36e37-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (54, N'D', N'C14     ', N'Structure Query Locator

', N'b239ec3d-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (55, N'A', N'C15     ', N'Chứa liên kết một -một, một - nhiều', N'6096afae-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (56, N'B', N'C15     ', N'Chứa liên kết một -một, một -nhiều, nhiều - nhiều', N'10c481c5-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (57, N'C', N'C15     ', N'Chứa liên kết một -một', N'14f6bce1-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (58, N'D', N'C15     ', N'Chứa liên kết nhiều - nhiều', N'86eb35ea-f827-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (59, N'D', N'C11     ', N'Các liên kết', N'239ffe56-fa27-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (60, N'D', N'C12     ', N'Oracel', N'd6844664-fa27-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (61, N'A', N'A1      ', N'Tìm đường theo chiều sâu', N'46c48ed4-e228-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (62, N'B', N'A1      ', N'Tìm đường theo chiều sâu', N'c0bd34dc-e228-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (64, N'C', N'A1      ', N'Tìm đường theo vector khoảng cách', N'4e2b42e4-e228-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (65, N'D', N'A1      ', N'Tìm đường theo trạng thái đường truyền', N'dcfe52f6-e228-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (66, N'A', N'A2      ', N'1-presistent CSMA', N'217099fd-e228-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (67, N'B', N'A2      ', N'p-presistent CSMA', N'082c1e05-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (68, N'C', N'A2      ', N'Non-presistent CSMA', N'092c1e05-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (69, N'D', N'A2      ', N'CSMA/CD', N'62bdb40f-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (70, N'A', N'A3      ', N'Phân biệt đầu và cuối frame', N'63bdb40f-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (72, N'B', N'A3      ', N'Bổ sung cho đủ kích thước frame tối thiểu', N'c8c9dd1c-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (73, N'C', N'A3      ', N'Phân cách nhiều bit 0 bằng bit 1', N'2d6c0b23-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (74, N'D', N'A3      ', N'Biến đổi dạng dữ liệu 8 bit ra 16 bit', N'2e6c0b23-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (75, N'A', N'A4      ', N'Xoắn đôi', N'39f4762c-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (76, N'B', N'A4      ', N'Đồng trục', N'3af4762c-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (77, N'C', N'A4      ', N'Cáp quang', N'757f943a-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (78, N'D', N'A4      ', N'Mạng không dây', N'4aa1a640-e328-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (80, N'B', N'A5      ', N'Network', N'a722bb32-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (81, N'C', N'A5      ', N'Application', N'58538c3a-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (82, N'D', N'A5      ', N'Presentation', N'5aefe340-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (83, N'A', N'A6      ', N'Mã hóa tín hiệu', N'bd002247-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (84, N'B', N'A6      ', N'Triệt tiêu tín hiệu', N'8af35652-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (85, N'C', N'A6      ', N'Phân chia tín hiệu', N'65986358-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (86, N'D', N'A6      ', N'Điều chế tín hiếu', N'66986358-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (87, N'A', N'A7      ', N'Hub', N'0d124063-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (88, N'B', N'A7      ', N'Repeater', N'704e636c-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (89, N'C', N'A7      ', N'Router', N'3552c772-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (90, N'D', N'A7      ', N'Bridge', N'e7cbc378-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (91, N'A', N'A8      ', N'Bridge', N'96808d82-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (92, N'B', N'A8      ', N'Repeater', N'7074a98b-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (93, N'C', N'A8      ', N'Router', N'7174a98b-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (94, N'D', N'A8      ', N'Gateway', N'385b9898-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (95, N'A', N'A9      ', N'Hub', N'395b9898-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (96, N'B', N'A9      ', N'Switch', N'db211da5-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (97, N'C', N'A9      ', N'Repeater', N'f9f1c3ad-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (98, N'D', N'A9      ', N'Router', N'faf1c3ad-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (99, N'A', N'A10     ', N'5 segment trong 1 mạng', N'4ace23bb-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (100, N'B', N'A10     ', N'5 repeater trong 1 mạng', N'ab84c1c1-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (101, N'C', N'A10     ', N'5 máy tính trong 1 mạng', N'ac84c1c1-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (102, N'D', N'A10     ', N'5 máy tính trong 1 segment', N'5a73e4cd-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (103, N'A', N'A11     ', N'Router', N'3dffe7d5-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (104, N'B', N'A11     ', N'Repeater', N'e7ba07e2-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (105, N'C', N'A11     ', N'Máy tính', N'b630e7eb-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (106, N'D', N'A11     ', N'Tất cả đều đúng', N'b730e7eb-e428-eb11-be4c-982cbcfa2d6d')
GO
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (107, N'A', N'A12     ', N'Ethenet', N'25964ffe-e428-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (108, N'B', N'A12     ', N'Token-ring', N'3a15a907-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (109, N'C', N'A12     ', N'Token-bus', N'9b069e24-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (110, N'D', N'A12     ', N'Tất cả đều sai', N'c6f8832d-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (112, N'A', N'A13     ', N'Broadcast', N'8e82023d-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (113, N'B', N'A13     ', N'Broadbase', N'acffc545-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (114, N'C', N'A13     ', N'Broadband', N'46141a4f-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (115, N'D', N'A13     ', N'Broadway', N'11347557-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (116, N'A', N'A14     ', N'IP', N'cd8d216d-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (117, N'B', N'A14     ', N'TCP', N'5bb22776-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (119, N'C', N'A14     ', N'UDP', N'2612a67e-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (120, N'D', N'A14     ', N'FTP', N'2712a67e-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (121, N'A', N'A15     ', N'IP', N'2ac3808c-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (122, N'B', N'A15     ', N'TCP', N'2bc3808c-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (123, N'C', N'A15     ', N'UDP', N'1c010d97-e528-eb11-be4c-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (124, N'D', N'A15     ', N'TCP và UDF', N'82fae27c-733d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (125, N'A', N'C10     ', N'Không làm thay đổi chiến lược truy cập dữ liệu', N'f2afa89a-733d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (126, N'B', N'C10     ', N'Đảm bảo tính độc lập dữ liệu', N'b61cd9a1-733d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (127, N'C', N'C10     ', N'Dữ liệu chỉ được biểu diễn, mô tả 1 cách duy nhất', N'33d6b7ad-733d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (128, N'D', N'C10     ', N'Không làm thay đổi cấu trúc lưu trữ dữ liệu', N'34d6b7ad-733d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (129, N'A', N'CC2     ', N'<b>Click Here<b>', N'eb5edbc9-733d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (130, N'B', N'CC2     ', N'<strong>Click Here<strong>', N'f59557d1-733d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (131, N'C', N'CC2     ', N'<b>Click Here</b>', N'f69557d1-733d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (132, N'D', N'CC2     ', N'</strong>Click Here</strong>', N'1485abe5-733d-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (222013, N'A', N'A5      ', N'TCP and UDP', N'23ec1767-863d-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (222014, N'A', N'B1      ', N'Đáp án A', N'066beadc-6e42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[LUACHON] ([MALC], [TENLC], [MACH], [NOIDUNG], [rowguid]) VALUES (222015, N'B', N'B1      ', N'Đáp án B', N'076beadc-6e42-eb11-be50-982cbcfa2d6d')
SET IDENTITY_INSERT [dbo].[LUACHON] OFF
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [MAKH], [rowguid]) VALUES (N'CSDL1   ', N'Cơ sở dữ liệu ', N'CNTT1   ', N'16151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [MAKH], [rowguid]) VALUES (N'CTDLGT  ', N'Cấu trúc dữ liệu và giải thuật ', N'CNTT2   ', N'19151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [MAKH], [rowguid]) VALUES (N'LTW     ', N'Lập trình web', N'CNTT1   ', N'1a151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [MAKH], [rowguid]) VALUES (N'MMT     ', N'Mạng máy tính', N'CNTT1   ', N'29a40503-9419-eb11-be4a-982cbcfa2d6d')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [MAKH], [rowguid]) VALUES (N'QLMVT1  ', N'Quản lý mạng viễn thông', N'VT1     ', N'1c151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [MAKH], [rowguid]) VALUES (N'QLMVT2  ', N'Quản lý mạng viễn thông', N'VT2     ', N'1d151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [MAKH], [rowguid]) VALUES (N'TPVT    ', N'Thu phát vô tuyến', N'VT2     ', N'1f151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[NHANVIENPGV] ([MANV], [HO], [TEN], [DIACHI], [rowguid]) VALUES (N'NV01    ', N'NGUYỄN HỒNG', N'SƠN', N'HÀ NỘI', N'fd141bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[NHANVIENPGV] ([MANV], [HO], [TEN], [DIACHI], [rowguid]) VALUES (N'NV02    ', N'HUỲNH TRUNG', N'TRỤ', N'TP HCM', N'fe141bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[NHANVIENPGV] ([MANV], [HO], [TEN], [DIACHI], [rowguid]) VALUES (N'NV03    ', N'NGUYỄN ANH', N'HÀO', N'TP HCM', N'c66ac2bb-4413-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'cn3     ', N'VU VU', N'VU', 0, CAST(N'1998-09-08 00:00:00.000' AS DateTime), N'fff', N'ffff', N'D16VT1N ', N'288c9bef-b220-eb11-be4a-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N1501   ', N'Trần Phương', N'Nam', NULL, CAST(N'1998-12-11 00:00:00.000' AS DateTime), N'HN', N'HN', N'D15CN1B ', N'c27c3386-0b3b-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N1502   ', N'Lê Vũ ', N'Trần Bò', 1, CAST(N'1998-10-09 00:00:00.000' AS DateTime), N'Tp HCM', N'TPHCM', N'D15CN1B ', N'e653e0aa-ca19-eb11-be4a-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N1503   ', N'Lê Hoài', N'Vũ', NULL, CAST(N'1998-12-22 00:00:00.000' AS DateTime), N'Dak Lak', N'Dak Lak', N'D15CN1B ', N'cf0b1e27-0c3b-eb11-be4f-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N1504   ', N'Trần Hoài ', N'Nam', NULL, CAST(N'1998-11-11 00:00:00.000' AS DateTime), N'HCM', N'HCM', N'D15CN1B ', N'085cbc4a-ca3f-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16CN01B', N'Trần Văn', N'Anh ', 1, CAST(N'1998-12-20 00:00:00.000' AS DateTime), N'Hà Nội', N'Hà Nội', N'D16CN1B ', N'20151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16CN01N', N'Lên Văn', N'Thanh', 1, CAST(N'1998-04-22 00:00:00.000' AS DateTime), N'Nghệ An', N'TP HCM', N'D16CN1N ', N'21151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16CN02B', N'Trần Văn', N'Bình', 1, CAST(N'1998-02-13 00:00:00.000' AS DateTime), N'Hà Nội', N'Hà Nội', N'D16CN1B ', N'22151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16CN02N', N'Trần Đông', N'A', 1, CAST(N'1998-02-12 00:00:00.000' AS DateTime), N'Đăk Lăk', N'Tp HCM', N'D16CN1N ', N'23151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16CN03B', N'Nguyễn Thanh', N'An', 0, CAST(N'1998-05-03 00:00:00.000' AS DateTime), N'Thái Bình', N'Thái Bình', N'D16CN1B ', N'24151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16CN03N', N'Nguyễn Ngọc', N'Anh', 0, CAST(N'1998-04-02 00:00:00.000' AS DateTime), N'TP HCM', N'TP HCM', N'D16CN1N ', N'25151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16VT01B', N'Nguyễn Văn', N'Thanh', 1, CAST(N'1997-06-20 00:00:00.000' AS DateTime), N'TP HCM', N'Hà Nội', N'D16VT1B ', N'26151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16VT01N', N'Trần Đức', N'Bình', 1, CAST(N'1998-05-10 00:00:00.000' AS DateTime), N'Bình Dương', N'TP HCM', N'D16VT1N ', N'27151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16VT02B', N'Trần Hoài', N'Hoài', 1, CAST(N'1997-07-03 00:00:00.000' AS DateTime), N'Nghệ An', N'Hà Nội', N'D16VT1B ', N'28151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16VT02N', N'Nguyễn Anh', N'Anh', 1, CAST(N'1998-07-04 00:00:00.000' AS DateTime), N'Đồng Nai', N'Đồng Nai', N'D16VT1N ', N'29151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N16VT03N', N'Lên Thanh', N'Thanh', 0, CAST(N'1998-01-04 00:00:00.000' AS DateTime), N'TP HCM', N'Bình Dương', N'D16VT1N ', N'2a151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [GIOITINH], [NGAYSINH], [NOISINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'SV01    ', N'Lê Vũ Trần', N'Bò', 1, CAST(N'1998-08-12 00:00:00.000' AS DateTime), N'TpHCM', N'TPHCM', N'N16     ', N'cfd42995-e43e-eb11-be50-982cbcfa2d6d')
SET IDENTITY_INSERT [dbo].[THI] ON 

INSERT [dbo].[THI] ([MASV], [IDDK], [DIEM], [IDTHI], [rowguid]) VALUES (N'N16CN01B', 1, 8.6700000762939453, 222011, N'0ba9ada1-2942-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[THI] ([MASV], [IDDK], [DIEM], [IDTHI], [rowguid]) VALUES (N'N16CN01B', 6, 1, 222014, N'fdf50659-2a42-eb11-be50-982cbcfa2d6d')
INSERT [dbo].[THI] ([MASV], [IDDK], [DIEM], [IDTHI], [rowguid]) VALUES (N'N16CN02B', 1, 4, 222016, N'542a7273-3743-eb11-be50-982cbcfa2d6d')
SET IDENTITY_INSERT [dbo].[THI] OFF
INSERT [dbo].[TRINHDO] ([MATD], [TENTD], [rowguid]) VALUES (N'CDCQ    ', N'Cao đẳng chính quy', N'ff141bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[TRINHDO] ([MATD], [TENTD], [rowguid]) VALUES (N'DHCQ    ', N'Đại học chính quy', N'00151bb9-3f13-eb11-be49-982cbcfa2d6d')
INSERT [dbo].[TRINHDO] ([MATD], [TENTD], [rowguid]) VALUES (N'VB2     ', N'Văn bằng 2', N'01151bb9-3f13-eb11-be49-982cbcfa2d6d')
/****** Object:  Index [UK_IDDK]    Script Date: 20-Jan-21 10:43:42 AM ******/
ALTER TABLE [dbo].[DANGKY] ADD  CONSTRAINT [UK_IDDK] UNIQUE NONCLUSTERED 
(
	[IDDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UK_IDLBT]    Script Date: 20-Jan-21 10:43:42 AM ******/
ALTER TABLE [dbo].[LAYBAITHI] ADD  CONSTRAINT [UK_IDLBT] UNIQUE NONCLUSTERED 
(
	[IDLBT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UK_IDTHI]    Script Date: 20-Jan-21 10:43:42 AM ******/
ALTER TABLE [dbo].[THI] ADD  CONSTRAINT [UK_IDTHI] UNIQUE NONCLUSTERED 
(
	[IDTHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CAUHOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUHOI_GIANGVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[CAUHOI] CHECK CONSTRAINT [FK_CAUHOI_GIANGVIEN]
GO
ALTER TABLE [dbo].[CAUHOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUHOI_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CAUHOI] CHECK CONSTRAINT [FK_CAUHOI_MONHOC]
GO
ALTER TABLE [dbo].[CAUHOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUHOI_TRINHDO] FOREIGN KEY([MATD])
REFERENCES [dbo].[TRINHDO] ([MATD])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CAUHOI] CHECK CONSTRAINT [FK_CAUHOI_TRINHDO]
GO
ALTER TABLE [dbo].[CTBAITHI]  WITH CHECK ADD  CONSTRAINT [FK_CTBAITHI_LAYBAITHI] FOREIGN KEY([IDLBT])
REFERENCES [dbo].[LAYBAITHI] ([IDLBT])
GO
ALTER TABLE [dbo].[CTBAITHI] CHECK CONSTRAINT [FK_CTBAITHI_LAYBAITHI]
GO
ALTER TABLE [dbo].[CTBAITHI]  WITH CHECK ADD  CONSTRAINT [FK_CTBAITHI_THI] FOREIGN KEY([IDTHI])
REFERENCES [dbo].[THI] ([IDTHI])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTBAITHI] CHECK CONSTRAINT [FK_CTBAITHI_THI]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_DANGKY_LOPHOC] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOPHOC] ([MALOP])
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [FK_DANGKY_LOPHOC]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_DANGKY_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [FK_DANGKY_MONHOC]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_DANGKY_NHANVIENPGV] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIENPGV] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [FK_DANGKY_NHANVIENPGV]
GO
ALTER TABLE [dbo].[GIANGVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIANGVIEN_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GIANGVIEN] CHECK CONSTRAINT [FK_GIANGVIEN_KHOA]
GO
ALTER TABLE [dbo].[GV_DAY]  WITH CHECK ADD  CONSTRAINT [FK_GV_DAY_GIANGVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[GV_DAY] CHECK CONSTRAINT [FK_GV_DAY_GIANGVIEN]
GO
ALTER TABLE [dbo].[GV_DAY]  WITH CHECK ADD  CONSTRAINT [FK_GV_DAY_LOPHOC] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOPHOC] ([MALOP])
GO
ALTER TABLE [dbo].[GV_DAY] CHECK CONSTRAINT [FK_GV_DAY_LOPHOC]
GO
ALTER TABLE [dbo].[GV_DAY]  WITH CHECK ADD  CONSTRAINT [FK_GV_DAY_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GV_DAY] CHECK CONSTRAINT [FK_GV_DAY_MONHOC]
GO
ALTER TABLE [dbo].[KHOA]  WITH CHECK ADD  CONSTRAINT [FK_KHOA_COSO] FOREIGN KEY([MACS])
REFERENCES [dbo].[COSO] ([MACS])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KHOA] CHECK CONSTRAINT [FK_KHOA_COSO]
GO
ALTER TABLE [dbo].[LAYBAITHI]  WITH CHECK ADD  CONSTRAINT [FK_LAYBAITHI_CAUHOI] FOREIGN KEY([MACH])
REFERENCES [dbo].[CAUHOI] ([MACH])
GO
ALTER TABLE [dbo].[LAYBAITHI] CHECK CONSTRAINT [FK_LAYBAITHI_CAUHOI]
GO
ALTER TABLE [dbo].[LAYBAITHI]  WITH CHECK ADD  CONSTRAINT [FK_LAYBAITHI_DANGKY] FOREIGN KEY([IDDK])
REFERENCES [dbo].[DANGKY] ([IDDK])
GO
ALTER TABLE [dbo].[LAYBAITHI] CHECK CONSTRAINT [FK_LAYBAITHI_DANGKY]
GO
ALTER TABLE [dbo].[LOPHOC]  WITH CHECK ADD  CONSTRAINT [FK_LOPHOC_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOPHOC] CHECK CONSTRAINT [FK_LOPHOC_KHOA]
GO
ALTER TABLE [dbo].[LUACHON]  WITH CHECK ADD  CONSTRAINT [FK_LUACHON_CAUHOI] FOREIGN KEY([MACH])
REFERENCES [dbo].[CAUHOI] ([MACH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LUACHON] CHECK CONSTRAINT [FK_LUACHON_CAUHOI]
GO
ALTER TABLE [dbo].[MONHOC]  WITH CHECK ADD  CONSTRAINT [FK_MONHOC_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MONHOC] CHECK CONSTRAINT [FK_MONHOC_KHOA]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOPHOC] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOPHOC] ([MALOP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOPHOC]
GO
ALTER TABLE [dbo].[THI]  WITH CHECK ADD  CONSTRAINT [FK_THI_DANGKY] FOREIGN KEY([IDDK])
REFERENCES [dbo].[DANGKY] ([IDDK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[THI] CHECK CONSTRAINT [FK_THI_DANGKY]
GO
ALTER TABLE [dbo].[THI]  WITH CHECK ADD  CONSTRAINT [FK_THI_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[THI] CHECK CONSTRAINT [FK_THI_SINHVIEN]
GO
ALTER TABLE [dbo].[DANGKY]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_5D9C03C4_C0E2_4399_B373_1FD9EBDE9262] CHECK NOT FOR REPLICATION (([IDDK]>=(1) AND [IDDK]<=(1001) OR [IDDK]>(1001) AND [IDDK]<=(2001)))
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [repl_identity_range_5D9C03C4_C0E2_4399_B373_1FD9EBDE9262]
GO
ALTER TABLE [dbo].[LAYBAITHI]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_4562FD4D_59EB_4692_BE5E_3D837C26CB7F] CHECK NOT FOR REPLICATION (([IDLBT]>=(1) AND [IDLBT]<=(1001) OR [IDLBT]>(1001) AND [IDLBT]<=(2001)))
GO
ALTER TABLE [dbo].[LAYBAITHI] CHECK CONSTRAINT [repl_identity_range_4562FD4D_59EB_4692_BE5E_3D837C26CB7F]
GO
ALTER TABLE [dbo].[LUACHON]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_70489548_07A6_4F3D_B00C_C42670F1099F] CHECK NOT FOR REPLICATION (([MALC]>(12) AND [MALC]<=(1012) OR [MALC]>(1012) AND [MALC]<=(2012)))
GO
ALTER TABLE [dbo].[LUACHON] CHECK CONSTRAINT [repl_identity_range_70489548_07A6_4F3D_B00C_C42670F1099F]
GO
ALTER TABLE [dbo].[THI]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_C4C9D3E1_E661_4927_B16D_37A7EB614D9D] CHECK NOT FOR REPLICATION (([IDTHI]>=(1) AND [IDTHI]<=(1001) OR [IDTHI]>(1001) AND [IDTHI]<=(2001)))
GO
ALTER TABLE [dbo].[THI] CHECK CONSTRAINT [repl_identity_range_C4C9D3E1_E661_4927_B16D_37A7EB614D9D]
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(40),
		@HOTEN NVARCHAR(40),
		@TENNHOM nVARCHAR(50),
		@LOAI NVARCHAR(20),
		@MALOP NCHAR(8),
		@TENLOP NVARCHAR(40)
-- LẤY ID USER
SELECT @TENUSER = NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
-- ĐẢM BẢO USER ID NOT NULL
if (@TENUSER IS NOT NULL) 
BEGIN

-- LẤY HỌ TÊN USER TỪ BẢNG GIẢNG VIÊN
SELECT @HOTEN   = HO + ' '+ TEN FROM GIANGVIEN  WHERE MAGV = @TENUSER
SET @LOAI = 'giangvien'
-- ĐẢM BẢO HỌ TÊN NOT NULL. NẾU MÀ NULL THÌ LOGIN ĐÓ SẼ LÀ SINH VIÊN
if (@HOTEN IS NULL)
	BEGIN 
		-- LẤY HỌ TÊN USER TỪ BẢNG SINH VIÊN
		SELECT TOP 1 @HOTEN   = HO + ' '+ TEN, @MALOP = MALOP FROM SINHVIEN  WHERE MASV = @TENUSER
		SELECT TOP 1 @TENLOP = TENLOP from LOPHOC where MALOP = @MALOP
		SET @LOAI = 'sinhvien'
	END

-- LẤY RA TÊN NHÓM VÀ TRẢ VỀ  result
 SELECT USERNAME = @TENUSER, 
	    HOTEN = @HOTEN,
	    TENNHOM = NAME,
		LOAI = @LOAI,
		MALOP = @MALOP,
		TENLOP = @TENLOP
        FROM sys.sysusers 
        WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME = @TENUSER))
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DEM_CAU_HOI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DEM_CAU_HOI]
	@MAMH nchar(8),
	@TRINHDO nchar(8)
	
AS
DECLARE @DEM  INT
BEGIN

	 SELECT @DEM = COUNT(*) FROM CAUHOI WHERE MAMH =@MAMH AND MATD =@TRINHDO
	 RETURN @DEM

END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_BANG_DIEM_THEO_LOP]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_BANG_DIEM_THEO_LOP]
	-- Add the parameters for the stored procedure here
	@MALOP nchar(8),
	@MAMH nchar(8)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT THI.MASV ,
	HOTEN=SINHVIEN.HO+' ' +SINHVIEN.TEN,
	DIEM
	
	 FROM THI 
	 INNER JOIN SINHVIEN ON SINHVIEN.MASV = THI.MASV 
	 WHERE THI.MASV IN (SELECT MASV  FROM SINHVIEN WHERE SINHVIEN.MALOP=@MALOP)
	 AND @MAMH = (select MAMH  from DANGKY where IDDK = THI.IDDK )  

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_CHI_TIET_BAI_THI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_CHI_TIET_BAI_THI]
@IDTHI int
AS
BEGIN
SET NOCOUNT ON;
 SELECT LBT.MACH , CH.NOIDUNG, CH.DAPAN, CTBT.DACHON 
 FROM CTBAITHI CTBT LEFT JOIN LAYBAITHI LBT
		 ON CTBT.IDLBT = LBT.IDLBT LEFT JOIN CAUHOI CH
		 ON LBT.MACH = CH.MACH
		WHERE IDTHI = @IDTHI
	
ORDER BY (LBT.MACH)  ASC
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_DE_THI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_DE_THI]
	@MAMH nchar(8),
	@MaTD nchar(8),
	@SOCAUTHI INT
	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	if(@MATD = 'DHCQ' or @MATD = 'CDCQ' or @MATD = 'VB2')
	BEGIN
		SELECT TOP (@SOCAUTHI) * FROM CAUHOI WHERE MAMH =@MAMH  AND MATD =@MaTD ORDER BY NEWID() ;
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_DK_THI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_DK_THI]
	-- Add the parameters for the stored procedure here
	@MALOP nchar(8),
	@MAMH  nchar(8),
	@NGAYTHI datetime
	
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM DANGKY WHERE  MALOP=@MALOP AND MAMH=@MAMH  AND NGAYTHI=@NGAYTHI;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_LUA_CHON]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_LUA_CHON]
	@MACH nchar(8)

AS
BEGIN
	
	SET NOCOUNT ON;
	
	BEGIN
		SELECT NOIDUNG FROM LUACHON WHERE MACH = @MACH;
	END

	
	
END


GO
/****** Object:  StoredProcedure [dbo].[SP_GHI_CHI_TIET_BAI_THI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GHI_CHI_TIET_BAI_THI]
@IDTHI int,
@IDLBT int,
@DACHON char(1)

AS
BEGIN
	INSERT INTO CTBAITHI(IDTHI,IDLBT,DACHON)
    VALUES (@IDTHI,@IDLBT,@DACHON);
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GHIDIEM]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GHIDIEM]
@MASV char(8),
@IDDK smallint,
@DIEM float

AS
BEGIN
	INSERT INTO THI(MASV,IDDK,DIEM)
    VALUES (@MASV,@IDDK,@DIEM);
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEM_TRA_DANG_KY]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KIEM_TRA_DANG_KY]
 @MAMH nchar(8),
 @MALOP nchar (8),
 @NGAYTHI datetime
AS
BEGIN
--Tra ve 1: neu ton tai -> tra ve 0 neu ko ton tai
	IF EXISTS (SELECT * FROM DANGKY WHERE MAMH=@MAMH AND MALOP=@MALOP AND NGAYTHI=@NGAYTHI)
		RETURN 1;
	RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYBAITHI]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAYBAITHI]

@IDDK smallint,
@MACH char(8)

AS
BEGIN
if(@MACH not in (select MACH from LAYBAITHI where IDDK=@IDDK))
BEGIN
	INSERT INTO LAYBAITHI(IDDK,MACH)
    VALUES (@IDDK,@MACH);
	END
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS

	-- Kiểm tra login, user có bị trùng 
	IF EXISTS(SELECT name FROM sys.server_principals 
				WHERE TYPE IN ('U', 'S', 'G')	--U: Windows Login Accounts
				AND name NOT LIKE '%##%'		--S: SQL Login Accounts
				AND name = @LGNAME)				--G: Windows Group Login Accounts
		RETURN 1	--Nếu trùng Login
	ELSE IF EXISTS(SELECT name FROM sys.database_principals
					WHERE type_desc = 'SQL_USER'
					AND name = @USERNAME)
		RETURN 2	--Nếu trùng User

	-- băt đầu tạo tài khoản
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'TRACNGHIEM'
  IF (@RET =1) 
     RETURN 3 -- tạo tài khoản không thành công
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1) 
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 3 -- tạo  tài khoảng không thành công
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  --Thêm quyền SECURITYADMIN để có quyên tạo tài khoản
  EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'

  RETURN 0  -- Tạo tài khoản thành công
GO
/****** Object:  StoredProcedure [dbo].[SP_TIMBANGDIEM]    Script Date: 20-Jan-21 10:43:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[SP_TIMBANGDIEM]
	@MASV nchar(8),
	@MAMH nchar(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT THI.DIEM FROM THI WHERE MASV=@MASV and @MAMH = (
		select MAMH  from DANGKY where IDDK = THI.IDDK 
	)
END

GO
