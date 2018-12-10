USE Notas
GO

CREATE PROCEDURE sp_InsertarCarrera(
	@descripcion NVARCHAR(45)
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Carreras.descripcion) FROM SCN.Carreras WHERE descripcion=@descripcion;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe una Carrera con el nombre "%s"', 16, 1, @descripcion);
			RETURN 0
		END
	ELSE
		BEGIN
			INSERT INTO SCN.Carreras(descripcion)
				VALUES(@descripcion)
			RETURN 1
		END
END
GO

CREATE PROCEDURE sp_ActualizarCarrera(
	@descripcion NVARCHAR(45),
	@descripcionNueva NVARCHAR(45)	
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Carreras.descripcion) FROM SCN.Carreras WHERE descripcion=@descripcionNueva;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe una Carrera con el nombre "%s"', 16, 1, @descripcionNueva);
			RETURN 0
		END
	ELSE
		BEGIN
		UPDATE SCN.Carreras SET descripcion = @descripcionNueva WHERE descripcion = @descripcion
		END
END
GO

CREATE PROCEDURE sp_InhabilitarCarrera(
	@descripcion NVARCHAR(45)
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;
	SELECT @existe = COUNT(SCN.Carreras.descripcion) FROM SCN.Carreras WHERE descripcion=@descripcion AND habilitado = 0
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'La Carrera "%s" ya está inhabilitada', 16, 1, @descripcion);
			RETURN 0
		END
	ELSE
		BEGIN
		UPDATE SCN.Carreras SET habilitado = 0 WHERE descripcion = @descripcion
		END

END
GO

CREATE PROCEDURE sp_HabilitarCarrera(
	@codigo INT
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;
	SELECT @existe = COUNT(SCN.Carreras.codigo) FROM SCN.Carreras WHERE codigo = @codigo AND habilitado = 1
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'La Carrera ya está habilitada', 16, 1);
			RETURN 0
		END
	ELSE
		BEGIN
		UPDATE SCN.Carreras SET habilitado = 1 WHERE codigo = @codigo;
		END

END
GO
