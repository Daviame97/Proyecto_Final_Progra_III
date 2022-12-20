
USE DB_CLUB_CAMPESTRE_UAM
GO
-- INSERT //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------ TABLAS PADRES
--  ********************* TB_CLUB *********************************

INSERT INTO [SCH_CLUB].[TB_CLUB]
([CED_JUR],[NOMBRE],[TEL],[E_MAIL])
VALUES('3-222-2312','Club UAM','22077000','SOPORTE@UAMCR.NET')
GO

SELECT *
FROM [SCH_CLUB].[TB_CLUB]
GO

-- ********************* TB_CLIENTES *********************

INSERT INTO [SCH_PERSONA].[TB_CLIENTES]
([CED],[NOMBRE],[APELLIDO],[EDAD],[GENERO])
VALUES('305080556','KEVIN','MASIS',25,'Masculino')
GO

SELECT *
FROM [SCH_PERSONA].[TB_CLIENTES]
GO

-- ********************* TB_TIPO_HABITACION *********************
INSERT INTO [SCH_CLUB].[TB_TIPO_HABITACIONES]
([CODIGO],[MODELO],[CANT_CAMAS],[CANT_HABITACIONES],[TV],[JACUZZI],[PRECIO])
VALUES(1,'BASICA',2,1,0,1,100000.00)
GO
INSERT INTO [SCH_CLUB].[TB_TIPO_HABITACIONES]
([CODIGO],[MODELO],[CANT_CAMAS],[CANT_HABITACIONES],[TV],[JACUZZI],[PRECIO])
VALUES(2,'ESTANDAR',4,2,0,1,150000.00)
GO
INSERT INTO [SCH_CLUB].[TB_TIPO_HABITACIONES]
([CODIGO],[MODELO],[CANT_CAMAS],[CANT_HABITACIONES],[TV],[JACUZZI],[PRECIO])
VALUES(3,'SUPREMA',4,2,0,1,300000.00)
GO

SELECT *
FROM [SCH_CLUB].[TB_TIPO_HABITACIONES]
GO
----------------------- TABLAS HIJOS
-- ********************* TB_FACTURA *********************
INSERT INTO [SCH_CLUB].[TB_FACTURA]
([COD_FACTURA],[FECHA],[DIRECCION],[CLIENTE],[TIPO_HABITACION])
VALUES(1,SYSDATETIME(),'Santiago - Paraiso','305080556',1)
GO

SELECT *
FROM [SCH_CLUB].[TB_FACTURA]
GO
-- ********************* TB_HABITACIONES *********************
INSERT INTO [SCH_CLUB].[TB_HABITACIONES]
([NUM_HABITACION],[TIPO_HABITACION])
VALUES(1,1)
GO
-- ********************* TB_COLABORADORES *********************
INSERT INTO [SCH_PERSONA].[TB_COLABORADOR]
([COLABORADOR_ID],[CEDULA],[NOMBRE],[APELLIDO],[EDAD],[GENERO],[EMPRESA])
VALUES(1,'107890987','JEFFERSON','SOTO',25,'MASCULINO','3-222-2312')
GO
-- ********************* TB_SERVICIOS *********************
INSERT INTO [SCH_CLUB].[TB_SERVICIOS]
([SERVICIO_ID],[TIPO_SERVICIO],[EMPRESA])
VALUES(1,'PISCINA','3-222-2312')
GO
INSERT INTO [SCH_CLUB].[TB_SERVICIOS]
([SERVICIO_ID],[TIPO_SERVICIO],[EMPRESA])
VALUES(2,'CANCHA FUT','3-222-2312')
GO
INSERT INTO [SCH_CLUB].[TB_SERVICIOS]
([SERVICIO_ID],[TIPO_SERVICIO],[EMPRESA])
VALUES(3,'CABAÑA','3-222-2312')
GO
-- ********************* TB_RESERVAS *********************
INSERT INTO [SCH_CLUB].[TB_RESERVAS]
([RESERVA_ID],[CANT_PERSONAS],[FECHA],[CLIENTE],[HABITACION],[EMPRESA])
VALUES(1,4,SYSDATETIME(),'305080556',1,'3-222-2312')
GO

-- UPDATE //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------ TABLAS PADRES
--  ********************* TB_CLUB *********************************
UPDATE [SCH_CLUB].[TB_CLUB] SET [E_MAIL] = 'INFO@CLUBUAM.COM' WHERE [CED_JUR] = '3-222-2312'
GO

