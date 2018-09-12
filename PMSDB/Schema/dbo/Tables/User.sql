CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [nvarchar](20) NULL,
	[Address] [nvarchar](200) NULL,
	[HashedPassword] [nvarchar](100) NULL,
	[SecurityQuestion] [nvarchar](100) NULL,
	[SecurityAnswer] [nvarchar](100) NULL,
	[IsCustomer] [bit] NULL,
	[IsLocked] [bit] NULL,
	[IsDeleted] [bit] NOT NULL DEFAULT 0,
	[CreatedBy] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[UpdatedOn] [datetime] NULL,
	CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]