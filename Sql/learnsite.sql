SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autonomic](
	[Aid] [int] IDENTITY(1,1) NOT NULL,
	[Asid] [int] NULL,
	[Anum] [nvarchar](50) NULL,
	[Aname] [nvarchar](50) NULL,
	[Ayid] [int] NULL,
	[Afid] [int] NULL,
	[Atype] [nvarchar](50) NULL,
	[Afilename] [nvarchar](50) NULL,
	[Aurl] [nvarchar](200) NULL,
	[Alength] [int] NULL,
	[Ascore] [int] NULL,
	[Adate] [datetime] NULL,
	[Aip] [nvarchar](50) NULL,
	[Avote] [int] NULL,
	[Aegg] [int] NULL,
	[Acheck] [bit] NULL,
	[Aself] [nvarchar](200) NULL,
	[Agood] [bit] NULL,
	[Ayear] [int] NULL,
	[Agrade] [int] NULL,
	[Aclass] [int] NULL,
	[Aterm] [int] NULL,
	[Ahit] [int] NULL,
	[Aoffice] [bit] NULL,
	[Aflash] [bit] NULL,
	[Aerror] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Aid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chinese]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chinese](
	[Nid] [int] IDENTITY(1,1) NOT NULL,
	[Ntitle] [nvarchar](50) NULL,
	[Ncontent] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[Nid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Computers]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Computers](
	[Pid] [int] IDENTITY(1,1) NOT NULL,
	[Pip] [nvarchar](50) NULL,
	[Pmachine] [nvarchar](50) NULL,
	[Plock] [bit] NULL,
	[Pdate] [datetime] NULL,
	[Px] [int] NULL,
	[Py] [int] NULL,
	[Pm] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Pid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Courses]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Cid] [int] IDENTITY(1,1) NOT NULL,
	[Ctitle] [nvarchar](50) NULL,
	[Cclass] [nvarchar](50) NULL,
	[Ccontent] [ntext] NULL,
	[Cdate] [datetime] NULL,
	[Chit] [int] NULL,
	[Cobj] [int] NULL,
	[Cterm] [int] NULL,
	[Cks] [int] NULL,
	[Cfiletype] [nvarchar](50) NULL,
	[Cupload] [bit] NULL,
	[Chid] [int] NULL,
	[Cpublish] [bit] NULL,
	[Cdelete] [bit] NULL,
	[Cgood] [bit] NULL,
	[Cold] [bit] NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Cid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DelStudents]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DelStudents](
	[Did] [int] IDENTITY(1,1) NOT NULL,
	[Dnum] [nvarchar](50) NULL,
	[Dyear] [int] NULL,
	[Dgrade] [int] NULL,
	[Dclass] [int] NULL,
	[Dname] [nvarchar](50) NULL,
	[Dsex] [nvarchar](2) NULL,
	[Daddress] [nvarchar](200) NULL,
	[Dphone] [nvarchar](50) NULL,
	[Dparents] [nvarchar](50) NULL,
	[Dheadtheacher] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Did] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[English]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[English](
	[Eid] [int] IDENTITY(1,1) NOT NULL,
	[Eword] [nvarchar](50) NULL,
	[Emeaning] [ntext] NULL,
	[Elevel] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Eid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Flection]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flection](
	[Fid] [int] IDENTITY(1,1) NOT NULL,
	[Fcid] [int] NULL,
	[Fhid] [int] NULL,
	[Fcontent] [ntext] NULL,
	[Fdate] [datetime] NULL,
 CONSTRAINT [PK_Flection] PRIMARY KEY CLUSTERED 
(
	[Fid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gauge]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gauge](
	[Gid] [int] IDENTITY(1,1) NOT NULL,
	[Ghid] [int] NULL,
	[Gtype] [nvarchar](50) NULL,
	[Gtitle] [nvarchar](50) NULL,
	[Gcount] [int] NULL,
	[Gdate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Gid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GaugeFeedback]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GaugeFeedback](
	[Fid] [int] IDENTITY(1,1) NOT NULL,
	[Fnum] [nvarchar](50) NULL,
	[Fgrade] [int] NULL,
	[Fclass] [int] NULL,
	[Fcid] [int] NULL,
	[Fmid] [int] NULL,
	[Fwid] [int] NULL,
	[Fgid] [int] NULL,
	[Fselect] [nvarchar](50) NULL,
	[Fscore] [int] NULL,
	[Fgood] [bit] NULL,
	[Fdate] [datetime] NULL,
	[Fsid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Fid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GaugeItem]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GaugeItem](
	[Mid] [int] IDENTITY(1,1) NOT NULL,
	[Mgid] [int] NULL,
	[Mitem] [nvarchar](50) NULL,
	[Mscore] [int] NULL,
	[Msort] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Mid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupWork]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupWork](
	[Gid] [int] IDENTITY(1,1) NOT NULL,
	[Gnum] [nvarchar](50) NULL,
	[Gstudents] [nvarchar](200) NULL,
	[Gterm] [int] NULL,
	[Ggrade] [int] NULL,
	[Gclass] [int] NULL,
	[Gcid] [int] NULL,
	[Gmid] [int] NULL,
	[Gfilename] [nvarchar](50) NULL,
	[Gtype] [nvarchar](50) NULL,
	[Gurl] [nvarchar](200) NULL,
	[Glengh] [int] NULL,
	[Gscore] [int] NULL,
	[Gtime] [int] NULL,
	[Gvote] [int] NULL,
	[Gcheck] [bit] NULL,
	[Gnote] [ntext] NULL,
	[Grank] [int] NULL,
	[Ghit] [int] NULL,
	[Gip] [nvarchar](50) NULL,
	[Gdate] [datetime] NULL,
	[Ggroup] [int] NULL,
 CONSTRAINT [PK_GroupWork] PRIMARY KEY CLUSTERED 
(
	[Gid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[House]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[House](
	[Hid] [int] IDENTITY(1,1) NOT NULL,
	[Hname] [nvarchar](50) NULL,
	[Hseat] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[Hid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ip]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ip](
	[Iid] [int] IDENTITY(1,1) NOT NULL,
	[Ihid] [int] NULL,
	[Inum] [int] NULL,
	[Iip] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Iid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ListMenu]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListMenu](
	[Lid] [int] IDENTITY(1,1) NOT NULL,
	[Lcid] [int] NULL,
	[Lsort] [int] NULL,
	[Ltype] [int] NULL,
	[Lxid] [int] NULL,
	[Lshow] [bit] NULL,
	[Ltitle] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Lid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mission]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mission](
	[Mid] [int] IDENTITY(1,1) NOT NULL,
	[Mtitle] [nvarchar](50) NULL,
	[Mcid] [int] NULL,
	[Mcontent] [ntext] NULL,
	[Mdate] [datetime] NULL,
	[Mhit] [int] NULL,
	[Mfiletype] [nvarchar](50) NULL,
	[Mupload] [bit] NULL,
	[Msort] [int] NULL,
	[Mpublish] [bit] NULL,
	[Mgroup] [bit] NULL,
	[Mgid] [int] NULL,
	[Mdelete] [bit] NULL,
	[Mexample] [nvarchar](50) NULL,
	[Mcategory] [int] NULL,
	[Microworld] [bit] NULL,
 CONSTRAINT [PK_Mission] PRIMARY KEY CLUSTERED 
(
	[Mid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NotSign]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotSign](
	[Nid] [int] IDENTITY(1,1) NOT NULL,
	[Nnum] [nvarchar](50) NULL,
	[Ndate] [datetime] NULL,
	[Nyear] [int] NULL,
	[Nmonth] [int] NULL,
	[Nday] [int] NULL,
	[Nweek] [nvarchar](50) NULL,
	[Nnote] [ntext] NULL,
	[Ngrade] [int] NULL,
	[Nterm] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Nid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pchinese]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pchinese](
	[Pid] [int] IDENTITY(1,1) NOT NULL,
	[Psid] [int] NULL,
	[Psnum] [nvarchar](50) NULL,
	[Papple] [int] NULL,
	[Ptotal] [int] NULL,
	[Pspeed] [int] NULL,
	[Pdegree] [int] NULL,
	[Pyear] [int] NULL,
	[Pgrade] [int] NULL,
	[Pclass] [int] NULL,
	[Pterm] [int] NULL,
	[Pdate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Pid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pfinger]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pfinger](
	[Pid] [int] IDENTITY(1,1) NOT NULL,
	[Psnum] [nvarchar](50) NULL,
	[Pspd] [decimal](18, 2) NULL,
	[Pyear] [int] NULL,
	[Pmonth] [int] NULL,
	[Pdate] [datetime] NULL,
	[Pdegree] [int] NULL,
	[Pgrade] [int] NULL,
	[Pterm] [int] NULL,
	[Psid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Pid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ptyper]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ptyper](
	[Pid] [int] IDENTITY(1,1) NOT NULL,
	[Ptid] [int] NULL,
	[Psnum] [nvarchar](50) NULL,
	[Pscore] [int] NULL,
	[Pdate] [datetime] NULL,
	[Pip] [nvarchar](50) NULL,
	[Ptype] [int] NULL,
	[Pdegree] [int] NULL,
	[Pgrade] [int] NULL,
	[Pterm] [int] NULL,
	[Psid] [int] NULL,
 CONSTRAINT [PK_Ptyper] PRIMARY KEY CLUSTERED 
(
	[Pid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Quiz]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quiz](
	[Qid] [int] IDENTITY(1,1) NOT NULL,
	[Qtype] [int] NULL,
	[Question] [ntext] NULL,
	[Qanswer] [nvarchar](50) NULL,
	[Qanalyze] [nvarchar](50) NULL,
	[Qscore] [int] NULL,
	[Qclass] [nvarchar](50) NULL,
	[Qselect] [bit] NULL,
	[Qright] [int] NULL,
	[Qwrong] [int] NULL,
	[Qaccuracy] [int] NULL,
 CONSTRAINT [PK_Quiz] PRIMARY KEY CLUSTERED 
(
	[Qid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuizGrade]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuizGrade](
	[Qid] [int] IDENTITY(1,1) NOT NULL,
	[Qobj] [int] NULL,
	[Qclass] [ntext] NULL,
	[Qhid] [int] NULL,
	[Qonly] [int] NULL,
	[Qmore] [int] NULL,
	[Qjudge] [int] NULL,
	[Qopen] [bit] NULL,
	[Qanswer] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Qid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Result]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[Rid] [int] IDENTITY(1,1) NOT NULL,
	[Rnum] [nvarchar](50) NULL,
	[Rscore] [int] NULL,
	[Rdate] [datetime] NULL,
	[Rhistory] [ntext] NULL,
	[Rwrong] [ntext] NULL,
	[Rgrade] [int] NULL,
	[Rterm] [int] NULL,
	[Rsid] [int] NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[Rid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[Rid] [int] IDENTITY(1,1) NOT NULL,
	[Rhid] [int] NULL,
	[Rgrade] [int] NULL,
	[Rclass] [int] NULL,
	[Rset] [bit] NULL,
	[Rpwd] [nvarchar](50) NULL,
	[Rlock] [bit] NULL,
	[Rip] [nvarchar](50) NULL,
	[Rgauge] [bit] NULL,
	[RgroupMax] [int] NULL,
	[Rclassedit] [bit] NULL,
	[Rphotoedit] [bit] NULL,
	[Rsexedit] [bit] NULL,
	[Rnameedit] [bit] NULL,
	[Rcid] [int] NULL,
	[Ropen] [bit] NULL,
	[Rseat] [int] NULL,
	[Rshare] [bit] NULL,
	[Rpwdsee] [bit] NULL,
	[Rgroupshare] [bit] NULL,
	[Rtyper] [nvarchar](200) NULL,
	[Rreg] [bit] NULL,
	[Rchinese] [nvarchar](200) NULL,
	[Rscratch] [bit] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[Rid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ShareDisk]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShareDisk](
	[Kid] [int] IDENTITY(1,1) NOT NULL,
	[Kown] [bit] NULL,
	[Kyear] [int] NULL,
	[Kgrade] [int] NULL,
	[Kclass] [int] NULL,
	[Kgroup] [int] NULL,
	[Knum] [nvarchar](50) NULL,
	[Kname] [nvarchar](50) NULL,
	[Kfilename] [nvarchar](50) NULL,
	[Kfsize] [int] NULL,
	[Kfurl] [nvarchar](200) NULL,
	[Kftpe] [nvarchar](50) NULL,
	[Kfdate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Kid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Signin]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Signin](
	[Qid] [int] IDENTITY(1,1) NOT NULL,
	[Qnum] [nvarchar](50) NULL,
	[Qattitude] [int] NULL,
	[Qdate] [datetime] NULL,
	[Qyear] [int] NULL,
	[Qmonth] [int] NULL,
	[Qday] [int] NULL,
	[Qweek] [nvarchar](50) NULL,
	[Qip] [nvarchar](50) NULL,
	[Qmachine] [nvarchar](50) NULL,
	[Qnote] [nvarchar](50) NULL,
	[Qwork] [int] NULL,
	[Qgrade] [int] NULL,
	[Qterm] [int] NULL,
	[Qgroup] [nvarchar](50) NULL,
	[Qgscore] [int] NULL,
	[Qsid] [int] NULL,
	[Qname] [nvarchar](50) NULL,
	[Qclass] [int] NULL,
	[Qsyear] [int] NULL,
	[Qcid] [int] NULL,
 CONSTRAINT [PK_Signin] PRIMARY KEY CLUSTERED 
(
	[Qid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Soft]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Soft](
	[Fid] [int] IDENTITY(1,1) NOT NULL,
	[Ftitle] [nvarchar](50) NULL,
	[Fcontent] [ntext] NULL,
	[Furl] [nvarchar](200) NULL,
	[Fhit] [int] NULL,
	[Fdate] [datetime] NULL,
	[Ffiletype] [nvarchar](50) NULL,
	[Fclass] [nvarchar](50) NULL,
	[Fhide] [bit] NULL,
	[Fopen] [int] NULL,
	[Fhid] [int] NULL,
	[Fyid] [int] NULL,
	[Fup] [bit] NULL,
 CONSTRAINT [PK_Soft] PRIMARY KEY CLUSTERED 
(
	[Fid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SoftCategory]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoftCategory](
	[Yid] [int] IDENTITY(1,1) NOT NULL,
	[Ysort] [int] NULL,
	[Ytitle] [nvarchar](50) NULL,
	[Ycontent] [nvarchar](200) NULL,
	[Yopen] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Yid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Sid] [int] IDENTITY(1,1) NOT NULL,
	[Snum] [nvarchar](50) NULL,
	[Syear] [int] NULL,
	[Sgrade] [int] NULL,
	[Sclass] [int] NULL,
	[Sname] [nvarchar](50) NULL,
	[Spwd] [nvarchar](50) NULL,
	[Sex] [nvarchar](2) NULL,
	[Saddress] [nvarchar](200) NULL,
	[Sphone] [nvarchar](50) NULL,
	[Sparents] [nvarchar](50) NULL,
	[Sheadtheacher] [nvarchar](50) NULL,
	[Sscore] [int] NULL,
	[Squiz] [int] NULL,
	[Sattitude] [int] NULL,
	[Sape] [nvarchar](1) NULL,
	[Swscore] [int] NULL,
	[Stscore] [int] NULL,
	[Sallscore] [int] NULL,
	[Spscore] [int] NULL,
	[Sgroup] [int] NULL,
	[Sleader] [bit] NULL,
	[Svote] [int] NULL,
	[Sgscore] [int] NULL,
	[Sfscore] [int] NULL,
	[Svscore] [int] NULL,
	[Sgtitle] [nvarchar](50) NULL,
	[Sascore] [int] NULL,
	[Skaoxu] [nvarchar](50) NULL,
	[Swdscore] [int] NULL,
	[Stxtform] [int] NULL,
	[Schinese] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Sid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentsExcel]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentsExcel](
	[Sid] [int] IDENTITY(1,1) NOT NULL,
	[Snum] [nvarchar](50) NULL,
	[Syear] [int] NULL,
	[Sgrade] [int] NULL,
	[Sclass] [int] NULL,
	[Sname] [nvarchar](50) NULL,
	[Spwd] [nvarchar](50) NULL,
	[Sex] [nvarchar](2) NULL,
	[Saddress] [nvarchar](200) NULL,
	[Sphone] [nvarchar](50) NOT NULL,
	[Sparents] [nvarchar](50) NULL,
	[Sheadtheacher] [nvarchar](50) NULL,
	[Sscore] [int] NULL,
	[Squiz] [int] NULL,
	[Sattitude] [int] NULL,
	[Sape] [nvarchar](1) NULL,
 CONSTRAINT [PK_StudentsExcel] PRIMARY KEY CLUSTERED 
(
	[Sid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Summary]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Summary](
	[Sid] [int] IDENTITY(1,1) NOT NULL,
	[Scid] [int] NULL,
	[Smid] [int] NULL,
	[Shid] [int] NULL,
	[Scontent] [ntext] NULL,
	[Sdate] [datetime] NULL,
	[Sgrade] [int] NULL,
	[Sclass] [int] NULL,
	[Syear] [int] NULL,
	[Sshow] [bit] NULL,
 CONSTRAINT [PK_Summary] PRIMARY KEY CLUSTERED 
(
	[Sid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Survey]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Survey](
	[Vid] [int] IDENTITY(1,1) NOT NULL,
	[Vcid] [int] NULL,
	[Vhid] [int] NULL,
	[Vtitle] [nvarchar](50) NULL,
	[Vcontent] [ntext] NULL,
	[Vtype] [int] NULL,
	[Vtotal] [int] NULL,
	[Vscore] [int] NULL,
	[Vaverage] [int] NULL,
	[Vclose] [bit] NULL,
	[Vpoint] [bit] NULL,
	[Vdate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Vid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SurveyClass]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveyClass](
	[Yid] [int] IDENTITY(1,1) NOT NULL,
	[Yyear] [int] NULL,
	[Ygrade] [int] NULL,
	[Yclass] [int] NULL,
	[Yterm] [int] NULL,
	[Ycid] [int] NULL,
	[Yvid] [int] NULL,
	[Yselect] [ntext] NULL,
	[Ycount] [ntext] NULL,
	[Yscore] [int] NULL,
	[Ydate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Yid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SurveyFeedback]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveyFeedback](
	[Fid] [int] IDENTITY(1,1) NOT NULL,
	[Fnum] [nvarchar](50) NULL,
	[Fyear] [int] NULL,
	[Fgrade] [int] NULL,
	[Fclass] [int] NULL,
	[Fterm] [int] NULL,
	[Fcid] [int] NULL,
	[Fvid] [int] NULL,
	[Fvtype] [int] NULL,
	[Fselect] [ntext] NULL,
	[Fscore] [int] NULL,
	[Fdate] [datetime] NULL,
	[Fsid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Fid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SurveyItem]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveyItem](
	[Mid] [int] IDENTITY(1,1) NOT NULL,
	[Mqid] [int] NULL,
	[Mvid] [int] NULL,
	[Mitem] [ntext] NULL,
	[Mscore] [int] NULL,
	[Mcount] [int] NULL,
	[Mcid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Mid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SurveyQuestion]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurveyQuestion](
	[Qid] [int] IDENTITY(1,1) NOT NULL,
	[Qvid] [int] NULL,
	[Qcid] [int] NULL,
	[Qtitle] [ntext] NULL,
	[Qcount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Qid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Hid] [int] IDENTITY(1,1) NOT NULL,
	[Hname] [nvarchar](50) NULL,
	[Hpwd] [nvarchar](50) NULL,
	[Hpermiss] [bit] NULL,
	[Hnote] [ntext] NULL,
	[Hpath] [nvarchar](50) NULL,
	[Hdelete] [bit] NULL,
	[Hcount] [int] NULL,
	[Hnick] [nvarchar](50) NULL,
	[Hroom] [nvarchar](50) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Hid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TermTotal]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TermTotal](
	[Tid] [int] IDENTITY(1,1) NOT NULL,
	[Tnum] [nvarchar](50) NULL,
	[Tterm] [int] NULL,
	[Tgrade] [int] NULL,
	[Tscore] [int] NULL,
	[Tgscore] [int] NULL,
	[Tquiz] [int] NULL,
	[Tattitude] [int] NULL,
	[Twscore] [int] NULL,
	[Ttscore] [int] NULL,
	[Tpscore] [int] NULL,
	[Tallscore] [int] NULL,
	[Tape] [nvarchar](1) NULL,
	[Tfscore] [int] NULL,
	[Tvscore] [int] NULL,
	[Tsid] [int] NULL,
	[Tyear] [int] NULL,
	[Tclass] [int] NULL,
	[Tname] [nvarchar](50) NULL,
	[Ttxtform] [int] NULL,
	[Tchinese] [int] NULL,
 CONSTRAINT [PK_TermTotal] PRIMARY KEY CLUSTERED 
(
	[Tid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TopicDiscuss]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopicDiscuss](
	[Tid] [int] IDENTITY(1,1) NOT NULL,
	[Tcid] [int] NULL,
	[Ttitle] [nvarchar](50) NULL,
	[Tcontent] [ntext] NULL,
	[Tcount] [int] NULL,
	[Tteacher] [int] NULL,
	[Tdate] [datetime] NULL,
	[Tclose] [bit] NULL,
	[Tresult] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[Tid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TopicReply]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopicReply](
	[Rid] [int] IDENTITY(1,1) NOT NULL,
	[Rtid] [int] NULL,
	[Rsnum] [nvarchar](50) NULL,
	[Rwords] [ntext] NULL,
	[Rtime] [datetime] NULL,
	[Rip] [nvarchar](50) NULL,
	[Rscore] [int] NULL,
	[Rban] [bit] NULL,
	[Rgrade] [int] NULL,
	[Rterm] [int] NULL,
	[Rcid] [int] NULL,
	[Rclass] [int] NULL,
	[Rsid] [int] NULL,
	[Ryear] [int] NULL,
	[Redit] [bit] NULL,
	[Ragree] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Rid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TxtForm]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TxtForm](
	[Mid] [int] IDENTITY(1,1) NOT NULL,
	[Mtitle] [nvarchar](50) NULL,
	[Mcid] [int] NULL,
	[Mcontent] [ntext] NULL,
	[Mdate] [datetime] NULL,
	[Mhit] [int] NULL,
	[Mpublish] [bit] NULL,
	[Mdelete] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Mid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TxtFormBack]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TxtFormBack](
	[Rid] [int] IDENTITY(1,1) NOT NULL,
	[Rmid] [int] NULL,
	[Rsnum] [nvarchar](50) NULL,
	[Rsid] [int] NULL,
	[Rwords] [ntext] NULL,
	[Rtime] [datetime] NULL,
	[Rip] [nvarchar](50) NULL,
	[Rscore] [int] NULL,
	[Ryear] [int] NULL,
	[Rterm] [int] NULL,
	[Rgrade] [int] NULL,
	[Rclass] [int] NULL,
	[Ragree] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Rid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Typer]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Typer](
	[Tid] [int] IDENTITY(1,1) NOT NULL,
	[Ttype] [smallint] NULL,
	[Tuse] [int] NULL,
	[Ttitle] [nvarchar](100) NULL,
	[Tcontent] [ntext] NULL,
 CONSTRAINT [PK_Typer] PRIMARY KEY CLUSTERED 
(
	[Tid] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Webstudy]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Webstudy](
	[Wid] [int] IDENTITY(1,1) NOT NULL,
	[Wnum] [nvarchar](50) NULL,
	[Wpwd] [nvarchar](50) NULL,
	[Wvote] [int] NULL,
	[Wegg] [int] NULL,
	[Wscore] [int] NULL,
	[Wcheck] [bit] NULL,
	[WquotaCurrent] [int] NULL,
	[Wupdate] [datetime] NULL,
	[Wurl] [nvarchar](50) NULL,
	[Wsid] [int] NULL,
 CONSTRAINT [PK_Webstudy] PRIMARY KEY CLUSTERED 
(
	[Wid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Works]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Works](
	[Wid] [int] IDENTITY(1,1) NOT NULL,
	[Wnum] [nvarchar](50) NULL,
	[Wcid] [int] NULL,
	[Wmid] [int] NULL,
	[Wmsort] [int] NULL,
	[Wfilename] [nvarchar](50) NULL,
	[Wurl] [nvarchar](200) NULL,
	[Wlength] [int] NULL,
	[Wscore] [int] NULL,
	[Wdate] [datetime] NULL,
	[Wip] [nvarchar](50) NULL,
	[Wtime] [nvarchar](50) NULL,
	[Wvote] [int] NULL,
	[Wegg] [smallint] NULL,
	[Wcheck] [bit] NULL,
	[Wself] [nvarchar](200) NULL,
	[Wcan] [bit] NULL,
	[Wgood] [bit] NULL,
	[Wtype] [nvarchar](50) NULL,
	[Wgrade] [int] NULL,
	[Wterm] [int] NULL,
	[Whit] [int] NULL,
	[Wlscore] [int] NULL,
	[Wlemotion] [int] NULL,
	[Woffice] [bit] NULL,
	[Wflash] [bit] NULL,
	[Werror] [bit] NULL,
	[Wfscore] [int] NULL,
	[Wclass] [int] NULL,
	[Wsid] [int] NULL,
	[Wname] [nvarchar](50) NULL,
	[Wyear] [int] NULL,
	[Wdscore] [int] NULL,
	[Wthumbnail] [nvarchar](200) NULL,
 CONSTRAINT [PK_Works] PRIMARY KEY CLUSTERED 
(
	[Wid] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorksDiscuss]    Script Date: 2016/3/5 20:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorksDiscuss](
	[Did] [int] IDENTITY(1,1) NOT NULL,
	[Dwid] [int] NULL,
	[Dsnum] [nvarchar](50) NULL,
	[Dwords] [ntext] NULL,
	[Dtime] [datetime] NULL,
	[Dip] [nvarchar](50) NULL,
	[Dsid] [int] NULL,
 CONSTRAINT [PK_WorksDiscuss] PRIMARY KEY CLUSTERED 
(
	[Did] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Autonomic] ADD  DEFAULT ((0)) FOR [Ascore]
GO
ALTER TABLE [dbo].[Autonomic] ADD  DEFAULT ((0)) FOR [Avote]
GO
ALTER TABLE [dbo].[Autonomic] ADD  DEFAULT ((0)) FOR [Aegg]
GO
ALTER TABLE [dbo].[Autonomic] ADD  DEFAULT ((0)) FOR [Acheck]
GO
ALTER TABLE [dbo].[Autonomic] ADD  DEFAULT ((0)) FOR [Agood]
GO
ALTER TABLE [dbo].[Autonomic] ADD  DEFAULT ((0)) FOR [Ahit]
GO
ALTER TABLE [dbo].[Autonomic] ADD  DEFAULT ((0)) FOR [Aoffice]
GO
ALTER TABLE [dbo].[Autonomic] ADD  DEFAULT ((0)) FOR [Aflash]
GO
ALTER TABLE [dbo].[Autonomic] ADD  DEFAULT ((0)) FOR [Aerror]
GO
ALTER TABLE [dbo].[Computers] ADD  DEFAULT ((0)) FOR [Plock]
GO
ALTER TABLE [dbo].[Computers] ADD  DEFAULT ((0)) FOR [Px]
GO
ALTER TABLE [dbo].[Computers] ADD  DEFAULT ((0)) FOR [Py]
GO
ALTER TABLE [dbo].[Courses] ADD  CONSTRAINT [DF_Courses_Chit]  DEFAULT ((0)) FOR [Chit]
GO
ALTER TABLE [dbo].[Courses] ADD  CONSTRAINT [DF_Courses_Cupload]  DEFAULT ((1)) FOR [Cupload]
GO
ALTER TABLE [dbo].[Courses] ADD  CONSTRAINT [DF_Courses_Cpublish]  DEFAULT ((1)) FOR [Cpublish]
GO
ALTER TABLE [dbo].[Courses] ADD  DEFAULT ((0)) FOR [Cdelete]
GO
ALTER TABLE [dbo].[Courses] ADD  DEFAULT ((1)) FOR [Cgood]
GO
ALTER TABLE [dbo].[Courses] ADD  DEFAULT ((0)) FOR [Cold]
GO
ALTER TABLE [dbo].[GaugeFeedback] ADD  DEFAULT ((0)) FOR [Fgood]
GO
ALTER TABLE [dbo].[GaugeFeedback] ADD  DEFAULT ((0)) FOR [Fsid]
GO
ALTER TABLE [dbo].[GroupWork] ADD  CONSTRAINT [DF_GroupWork_Gcheck]  DEFAULT ((0)) FOR [Gcheck]
GO
ALTER TABLE [dbo].[GroupWork] ADD  CONSTRAINT [DF_GroupWork_Ghit]  DEFAULT ((0)) FOR [Ghit]
GO
ALTER TABLE [dbo].[ListMenu] ADD  DEFAULT ((0)) FOR [Lsort]
GO
ALTER TABLE [dbo].[ListMenu] ADD  DEFAULT ((1)) FOR [Lshow]
GO
ALTER TABLE [dbo].[Mission] ADD  CONSTRAINT [DF_Mission_Mhit]  DEFAULT ((0)) FOR [Mhit]
GO
ALTER TABLE [dbo].[Mission] ADD  CONSTRAINT [DF_Mission_Mupload]  DEFAULT ((0)) FOR [Mupload]
GO
ALTER TABLE [dbo].[Mission] ADD  CONSTRAINT [DF_Mission_Msort]  DEFAULT ((0)) FOR [Msort]
GO
ALTER TABLE [dbo].[Mission] ADD  CONSTRAINT [DF_Mission_Mpublish]  DEFAULT ((1)) FOR [Mpublish]
GO
ALTER TABLE [dbo].[Mission] ADD  DEFAULT ((0)) FOR [Mgroup]
GO
ALTER TABLE [dbo].[Mission] ADD  DEFAULT ((0)) FOR [Mgid]
GO
ALTER TABLE [dbo].[Mission] ADD  DEFAULT ((0)) FOR [Mdelete]
GO
ALTER TABLE [dbo].[Mission] ADD  DEFAULT ((0)) FOR [Mcategory]
GO
ALTER TABLE [dbo].[Mission] ADD  DEFAULT ((0)) FOR [Microworld]
GO
ALTER TABLE [dbo].[Pchinese] ADD  DEFAULT ((0)) FOR [Papple]
GO
ALTER TABLE [dbo].[Pchinese] ADD  DEFAULT ((0)) FOR [Ptotal]
GO
ALTER TABLE [dbo].[Pchinese] ADD  DEFAULT ((0)) FOR [Pspeed]
GO
ALTER TABLE [dbo].[Pfinger] ADD  DEFAULT ((0)) FOR [Pgrade]
GO
ALTER TABLE [dbo].[Pfinger] ADD  DEFAULT ((0)) FOR [Pterm]
GO
ALTER TABLE [dbo].[Pfinger] ADD  DEFAULT ((0)) FOR [Psid]
GO
ALTER TABLE [dbo].[Ptyper] ADD  CONSTRAINT [DF_Ptyper_Ptype]  DEFAULT ((1)) FOR [Ptype]
GO
ALTER TABLE [dbo].[Ptyper] ADD  CONSTRAINT [DF__Ptyper__Pdegree__0DAF0CB0]  DEFAULT ((0)) FOR [Pdegree]
GO
ALTER TABLE [dbo].[Ptyper] ADD  DEFAULT ((0)) FOR [Pgrade]
GO
ALTER TABLE [dbo].[Ptyper] ADD  DEFAULT ((0)) FOR [Pterm]
GO
ALTER TABLE [dbo].[Ptyper] ADD  DEFAULT ((0)) FOR [Psid]
GO
ALTER TABLE [dbo].[Quiz] ADD  CONSTRAINT [DF__Quiz__Qselect__0EA330E9]  DEFAULT ((0)) FOR [Qselect]
GO
ALTER TABLE [dbo].[Quiz] ADD  DEFAULT ((0)) FOR [Qright]
GO
ALTER TABLE [dbo].[Quiz] ADD  DEFAULT ((0)) FOR [Qwrong]
GO
ALTER TABLE [dbo].[Quiz] ADD  DEFAULT ((0)) FOR [Qaccuracy]
GO
ALTER TABLE [dbo].[QuizGrade] ADD  DEFAULT ((0)) FOR [Qobj]
GO
ALTER TABLE [dbo].[QuizGrade] ADD  CONSTRAINT [DF_QuizGrade_Qopen]  DEFAULT ((1)) FOR [Qopen]
GO
ALTER TABLE [dbo].[QuizGrade] ADD  DEFAULT ((1)) FOR [Qanswer]
GO
ALTER TABLE [dbo].[Result] ADD  DEFAULT ((0)) FOR [Rgrade]
GO
ALTER TABLE [dbo].[Result] ADD  DEFAULT ((0)) FOR [Rterm]
GO
ALTER TABLE [dbo].[Result] ADD  DEFAULT ((0)) FOR [Rsid]
GO
ALTER TABLE [dbo].[Room] ADD  CONSTRAINT [DF_Room_Rhid]  DEFAULT ((0)) FOR [Rhid]
GO
ALTER TABLE [dbo].[Room] ADD  CONSTRAINT [DF_Room_Rset]  DEFAULT ((0)) FOR [Rset]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rlock]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rgauge]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [RgroupMax]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rclassedit]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rphotoedit]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rsexedit]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rnameedit]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Ropen]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rseat]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rshare]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rpwdsee]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rgroupshare]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rreg]
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [Rscratch]
GO
ALTER TABLE [dbo].[ShareDisk] ADD  DEFAULT ((0)) FOR [Kown]
GO
ALTER TABLE [dbo].[Signin] ADD  CONSTRAINT [DF_Signin_Qattitude]  DEFAULT ((0)) FOR [Qattitude]
GO
ALTER TABLE [dbo].[Signin] ADD  CONSTRAINT [DF_Signin_Qwork]  DEFAULT ((0)) FOR [Qwork]
GO
ALTER TABLE [dbo].[Signin] ADD  DEFAULT ((0)) FOR [Qgscore]
GO
ALTER TABLE [dbo].[Signin] ADD  DEFAULT ((0)) FOR [Qsid]
GO
ALTER TABLE [dbo].[Signin] ADD  DEFAULT ((0)) FOR [Qclass]
GO
ALTER TABLE [dbo].[Signin] ADD  DEFAULT ((0)) FOR [Qsyear]
GO
ALTER TABLE [dbo].[Soft] ADD  CONSTRAINT [DF_Soft_Fhit]  DEFAULT ((0)) FOR [Fhit]
GO
ALTER TABLE [dbo].[Soft] ADD  DEFAULT ((0)) FOR [Fhide]
GO
ALTER TABLE [dbo].[Soft] ADD  DEFAULT ((0)) FOR [Fopen]
GO
ALTER TABLE [dbo].[Soft] ADD  DEFAULT ((0)) FOR [Fhid]
GO
ALTER TABLE [dbo].[Soft] ADD  DEFAULT ((1)) FOR [Fyid]
GO
ALTER TABLE [dbo].[Soft] ADD  DEFAULT ((0)) FOR [Fup]
GO
ALTER TABLE [dbo].[SoftCategory] ADD  DEFAULT ((0)) FOR [Yopen]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_Sscore]  DEFAULT ((0)) FOR [Sscore]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_Squiz]  DEFAULT ((0)) FOR [Squiz]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF_Students_Sattitude]  DEFAULT ((0)) FOR [Sattitude]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF__Students__Swscor__0AD2A005]  DEFAULT ((0)) FOR [Swscore]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF__Students__Stscor__0BC6C43E]  DEFAULT ((0)) FOR [Stscore]
GO
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [DF__Students__Sallsc__0CBAE877]  DEFAULT ((0)) FOR [Sallscore]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Spscore]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Sgroup]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Sleader]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Svote]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Sfscore]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Svscore]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Sascore]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Swdscore]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Stxtform]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT ((0)) FOR [Schinese]
GO
ALTER TABLE [dbo].[StudentsExcel] ADD  CONSTRAINT [DF_StudentsExcel_Sscore]  DEFAULT ((0)) FOR [Sscore]
GO
ALTER TABLE [dbo].[StudentsExcel] ADD  CONSTRAINT [DF_StudentsExcel_Squiz]  DEFAULT ((0)) FOR [Squiz]
GO
ALTER TABLE [dbo].[StudentsExcel] ADD  CONSTRAINT [DF_StudentsExcel_Sattitude]  DEFAULT ((0)) FOR [Sattitude]
GO
ALTER TABLE [dbo].[Summary] ADD  CONSTRAINT [DF_Summary_Sshow]  DEFAULT ((1)) FOR [Sshow]
GO
ALTER TABLE [dbo].[Survey] ADD  DEFAULT ((0)) FOR [Vtype]
GO
ALTER TABLE [dbo].[Survey] ADD  DEFAULT ((0)) FOR [Vtotal]
GO
ALTER TABLE [dbo].[Survey] ADD  DEFAULT ((0)) FOR [Vscore]
GO
ALTER TABLE [dbo].[Survey] ADD  DEFAULT ((0)) FOR [Vclose]
GO
ALTER TABLE [dbo].[Survey] ADD  DEFAULT ((0)) FOR [Vpoint]
GO
ALTER TABLE [dbo].[SurveyFeedback] ADD  DEFAULT ((0)) FOR [Fvtype]
GO
ALTER TABLE [dbo].[SurveyFeedback] ADD  DEFAULT ((0)) FOR [Fscore]
GO
ALTER TABLE [dbo].[SurveyFeedback] ADD  DEFAULT ((0)) FOR [Fsid]
GO
ALTER TABLE [dbo].[SurveyItem] ADD  DEFAULT ((0)) FOR [Mscore]
GO
ALTER TABLE [dbo].[SurveyItem] ADD  DEFAULT ((0)) FOR [Mcount]
GO
ALTER TABLE [dbo].[SurveyQuestion] ADD  DEFAULT ((0)) FOR [Qcount]
GO
ALTER TABLE [dbo].[Teacher] ADD  CONSTRAINT [DF_Teacher_Hpermiss]  DEFAULT ((0)) FOR [Hpermiss]
GO
ALTER TABLE [dbo].[Teacher] ADD  DEFAULT ((0)) FOR [Hdelete]
GO
ALTER TABLE [dbo].[Teacher] ADD  DEFAULT ((0)) FOR [Hcount]
GO
ALTER TABLE [dbo].[TermTotal] ADD  DEFAULT ((0)) FOR [Tfscore]
GO
ALTER TABLE [dbo].[TermTotal] ADD  DEFAULT ((0)) FOR [Tvscore]
GO
ALTER TABLE [dbo].[TermTotal] ADD  DEFAULT ((0)) FOR [Tsid]
GO
ALTER TABLE [dbo].[TermTotal] ADD  DEFAULT ((0)) FOR [Ttxtform]
GO
ALTER TABLE [dbo].[TermTotal] ADD  DEFAULT ((0)) FOR [Tchinese]
GO
ALTER TABLE [dbo].[TopicDiscuss] ADD  DEFAULT ((0)) FOR [Tcount]
GO
ALTER TABLE [dbo].[TopicDiscuss] ADD  DEFAULT ((0)) FOR [Tclose]
GO
ALTER TABLE [dbo].[TopicReply] ADD  DEFAULT ((0)) FOR [Rban]
GO
ALTER TABLE [dbo].[TopicReply] ADD  DEFAULT ((0)) FOR [Rcid]
GO
ALTER TABLE [dbo].[TopicReply] ADD  DEFAULT ((0)) FOR [Rclass]
GO
ALTER TABLE [dbo].[TopicReply] ADD  DEFAULT ((0)) FOR [Rsid]
GO
ALTER TABLE [dbo].[TopicReply] ADD  DEFAULT ((0)) FOR [Ryear]
GO
ALTER TABLE [dbo].[TopicReply] ADD  DEFAULT ((0)) FOR [Redit]
GO
ALTER TABLE [dbo].[TopicReply] ADD  DEFAULT ((0)) FOR [Ragree]
GO
ALTER TABLE [dbo].[TxtForm] ADD  DEFAULT ((0)) FOR [Mpublish]
GO
ALTER TABLE [dbo].[TxtForm] ADD  DEFAULT ((0)) FOR [Mdelete]
GO
ALTER TABLE [dbo].[TxtFormBack] ADD  DEFAULT ((0)) FOR [Rscore]
GO
ALTER TABLE [dbo].[Webstudy] ADD  CONSTRAINT [DF_Webstudy_Wvote]  DEFAULT ((0)) FOR [Wvote]
GO
ALTER TABLE [dbo].[Webstudy] ADD  CONSTRAINT [DF_Webstudy_Wegg]  DEFAULT ((1)) FOR [Wegg]
GO
ALTER TABLE [dbo].[Webstudy] ADD  CONSTRAINT [DF_Webstudy_Wscore]  DEFAULT ((0)) FOR [Wscore]
GO
ALTER TABLE [dbo].[Webstudy] ADD  CONSTRAINT [DF_Webstudy_Wcheck]  DEFAULT ((0)) FOR [Wcheck]
GO
ALTER TABLE [dbo].[Webstudy] ADD  CONSTRAINT [DF_Webstudy_WquotaCurrent]  DEFAULT ((0)) FOR [WquotaCurrent]
GO
ALTER TABLE [dbo].[Webstudy] ADD  DEFAULT ((0)) FOR [Wsid]
GO
ALTER TABLE [dbo].[Works] ADD  CONSTRAINT [DF_Works_Wscore]  DEFAULT ((0)) FOR [Wscore]
GO
ALTER TABLE [dbo].[Works] ADD  CONSTRAINT [DF_Works_Wvote]  DEFAULT ((0)) FOR [Wvote]
GO
ALTER TABLE [dbo].[Works] ADD  CONSTRAINT [DF_Works_Wegg]  DEFAULT ((1)) FOR [Wegg]
GO
ALTER TABLE [dbo].[Works] ADD  CONSTRAINT [DF_Works_Wcheck]  DEFAULT ((0)) FOR [Wcheck]
GO
ALTER TABLE [dbo].[Works] ADD  CONSTRAINT [DF_Works_Wcan]  DEFAULT ((1)) FOR [Wcan]
GO
ALTER TABLE [dbo].[Works] ADD  CONSTRAINT [DF_Works_Wgood]  DEFAULT ((0)) FOR [Wgood]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Whit]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Wlscore]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Wlemotion]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Woffice]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Wflash]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Werror]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Wfscore]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Wclass]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Wsid]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Wyear]
GO
ALTER TABLE [dbo].[Works] ADD  DEFAULT ((0)) FOR [Wdscore]
GO
ALTER TABLE [dbo].[WorksDiscuss] ADD  DEFAULT ((0)) FOR [Dsid]
GO
BEGIN
insert into Teacher(Hname,Hpwd,Hpermiss,Hnote) values ('admin','12345','1','管理员')
END
