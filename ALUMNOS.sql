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

INSERT INTO persona (ap_paterno, ap_materno, nombres, correo, contrasenia, rol) VALUES 
('Puente', 'Cruz', 'Emmanuel', 'emmanuel_cruz', 'manu21291', 3),  -- alumno
('Chavana', 'Cazares', 'Cesar', 'cesar_chavana', 'chavana1234', 3), -- alumno
('Garcia', 'Montoya', 'Jahir', 'jahir_garcia', 'garcia1234', 1), -- admin
('Ramos', 'Ruelas', 'Raul', 'raul_ramos', 'ramoss1234', 2), -- maestro
('Lopez', 'Hernandez', 'Lili', 'lili_lopez', 'lili123', 3), -- alumno
('Martinez', 'Gomez', 'Lolo', 'lolo_martinez', 'lolo123', 3), -- alumno
('Perez', 'Diaz', 'Pepe', 'pepe_perez', 'pepe123', 2); -- maestro
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
fecha DATE NOT NULL,
id_maestro INT FOREIGN KEY REFERENCES persona(id_persona)
);
GO


CREATE PROCEDURE ObtenerMaestroCalificacionReprobatoria
     @id_alumno INT
AS
BEGIN
    SELECT 
        CONCAT(m.nombres, ' ', m.ap_paterno, ' ', m.ap_materno) AS Maestro,
        ma.nombre_materia AS Materia,
        COUNT(k.calif) AS VecesReprobada
    FROM persona p
    JOIN kardex k ON p.id_persona = k.id_alumno
    JOIN persona m ON k.id_maestro = m.id_persona
    JOIN materias ma ON k.id_materia = ma.id_materia
    WHERE p.id_persona = @id_alumno AND k.calif < 6
    GROUP BY m.nombres, m.ap_paterno, m.ap_materno, ma.nombre_materia;
END;
GO


CREATE PROCEDURE ObtenerAlumnoRepruebaNVeces
    @num_reprobadas INT
AS
BEGIN
    SELECT 
        p.nombres, 
        p.ap_paterno, 
        p.ap_materno, 
        m.nombre_materia AS Materia
    FROM persona p
    JOIN kardex k ON p.id_persona = k.id_alumno
    JOIN materias m ON k.id_materia = m.id_materia
    WHERE k.calif < 6
    GROUP BY p.nombres, p.ap_paterno, p.ap_materno, m.nombre_materia
    HAVING COUNT(k.id_kardex) >= @num_reprobadas;
END;
GO


CREATE PROCEDURE ObtenerOportunidadAprobarMateria
    @id_alumno INT,
    @nombre_materia VARCHAR(MAX)
AS
BEGIN
    SELECT COUNT(*) AS NumeroDeOportunidades
    FROM kardex k
    JOIN materias m ON k.id_materia = m.id_materia
    JOIN persona p ON k.id_alumno = p.id_persona
    WHERE p.id_persona = @id_alumno AND m.nombre_materia = @nombre_materia;
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
    SELECT 
        m.nombre_materia AS Materia,
        m.semestre AS Semestre,
        CONCAT(p.nombres, ' ', p.ap_paterno, ' ', p.ap_materno) AS NombreMaestro
    FROM curso cu
    JOIN materias m ON cu.id_materia = m.id_materia
    JOIN persona p ON cu.id_maestro = p.id_persona
    WHERE @nombre_maestro IS NULL OR CONCAT(p.nombres, ' ', p.ap_paterno, ' ', p.ap_materno) LIKE '%' + @nombre_maestro + '%';
END;
GO


CREATE PROCEDURE ObtenerSemestreConMasReprobadas
    @id_alumno INT
AS
BEGIN
    SELECT m.semestre as Semestre, COUNT(k.id_kardex) AS 'Cantidad materia reprobadas'
    FROM kardex k
    JOIN materias m ON k.id_materia = m.id_materia
    WHERE k.id_alumno = @id_alumno AND k.calif < 6
    GROUP BY m.semestre
    ORDER BY 'Cantidad materia reprobadas' DESC;
END;
GO

CREATE PROCEDURE ObtenerMaestroSinClasesEsteSemestre
    @semestre_actual SMALLINT
