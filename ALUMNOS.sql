USE master;
DROP DATABASE IF EXISTS siia_uadec;
CREATE DATABASE siia_uadec;
go
USE siia_uadec;

CREATE TABLE carrera(
id_carrera INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
carrera VARCHAR (MAX) NOT NULL
);
CREATE TABLE persona(
id_persona INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
ap_paterno VARCHAR(MAX) NOT NULL,
ap_materno VARCHAR(MAX) NOT NULL,
nombres VARCHAR(MAX) NOT NULL,
correo VARCHAR(MAX) NOT NULL,
contrasenia VARCHAR(MAX) NOT NULL,
rol SMALLINT NOT NULL
);

INSERT INTO persona VALUES ('Puente', 'Cruz', 'Emmanuel', 'emmanuel_cruz', 'manu21291', 1),
('Chavana', 'Cazares', 'Cesar', 'cesar_chavana', 'chavana1234', 1),
('Garcia', 'Montoya', 'Jahir', 'jahir_garcia', 'garcia1234', 3),
('Ramos', 'Ruelas', 'Raul', 'raul_ramos', 'ramoss1234', 2)

--CREATE TABLE alumnos(
--id_alumno INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
--ap_paterno VARCHAR(MAX) NOT NULL,
--ap_materno VARCHAR(MAX) NOT NULL,
--nombres VARCHAR(MAX) NOT NULL,
--correo VARCHAR(MAX) NOT NULL,
--contrasenia VARCHAR(MAX) NOT NULL,
--id_carr INT FOREIGN KEY REFERENCES carrera(id_carrera)
--);

--CREATE TABLE maestros(
--id_maestro INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
--ap_paterno VARCHAR(MAX) NOT NULL,
--ap_materno VARCHAR(MAX) NOT NULL,
--nombres VARCHAR(MAX) NOT NULL,
--correo VARCHAR(MAX) NOT NULL,
--contrasenia VARCHAR(MAX) NOT NULL,);

CREATE TABLE carrera_persona(
id_persona INT FOREIGN KEY REFERENCES persona(id_persona),
id_carrera INT FOREIGN KEY REFERENCES carrera(id_carrera)
)

CREATE TABLE materias(
id_materia INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
nombre_materia VARCHAR(MAX),
horas_sem SMALLINT,
semestre SMALLINT,
id_carr INT FOREIGN KEY REFERENCES carrera(id_carrera)
);

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

