USE [DINHQUOCDAT_2210900139]
GO
/****** Object:  Table [dbo].[Dqd_Sach]    Script Date: 7/11/2024 3:37:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dqd_Sach](
	[Dqd_MaSach] [char](5) NOT NULL,
	[Dqd_TenSach] [nvarchar](50) NULL,
	[Dqd_SoTrang] [nvarchar](50) NULL,
	[Dqd_NamXB] [nvarchar](50) NOT NULL,
	[Dqd_MaTG] [nvarchar](50) NULL,
	[Dqd_TrangThai] [bit] NULL,
 CONSTRAINT [PK_Dqd_Sach] PRIMARY KEY CLUSTERED 
(
	[Dqd_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dqd_TacGia]    Script Date: 7/11/2024 3:37:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dqd_TacGia](
	[Dqd_MaTG] [char](5) NOT NULL,
	[Dqd_TenTacGia] [varchar](50) NULL,
 CONSTRAINT [PK_Dqd_TacGia] PRIMARY KEY CLUSTERED 
(
	[Dqd_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Dqd_Sach] ([Dqd_MaSach], [Dqd_TenSach], [Dqd_SoTrang], [Dqd_NamXB], [Dqd_MaTG], [Dqd_TrangThai]) VALUES (N'T01  ', N'Cổ Tích', N'100', N'1998', N'2210900139', 1)
INSERT [dbo].[Dqd_Sach] ([Dqd_MaSach], [Dqd_TenSach], [Dqd_SoTrang], [Dqd_NamXB], [Dqd_MaTG], [Dqd_TrangThai]) VALUES (N'T02  ', N'Tiếu Lâm', N'200', N'1980', N'2210900111', 1)
GO
INSERT [dbo].[Dqd_TacGia] ([Dqd_MaTG], [Dqd_TenTacGia]) VALUES (N'G01  ', N'dinh quoc dat')
INSERT [dbo].[Dqd_TacGia] ([Dqd_MaTG], [Dqd_TenTacGia]) VALUES (N'G02  ', N'Tr?n Tr?ng Bình')
GO
