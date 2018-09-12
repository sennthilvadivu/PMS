CREATE TABLE [dbo].[UserPropertyDueBalanceDetail]
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserPropertyRelationId] [int] NOT NULL,
	[DueAmount] [decimal](18, 0) NULL,
	[DueAmountDate] [datetime] NULL,
	[IsDeleted] [bit] NOT NULL DEFAULT 0,
	[CreatedBy] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[UpdatedOn] [datetime] NULL, 
    CONSTRAINT [PK_UserPropertyDueBalanceDetail] PRIMARY KEY ([ID]), 
    CONSTRAINT [FK_UserPropertyDueBalanceDetail_ToTable] FOREIGN KEY ([UserPropertyRelationId]) REFERENCES [UserPropertyRelation]([ID])
) ON [PRIMARY]
