CREATE TABLE [dbo].[UserPropertyRelation]
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[UserId] [int] NOT NULL,
	[PropertyId] [int] NOT NULL,
	[PurchaseDate] [datetime] NULL,
	[IsDeleted] [bit] NOT NULL DEFAULT 0,
	[CreatedBy] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[UpdatedOn] [datetime] NULL, 
    CONSTRAINT [PK_UserPropertyRelation] PRIMARY KEY ([ID]), 
    CONSTRAINT [FK_UserPropertyRelation_ToTable] FOREIGN KEY ([UserId]) REFERENCES [User]([ID]), 
    CONSTRAINT [FK_UserPropertyRelation_ToTable_1] FOREIGN KEY ([PropertyId]) REFERENCES [Property]([ID])
)
