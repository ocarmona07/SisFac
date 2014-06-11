IF EXISTS ( SELECT  *
            FROM    sys.objects
            WHERE   object_id = OBJECT_ID(N'[dbo].[PA_Documento_de_venta]')
                    AND type IN ( N'P', N'PC' ) ) 
    DROP PROCEDURE [dbo].[PA_Documento_de_venta] 
GO

CREATE PROCEDURE [dbo].[PA_Documento_de_venta] @idventa AS INT
AS /****************************************************************************************
Procedimiento			: PA_Documento_de_venta.sql
Objetivo Descripcion	: Entregar un documento para el pago del o los productos.
Sistema					: SISFAC
Base de Datos			: SisFac
Tablas usadas			: Clientes, DetallesVenta, Empleados, Productos, Ventas.
Parametros entrada		: @idventa
Parametros salida		: 
Cadena ejecución		: 
Autor					: Omar Carmona, Jesús Parra, Estaban Valdevenito
Fecha creación			: 12/06/2013
****************************************************************************************/

    SELECT  a.idVenta ,
            CONVERT(VARCHAR(15), a.RUTCliente) + '-' + b.RUTVer RUTCliente ,
            b.Nombres + ' ' + b.ApPaterno + ' ' + b.ApMaterno nombre_completo_cliente ,
            CONVERT(VARCHAR(15), a.RUTEmpleado) + '-' + c.RUTVer RUTEmpleado ,
            c.Nombres + ' ' + c.ApPaterno + ' ' + c.ApMaterno nombre_completo_empleado ,
            CASE a.TipoVenta
              WHEN 0 THEN 'Boleta'
              WHEN 1 THEN 'Factura'
            END TipoVenta ,
            a.Descuento ,
            d.idProducto ,
            e.Producto ,
            d.Valor ,
            d.Cantidad
    FROM    dbo.Ventas a
            INNER JOIN dbo.Clientes b ON a.RUTCliente = b.RUT
            INNER JOIN dbo.Empleados c ON a.RUTEmpleado = c.RUT
            INNER JOIN dbo.DetallesVenta d ON a.idVenta = d.idVenta
            INNER JOIN dbo.Productos e ON d.idProducto = e.idProducto
    WHERE   a.idVenta = @idventa
    