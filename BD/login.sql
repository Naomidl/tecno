CREATE DATABASE logueo;
USE  logueo;

CREATE TABLE Usuario
(
Nombre varchar(30),
Contraseņa varchar (30),
Roll varchar(25)
); 

create procedure iniciar
@Nombre varchar(30),
@Contraseņa varchar (30)
as
SELECT *FROM Usuario WHERE 
Nombre=@Nombre and Contraseņa=@Contraseņa
go


INSERT INTO Usuario VALUES ('naomidl','gatitos','administrador');

