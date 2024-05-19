USE master;
DROP DATABASE IF EXISTS siia_uadec;
CREATE DATABASE siia_uadec;
go
USE siia_uadec;

CREATE TABLE carrera(
id_carrera INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
carrera VARCHAR (MAX) NOT NULL
);

INSERT INTO carrera VALUES ('Ingenieria En Sistemas Computacionales'), 
('Ingenieria Mecanico Electrica'), 
('Ingenieria Biomedica'),
('Ingenieria Mecatronica')

CREATE TABLE persona(
id_persona INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
ap_paterno VARCHAR(MAX) NOT NULL,
ap_materno VARCHAR(MAX) NOT NULL,
nombres VARCHAR(MAX) NOT NULL,
correo VARCHAR(MAX) NOT NULL,
contrasenia VARCHAR(MAX) NOT NULL,
rol SMALLINT NOT NULL
);

delete from persona where id_persona = 5

CREATE TABLE carrera_persona(
id_persona INT FOREIGN KEY REFERENCES persona(id_persona),
id_carrera INT FOREIGN KEY REFERENCES carrera(id_carrera)
)
--StoreProcedure Registro carrera persona
CREATE PROCEDURE RegistroCerrera_Persona
@id_persona INT,
@id_carrera INT
AS BEGIN
INSERT INTO carrera_persona VALUES (@id_persona, @id_carrera)
END

SELECT
 pe.nombres, 
 pe.ap_paterno,
 pe.correo,
 ca.carrera
FROM persona AS pe, carrera AS ca, carrera_persona AS pc
WHERE pe.id_persona = pc.id_persona and ca.id_carrera = pc.id_carrera
--EXEC RegistroCerrera_Persona @id_persona = 1, @id_carrera = 1;	
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

INSERT INTO persona VALUES ('Puente', 'Cruz', 'Emmanuel', 'emmanuel_cruz', 'manu21291', 1),
('Chavana', 'Cazares', 'Cesar', 'cesar_chavana', 'chavana1234', 1),
('Garcia', 'Montoya', 'Jahir', 'jahir_garcia', 'garcia1234', 3),
('Ramos', 'Ruelas', 'Raul', 'raul_ramos', 'ramoss1234', 2)

CREATE TABLE materias(
id_materia INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
nombre_materia VARCHAR(MAX),
horas_sem SMALLINT,
semestre SMALLINT,
id_carr INT FOREIGN KEY REFERENCES carrera(id_carrera)
);

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

CREATE TABLE horas(
id_hora SMALLINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
start_at time,
end_at time
);
CREATE TABLE dias(
id_dia SMALLINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
descripcion varchar(60),
);
CREATE TABLE curso(
id_cursos INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_maestro INT FOREIGN KEY REFERENCES persona(id_persona),
id_materia INT FOREIGN KEY REFERENCES materias(id_materia)
);
CREATE TABLE curso_alumno(
id_curso INT FOREIGN KEY REFERENCES curso(id_cursos),
id_persona INT FOREIGN KEY REFERENCES persona(id_persona)
);
CREATE TABLE sesiones(
id_sesion INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
id_curso INT FOREIGN KEY REFERENCES curso(id_cursos) ,
id_dia SMALLINT FOREIGN KEY REFERENCES dias(id_dia),
id_hora SMALLINT FOREIGN KEY REFERENCES horas(id_hora)
);

