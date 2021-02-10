CREATE TABLE [dbo].[Productoes] (
    [id]          INT            IDENTITY (1, 1) NOT NULL  ,
    [descripcion] NVARCHAR (MAX) NULL  ,
    [precio]      FLOAT (53)     NOT NULL  ,
    CONSTRAINT [PK_dbo.Productoes] PRIMARY KEY CLUSTERED ([id] ASC)
);

