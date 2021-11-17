CREATE DATABASE EXAMEN2DB



CREATE TABLE Clientes

(
   Cedula varchar (50) ,
   Nombre varchar (50)not null,	
   Telefono varchar (50)not null,
   Direccion varchar (50)not null
   Constraint PK_Clientes PRIMARY key(Cedula)

)

CREATE TABLE Facturacion
(
   NFactura varchar (50) ,
   CodigoServicio varchar (50)not null,	
   Mes varchar (50)not null,
   Monto varchar (50)not null,
   Descuento varchar (50)not null
   Constraint PK_Facturacion PRIMARY key(NFactura)

)




INSERT INTO Clientes (Cedula,Nombre,Telefono,Direccion) values ('1111','A','1111','A')

INSERT INTO Facturacion(NFactura, CodigoServicio, Mes, Monto, Descuento) values ('1111','1','A','11','11')

SELECT * FROM Clientes
SELECT * FROM Facturacion

DELETE Clientes WHERE Cedula = "Cedula"
DELETE Facturacion WHERE NFactura = "NFactura"