-- ********************* TB_CLIENTES *********************
UPDATE [SCH_PERSONA].[TB_CLIENTES] SET [EDAD] = 24 WHERE [CED] = '305080556'
GO

-- ********************* TB_TIPO_HABITACION *********************
UPDATE [SCH_CLUB].[TB_TIPO_HABITACIONES] SET [PRECIO] = 15000 WHERE [CODIGO] = 1
GO

----------------------- TABLAS HIJOS
-- ********************* TB_FACTURA *********************
UPDATE [SCH_CLUB].[TB_FACTURA] SET [DIRECCION] = 'Distrito Santiago - Paraiso' WHERE [COD_FACTURA] = 1
GO

-- ********************* TB_HABITACIONES *********************
UPDATE [SCH_CLUB].[TB_HABITACIONES] SET [TIPO_HABITACION] = 2 WHERE [NUM_HABITACION] = 1
GO

-- ********************* TB_COLABORADORES *********************
UPDATE [SCH_PERSONA].[TB_COLABORADOR] SET [APELLIDO] = 'MANZANARES' WHERE [COLABORADOR_ID] = 1
GO

-- ********************* TB_SERVICIOS *********************
UPDATE [SCH_CLUB].[TB_SERVICIOS] SET [TIPO_SERVICIO] = 'PICNIC' WHERE [SERVICIO_ID] = 1
GO

-- ********************* TB_RESERVAS *********************
UPDATE [SCH_CLUB].[TB_RESERVAS] SET [CANT_PERSONAS] = 3 WHERE [RESERVA_ID] = 1
GO

-- DELETE //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
----------------------- TABLAS HIJOS
-- ********************* TB_FACTURA *********************
DELETE FROM [SCH_CLUB].[TB_FACTURA] WHERE [COD_FACTURA] = 1
GO
-- ********************* TB_RESERVAS *********************
DELETE FROM [SCH_CLUB].[TB_RESERVAS] WHERE [RESERVA_ID] = 1
GO
-- ********************* TB_COLABORADORES *********************
DELETE FROM [SCH_PERSONA].[TB_COLABORADOR] WHERE [COLABORADOR_ID] = 1
GO

-- ********************* TB_SERVICIOS *********************
DELETE FROM [SCH_CLUB].[TB_SERVICIOS] WHERE [SERVICIO_ID] = 1
GO
DELETE FROM [SCH_CLUB].[TB_SERVICIOS] WHERE [SERVICIO_ID] = 2
GO
DELETE FROM [SCH_CLUB].[TB_SERVICIOS] WHERE [SERVICIO_ID] = 3
GO

-- ********************* TB_HABITACIONES *********************
DELETE FROM [SCH_CLUB].[TB_HABITACIONES] WHERE [NUM_HABITACION] = 1
GO

------------------------ TABLAS PADRES
-- ********************* TB_CLIENTES *********************
DELETE FROM [SCH_PERSONA].[TB_CLIENTES] WHERE [CED] = '305080556'
GO

-- ********************* TB_TIPO_HABITACION *********************
DELETE FROM [SCH_CLUB].[TB_TIPO_HABITACIONES] WHERE [CODIGO] = 1
GO
DELETE FROM [SCH_CLUB].[TB_TIPO_HABITACIONES] WHERE [CODIGO] = 2
GO
DELETE FROM [SCH_CLUB].[TB_TIPO_HABITACIONES] WHERE [CODIGO] = 3
GO

--  ********************* TB_CLUB *********************************
DELETE FROM [SCH_CLUB].[TB_CLUB] WHERE [CED_JUR] = '3-222-2312'
GO

-- SELECT //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
SELECT ([COD_FACTURA]) AS [FACTURA DEL CLIENTE]
FROM [SCH_CLUB].[TB_FACTURA]
GO

SELECT [FECHA] AS [FECHA DE FACTURACION]
FROM [SCH_CLUB].[TB_FACTURA]
WHERE [CLIENTE] = ('305080556')
GO

SELECT [CLIENTE] AS [FACTURA DEL CLIENTE]
FROM [SCH_CLUB].[TB_FACTURA]
WHERE [CLIENTE] = ('305080556')
GO

SELECT * 
FROM [SCH_CLUB].[TB_FACTURA]
GO

SELECT ([CED]) AS [CEDULA DEL CLIENTE]
FROM [SCH_PERSONA].[TB_CLIENTES]
GO

SELECT COUNT([CLIENTE]) AS [CANTIDAD DE CLIENTES]
FROM [SCH_CLUB].[TB_FACTURA]
GO