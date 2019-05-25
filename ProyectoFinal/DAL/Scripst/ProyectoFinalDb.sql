create database ProyectoFinalDb
go
use ProyectoFinalDb
go
create table Usuarios(

UsuarioId int primary key identity,
Nombre varchar(30),
Email varchar(30),
NivelUsuario varchar(20),
Usuario varchar(15),
Clave varchar(15),
FechaIngreso datetime
);
go
create table Cargos
(
	CargoId int primary key identity,
	Descripcion varchar(40)
);