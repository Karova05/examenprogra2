CREATE DATABASE TALLERUH

GO

USE TALLERUH

GO

CREATE TABLE usuarios

(

usuarioID int identity (2,2) PRIMARY KEY,

nombre varchar (50) NOT NULL,

correoelectronico varchar (50) NOT NULL,

telefono int

)

GO

CREATE TABLE equipos

(

equipoID int identity (1,1) PRIMARY KEY,

tipoequipo varchar (50) NOT NULL,

modelo varchar	(50) NOT NULL,

usuarioID int NOT NULL,

CONSTRAINT fk_usuarioID FOREIGN KEY (usuarioID) REFERENCES usuarios (usuarioID)

)


GO

CREATE TABLE reparaciones

(

reparacionID int identity (3,3) PRIMARY KEY,

fechasolicitud DATETIME CONSTRAINT fa_fechasolicitud DEFAULT GETDATE(),

equipoID int NOT NULL,

estado varchar (50) NOT NULL,

CONSTRAINT fk_equipoID FOREIGN KEY (equipoID) REFERENCES equipos (equipoID)

)

GO

CREATE TABLE detallesReparaciones

(

detalleID int identity (5,5) PRIMARY KEY,

descripcion varchar (200) NOT NULL,

fechainicio DATETIME  CONSTRAINT fa_fechainicio DEFAULT GETDATE(),

fechafin DATETIME  CONSTRAINT fa_fechafin DEFAULT GETDATE(),

reparacionID1 int NOT NULL,

CONSTRAINT fk_reparacionID1 FOREIGN KEY (reparacionID1) REFERENCES reparaciones (reparacionID)

)

GO

CREATE TABLE tecnicos

(

tecnicoID int identity (4,4) PRIMARY KEY,

nombre varchar (50) NOT NULL,

especialidad varchar (50) NOT NULL,

)

GO

CREATE TABLE asignaciones

(

asignacionID int identity (6,6) PRIMARY KEY,

fechaasignacion DATETIME CONSTRAINT fa_fechaasignacion DEFAULT GETDATE(),

reparacionID2 int NOT NULL,

tecnicoID int NOT NULL,

CONSTRAINT fk_reparacionID2 FOREIGN KEY (reparacionID2) REFERENCES reparaciones (reparacionID),

CONSTRAINT fk_tecnicoID FOREIGN KEY (tecnicoID) REFERENCES tecnicos (tecnicoID)

)

