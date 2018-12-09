USE NOTAS
GO

CREATE PROCEDURE sp_InsertarCalificacion(
	@nota1 DECIMAL(5,2),
	@nota2 DECIMAL(5,2),
	@nota3 DECIMAL(5,2),
	@promedio DECIMAL(5,2),
	@codigoRegistro INT
)
AS
BEGIN
	DECLARE @existeCalificacion INT;
	SET @existeCalificacion = 0;

	SELECT @existeCalificacion = COUNT(SCN.Calificaciones.codigo) FROM SCN.Calificaciones WHERE Registro_codigo = @codigoRegistro;
	IF (@existeCalificacion > 0)
		BEGIN
			RAISERROR(N'El Alumno ya registró la clase "%s"', 16, 1);
			RETURN 0
		END
	ELSE
		BEGIN
			INSERT INTO SCN.Calificaciones(nota1, nota2, nota3, promedio, Registro_codigo)
				VALUES(@nota1, @nota2, @nota3, @promedio, @codigoRegistro)

			UPDATE SCN.Registro SET estadoCalificacion = 1 WHERE codigo = @codigoRegistro;
		END
END
GO

CREATE PROCEDURE sp_ActualizarCalificacion(
	@nota1 DECIMAL(5,2),
	@nota2 DECIMAL(5,2),
	@nota3 DECIMAL(5,2),
	@promedio DECIMAL(5,2),
	@codigoCalificacion INT
)
AS
BEGIN
	DECLARE @existe INT;
	SET @existe = 0;

	SELECT @existe = COUNT(SCN.Calificaciones.codigo) FROM SCN.Calificaciones WHERE codigo = @codigoCalificacion;
	IF (@existe = 0)
		BEGIN
			RAISERROR(N'No existe ninguna Calificacion con ese código', 16, 1);
			RETURN 0
		END
	ELSE
		BEGIN
			UPDATE SCN.Calificaciones SET nota1 = @nota1, nota2 = @nota2, nota3 = @nota3, promedio = @promedio WHERE codigo = @codigoCalificacion;
		END
END
GO