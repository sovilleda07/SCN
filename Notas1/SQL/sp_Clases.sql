USE Notas
GO

CREATE PROCEDURE sp_InsertarClase(
	@nombre NVARCHAR(45),
	@creditos INT,
	@descripcionCarrera NVARCHAR(45)
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Clases.nombre) FROM SCN.Clases WHERE nombre = @nombre
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe una Clase con el nombre "%s"', 16, 1, @nombre);
			RETURN 0
		END
	ELSE
		BEGIN
			DECLARE @codigoCarrera INT

			SET @codigoCarrera = (SELECT codigo FROM SCN.Carreras WHERE descripcion = @descripcionCarrera)

			INSERT INTO SCN.Clases(nombre, creditos, Carreras_codigo)
				VALUES(@nombre, @creditos, @codigoCarrera)
		END
END
GO

CREATE PROCEDURE sp_ActualizarClase(
	@nombre NVARCHAR(45),
	@nombreNuevo NVARCHAR(45),
	@creditos INT,
	@descripcionCarrera NVARCHAR(45)
)
AS
BEGIN
	DECLARE @codigoCarrera INT
	SET @codigoCarrera = (SELECT codigo FROM SCN.Carreras WHERE descripcion = @descripcionCarrera)

	IF (@nombre = @nombreNuevo)
		BEGIN	
			UPDATE SCN.Clases SET creditos = @creditos, Carreras_codigo = @codigoCarrera WHERE nombre = @nombre
		END
	ELSE
		BEGIN
			DECLARE @existe INT;
			SET @existe = 0;
			SELECT @existe = COUNT(SCN.Clases.nombre) FROM SCN.Clases WHERE nombre = @nombreNuevo;
			IF (@existe > 0)
				BEGIN
					RAISERROR(N'Ya existe una Clase con el nombre "%s"', 16, 1, @nombreNuevo);
				END
			ELSE
				BEGIN
					UPDATE SCN.Clases SET nombre = @nombreNuevo, creditos = @creditos, Carreras_codigo = @codigoCarrera WHERE nombre = @nombre
				END
		END
END
GO

CREATE PROCEDURE sp_InhabilitarClase(
	@nombre NVARCHAR(45)
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;
	SELECT @existe = COUNT(SCN.Clases.nombre) FROM SCN.Clases WHERE nombre = @nombre AND habilitado = 0;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'La Clase "%s" ya está inhabilitada', 16, 1, @nombre);
			RETURN 0
		END
	ELSE
		BEGIN
		UPDATE SCN.Clases SET habilitado = 0 WHERE nombre = @nombre;
		END

END
GO

CREATE PROCEDURE sp_HabilitarClase(
	@nombre NVARCHAR(45)
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;
	SELECT @existe = COUNT(SCN.Clases.nombre) FROM SCN.Clases WHERE nombre = @nombre AND habilitado = 1;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'La Clase "%s" ya está Habilitada', 16, 1, @nombre);
			RETURN 0
		END
	ELSE
		BEGIN
		UPDATE SCN.Clases SET habilitado = 1 WHERE nombre = @nombre;
		END

END
GO