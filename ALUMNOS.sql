USE master;
DROP DATABASE IF EXISTS siia_uadec;
CREATE DATABASE siia_uadec;
go
USE siia_uadec;
GO

CREATE TABLE carrera(
id_carrera INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
carrera VARCHAR (MAX) NOT NULL
);
GO

INSERT INTO carrera VALUES ('Ingenieria En Sistemas Computacionales'), 
('Ingenieria Mecanico Electrica'), 
('Ingenieria Biomedica'),
('Ingenieria Mecatronica')
GO

CREATE TABLE persona(
id_persona INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
ap_paterno VARCHAR(MAX) NOT NULL,
ap_materno VARCHAR(MAX) NOT NULL,
nombres VARCHAR(MAX) NOT NULL,
correo VARCHAR(MAX) NOT NULL,
contrasenia VARCHAR(MAX) NOT NULL,
rol SMALLINT NOT NULL
);
GO

CREATE TABLE carrera_persona(
id_persona INT FOREIGN KEY REFERENCES persona(id_persona),
id_carrera INT FOREIGN KEY REFERENCES carrera(id_carrera)
)
GO

--StoreProcedure Registro carrera persona
CREATE PROCEDURE RegistroCerrera_Persona
@id_persona INT,
@id_carrera INT
AS BEGIN
INSERT INTO carrera_persona VALUES (@id_persona, @id_carrera)
END
GO

--StoreProcedure Registro Personas
CREATE PROCEDURE RegistroPersona
@ap_paterno VARCHAR(MAX),
@ap_materno VARCHAR(MAX),
@nombres VARCHAR(MAX),
@correo VARCHAR(MAX),
@contrasenia VARCHAR(MAX),
@rol SMALLINT
AS BEGIN
INSERT INTO persona VALUES (@ap_paterno, @ap_materno, @nombres, @correo, @contrasenia, @rol)
END
GO

INSERT INTO persona VALUES ('Puente', 'Cruz', 'Emmanuel', 'emmanuel_cruz', 'manu21291', 1),
('Chavana', 'Cazares', 'Cesar', 'cesar_chavana', 'chavana1234', 1),
('Garcia', 'Montoya', 'Jahir', 'jahir_garcia', 'garcia1234', 3),
('Ramos', 'Ruelas', 'Raul', 'raul_ramos', 'ramoss1234', 2)
GO

CREATE TABLE materias(
id_materia INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
nombre_materia VARCHAR(MAX),
horas_sem SMALLINT,
semestre SMALLINT,
id_carr INT FOREIGN KEY REFERENCES carrera(id_carrera)
);
GO

insert into materias values ('Programacion I', 5, 1, 1),
('Sistemas de Programacion', 3, 1, 1),
('Calculo Diferencial', 5, 1, 1),
('Introduccion a la ingenieria', 3, 1, 1),
('Base de Datos I', 5, 1, 1),
('Electronica Digital', 5, 1, 2),
('Calculo Diferencial', 5, 1, 2),
('Introduccion a la ingenieria', 3, 1, 2),
('Electronica analogica', 5, 1, 2),
('Fisica I', 5, 1, 2),
('Electronica Digital', 5, 1, 3),
('Programacion I', 5, 1, 3),
('Introduccion a la ingenieria', 3, 1, 3),
('Calculo Diferencial', 5, 1, 3),
('Quimica', 3, 1, 3),
('Programacion I', 5, 1, 1),
('Programacion I', 5, 1, 1),
('Programacion I', 5, 1, 1),
('Programacion I', 5, 1, 1),
('Programacion I', 5, 1, 1),
('Programacion I', 5, 1, 1),
('Programacion I', 5, 1, 1),
('Programacion I', 5, 1, 1)
GO

CREATE TABLE horas(
id_hora SMALLINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
start_at time,
end_at time
);
GO

CREATE TABLE dias(
id_dia SMALLINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
descripcion varchar(60),
);
GO

CREATE TABLE curso(
id_cursos INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_maestro INT FOREIGN KEY REFERENCES persona(id_persona),
id_materia INT FOREIGN KEY REFERENCES materias(id_materia)
);
GO

CREATE TABLE curso_alumno(
id_curso INT FOREIGN KEY REFERENCES curso(id_cursos),
id_persona INT FOREIGN KEY REFERENCES persona(id_persona)
);
GO

CREATE TABLE sesiones(
id_sesion INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_curso INT FOREIGN KEY REFERENCES curso(id_cursos) ,
id_dia SMALLINT FOREIGN KEY REFERENCES dias(id_dia),
id_hora SMALLINT FOREIGN KEY REFERENCES horas(id_hora)
);
GO

CREATE TABLE kardex (
id_kardex INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
id_alumno INT FOREIGN KEY REFERENCES persona(id_persona),
id_materia INT FOREIGN KEY REFERENCES materias(id_materia),
calif DECIMAL NOT NULL,
id_maestro INT FOREIGN KEY REFERENCES persona(id_persona)
);
GO


CREATE PROCEDURE ObtenerMaestroCalificacionReprobatoria
    @nombre_alumno VARCHAR(MAX)
AS
BEGIN
    SELECT m.nombres AS NombreMaestro, m.ap_paterno, m.ap_materno, k.calif
    FROM persona p
    JOIN kardex k ON p.id_persona = k.id_alumno
    JOIN persona m ON k.id_maestro = m.id_persona
    WHERE p.nombres = @nombre_alumno AND k.calif < 6;
