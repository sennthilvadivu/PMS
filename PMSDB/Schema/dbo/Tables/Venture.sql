CREATE TABLE [dbo].[Venture]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[Status] [nvarchar](20) NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[UpdatedOn] [datetime] NULL
	PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
