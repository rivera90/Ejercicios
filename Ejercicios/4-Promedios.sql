CREATE DATABASE Promedios
GO
USE Promedios
GO

CREATE TABLE Alumnos(
	idAlumno int primary key,
	nomAlumnos varchar(100),
	apellidoPaterno varchar(100),
	apellidoMaterno varchar(100)
)
GO

Create TABLE Materias(
	idMateria int primary key,	
	nomMateria varchar(100),
	nomMaestro varchar(100)
)
GO

CREATE TABLE Calificacion(
	idCalificacion int IDENTITY(1,1),
	idMateria int,
	idAlumno int,
	Calificacion int,
	CONSTRAINT fk_Materia FOREIGN KEY (idMateria) REFERENCES Materias (idMateria),
	CONSTRAINT fk_Alumno FOREIGN KEY (idAlumno) REFERENCES Alumnos (idAlumno)
)


INSERT INTO Alumnos VALUES (1,'Jesus Armando','Rivera','Ortiz')
INSERT INTO Alumnos VALUES (2,'Santiago','Rivera','Urias');
INSERT INTO Alumnos VALUES (3,'Mayra','Aguado','López');
INSERT INTO Alumnos VALUES (4,'Rafael','Alberola','Robles');
INSERT INTO Alumnos VALUES (5,'Jaime','Apariecido','dos Santos');
INSERT INTO Alumnos VALUES (6,'Guido','Arias','Brenes');
INSERT INTO Alumnos VALUES (7,'Nekane','Bariain','Carrasco');
INSERT INTO Alumnos VALUES (8,'Jorge','Barriobero','Olarte');
INSERT INTO Alumnos VALUES (9,'Dolores','Bastida','López');
INSERT INTO Alumnos VALUES (10,'Maria E','Berenguer','Borja');
INSERT INTO Alumnos VALUES (11,'María','Bernad','Albiol');
INSERT INTO Alumnos VALUES (12,'José Manuel','Blasco','Boix');
INSERT INTO Alumnos VALUES (13,'Yanneth','Bohorquez','Pérez');
INSERT INTO Alumnos VALUES (14,'Antonio','Camarasa','Sanfelix');
INSERT INTO Alumnos VALUES (15,'Ramón','Carañana','Sanchís');

GO

INSERT INTO Materias VALUES(1,'ESPAÑOL','Prof.  Dr.  Adel  A.  Kader.')
INSERT INTO Materias VALUES(2,'MATEMATICAS','Prof.  Dr.  Jean  Claude  Pech.')
INSERT INTO Materias VALUES(3,'ROBOTICA','Prof.  Dr.  Manuel  Camps  Michelena.')

GO



INSERT INTO Calificacion VALUES (1,1,10)
INSERT INTO Calificacion VALUES (2,1,10)
INSERT INTO Calificacion VALUES (3,1,8)
INSERT INTO Calificacion VALUES (1,2,10)
INSERT INTO Calificacion VALUES (2,2,9)
INSERT INTO Calificacion VALUES (3,2,8)
INSERT INTO Calificacion VALUES (1,3,9)
INSERT INTO Calificacion VALUES (2,3,9)
INSERT INTO Calificacion VALUES (3,3,9)
INSERT INTO Calificacion VALUES (1,4,9)
INSERT INTO Calificacion VALUES (2,4,10)
INSERT INTO Calificacion VALUES (3,4,10)
INSERT INTO Calificacion VALUES (1,5,10)
INSERT INTO Calificacion VALUES (2,5,10)
INSERT INTO Calificacion VALUES (3,5,10)
INSERT INTO Calificacion VALUES (1,6,7)
INSERT INTO Calificacion VALUES (2,6,5)
INSERT INTO Calificacion VALUES (3,6,6)
INSERT INTO Calificacion VALUES (1,7,9)
INSERT INTO Calificacion VALUES (2,7,8)
INSERT INTO Calificacion VALUES (3,7,7)
INSERT INTO Calificacion VALUES (1,8,9)
INSERT INTO Calificacion VALUES (2,8,9)
INSERT INTO Calificacion VALUES (3,8,9)
INSERT INTO Calificacion VALUES (1,9,10)
INSERT INTO Calificacion VALUES (2,9,7)
INSERT INTO Calificacion VALUES (3,9,7)
INSERT INTO Calificacion VALUES (1,10,8)
INSERT INTO Calificacion VALUES (2,10,6)
INSERT INTO Calificacion VALUES (3,10,6)
INSERT INTO Calificacion VALUES (1,11,8)
INSERT INTO Calificacion VALUES (2,11,8)
INSERT INTO Calificacion VALUES (3,11,6)
INSERT INTO Calificacion VALUES (1,12,6)
INSERT INTO Calificacion VALUES (2,12,6)
INSERT INTO Calificacion VALUES (3,12,6)
INSERT INTO Calificacion VALUES (1,13,9)
INSERT INTO Calificacion VALUES (2,13,9)
INSERT INTO Calificacion VALUES (3,13,9)
INSERT INTO Calificacion VALUES (1,14,10)
INSERT INTO Calificacion VALUES (2,14,10)
INSERT INTO Calificacion VALUES (3,14,10)
INSERT INTO Calificacion VALUES (1,15,6)
INSERT INTO Calificacion VALUES (2,15,6)
INSERT INTO Calificacion VALUES (3,15,6)

GO

Select TOP 10 Cal.idalumno,Al.nomAlumnos,AL.apellidoPaterno,Al.apellidoMaterno ,sum(calificacion)/3 as Promedio from Calificacion Cal
inner join Alumnos Al on Al.idAlumno = Cal.idAlumno
group by Cal.idalumno,Al.nomAlumnos,AL.apellidoPaterno,Al.apellidoMaterno
order by Promedio desc