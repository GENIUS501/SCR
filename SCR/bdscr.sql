CREATE DATABASE SCR
GO 

USE SCR
GO

CREATE TABLE Roles
(
	Id_Rol	Int PRIMARY KEY NOT NULL,
	Nombre_Rol	VARCHAR(30) NOT NULL
);

CREATE TABLE Usuarios
(
	Cedula	INT UNIQUE NOT NULL,
	Nombre_Usuario VARCHAR(25) PRIMARY KEY NOT NULL,
	Nombre	Varchar(25) NOT NULL,
	Primer_Apellido	Varchar(25) NOT NULL,
	Segundo_Apellido Varchar(25) NOT NULL,
	Clave	Varchar(max) NOT NULL,
	Sexo Varchar(1),
	Id_Rol	INT NOT NULL,
	CONSTRAINT Fk_Usu_Rol FOREIGN KEY(Id_Rol) REFERENCES Roles(Id_Rol)
);

CREATE TABLE Accesos
(	
	Id_Rol	INT NOT NULL ,
	Modulo	INT NOT NULL,
	Accion	VARCHAR(10),
	PRIMARY KEY(Id_Rol,Modulo,Accion),
	CONSTRAINT Fk_Acc_Rol FOREIGN KEY(Id_Rol) REFERENCES Roles(Id_Rol)
);

CREATE TABLE Ingresos_Salidas
(	
	Id	INT PRIMARY KEY IDENTITY(1,1),
	Fecha_Hora_Ingreso	DATETIME NOT NULL,
	Fecha_Hora_Salida	DATETIME,
	Nombre_Usuario	VARCHAR(25)NOT NULL,
	CONSTRAINT Fk_Ing_Usu FOREIGN KEY(Nombre_Usuario) REFERENCES Usuarios(Nombre_Usuario)
);

CREATE TABLE Acciones_Realizadas
(	
	Fecha	DATETIME NOT NULL,
	Id_Accion	INT PRIMARY KEY IDENTITY(1,1),
	Accion	VARCHAR(16) NOT NULL,
	Tabla	VARCHAR(25) NOT NULL,
	Nombre_Usuario	VARCHAR(25) NOT NULL,
	CONSTRAINT Fk_Acr_Usu FOREIGN KEY(Nombre_Usuario) REFERENCES Usuarios(Nombre_Usuario)
);

CREATE TABLE Productos
(
	Codigo_Producto INT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(30) NOT NULL,
	Descripcion VARCHAR(MAX),
	Marca VARCHAR(30) NOT NULL
);

CREATE TABLE Punto_Venta_Cliente
(
	Nombre VARCHAR(40) NOT NULL,
	Direccion VARCHAR(MAX),
	Telefono INT,
	CorreoElectronico VARCHAR(30),
	Cedula_juridica_fisica BIGINT PRIMARY KEY
);

CREATE TABLE Supervisores
(
	Cedula BIGINT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(25) NOT NULL,
	Primer_Apellido VARCHAR(25) NOT NULL,
	Segundo_Apellido VARCHAR(25) NOT NULL,
	Correo VARCHAR(25) NOT NULL,
	Telefono INT NOT NULL
);
CREATE TABLE Zonas
(
	Id_Zona INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nombre_Zona VARCHAR(30) NOT NULL
);
CREATE TABLE Faltantes
(
	Id_Registro INT PRIMARY KEY IDENTITY(1,1),
	Codigo_Producto INT NOT NULL,
	Cedula BIGINT NOT NULL,
	Sugeridos VARCHAR(25),
	Fecha_Mes VARCHAR(MAX) NOT NULL,
	Cantidad INT NOT NULL,
	Usuario VARCHAR(25) NOT NULL,
	CONSTRAINT Fk_Fal_Usu FOREIGN KEY(Usuario) REFERENCES Usuarios(Nombre_Usuario),
	CONSTRAINT Fk_Fal_Pro FOREIGN KEY(Codigo_Producto) REFERENCES Productos(Codigo_Producto),
	CONSTRAINT Fk_Fal_Pun FOREIGN KEY(Cedula) REFERENCES Punto_Venta_Cliente(Cedula_juridica_fisica)
);

CREATE TABLE Vencimiento_Productos
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Fecha_reporte_vencimiento DATETIME NOT NULL,
	Fecha_vencimiento_producto DATETIME NOT NULL,
	tiempo_reaccion FLOAT NOT NULL,
	Cedula_Supervisor BIGINT NOT NULL,
	Zona INT NOT NULL,
	Cliente BIGINT NOT NULL,
	Descripcion_SKU VARCHAR(MAX),
	UnidadesxSKU INT,
	Observaciones VARCHAR(MAX),
	Seguimiento_3_meses VARCHAR(2),
	Seguimiento_5_meses VARCHAR(2),
	Usuario VARCHAR(25) NOT NULL,
	CONSTRAINT Fk_Ven_Usu FOREIGN KEY(Usuario) REFERENCES Usuarios(Nombre_Usuario),
	CONSTRAINT Fk_Ven_Sup FOREIGN KEY(Cedula_Supervisor) REFERENCES Supervisores(Cedula),
	CONSTRAINT Fk_Ven_Zon FOREIGN KEY(Zona) REFERENCES Zonas(Id_Zona)
);
insert into Roles (Id_Rol,Nombre_Rol) values(1,'Administrador')
--Roles
insert into Accesos (Id_Rol,Modulo,Accion) values(1,1,'Agregar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,1,'Modificar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,1,'Eliminar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,1,'Consultar')
--Usuarios
insert into Accesos (Id_Rol,Modulo,Accion) values(1,2,'Agregar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,2,'Modificar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,2,'Eliminar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,2,'Consultar')
--Productos
insert into Accesos (Id_Rol,Modulo,Accion) values(1,3,'Agregar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,3,'Modificar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,3,'Eliminar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,3,'Consultar')
--Punto-venta
insert into Accesos (Id_Rol,Modulo,Accion) values(1,4,'Agregar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,4,'Modificar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,4,'Eliminar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,4,'Consultar')
--Supervisores
insert into Accesos (Id_Rol,Modulo,Accion) values(1,5,'Agregar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,5,'Modificar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,5,'Eliminar')
insert into Accesos (Id_Rol,Modulo,Accion) values(1,5,'Consultar')
--Proceso Faltante Productos
insert into Accesos (Id_Rol,Modulo,Accion) values(1,6,'Modulo')
--Proceso vencimiento Productos
insert into Accesos (Id_Rol,Modulo,Accion) values(1,7,'Modulo')
--Reporte vencimiento Productos
insert into Accesos (Id_Rol,Modulo,Accion) values(1,8,'Modulo')
--Reporte faltante de productos
insert into Accesos (Id_Rol,Modulo,Accion) values(1,9,'Modulo')
--Reporte de Punto de venta
insert into Accesos (Id_Rol,Modulo,Accion) values(1,10,'Modulo')
--Bitacora Sesiones
insert into Accesos (Id_Rol,Modulo,Accion) values(1,11,'Modulo')
--Bitacora Movimiento
insert into Accesos (Id_Rol,Modulo,Accion) values(1,12,'Modulo')
--Agrega el usuario
insert into Usuarios (Nombre,Cedula,Nombre_Usuario,Primer_Apellido,Segundo_Apellido,Clave,Sexo,Id_Rol) values('Admin',123456789,'Admin','Admin','Admin','rIQeOq7XMQ4ZE1g/tfO3/Da5jKI=','M',1)