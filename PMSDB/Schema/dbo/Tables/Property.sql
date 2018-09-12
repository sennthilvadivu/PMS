CREATE TABLE [dbo].[Property]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[VentureId] [int] NOT NULL,
	[Status] [nvarchar](20) NULL,
	[Unit] [decimal](18, 0) NULL,
	[UoM] [nvarchar](100) NULL,
	[CurrencyCode] [nvarchar](50) NULL,
	[BasePrice] [decimal](18, 0) NULL,
	[IsDeleted] [bit] NOT NULL DEFAULT 0,
	[CreatedBy] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[UpdatedOn] [datetime] NULL, 
    CONSTRAINT [PK_Property] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Property_ToTable] FOREIGN KEY ([VentureId]) REFERENCES [Venture]([ID]) 
) ON [PRIMARY]

