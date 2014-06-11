/****************************************************************************************
Procedimiento			: Script_Cargos para Empleados.sql
Objetivo Descripcion	: Ingresar cargos al sistema SisFac.
Sistema					: SISFAC
Base de Datos			: SisFac
Tablas usadas			: Cargos
Parametros entrada		: 
Parametros salida		: 
Cadena ejecución		: 
Autor					: Omar Carmona, Jesús Parra, Estaban Valdevenito
Fecha creación			: 09/05/2013
****************************************************************************************/

USE SisFac;

INSERT  INTO dbo.Cargos
VALUES  ( 'Bodeguero' )
		,
        ( 'Cajero' )
		,
        ( 'Vendedor' )
		,
        ( 'Administrador' )
GO