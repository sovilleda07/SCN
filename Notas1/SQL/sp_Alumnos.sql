USE Notas
GO

CREATE PROCEDURE sp_InsertarAlumno(
	@nombres NVARCHAR(45),
	@apellidos NVARCHAR(45),
	@telefono NVARCHAR(10),
	@correoElectronico NVARCHAR(50),
	@observaciones NVARCHAR(60),
	@descripcionCarrera NVARCHAR(45)
)
AS
BEGIN
	DECLARE @codigoCarrera INT
	SET @codigoCarrera = (SELECT codigo FROM SCN.Carreras WHERE descripcion = @descripcionCarrera)

	DECLARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Alumnos.id) FROM SCN.Alumnos WHERE nombres = @nombres AND apellidos = @apellidos AND Carreras_codigo = @codigoCarrera
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe una Alumno con los datos: "%s" "%s" ', 16, 1, @nombres, @apellidos);
			RETURN 0
		END
	ELSE
		BEGIN
			INSERT INTO SCN.Alumnos(nombres, apellidos, telefono, correoElectronico, observaciones, Carreras_codigo)
				VALUES(@nombres, @apellidos, @telefono, @correoElectronico, @observaciones, @codigoCarrera)
		END
END
GO

CREATE PROCEDURE sp_ActualizarAlumno(
	@id INT,
	@nombres NVARCHAR(45),
	@apellidos NVARCHAR(45),
	@telefono NVARCHAR(10),
	@correoElectronico NVARCHAR(50),
	@observaciones NVARCHAR(60),
	@descripcionCarrera NVARCHAR(45)
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Alumnos.id) FROM SCN.Alumnos WHERE id = @id
	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe ningún Alumno con los datos: "%s" "%s" ', 16, 1, @nombres, @apellidos);
			RETURN 0
		END
	ELSE
		BEGIN
			DECLARE @codigoCarrera INT
			SET @codigoCarrera = (SELECT codigo FROM SCN.Carreras WHERE descripcion = @descripcionCarrera)

			UPDATE SCN.Alumnos SET nombres = @nombres, apellidos = @apellidos, telefono = @telefono, correoElectronico = @correoElectronico,
									observaciones = @observaciones, Carreras_codigo = @codigoCarrera WHERE id = @id;							

		END					
END
GO

CREATE PROCEDURE sp_InhabilitarAlumno(
	@id INT
)
AS
BEGIN
	DECLARE @nombres NVARCHAR(45);
	DECLARE @apellidos NVARCHAR(45);

	SET @nombres = (SELECT nombres FROM SCN.Alumnos WHERE id =@id);
	SET @apellidos = (SELECT apellidos FROM SCN.Alumnos WHERE id =@id);

	DECLARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Alumnos.id) FROM SCN.Alumnos WHERE id = @id AND habilitado = 0
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'El Alumno "%s" "%s" ya está inhabilitado', 16, 1, @nombres, @apellidos)
			RETURN 0
		END
	ELSE
		BEGIN
			UPDATE SCN.Alumnos SET habilitado = 0 WHERE id = @id
		END
END
GO

CREATE PROCEDURE sp_HabilitarAlumno(
	@id INT
)
AS
BEGIN
	DECLARE @nombres NVARCHAR(45);
	DECLARE @apellidos NVARCHAR(45);

	SET @nombres = (SELECT nombres FROM SCN.Alumnos WHERE id =@id);
	SET @apellidos = (SELECT apellidos FROM SCN.Alumnos WHERE id =@id);

	DECLARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Alumnos.id) FROM SCN.Alumnos WHERE id = @id AND habilitado = 1
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'El Alumno "%s" "%s" ya está Habilitado', 16, 1, @nombres, @apellidos)
			RETURN 0
		END
	ELSE
		BEGIN
			UPDATE SCN.Alumnos SET habilitado = 1 WHERE id = @id
		END
END
GO