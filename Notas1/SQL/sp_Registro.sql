USE Notas
GO

CREATE PROCEDURE sp_InsertarRegistro(
	@fecha DATETIME,
	@alumnosId INT,
	@clasescodigo INT,
	@periodosCodigo INT
)
AS
BEGIN
	DECLARE @existeRegistro INT;
	SET @existeRegistro = 0;

	SELECT @existeRegistro = COUNT(SCN.Registro.codigo) FROM SCN.Registro WHERE Alumnos_id = @alumnosId AND Clases_codigo = @clasescodigo AND Periodos_codigo = @periodosCodigo;
	IF (@existeRegistro > 0)
		BEGIN
			RAISERROR(N'El Alumno ya registró la clase "%s"', 16, 1);
			RETURN 0
		END
	ELSE
		BEGIN
			DECLARE @existeCalificacion INT;
			SET @existeCalificacion = 0;

			SELECT @existeCalificacion = COUNT(c.codigo) FROM SCN.Calificaciones AS c
														 INNER JOIN SCN.Registro AS r
														 ON c.Registro_codigo = r.codigo
														 INNER JOIN SCN.Alumnos as a
														 ON a.id = r.Alumnos_id
														 INNER JOIN SCN.Clases as cl
														 ON cl.codigo = r.Clases_codigo
														 WHERE a.id = @alumnosId
														 AND cl.codigo = @clasescodigo
														 AND c.promedio >= 70
			IF (@existeCalificacion > 0)
				BEGIN
					RAISERROR(N'El alumno ya aprobó la clase', 16, 1);
					RETURN 0
				END
			ELSE
				BEGIN
					INSERT INTO SCN.Registro(fecha, Alumnos_id, Clases_codigo, Periodos_codigo)
						VALUES(@fecha, @alumnosId, @clasescodigo, @periodosCodigo)
				END
		END
END
GO

CREATE PROCEDURE sp_ActualizarRegistro(
	@codigoRegistro INT,
	@fecha DATETIME,
	@alumnosId INT,
	@clasescodigo INT,
	@periodosCodigo INT,
	@alumnosIdNuevo INT,
	@clasescodigoNuevo INT,
	@periodosCodigoNuevo INT
)
AS
BEGIN
	DECLARE @estadoCalificacion INT;
	SET @estadoCalificacion = 0;

	SET @estadoCalificacion = (SELECT SCN.Registro.estadoCalificacion FROM SCN.Registro WHERE codigo = @codigoRegistro)
	IF(@estadoCalificacion = 1)
		BEGIN
			RAISERROR(N'El Alumno ya fue calificado, no se puede modificar el registro"', 16, 1);
			RETURN 0
		END
	ELSE
		BEGIN
			DECLARE @existeRegistro INT;
			SET @existeRegistro = 0;

			SELECT @existeRegistro = COUNT(SCN.Registro.codigo) FROM SCN.Registro WHERE Alumnos_id = @alumnosIdNuevo AND Clases_codigo = @clasescodigoNuevo  AND Periodos_codigo = @periodosCodigoNuevo;
			IF (@existeRegistro > 0)
				BEGIN
					RAISERROR(N'El Alumno ya registró la clase "%s"', 16, 1);
					RETURN 0
				END
			ELSE
				BEGIN
					DECLARE @existeCalificacion INT;
					SET @existeCalificacion = 0;
					
					SELECT @existeCalificacion = COUNT(c.codigo) FROM SCN.Calificaciones AS c
														 INNER JOIN SCN.Registro AS r
														 ON c.Registro_codigo = r.codigo
														 INNER JOIN SCN.Alumnos as a
														 ON a.id = r.Alumnos_id
														 INNER JOIN SCN.Clases as cl
														 ON cl.codigo = r.Clases_codigo
														 WHERE a.id = @alumnosIdNuevo
														 AND cl.codigo = @clasescodigoNuevo 
														 AND c.promedio >= 70

					IF (@existeCalificacion > 0)
						BEGIN
							RAISERROR(N'El alumno ya aprobó la clase', 16, 1);
							RETURN 0
						END
					ELSE
						BEGIN
							DECLARE @periodo INT;
							SET @periodo = 0;

							SET @periodo = (SELECT r.Periodos_codigo
											FROM SCN.Registro as r
											INNER JOIN SCN.Calificaciones as c
											ON r.codigo = c.Registro_codigo
											INNER JOIN SCN.Alumnos as a
											ON a.id = r.Alumnos_id
											INNER JOIN SCN.Clases as cl
											ON cl.codigo = r.Clases_codigo
											WHERE a.id = @alumnosIdNuevo
											AND cl.codigo = @clasescodigoNuevo
											AND c.promedio < 70);

							IF(@periodo = @periodosCodigoNuevo)
								BEGIN
									RAISERROR(N'No se puede registrar en ese periodo', 16, 1);
									RETURN 0
								END
							ELSE
								BEGIN
									UPDATE SCN.Registro SET Alumnos_id = @alumnosIdNuevo, Clases_codigo = @clasescodigoNuevo, Periodos_codigo = @periodosCodigoNuevo WHERE SCN.Registro.codigo = @codigoRegistro;
								END
						END
				END
		END
END
GO