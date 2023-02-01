CREATE DATABASE logueo;
USE  logueo;

CREATE TABLE Usuario
(
Nombre varchar(30),
Contraseña varchar (30),
Roll varchar(25)
); 

create procedure iniciar
@Nombre varchar(30),
@Contraseña varchar (30)
as
SELECT *FROM Usuario WHERE 
Nombre=@Nombre and Contraseña=@Contraseña
go


INSERT INTO Usuario VALUES ('naomidl','gatitos','administrador');