AS
BEGIN
    SELECT p.nombres, p.ap_paterno, p.ap_materno
    FROM persona p
    WHERE p.rol = 2 AND p.id_persona NOT IN (
        SELECT cu.id_maestro
        FROM curso cu
        JOIN materias m ON cu.id_materia = m.id_materia
        WHERE m.semestre = 1
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
    WHERE p.rol = 2 AND p.id_persona NOT IN (
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
    SELECT k.id_kardex, p.id_persona AS Matricula, p.nombres + ' ' + p.ap_paterno + ' ' + p.ap_materno AS Alumno, 
           m.nombre_materia AS Materia, k.calif AS Calif, k.fecha AS Fecha, 
           maestro.nombres + ' ' + maestro.ap_paterno + ' ' + maestro.ap_materno AS Maestro
    FROM kardex k
    JOIN materias m ON k.id_materia = m.id_materia
    JOIN persona p ON k.id_alumno = p.id_persona  
    JOIN persona maestro ON k.id_maestro = maestro.id_persona
    WHERE @id_alumno IS NULL OR k.id_alumno = @id_alumno;
END;
GO



CREATE PROCEDURE ObtenerAlumnoQuintaOportunidad
AS
BEGIN
    SELECT CONCAT(p.nombres, ' ', p.ap_paterno, ' ', p.ap_materno) AS Nombre, 
           m.nombre_materia AS Materia, 
           COUNT(k.id_kardex) AS Oportunidad
    FROM kardex k
    JOIN persona p ON k.id_alumno = p.id_persona
    JOIN materias m ON k.id_materia = m.id_materia
    GROUP BY p.nombres, p.ap_paterno, p.ap_materno, m.nombre_materia
    HAVING COUNT(k.id_kardex) = 5;
END;
GO


CREATE PROCEDURE CapturarCalificacion
    @id_alumno INT,
    @id_materia INT,
    @calif DECIMAL,
    @fecha DATE,
    @id_maestro INT
AS
BEGIN
    INSERT INTO kardex (id_alumno, id_materia, calif, fecha, id_maestro)
    VALUES (@id_alumno, @id_materia, @calif, @fecha, @id_maestro);
END;
GO



-- Insertar datos en la tabla carrera_persona
INSERT INTO carrera_persona (id_persona, id_carrera) VALUES 
(5, 1), -- Lili en Ingenieria En Sistemas Computacionales
(6, 1), -- Lolo en Ingenieria En Sistemas Computacionales
(7, 1), -- Pepe en Ingenieria En Sistemas Computacionales
(4, 1); -- Raul en Ingenieria En Sistemas Computacionales
GO

INSERT INTO horas (start_at, end_at) VALUES 
('08:00', '09:00'),
('09:00', '10:00'),
('10:00', '11:00');
GO

INSERT INTO dias (descripcion) VALUES 
('Lunes'),
('Martes'),
('Miercoles');
GO

INSERT INTO curso (id_maestro, id_materia) VALUES 
(4, 1),
(4, 2),
(4, 3),
(4, 4),
(7, 5),
(7, 6);
GO

INSERT INTO curso_alumno (id_curso, id_persona) VALUES 
(1, 3),
(2, 3),
(3, 4),
(4, 4),
(5, 5),
(6, 5),
(1, 6),
(2, 6),
(3, 6),
(4, 6),
(5, 6),
(6, 6);
GO

INSERT INTO sesiones (id_curso, id_dia, id_hora) VALUES 
(1, 1, 1),
(2, 1, 2),
(3, 2, 1),
(4, 2, 2),
(5, 3, 1),
(6, 3, 2);
GO

-- Insertar datos en la tabla kardex con la columna fecha
INSERT INTO kardex (id_alumno, id_materia, calif, fecha, id_maestro) VALUES 
(5, 1, 5.0, '2022-01-15', 1), -- Lili, Programacion I, 5.0, Emmanuel
(5, 2, 7.0, '2022-05-20', 1), -- Lili, Sistemas de Programacion, 7.0, Emmanuel
(5, 3, 4.0, '2022-06-10', 2), -- Lili, Calculo Diferencial, 4.0, Cesar
(5, 3, 6.0, '2023-01-20', 2), -- Lili, Calculo Diferencial, 6.0, Cesar (segunda oportunidad)
(6, 6, 4.0, '2022-03-15', 7), -- Lolo, Fisica I, 4.0, Pepe
(6, 6, 4.0, '2022-08-25', 7), -- Lolo, Fisica I, 4.0, Pepe (segunda oportunidad)
(6, 6, 7.0, '2023-03-15', 7), -- Lolo, Fisica I, 7.0, Pepe (tercera oportunidad)
(3, 1, 9.0, '2021-12-20', 1), -- Jahir, Programacion I, 9.0, Emmanuel
(4, 3, 8.0, '2022-11-10', 2); -- Raul, Calculo Diferencial, 8.0, Cesar
GO



CREATE PROCEDURE BuscarAlumnosPorFiltros
    @id_maestro INT,
    @id_curso INT = NULL,
    @nombre_alumno VARCHAR(MAX) = NULL,
    @nombre_materia VARCHAR(MAX) = NULL,
    @semestre INT = NULL
AS
BEGIN
    SELECT p.id_persona AS 'Id Alumno', CONCAT(p.nombres, ' ', p.ap_paterno, ' ', p.ap_materno) AS Nombre, 
           cu.id_cursos AS CursoID, 
           m.id_materia AS 'Id Materia', m.nombre_materia AS Materia, 
           m.semestre AS Semestre
    FROM persona p
    JOIN curso_alumno ca ON p.id_persona = ca.id_persona
    JOIN curso cu ON ca.id_curso = cu.id_cursos
    JOIN materias m ON cu.id_materia = m.id_materia
    JOIN persona maestro ON cu.id_maestro = maestro.id_persona
    WHERE maestro.id_persona = @id_maestro
    AND (@nombre_alumno IS NULL OR CONCAT(p.nombres, ' ', p.ap_paterno, ' ', p.ap_materno) LIKE '%' + @nombre_alumno + '%')
    AND (@nombre_materia IS NULL OR m.nombre_materia LIKE '%' + @nombre_materia + '%')
    AND (@semestre IS NULL OR m.semestre = @semestre);
END;

