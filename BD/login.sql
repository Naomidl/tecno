CREATE DATABASE logueo;
USE  logueo;

CREATE TABLE Usuario
(
Nombre varchar(30),
Contrase�a varchar (30),
Roll varchar(25)
); 

create procedure iniciar
@Nombre varchar(30),
@Contrase�a varchar (30)
as
SELECT *FROM Usuario WHERE 
Nombre=@Nombre and Contrase�a=@Contrase�a
go


INSERT INTO Usuario VALUES ('naomidl','gatitos','administrador');

