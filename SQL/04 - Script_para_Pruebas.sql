
USE SisFac;

INSERT  INTO dbo.Categorias ( Categoria )
VALUES  ( 'Computadores' )
      , ( 'Notebooks' )
      , ( 'Netbooks' )
      , ( 'Tarjetas video' )
      , ( 'Almacenamiento' )
      , ( 'Accesorios' )
      , ( 'Memorias' )
      , ( 'Software' )
      , ( 'Tablets' )
GO

INSERT  INTO dbo.Productos ( idCategoria, Producto, Cantidad, Valor, Comentario, Estado )
VALUES  ( 1, 'Compaq C3120', 5, 100000, 'P4 2.8Ghz, 2Gb Ram, 320Gb HDD', 1 )
	  , ( 1, 'Acer AZ1110-CR10', 3, 239000, 'AMD E1-1500 1480 MHz, 2Gb Ram, 500Gb HDD', 1 )
	  , ( 2, 'HP 420', 3, 250000, 'Core2Duo 2Ghz, 8Gb Ram, 500Gb HDD', 1 )
	  , ( 2, 'Lenovo H54', 1, 300000, 'i3 3Ghz, 2Gb Ram, 320Gb HDD', 1 )
	  , ( 2, 'Sony Vaio V320', 0, 500000, 'i7 3.4Ghz, 4Gb Ram, 1Tb HDD', 0 )
	  , ( 3, 'Samsung G123', 10, 150000, 'Atom 1Ghz, 1Gb Ram, 120Gb SDD', 1 )
	  , ( 3, 'Packard Bell DOTS-C-496', 2, 145000, ' Intel Atom 1.60GHz, 2Gb Ram, 350Gb SDD', 1 )
	  , ( 4, 'nVidia GeForce 520GX', 8, 29000, '1Gb GDDR3, HDMI, DVI', 1 )
	  , ( 4, 'Atti Radeon HD4000', 4, 21500, '2Gb GDDR3, HDMI, DVI', 1 )	  
	  , ( 5, 'Seagate 500Gb Sata', 0, 30000, '500Gb, 7200RPM, Sata 3', 1 )
	  , ( 5, 'Cruzer Micro 2.0', 7, 7500, '8gb', 1 )
	  , ( 6, 'Parlanes Sony', 11, 16000, '1000 watts', 1 )
	  , ( 6, 'Audifonos Genius', 22, 5000, 'Modelo Chat', 1 )
      , ( 7, 'Kingstone 1Gb DDR3', 15, 20000, '1Gb, DDR3, 1333Mhz', 1 )
	  , ( 7, 'Kingstone 2Gb DDR3', 21, 27000, '2Gb, DDR3, 1480Mhz', 1 )
	  , ( 8, 'MS Windows 8', 3, 99000, 'Profesional Español', 1 )
	  , ( 8, 'MS Windows 7', 7, 75000, 'Ultimate Español', 1 )
	  , ( 9, 'Samsung Galaxy Tab 2', 4, 200000, 'DC 1.2Ghz, 1Gb Ram, 8Gb Rom', 1 )
	  , ( 9, 'Motorola Xoom', 2, 150000, 'DC 1Ghz, 1Gb Ram, 32Gb Rom', 1 )
	  

GO

INSERT  INTO dbo.Empleados ( RUT, RUTVer, Nombres, ApPaterno, ApMaterno, FechaNac, Sexo,
							 Email, Telefono, Direccion, idRegion, idCiudad, idCargo,
							 Password, Estado )
VALUES  ( 1, '9', 'Omar Eduardo', 'Carmona', 'Rivas', '1985-10-07', 1, 'ocarmona07@gmail.com', 82433600,
		  'Siena 01699', 10, 200, 4, '123456', 1 )
GO

INSERT  INTO dbo.Clientes ( RUT, RUTVer, Empresa, Nombres, ApPaterno, ApMaterno, FechaNac, Sexo,
							Email, Telefono, Direccion, idRegion, idCiudad, Estado )
VALUES  ( 2, '7', 0, 'Leonor Genoveva', 'Seguel', 'López', '1986-04-29', 0,
		  'leonor@gmail.com', 123456789, 'Portales 806', 10, 200, 1 )
GO
