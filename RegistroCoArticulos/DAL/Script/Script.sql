CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TABLE Articulos
(
	ArticulosId int primary key identity(1,1),
	FechaVencimiento Datetime,
	Descripcion Varchar(50),
	Precio int,
	CantidadCotizada int,
);