USE Notas
GO

CREATE PROCEDURE sp_ReporteCalificaciones(
	@clase NVARCHAR(45),
	@periodo NVARCHAR(20)
)
AS
BEGIN
	DECLARE @codigoClase INT
	SET @codigoClase = (SELECT codigo FROM SCN.Clases WHERE nombre = @clase)

	DECLARE @codigoPeriodo INT
	SET @codigoPeriodo = (SELECT codigo FROM SCN.Periodos WHERE descripcion = @periodo)

	DECLARE @aprobados INT
	SET @aprobados = 0;

	SELECT @aprobados = (SELECT COUNT(SCN.Calificaciones.codigo) AS 'Aprobados'
	FROM SCN.Calificaciones
	INNER JOIN SCN.Registro
	ON SCN.Registro.codigo = SCN.Calificaciones.Registro_codigo
	INNER JOIN SCN.Periodos
	ON SCN.Periodos.codigo = SCN.Registro.Periodos_codigo
	INNER JOIN SCN.Clases
	ON SCN.Clases.codigo = SCN.Registro.Clases_codigo
	WHERE SCN.Calificaciones.promedio > 70
	AND SCN.Periodos.codigo = @codigoPeriodo
	AND SCN.Clases.codigo = @codigoClase)

	DECLARE @reprobados INT
	SET @reprobados = 0;

	SELECT @reprobados = (SELECT COUNT(SCN.Calificaciones.codigo) AS 'Reprobados'
	FROM SCN.Calificaciones
	INNER JOIN SCN.Registro
	ON SCN.Registro.codigo = SCN.Calificaciones.Registro_codigo
	INNER JOIN SCN.Periodos
	ON SCN.Periodos.codigo = SCN.Registro.Periodos_codigo
	INNER JOIN SCN.Clases
	ON SCN.Clases.codigo = SCN.Registro.Clases_codigo
	WHERE SCN.Calificaciones.promedio < 70
	AND SCN.Periodos.codigo = @codigoPeriodo
	AND SCN.Clases.codigo = @codigoClase)

	SELECT						ca.nota1,
			                    ca.nota2,
			                    ca.nota3,
			                    ca.promedio,
                                a.nombres,
                                a.apellidos,
                                cl.nombre,
                                p.descripcion,
                                p.anio,
								@aprobados,
								@reprobados
                    FROM SCN.Periodos as p
                    INNER JOIN SCN.Registro as r
                    ON p.codigo = r.Periodos_codigo
                    INNER JOIN SCN.Clases as cl
                    ON cl.codigo = r.Clases_codigo
                    INNER JOIN SCN.Alumnos as a
                    ON a.id = r.Alumnos_id
                    INNER JOIN SCN.Calificaciones as ca
                    ON ca.Registro_codigo = r.codigo
                    WHERE r.Clases_codigo = @codigoClase
					AND r.Periodos_codigo = @codigoPeriodo
                    AND r.estadoCalificacion = 1;
END
GO
