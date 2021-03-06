USE [HeThongTaiLieu]
GO
/****** Object:  Table [dbo].[AnswerQuiz]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnswerQuiz](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDQues] [int] NULL,
	[Answer] [nvarchar](max) NULL,
	[explainAns] [nvarchar](max) NULL,
	[CorrectAns] [bit] NULL,
 CONSTRAINT [PK_AnswerQuiz] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AnswerStatus]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnswerStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDStudent] [int] NULL,
	[IDQuiz] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_AnswerStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Documents]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDTeacher] [int] NULL,
	[CreateAt] [date] NULL,
	[IDKhoi] [int] NULL,
	[IDSubject] [int] NULL,
	[Path] [nvarchar](max) NULL,
	[NameDocument] [nvarchar](50) NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuestionTopic]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionTopic](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](max) NULL,
	[IDQuizTopic] [int] NULL,
	[levelQues] [int] NULL,
 CONSTRAINT [PK_QuestionTopic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuizTopic]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuizTopic](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDSubject] [int] NULL,
	[IDTeacher] [int] NULL,
	[CreateAt] [date] NULL,
	[NameTopic] [nvarchar](max) NULL,
	[IDKhoi] [nchar](10) NULL,
	[MultipleChoice] [bit] NULL,
 CONSTRAINT [PK_QuizTopic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ScoresTable]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScoresTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDTopic] [int] NULL,
	[IDStudent] [int] NULL,
	[efficiencyLevel] [int] NULL,
 CONSTRAINT [PK_ScoresTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Pass] [varchar](50) NULL,
	[CreateAt] [date] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[AnswerQuiz] ON 

INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (1, 7, N'∀n € N thì n ≤ 2n', NULL, 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (2, 7, N'∀x € R : x2 > 0 ', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (3, 7, N'∃n € N : n2 = n', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (4, 7, N'∃x € R : x > x2', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (5, 1, N'2', N'vì 1+1 = 2', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (6, 1, N'5', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (7, 1, N'6', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (8, 1, N'7', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (9, 2, N'25', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (10, 2, N'33', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (11, 2, N'11', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (12, 2, N'50', NULL, 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (13, 3, N'10', NULL, 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (14, 3, N'321', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (15, 3, N'50', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (16, 3, N'18', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (17, 4, N'9', NULL, 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (18, 4, N'0', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (19, 4, N'56', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (20, 4, N'8', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (21, 5, N'số 6', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (22, 5, N'số 7', NULL, 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (23, 5, N'số 3', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (24, 5, N'số 8', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (25, 6, N'a2 + b2 = c2', NULL, 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (26, 6, N'a + b2', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (27, 6, N'a + b =c', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (28, 6, N'c2 + a = b2', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (29, 8, N'300', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (30, 8, N'400', NULL, 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (31, 8, N'100', NULL, 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (32, 8, N'300', N'1515', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (354, 91, N'(0; 3)', N'Để tìm giao của các tập hợp số, ta lần lượt biểu diễn chúng trên cùng một trục số bằng cách gạch bỏ các phần tử không thuộc mỗi tập hợp đó. Khi đó, phần còn lại không bị gạch chính là giao của các tập hợp đã cho.', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (355, 91, N'(0; 3]', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (356, 91, N'[0; 3)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (357, 91, N'(-2; 4)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (358, 92, N' (-2; 1)', N'Phương pháp: Để tìm hợp của các tập hợp số, ta lần lượt biểu diễn chúng trên cùng một trục số bằng cách tô đậm các phần tử thuộc mỗi tập hợp đó. Khi đó, toàn bộ phần được tô đậm chính là hợp của các tập hợp đã cho.', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (359, 92, N'[ -4; +∞)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (360, 92, N'(-4; +∞)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (361, 92, N'(1; +∞)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (362, 93, N'(1; 2]', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (363, 93, N' (1; 2)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (364, 93, N'(1; 5)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (365, 93, N'(2; 3]', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (366, 94, N'm>3', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (367, 94, N'm<3', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (368, 94, N'm = 3', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (369, 94, N'm<1', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (370, 95, N'18', N'vì 3*6 = 18', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (371, 95, N'15', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (372, 95, N'5', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (373, 95, N'6', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (374, 96, N'48', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (375, 96, N'40', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (376, 96, N'5', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (377, 96, N'16', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (378, 97, N'10', N'vì 20-10=10', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (379, 97, N'3', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (380, 97, N'444', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (381, 97, N'9', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (382, 98, N'66', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (383, 98, N'4', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (384, 98, N'6', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (385, 98, N'48', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (386, 99, N'90', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (387, 99, N'15', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (388, 99, N'446', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (389, 99, N'48', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (390, 100, N'30', N'vì 30-6 = 30', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (391, 100, N'66', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (392, 100, N'48', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (393, 100, N'10', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (394, 101, N'88', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (395, 101, N'15', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (396, 101, N'4868', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (397, 101, N'321', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (398, 102, N'0', N'vì 42-45 =0', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (399, 102, N'2', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (400, 102, N'5', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (401, 102, N'8', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (402, 103, N'64', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (403, 103, N'23', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (404, 103, N'4', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (405, 103, N'8', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (406, 104, N'559', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (407, 104, N'45', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (408, 104, N'56', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (409, 104, N'989', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (410, 105, N'2', N'vì 1 + 1 = 2', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (411, 106, N'4', N'vì 4', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (412, 107, N'(0; 3)', N'Để tìm giao của các tập hợp số, ta lần lượt biểu diễn chúng trên cùng một trục số bằng cách gạch bỏ các phần tử không thuộc mỗi tập hợp đó. Khi đó, phần còn lại không bị gạch chính là giao của các tập hợp đã cho.', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (413, 107, N'(0; 3]', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (414, 107, N'[0; 3)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (415, 107, N'(-2; 4)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (416, 108, N' (-2; 1)', N'Phương pháp: Để tìm hợp của các tập hợp số, ta lần lượt biểu diễn chúng trên cùng một trục số bằng cách tô đậm các phần tử thuộc mỗi tập hợp đó. Khi đó, toàn bộ phần được tô đậm chính là hợp của các tập hợp đã cho.', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (417, 108, N'[ -4; +∞)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (418, 108, N'(-4; +∞)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (419, 108, N'(1; +∞)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (420, 109, N'(1; 2]', N'', 1)
GO
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (421, 109, N' (1; 2)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (422, 109, N'(1; 5)', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (423, 109, N'(2; 3]', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (424, 110, N'm>3', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (425, 110, N'm<3', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (426, 110, N'm = 3', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (427, 110, N'm<1', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (428, 111, N'18', N'vì 3*6 = 18', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (429, 111, N'15', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (430, 111, N'5', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (431, 111, N'6', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (432, 112, N'48', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (433, 112, N'40', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (434, 112, N'5', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (435, 112, N'16', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (436, 113, N'10', N'vì 20-10=10', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (437, 113, N'3', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (438, 113, N'444', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (439, 113, N'9', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (440, 114, N'66', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (441, 114, N'4', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (442, 114, N'6', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (443, 114, N'48', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (444, 115, N'90', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (445, 115, N'15', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (446, 115, N'446', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (447, 115, N'48', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (448, 116, N'30', N'vì 30-6 = 30', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (449, 116, N'66', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (450, 116, N'48', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (451, 116, N'10', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (452, 117, N'88', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (453, 117, N'15', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (454, 117, N'4868', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (455, 117, N'321', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (456, 118, N'0', N'vì 42-45 =0', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (457, 118, N'2', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (458, 118, N'5', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (459, 118, N'8', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (460, 119, N'64', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (461, 119, N'23', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (462, 119, N'4', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (463, 119, N'8', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (464, 120, N'559', N'', 1)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (465, 120, N'45', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (466, 120, N'56', N'', 0)
INSERT [dbo].[AnswerQuiz] ([ID], [IDQues], [Answer], [explainAns], [CorrectAns]) VALUES (467, 120, N'989', N'', 0)
SET IDENTITY_INSERT [dbo].[AnswerQuiz] OFF
SET IDENTITY_INSERT [dbo].[Documents] ON 

INSERT [dbo].[Documents] ([ID], [IDTeacher], [CreateAt], [IDKhoi], [IDSubject], [Path], [NameDocument]) VALUES (13, 6, CAST(N'2021-05-22' AS Date), 1, 1, N'/UploadedFiles/file-20210522171529287-DE_1_18_01_2021.pdf', N'file-20210522171529287-DE_1_18_01_2021.pdf')
SET IDENTITY_INSERT [dbo].[Documents] OFF
SET IDENTITY_INSERT [dbo].[QuestionTopic] ON 

INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (1, N'1 + 1 bằng', 1, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (2, N'10 x 5 =', 1, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (3, N'3 * 2 + 4 =', 1, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (4, N'3 + 6 = ', 1, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (5, N'sau số 6 là', 1, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (6, N'định lý Pytago', 1, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (7, N'Mệnh đề nào sau là mệnh đề sai?', 1, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (8, N'200 + 200 =', 1, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (91, N'Cho các tập hợp A = [0; 4), B = (-2; 3). Khi đó A ∩ B bằng:', 2, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (92, N'Cho các tập hợp A = [-4; 1), B = (-2; +∞). Khi đó A ∪ B bằng:', 2, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (93, N'Cho các tập hợp A = (1; 3], B = (2; 5) . Khi đó A\B bằng:', 2, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (94, N'Giá trị x = -1 là nghiệm của bất phương trình m - x2 < 2 khi và chỉ khi:', 2, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (95, N'3*6', 2, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (96, N'6*8', 2, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (97, N'20-10', 2, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (98, N'(9:3)x6', 2, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (99, N'15 x 6', 2, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (100, N'36-6', 2, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (101, N'89-1', 2, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (102, N'42-42', 2, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (103, N'60+4', 2, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (104, N'48+9', 2, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (105, N'1 + 1 ', 10, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (106, N'3 + 1 ', 10, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (107, N'Cho các tập hợp A = [0; 4), B = (-2; 3). Khi đó A ∩ B bằng:', 4, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (108, N'Cho các tập hợp A = [-4; 1), B = (-2; +∞). Khi đó A ∪ B bằng:', 4, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (109, N'Cho các tập hợp A = (1; 3], B = (2; 5) . Khi đó A\B bằng:', 4, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (110, N'Giá trị x = -1 là nghiệm của bất phương trình m - x2 < 2 khi và chỉ khi:', 4, 1)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (111, N'3*6', 4, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (112, N'6*8', 4, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (113, N'20-10', 4, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (114, N'(9:3)x6', 4, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (115, N'15 x 6', 4, 2)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (116, N'36-6', 4, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (117, N'89-1', 4, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (118, N'42-42', 4, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (119, N'60+4', 4, 3)
INSERT [dbo].[QuestionTopic] ([ID], [Question], [IDQuizTopic], [levelQues]) VALUES (120, N'48+9', 4, 3)
SET IDENTITY_INSERT [dbo].[QuestionTopic] OFF
SET IDENTITY_INSERT [dbo].[QuizTopic] ON 

INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (1, 1, 6, CAST(N'2021-04-26' AS Date), N'Bài 1', N'1         ', 0)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (2, 1, 6, CAST(N'2021-04-26' AS Date), N'Bài 2', N'1         ', 0)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (3, 1, 6, CAST(N'2021-04-26' AS Date), N'Bài 3', N'1         ', 0)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (4, 1, 6, CAST(N'2021-04-26' AS Date), N'Bài 4', N'1         ', 0)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (5, 1, 6, CAST(N'2021-04-22' AS Date), N'Bai 5', N'1         ', 0)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (6, 1, 6, CAST(N'2021-05-13' AS Date), N'bai 6', N'1         ', 0)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (7, 1, 6, CAST(N'2021-05-13' AS Date), N'bai 7', N'2         ', 0)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (8, 1, 6, CAST(N'2021-05-13' AS Date), N'bai 8', N'2         ', 0)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (9, 1, 6, CAST(N'2021-05-13' AS Date), N'bai 10', N'1         ', 0)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (10, 1, 6, CAST(N'2021-05-22' AS Date), N'bai 11', N'1         ', 1)
INSERT [dbo].[QuizTopic] ([ID], [IDSubject], [IDTeacher], [CreateAt], [NameTopic], [IDKhoi], [MultipleChoice]) VALUES (11, 1, 6, CAST(N'2021-05-22' AS Date), N'Bài 12', N'1         ', 1)
SET IDENTITY_INSERT [dbo].[QuizTopic] OFF
SET IDENTITY_INSERT [dbo].[ScoresTable] ON 

INSERT [dbo].[ScoresTable] ([ID], [IDTopic], [IDStudent], [efficiencyLevel]) VALUES (1, 1, 1, 2)
INSERT [dbo].[ScoresTable] ([ID], [IDTopic], [IDStudent], [efficiencyLevel]) VALUES (2, 1, 3, 1)
INSERT [dbo].[ScoresTable] ([ID], [IDTopic], [IDStudent], [efficiencyLevel]) VALUES (3, 2, 3, 1)
INSERT [dbo].[ScoresTable] ([ID], [IDTopic], [IDStudent], [efficiencyLevel]) VALUES (4, 3, 3, 1)
INSERT [dbo].[ScoresTable] ([ID], [IDTopic], [IDStudent], [efficiencyLevel]) VALUES (5, 10, 3, 1)
SET IDENTITY_INSERT [dbo].[ScoresTable] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [UserName], [Pass], [CreateAt]) VALUES (1, N'phong', N'9F48495BB4B98AC37A1A72C7E6490C7A', CAST(N'1999-07-07' AS Date))
INSERT [dbo].[Students] ([ID], [UserName], [Pass], [CreateAt]) VALUES (2, N'hs001', N'E2B246F2577F27F45D8199508EE97FF2', CAST(N'2021-04-26' AS Date))
INSERT [dbo].[Students] ([ID], [UserName], [Pass], [CreateAt]) VALUES (3, N'hs002', N'8FD5D72BDA403A48A8AA1EF4905A37E2', CAST(N'2021-04-26' AS Date))
INSERT [dbo].[Students] ([ID], [UserName], [Pass], [CreateAt]) VALUES (4, N'hs003', N'E5F5765A18C103A81ECA900086D19409', CAST(N'2021-04-26' AS Date))
SET IDENTITY_INSERT [dbo].[Students] OFF
ALTER TABLE [dbo].[AnswerQuiz]  WITH CHECK ADD  CONSTRAINT [FK_AnswerQuiz_QuestionTopic] FOREIGN KEY([IDQues])
REFERENCES [dbo].[QuestionTopic] ([ID])
GO
ALTER TABLE [dbo].[AnswerQuiz] CHECK CONSTRAINT [FK_AnswerQuiz_QuestionTopic]
GO
ALTER TABLE [dbo].[AnswerStatus]  WITH CHECK ADD  CONSTRAINT [FK_AnswerStatus_QuestionTopic] FOREIGN KEY([IDQuiz])
REFERENCES [dbo].[QuestionTopic] ([ID])
GO
ALTER TABLE [dbo].[AnswerStatus] CHECK CONSTRAINT [FK_AnswerStatus_QuestionTopic]
GO
ALTER TABLE [dbo].[AnswerStatus]  WITH CHECK ADD  CONSTRAINT [FK_AnswerStatus_Students] FOREIGN KEY([IDStudent])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[AnswerStatus] CHECK CONSTRAINT [FK_AnswerStatus_Students]
GO
ALTER TABLE [dbo].[QuestionTopic]  WITH CHECK ADD  CONSTRAINT [FK_QuestionTopic_QuizTopic] FOREIGN KEY([IDQuizTopic])
REFERENCES [dbo].[QuizTopic] ([ID])
GO
ALTER TABLE [dbo].[QuestionTopic] CHECK CONSTRAINT [FK_QuestionTopic_QuizTopic]
GO
ALTER TABLE [dbo].[ScoresTable]  WITH CHECK ADD  CONSTRAINT [FK_ScoresTable_QuizTopic] FOREIGN KEY([IDTopic])
REFERENCES [dbo].[QuizTopic] ([ID])
GO
ALTER TABLE [dbo].[ScoresTable] CHECK CONSTRAINT [FK_ScoresTable_QuizTopic]
GO
ALTER TABLE [dbo].[ScoresTable]  WITH CHECK ADD  CONSTRAINT [FK_ScoresTable_Students] FOREIGN KEY([IDStudent])
REFERENCES [dbo].[Students] ([ID])
GO
ALTER TABLE [dbo].[ScoresTable] CHECK CONSTRAINT [FK_ScoresTable_Students]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDocument]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteDocument]
@ID int
as
begin
	DELETE FROM Documents WHERE ID = @ID;
end
GO
/****** Object:  StoredProcedure [dbo].[insertAns]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertAns]
@IDQuestion int,
@Ans nvarchar(max),
@explain nvarchar(max),
@correct bit
as
begin
	INSERT AnswerQuiz
	(
	    
	    IDQues,
	    Answer,
		explainAns,
		CorrectAns
	)
	VALUES
	(   @IDQuestion,
		@Ans,
		@explain,
		@correct
	    )

end
GO
/****** Object:  StoredProcedure [dbo].[InsertDocument]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertDocument]
@IdTeacher int,
@NgayTao date,
@IDKhoi int,
@IDMon int,
@path nvarchar(max),
@Ten nvarchar(50)
as
begin
	INSERT Documents
	(
	    
	    IDTeacher,
		CreateAt,
		IDKhoi,
		IDSubject,
		Path,
		NameDocument
	)
	VALUES
	(   @IdTeacher,
		@NgayTao,
		@IDKhoi,
		@IDMon,
		@path,
		@Ten
	    )

end
GO
/****** Object:  StoredProcedure [dbo].[insertQuesTopic]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertQuesTopic]
@Question nvarchar(max),
@IDQuiz int,
@Level int
as
begin
	INSERT QuestionTopic
	(
	    
	    Question,
	    IDQuizTopic,
		levelQues
	)
	VALUES
	(   @Question,
		@IDQuiz,
		@Level
	    )

	SELECT SCOPE_IDENTITY() as ID
end
GO
/****** Object:  StoredProcedure [dbo].[insertQuiz]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertQuiz]
@IdMon int,
@IdGV int,
@NgayTao date,
@Ten nvarchar(max),
@IdKhoi int,
@Loai bit
as
begin
	INSERT QuizTopic
	(
	    
	    IDSubject,
	    IDTeacher,
		CreateAt,
		NameTopic,
		IDKhoi,
		MultipleChoice
	)
	VALUES
	(   @IdMon,
		@IdGV,
		@NgayTao,
		@Ten,
		@IdKhoi,
		@Loai
	    )

end
GO
/****** Object:  StoredProcedure [dbo].[insertScores]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertScores]
@IDStudent int,
@IDTopic int,
@efficiencyLevel int
as
begin
	INSERT ScoresTable
	(
	    
	    IDStudent,
	    IDTopic,
		efficiencyLevel
	)
	VALUES
	(   @IDStudent,
		@IDTopic,
		@efficiencyLevel
	    )
end
GO
/****** Object:  StoredProcedure [dbo].[InsertStudents]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStudents]
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(500),
@NgayTao date
AS
BEGIN
	INSERT Students
	(
	    UserName,
	    Pass,
	    CreateAt
	)
	VALUES
	(   @TaiKhoan,
		@MatKhau,
		@NgayTao
	    )
	DECLARE @I INT = (SELECT ID FROM Students WHERE Pass = @MatKhau AND UserName = @TaiKhoan)
	UPDATE Students SET Pass = CONVERT(VARCHAR(32), HASHBYTES('MD5', @MatKhau), 2) WHERE ID = @I
END



GO
/****** Object:  StoredProcedure [dbo].[Login_HTTL]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login_HTTL]
@TaiKhoan VARCHAR(100),
@MatKhau VARCHAR(200)
AS
SELECT * FROM Students WHERE UserName = @TaiKhoan AND Pass = CONVERT(VARCHAR(32),HASHBYTES('MD5', @MatKhau),2)



GO
/****** Object:  StoredProcedure [dbo].[selectAns]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selectAns]
@IDQues int
AS
BEGIN
	if(@IDQues = -1)
		select * from AnswerQuiz
	else
		select * from AnswerQuiz where IDQues = @IDQues
END
GO
/****** Object:  StoredProcedure [dbo].[SelectDocuments]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectDocuments]
@IDTeacher int,
@IDKhoi int,
@IDMon int
AS
BEGIN
	if @IDKhoi = -1
	select * from Documents where IDTeacher = @IDTeacher and IDSubject = @IDMon
	else 
	select * from Documents where IDTeacher = @IDTeacher and IDKhoi=@IDKhoi and IDSubject = @IDMon
END
GO
/****** Object:  StoredProcedure [dbo].[SelectDocuments_Student]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SelectDocuments_Student]
@IDKhoi int,
@IDMon int
AS
BEGIN
	if @IDKhoi = -1
	select * from Documents where IDSubject = @IDMon
	else 
	select * from Documents where IDKhoi=@IDKhoi and IDSubject = @IDMon
END
GO
/****** Object:  StoredProcedure [dbo].[SelectListQuest]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectListQuest]
@IDQuiz INT
AS
BEGIN
	SELECT A.ID ,A.Question ,B.ID as [IDAnswer] ,B.Answer,B.explainAns,B.CorrectAns
	FROM QuestionTopic as A join AnswerQuiz as B on A.ID = B.IDQues 
	WHERE A.IDQuizTopic = @IDQuiz
END



GO
/****** Object:  StoredProcedure [dbo].[selectQues]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[selectQues]
@IDQuiz int
AS
BEGIN
	select * from QuestionTopic where IDQuizTopic = @IDQuiz
END


GO
/****** Object:  StoredProcedure [dbo].[selectQuesLevel]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectQuesLevel]
@level int,
@IDQuiz int
as
begin
	select count(*) as total from QuestionTopic
	where levelQues = @level and IDQuizTopic = @IDQuiz
end
GO
/****** Object:  StoredProcedure [dbo].[selectScore]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectScore]
@IDStudent int,
@IDTopic int
as
begin
	select * from ScoresTable
	where IDStudent = @IDStudent and IDTopic = @IDTopic
end
GO
/****** Object:  StoredProcedure [dbo].[selectScores]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[selectScores]
@IDStudent int,
@IDTopic int
as
begin
	select * from ScoresTable
	where IDStudent = @IDStudent and IDTopic = @IDTopic
end
GO
/****** Object:  StoredProcedure [dbo].[selectTopic]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectTopic]
@IDKhoi int,
@IDMon int
as
begin
	select * from QuizTopic
	where IDSubject = @IDMon and IDKhoi = @IDKhoi
end

GO
/****** Object:  StoredProcedure [dbo].[SelectTopic2]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectTopic2]
@IDMon INT,
@IDTeacher int
AS
BEGIN
	SELECT *
	FROM QuizTopic
	WHERE IDSubject = @IDMon and IDTeacher = @IDTeacher
END



GO
/****** Object:  StoredProcedure [dbo].[updateScores]    Script Date: 5/22/2021 8:14:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateScores]
@IDStudent int,
@IDTopic int,
@efficiencyLevel int
as
begin
	Update ScoresTable	
	Set
	  
		efficiencyLevel = @efficiencyLevel
	where @IDStudent = IDStudent and @IDTopic = IDTopic
	    
end

GO
