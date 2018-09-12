CREATE TABLE [dbo].[UserPropertyTransaction]
(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserPropertyRelationId] [int] NOT NULL,
	[AmountPaid] [decimal](18, 0) NULL,
	[AmountPaidOn] [datetime] NULL,
	[IsDeleted] [bit] NOT NULL DEFAULT 0,
	[CreatedBy] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[UpdatedOn] [datetime] NULL, 
    CONSTRAINT [PK_UserPropertyTransaction] PRIMARY KEY ([ID]), 
    CONSTRAINT [FK_UserPropertyTransaction_ToTable] FOREIGN KEY ([UserPropertyRelationId]) REFERENCES [UserPropertyRelation]([ID]))