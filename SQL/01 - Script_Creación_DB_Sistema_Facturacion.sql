/****************************************************************************************
Procedimiento			: Script_Creación_DB_Sistema_Facturacion.sql
Objetivo Descripcion	: Se crea la base de datos para sistema de facturación.
Sistema					: SISFAC
Base de Datos			: SisFac
Tablas usadas			: Cargos, Categorias, Ciudades, Clientes, DetallesVenta,
						  Empleados, Productos, Regiones, Ventas.
Parametros entrada		: 
Parametros salida		: 
Cadena ejecución		: 
Autor					: Omar Carmona, Jesús Parra, Estaban Valdevenito
Fecha creación			: 09/05/2013
****************************************************************************************/

USE master
GO

IF ( EXISTS ( SELECT    name
              FROM      master.dbo.sysdatabases
              WHERE     ( '[' + name + ']' = N'SisFac'
                          OR name = N'SisFac'
                        ) ) )
    DROP DATABASE SisFac

CREATE DATABASE SisFac
GO

USE SisFac;
GO

/*==============================================================*/
/* Table: Cargos                                                */
/*==============================================================*/
CREATE TABLE Cargos
    (
      idCargo INT IDENTITY ,
      Cargo VARCHAR(15) NOT NULL ,
      CONSTRAINT PK_CARGOS PRIMARY KEY ( idCargo )
    )
GO

/*==============================================================*/
/* Table: Categorias                                            */
/*==============================================================*/
CREATE TABLE Categorias
    (
      idCategoria INT IDENTITY ,
      Categoria VARCHAR(20) NOT NULL ,
      CONSTRAINT PK_CATEGORIAS PRIMARY KEY ( idCategoria )
    )
GO

DECLARE @CurrentUser SYSNAME
SELECT  @CurrentUser = USER_NAME()
EXECUTE sys.sp_addextendedproperty 'MS_Description',
    'Tabla de Categoria de Productos', 'user', @CurrentUser, 'table',
    'Categorias'
GO

/*==============================================================*/
/* Table: Ciudades                                              */
/*==============================================================*/
CREATE TABLE Ciudades
    (
      idCiudad INT IDENTITY ,
      idRegion INT NULL ,
      Ciudad VARCHAR(25) NOT NULL ,
      CONSTRAINT PK_CIUDADES PRIMARY KEY ( idCiudad )
    )
GO

DECLARE @CurrentUser SYSNAME
SELECT  @CurrentUser = USER_NAME()
EXECUTE sys.sp_addextendedproperty 'MS_Description', 'Tabla de Ciudades',
    'user', @CurrentUser, 'table', 'Ciudades'
GO

/*==============================================================*/
/* Table: Clientes                                              */
/*==============================================================*/
CREATE TABLE Clientes
    (
      RUT INT NOT NULL ,
      RUTVer VARCHAR(1) NOT NULL ,
      Empresa BIT NOT NULL ,
      Nombres VARCHAR(30) NOT NULL ,
      ApPaterno VARCHAR(30) NOT NULL ,
      ApMaterno VARCHAR(15) NOT NULL ,
      FechaNac DATE NULL ,
      Sexo BIT NULL ,
      Email VARCHAR(30) NULL ,
      Telefono INT NULL ,
      Direccion VARCHAR(30) NULL ,
      idRegion INT NULL ,
      idCiudad INT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_CLIENTES PRIMARY KEY ( RUT )
    )
GO

DECLARE @CurrentUser SYSNAME
SELECT  @CurrentUser = USER_NAME()
EXECUTE sys.sp_addextendedproperty 'MS_Description', 'Tabla de Clientes',
    'user', @CurrentUser, 'table', 'Clientes'
GO

/*==============================================================*/
/* Table: DetallesVenta                                         */
/*==============================================================*/
CREATE TABLE DetallesVenta
    (
      idDetalleVenta BIGINT IDENTITY ,
      idVenta INT NOT NULL ,
      idProducto INT NOT NULL ,
      Cantidad INT NOT NULL ,
      Valor INT NOT NULL ,
      CONSTRAINT PK_DETALLESVENTA PRIMARY KEY ( idDetalleVenta )
    )
GO

DECLARE @CurrentUser SYSNAME
SELECT  @CurrentUser = USER_NAME()
EXECUTE sys.sp_addextendedproperty 'MS_Description',
    'Tabla de Detalles de la Venta', 'user', @CurrentUser, 'table',
    'DetallesVenta'
GO

/*==============================================================*/
/* Table: Empleados                                             */
/*==============================================================*/
CREATE TABLE Empleados
    (
      RUT INT NOT NULL ,
      RUTVer VARCHAR(1) NOT NULL ,
      Nombres VARCHAR(20) NOT NULL ,
      ApPaterno VARCHAR(15) NOT NULL ,
      ApMaterno VARCHAR(15) NOT NULL ,
      FechaNac DATE NULL ,
      Sexo BIT NULL ,
      Email VARCHAR(30) NULL ,
      Telefono INT NULL ,
      Direccion VARCHAR(30) NULL ,
      idRegion INT NULL ,
      idCiudad INT NULL ,
      idCargo INT NOT NULL ,
      Password VARCHAR(10) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_EMPLEADOS PRIMARY KEY ( RUT )
    )
