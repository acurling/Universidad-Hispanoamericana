

CREATE DATABASE CUESTIONARIO

--Crear Tablas

CREATE TABLE USUARIOS

(
   Cedula varchar (50) primary key,
   Nombre varchar (50),
   Genero varchar (50),
   Fecha varchar (50)
)

CREATE TABLE RESPUESTA

(
  RespuestaA varchar (50), 
  RespuestaB varchar (50),
  RespuestaC varchar (50)
)

-- Eliminar Tablas

DROP TABLE USUARIOS
DROP TABLE RESPUESTA

--Modificar tabla

ALTER TABLE RESPUESTAS

--Ingreso de registros

INSERT INTO USUARIOS (Cedula,Nombre,Genero,Fecha) values ('1','JOSE','M','21/10/2021')

INSERT INTO RESPUESTA (RespuestaA,RespuestaB,RespuestaC) values ('','','')

-- Consulta de datos

SELECT * FROM USUARIOS
SELECT * FROM RESPUESTA

--Actualizar tablas

UPDATE USUARIOS SET Nombre = @Nombre, Genero = @Genero WHERE Cedula @Cedula

-- Borrar

DELETE USUARIOS WHERE Cedula = @Cedula