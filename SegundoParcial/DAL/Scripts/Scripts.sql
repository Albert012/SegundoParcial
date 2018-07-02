create database Parcial2doDB
go
use Parcial2doDB
go

create table Vehiculo(
VehiculoId int primary key,
Descripcion varchar(30),
Mantenimiento decimal
);

sp_columns Vehiculo;

insert into Vehiculo(VehiculoId,Descripcion, Mantenimiento) values (1,'Toyota Corolla 2005 LE', 0);

insert into Vehiculo(VehiculoId,Descripcion, Mantenimiento) values (2,'Honda CRV 2015 Touring', 0);

;