GO

DECLARE @CurrentUser SYSNAME
SELECT  @CurrentUser = USER_NAME()
EXECUTE sys.sp_addextendedproperty 'MS_Description', 'Tabla de Empleados',
    'user', @CurrentUser, 'table', 'Empleados'
GO

/*==============================================================*/
/* Table: Productos                                             */
/*==============================================================*/
CREATE TABLE Productos
    (
      idProducto INT IDENTITY ,
      idCategoria INT NOT NULL ,
      Producto VARCHAR(25) NOT NULL ,
      Cantidad INT NOT NULL ,
      Valor INT NOT NULL ,
      Comentario VARCHAR(60) NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_PRODUCTOS PRIMARY KEY ( idProducto )
    )
GO

DECLARE @CurrentUser SYSNAME
SELECT  @CurrentUser = USER_NAME()
EXECUTE sys.sp_addextendedproperty 'MS_Description', 'Tabla de Productos',
    'user', @CurrentUser, 'table', 'Productos'
GO

/*==============================================================*/
/* Table: Regiones                                              */
/*==============================================================*/
CREATE TABLE Regiones
    (
      idRegion INT IDENTITY ,
      Region VARCHAR(25) NOT NULL ,
      CONSTRAINT PK_REGIONES PRIMARY KEY ( idRegion )
    )
GO

DECLARE @CurrentUser SYSNAME
SELECT  @CurrentUser = USER_NAME()
EXECUTE sys.sp_addextendedproperty 'MS_Description', 'Tabla de Regiones',
    'user', @CurrentUser, 'table', 'Regiones'
GO

/*==============================================================*/
/* Table: Ventas                                                */
/*==============================================================*/
CREATE TABLE Ventas
    (
      idVenta INT IDENTITY ,
      TipoVenta INT NOT NULL ,
      RUTEmpleado INT NOT NULL ,
      RUTCliente INT NOT NULL ,
      Fecha DATE NOT NULL ,
      Descuento INT NULL ,
      Pagado BIT NULL ,
      Entregado BIT NULL ,
      CONSTRAINT PK_VENTAS PRIMARY KEY ( idVenta )
    )
GO

DECLARE @CurrentUser SYSNAME
SELECT  @CurrentUser = USER_NAME()
EXECUTE sys.sp_addextendedproperty 'MS_Description',
    'Tabla de Boleta o Factura', 'user', @CurrentUser, 'table', 'Ventas'
GO

ALTER TABLE Ciudades
ADD CONSTRAINT FK_CIUDADES_REFERENCE_REGIONES FOREIGN KEY (idRegion)
REFERENCES Regiones (idRegion)
GO

ALTER TABLE Clientes
ADD CONSTRAINT FK_CLIENTES_REFERENCE_REGIONES FOREIGN KEY (idRegion)
REFERENCES Regiones (idRegion)
GO

ALTER TABLE Clientes
ADD CONSTRAINT FK_CLIENTES_REFERENCE_CIUDADES FOREIGN KEY (idCiudad)
REFERENCES Ciudades (idCiudad)
GO

ALTER TABLE DetallesVenta
ADD CONSTRAINT FK_DETALLES_REFERENCE_PRODUCTO FOREIGN KEY (idProducto)
REFERENCES Productos (idProducto)
GO

ALTER TABLE DetallesVenta
ADD CONSTRAINT FK_DETALLES_REFERENCE_VENTAS FOREIGN KEY (idVenta)
REFERENCES Ventas (idVenta)
GO

ALTER TABLE Empleados
ADD CONSTRAINT FK_EMPLEADO_REFERENCE_CIUDADES FOREIGN KEY (idCiudad)
REFERENCES Ciudades (idCiudad)
GO

ALTER TABLE Empleados
ADD CONSTRAINT FK_EMPLEADO_REFERENCE_REGIONES FOREIGN KEY (idRegion)
REFERENCES Regiones (idRegion)
GO

ALTER TABLE Empleados
ADD CONSTRAINT FK_EMPLEADO_REFERENCE_CARGOS FOREIGN KEY (idCargo)
REFERENCES Cargos (idCargo)
GO

ALTER TABLE Productos
ADD CONSTRAINT FK_PRODUCTO_REFERENCE_CATEGORI FOREIGN KEY (idCategoria)
REFERENCES Categorias (idCategoria)
GO

ALTER TABLE Ventas
ADD CONSTRAINT FK_VENTAS_REFERENCE_EMPLEADO FOREIGN KEY (RUTEmpleado)
REFERENCES Empleados (RUT)
GO

ALTER TABLE Ventas
ADD CONSTRAINT FK_VENTAS_REFERENCE_CLIENTES FOREIGN KEY (RUTCliente)
REFERENCES Clientes (RUT)
GO

