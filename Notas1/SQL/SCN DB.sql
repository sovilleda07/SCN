-- Seleccionar la base de datos por defecto
USE tempdb
GO

-- Eliminar la base de datos si existe
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'Notas')
	BEGIN
		DROP DATABASE Notas
	END
GO

-- Crear la base de datos
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Notas')
	BEGIN
		CREATE DATABASE Notas
	END
GO

-- Seleccionar la base de datos recién creada
USE Notas
GO

-- Crear Schemma
CREATE SCHEMA SCN
GO

-- Table: Alumnos
CREATE TABLE SCN.Alumnos (
    id int  NOT NULL IDENTITY(1,1),
    nombres NVARCHAR(45)  NOT NULL,
    apellidos NVARCHAR(45)  NOT NULL,
    telefono NVARCHAR(10)  NULL,
    correoElectronico NVARCHAR(50)  NULL,
    observaciones NVARCHAR(60)  NULL,
    habilitado int  NOT NULL,
    Carreras_codigo int  NOT NULL,
    CONSTRAINT PK_Alumnos_id PRIMARY KEY CLUSTERED (id)
);

-- Table: Calificaciones
CREATE TABLE SCN.Calificaciones (
    codigo int  NOT NULL IDENTITY(1,1),
    nota1 decimal(4,2)  NOT NULL,
    nota2 decimal(4,2)  NOT NULL,
    nota3 decimal(4,2)  NOT NULL,
    promedio decimal(4,2)  NOT NULL,
    Registro_codigo int  NOT NULL,
       CONSTRAINT PK_Calificaciones_codigo PRIMARY KEY CLUSTERED (codigo)
);

-- Table: Carreras
CREATE TABLE SCN.Carreras (
    codigo int  NOT NULL IDENTITY(1,1),
    descripcion NVARCHAR(45)  NOT NULL,
    habilitado int  NOT NULL,
    CONSTRAINT PK_Carreras_codigo PRIMARY KEY CLUSTERED (codigo)
);

-- Table: Clases
CREATE TABLE SCN.Clases (
    codigo int  NOT NULL IDENTITY(1,1),
    nombre NVARCHAR(45)  NOT NULL,
    creditos int  NULL,
    habilitado int  NOT NULL,
    Carreras_codigo int  NOT NULL,
    CONSTRAINT PK_Clases_codigo PRIMARY KEY CLUSTERED (codigo)
);

-- Table: Periodos
CREATE TABLE SCN.Periodos (
    codigo int  NOT NULL IDENTITY(1,1),
    descripcion NVARCHAR(20)  NOT NULL,
    anio NVARCHAR(5)  NOT NULL,
    periodo int  NOT NULL,
    habilitado int  NOT NULL,
    CONSTRAINT PK_Periodos_codigo PRIMARY KEY CLUSTERED (codigo)
);

-- Table: Registro
CREATE TABLE SCN.Registro (
    codigo int  NOT NULL IDENTITY(1,1),
    fecha datetime  NOT NULL,
    Alumnos_id int  NOT NULL,
    Clases_codigo int  NOT NULL,
    Periodos_codigo int  NOT NULL,
	estadoCalificacion int NOT NULL,
    CONSTRAINT PK_Registro_codigo PRIMARY KEY CLUSTERED  (codigo)
);

-- Table: Usuarios
CREATE TABLE SCN.Usuarios (
    usuario NVARCHAR(45)  NOT NULL,
    clave NVARCHAR(30)  NOT NULL,
    habilitado int  NOT NULL,
    CONSTRAINT PK_Usuario PRIMARY KEY CLUSTERED  (usuario)
);

-- foreign keys
-- Reference: Alumnos_Carreras (table: Alumnos)
ALTER TABLE SCN.Alumnos 
	ADD CONSTRAINT 
		FK_Alumnos_Carreras$TienenUna$Carrera
		FOREIGN KEY (Carreras_codigo) REFERENCES SCN.Carreras (codigo)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION;
GO

-- Reference: Calificaciones_Registro (table: Calificaciones)
ALTER TABLE SCN.Calificaciones
	ADD CONSTRAINT
		FK_Calificaciones_Registro$TieneUn$Registro
		FOREIGN KEY (Registro_codigo)
		REFERENCES SCN.Registro (codigo)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION;
GO

-- Reference: Clases_Carreras (table: Clases)
ALTER TABLE SCN.Clases 
	ADD CONSTRAINT
		FK_Clases_Carreras$PertenecenAUna$Carrera
		FOREIGN KEY (Carreras_codigo) REFERENCES SCN.Carreras (codigo)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION;
GO

-- Reference: Registro_Alumnos (table: Registro)
ALTER TABLE SCN.Registro 
	ADD CONSTRAINT 
		FK_Registro_Alumnos$TieneUn$Alumno
		FOREIGN KEY (Alumnos_id) REFERENCES SCN.Alumnos (id)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION;
GO

-- Reference: Registro_Clases (table: Registro)
ALTER TABLE SCN.Registro
	ADD CONSTRAINT
		FK_Registro_Clases$TieneUna$Clase
		FOREIGN KEY (Clases_codigo) REFERENCES SCN.Clases (codigo)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION;
GO

-- Reference: Registro_Periodos (table: Registro)
ALTER TABLE SCN.Registro
	ADD CONSTRAINT
		FK_Registro_Periodos$TieneUn$Periodo
		FOREIGN KEY (Periodos_codigo) REFERENCES SCN.Periodos (codigo)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION;
GO

-- Agregar CONSTRAINT de UNIQUE
ALTER TABLE SCN.Carreras
	ADD CONSTRAINT AK_Carrera_Nombre
		UNIQUE (descripcion)
GO

ALTER TABLE SCN.Clases
	ADD CONSTRAINT AK_Clases_Nombre
		UNIQUE (nombre)
GO

-- Agregar por defecto
ALTER TABLE SCN.Alumnos
	ADD CONSTRAINT DFLT_Alumnos_Habilitado
		DEFAULT '1' FOR habilitado
GO

ALTER TABLE SCN.Carreras
	ADD CONSTRAINT DFLT_Carreras_Habilitado
		DEFAULT '1' FOR habilitado
GO

ALTER TABLE SCN.Clases
	ADD CONSTRAINT DFLT_Clases_Habilitado
		DEFAULT '1' FOR habilitado
GO

ALTER TABLE SCN.Periodos
	ADD CONSTRAINT DFLT_Periodo_Habilitado
		DEFAULT '1' FOR habilitado
GO

ALTER TABLE SCN.Usuarios
	ADD CONSTRAINT DFLT_Usuario_Habilitado
		DEFAULT '1' FOR habilitado
GO

ALTER TABLE SCN.Registro
	ADD CONSTRAINT DFLT_Estado_Calificacion
		DEFAULT '0' FOR estadoCalificacion
GO

--INSERCIÓN DE DATOS PARA EL USUARIO
INSERT INTO SCN.Usuarios (usuario, clave)
VALUES ('admin', '1234')

SELECT * FROM SCN.Usuarios