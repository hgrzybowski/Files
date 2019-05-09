CREATE TABLE [dbo].[Klienci] (
    [KlientId]    INT            IDENTITY (1, 1) NOT NULL,
    [JazdyProbne] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Klienci] PRIMARY KEY CLUSTERED ([KlientId] ASC)
);

