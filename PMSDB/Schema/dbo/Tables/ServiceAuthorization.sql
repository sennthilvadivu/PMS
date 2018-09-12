CREATE TABLE [dbo].[ServiceAuthorization]
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL DEFAULT 0,
	[CreatedBy] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[UpdatedOn] [datetime] NULL, 
    CONSTRAINT [PK_ServiceAuthorization] PRIMARY KEY ([ID]), 
    CONSTRAINT [FK_ServiceAuthorization_User] FOREIGN KEY ([UserId]) REFERENCES [User]([ID]), 
    CONSTRAINT [FK_ServiceAuthorization_ToTable] FOREIGN KEY ([RoleID]) REFERENCES [Role]([ID])
) ON [PRIMARY]
