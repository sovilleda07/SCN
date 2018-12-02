USE Notas
GO

CREATE PROCEDURE sp_InsertarPeriodo(
	@descripcion NVARCHAR(20),
	@anio NVARCHAR(5),
	@periodo INT
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Periodos.descripcion) FROM SCN.Periodos WHERE descripcion = @descripcion AND anio = @anio AND periodo = @periodo;
	IF (@existe > 0)
		BEGIN
			RAISERROR(N'Ya existe un Periodo con la descripción "%s"', 16, 1, @descripcion);
			RETURN 0
		END
	ELSE
		BEGIN
			INSERT INTO SCN.Periodos(descripcion, anio, periodo)
				VALUES(@descripcion, @anio, @periodo)
		END
END
GO

CREATE PROCEDURE sp_ActualizarPeriodo(
	@codigoPeriodo INT,
	@descripcion NVARCHAR(20),
	@descripcionNueva NVARCHAR(20),
	@anio NVARCHAR(5),
	@periodo INT
)
AS
BEGIN
	IF(@descripcion = @descripcionNueva)
		BEGIN
			DECLARE @existe1 INT;
			SET @existe1 = 0;

			SELECT @existe1 = COUNT(SCN.Periodos.codigo) FROM SCN.Periodos WHERE descripcion = @descripcion AND anio = @anio AND periodo = @periodo;
			IF (@existe1 > 0)
				BEGIN
					RAISERROR(N'Ya existe un Periodo con esos datos', 16, 1);
				END
		ELSE
			BEGIN
				UPDATE SCN.Periodos SET anio = @anio, periodo = @periodo WHERE codigo = @codigoPeriodo;
			END
		END
	ELSE
		BEGIN
			DECLARE @existe2 INT;
			SET @existe2 = 0;

			SELECT @existe2 = COUNT(SCN.Periodos.codigo) FROM SCN.Periodos WHERE descripcion = @descripcionNueva AND anio = @anio AND periodo = @periodo;
			IF (@existe2 > 0)
				BEGIN
					RAISERROR(N'Ya existe un Periodo con esos datos', 16, 1);
				END
			ELSE
				BEGIN
					UPDATE SCN.Periodos SET descripcion = @descripcionNueva, anio = @anio, periodo = @periodo WHERE codigo = @codigoPeriodo;
				END

		END	

END
GO

CREATE PROCEDURE sp_InhabilitarPeriodo(
	@codigoPeriodo INT
)
AS
BEGIN
	DEClARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Periodos.codigo) FROM SCN.Periodos WHERE codigo = @codigoPeriodo AND habilitado = 0;
	IF(@existe > 0)
		BEGIN
			RAISERROR(N'El periodo "%s" ya está inhabilitado', 16, 1);
		END
	ELSE
		BEGIN
			UPDATE SCN.Periodos SET habilitado = 0 WHERE codigo = @codigoPeriodo
		END
END
GO

CREATE PROCEDURE sp_HabilitarPeriodo(
	@codigoPeriodo INT
)
AS
BEGIN
	DEClARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Periodos.codigo) FROM SCN.Periodos WHERE codigo = @codigoPeriodo AND habilitado = 1;
	IF(@existe > 0)
		BEGIN
			RAISERROR(N'El periodo "%s" ya está habilitado', 16, 1);
		END
	ELSE
		BEGIN
			UPDATE SCN.Periodos SET habilitado = 1 WHERE codigo = @codigoPeriodo
		END
END
GO