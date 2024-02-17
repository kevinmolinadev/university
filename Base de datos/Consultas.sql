----DML----
--Clausula select
--1
select Nombre, Apellido  from Tutor;
select  Nombre, Apellido,ID_Tutor from Estudiante;
--Clausula condicion, where
--2
select Estudiante.Nombre, Estudiante.Apellido, Tutor.Nombre
from Estudiante, Tutor
where  Estudiante.ID_Tutor=Tutor.ID
--3
select Curso.Nombre, Virtual.Contraseña 
from Curso, Virtual 
where Curso.ID_Virtual=Virtual.ID_Login
--4
select Curso.Nombre, Presencial.Curso, Presencial.Edificio 
from Curso, Presencial 
where Curso.ID_Presencial=Presencial.ID
--5
select Tipo_Examen.Nombre, Examen.ID, Resultado_Examen.Grado, Estudiante.Nombre 
from Tipo_Examen, Examen, Resultado_Examen, Estudiante 
where Examen.ID=Estudiante.ID and Examen.Tipo_Examen=Tipo_Examen.Tipo and Resultado_Examen.ID_Estudiante=Estudiante.ID


--MODIFICACIONES--
--1 Modificar nombre y apellido del tutor 2 de 2 estudiantes
update Estudiante
set Nombre='Orlando', Apellido='Orellana',Año_Registro='2015', Email='Orlando@gmail',ID_Tutor=3
where ID=4

--2 obtener los datos de todos los docentes de tiempo completo y el departamento en el que trabajan 
select Docente.Nombre, Docente.Apellido, Docente.Email, Docente.Salario, Docente.Plan_De_Seguro, Docente.Tipo_Docente, Departamento.Nombre 
from Departamento, Docente
where Docente.ID_Departamento=Departamento.ID and Docente.Tipo_Docente='Tiempo completo'

--3 Obtener la asistencia a las sesiones academicas de 1 materia de todos los estudiantes
select Asistencia.Numero_Dias_Asistidos, Sesion_Academica.Nombre, Curso.Nombre, Estudiante.Nombre
from Asistencia, Sesion_Academica, Curso, Estudiante
where Asistencia.ID_Sesion_Academica=Sesion_Academica.ID and Curso.Nombre='Ing Sistemas' and Curso.ID_Sesion_Academica=Sesion_Academica.ID and  Asistencia.ID_Estudiante=Estudiante.ID