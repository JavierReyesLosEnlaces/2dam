CREATE PROCEDURE SaveBook
@bookTitle varchar(50)
@bookAuthor varchar(50)
AS
INSERT INTO Books (title, author) VALUES ( @bookTitle, @bookAuthor)
GO
-- Los procedimientos almacenados se guardan en el directorio de "Programmability", hay que refrescar primero	
-- Para ejecutarlo, debes darle a "Execute"