END;
GO

CREATE PROCEDURE ObtenerAlumnoRepruebaDosMaterias
AS
BEGIN
    SELECT p.nombres, p.ap_paterno, p.ap_materno, COUNT(k.id_kardex) AS NumeroReprobadas
    FROM persona p
    JOIN kardex k ON p.id_persona = k.id_alumno
    WHERE k.calif < 6
    GROUP BY p.nombres, p.ap_paterno, p.ap_materno
    HAVING COUNT(k.id_kardex) >= 2;
END;
GO

CREATE PROCEDURE ObtenerOportunidadAprobarMateria
    @nombre_alumno VARCHAR(MAX),
    @nombre_materia VARCHAR(MAX)
AS
BEGIN
    SELECT k.id_kardex AS Oportunidad
    FROM kardex k
    JOIN materias m ON k.id_materia = m.id_materia
    JOIN persona p ON k.id_alumno = p.id_persona
    WHERE p.nombres = @nombre_alumno AND m.nombre_materia = @nombre_materia AND k.calif >= 6;
END;
GO


CREATE PROCEDURE ObtenerPromedioAlumno
    @id_alumno INT
AS
BEGIN
    SELECT AVG(k.calif) AS Promedio
    FROM kardex k
    WHERE k.id_alumno = @id_alumno;
END;
GO

CREATE PROCEDURE ObtenerMateriasImparteMaestro
    @nombre_maestro VARCHAR(MAX)
AS
BEGIN
    SELECT m.nombre_materia
    FROM curso cu
    JOIN materias m ON cu.id_materia = m.id_materia
    JOIN persona p ON cu.id_maestro = p.id_persona
    WHERE p.nombres = @nombre_maestro;
END;
GO

CREATE PROCEDURE ObtenerSemestreConMasReprobadas
    @nombre_alumno VARCHAR(MAX)
AS
BEGIN
    SELECT m.semestre, COUNT(k.id_kardex) AS NumeroReprobadas
    FROM kardex k
    JOIN materias m ON k.id_materia = m.id_materia
    JOIN persona p ON k.id_alumno = p.id_persona
    WHERE p.nombres = @nombre_alumno AND k.calif < 6
    GROUP BY m.semestre
    ORDER BY NumeroReprobadas DESC;
END;
GO

CREATE PROCEDURE ObtenerMaestroSinClasesEsteSemestre
    @semestre_actual SMALLINT
AS
BEGIN
    SELECT p.nombres, p.ap_paterno, p.ap_materno
    FROM persona p
    WHERE p.rol = 1 AND p.id_persona NOT IN (
        SELECT cu.id_maestro
        FROM curso cu
        JOIN materias m ON cu.id_materia = m.id_materia
        WHERE m.semestre = @semestre_actual
    );
END;
GO

CREATE PROCEDURE ObtenerMaestroConMasHorasClase
AS
BEGIN
    SELECT p.nombres, p.ap_paterno, p.ap_materno, SUM(DATEDIFF(HOUR, h.start_at, h.end_at)) AS HorasClase
    FROM persona p
    JOIN curso cu ON p.id_persona = cu.id_maestro
    JOIN sesiones s ON cu.id_cursos = s.id_curso
    JOIN horas h ON s.id_hora = h.id_hora
    GROUP BY p.nombres, p.ap_paterno, p.ap_materno
    ORDER BY HorasClase DESC;
END;
GO

CREATE PROCEDURE ObtenerMaestroLibreAHora
    @hora TIME,
    @dia VARCHAR(MAX)
AS
BEGIN
    SELECT p.nombres, p.ap_paterno, p.ap_materno
    FROM persona p
    WHERE p.rol = 1 AND p.id_persona NOT IN (
        SELECT cu.id_maestro
        FROM curso cu
        JOIN sesiones s ON cu.id_cursos = s.id_curso
        JOIN horas h ON s.id_hora = h.id_hora
        JOIN dias d ON s.id_dia = d.id_dia
        WHERE d.descripcion = @dia AND @hora BETWEEN h.start_at AND h.end_at
    );
END;
GO

CREATE PROCEDURE ObtenerKardexAlumno
    @id_alumno INT
AS
BEGIN
    SELECT m.nombre_materia, k.calif, k.id_kardex AS Oportunidad
    FROM kardex k
    JOIN materias m ON k.id_materia = m.id_materia
    WHERE k.id_alumno = @id_alumno;
END;
GO

CREATE PROCEDURE ObtenerAlumnoQuintaOportunidad
AS
BEGIN
    SELECT p.nombres, p.ap_paterno, p.ap_materno, k.id_materia, 
           COUNT(k.id_kardex) AS Oportunidad
    FROM kardex k
    JOIN persona p ON k.id_alumno = p.id_persona
    GROUP BY p.nombres, p.ap_paterno, p.ap_materno, k.id_materia
    HAVING COUNT(k.id_kardex) = 5;
END;
GO

CREATE PROCEDURE CapturarCalificaciones
    @id_kardex INT,
    @id_alumno INT,
    @calificacion DECIMAL(4,2),
    @id_maestro INT
AS
BEGIN
    INSERT INTO kardex (id_kardex, id_alumno, calif, id_maestro)
    VALUES (@id_kardex, @id_alumno, @calificacion, @id_maestro);
END;
GO





