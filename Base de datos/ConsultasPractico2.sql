--1.Obtener el Id, nombre, jefe del DEPARTAMENTO donde trabajan los docente de TIEMPO COMPLETO, mostrar el Id, Nombre y Apellido además del pago por hora y su Login Date Time de la tabla DETALLE LOGIN DOCENTE.
select Departamento.ID, Departamento.Nombre, Departamento.Director, Docente.ID, Docente.Nombre, Docente.Apellido, Docente.Pago_Hora, Docente.Tipo_Docente, Detalle_Login_Docente.Fecha_De_Inicio
from Departamento, Docente, Detalle_Login_Docente
where Docente.ID_Departamento=Departamento.ID and Docente.Tipo_Docente='Tiempo completo' and Detalle_Login_Docente.ID_Docente=Docente.ID 

--2.Modificar el Nombre del Jefe de 1 DEPARTAMENTO.
update Departamento
set Director='Orlando'
where ID=3
select*from Departamento

--3.Obtener todos los datos de ESTUDIANTES y la nota/grado que obtuvo en sus CURSOS/MATERIAS.
select Estudiante.ID, Estudiante.Nombre, Estudiante.Apellido, Estudiante.Año_Registro, Estudiante.Email, Detalle_Curso_Estudiante.Grado, Curso.Nombre
from Estudiante, Resultado_Examen, Curso, Detalle_Curso_Estudiante
where Resultado_Examen.ID_Estudiante=Estudiante.ID and Detalle_Curso_Estudiante.ID_Estudiante=Estudiante.ID and Detalle_Curso_Estudiante.ID_Curso=Curso.ID

--4.obtener la ASISTENCIA a las SESIONES ACADEMICAS de todas los CURSOS/MATERIAS de todos los ESTUDIATES.
select Asistencia.Numero_Dias_Asistidos, Asistencia.Numero_Dias_libres, Asistencia.Eligibilidad_examen,Sesion_Academica.Nombre, Curso.Nombre, Estudiante.Nombre, Estudiante.Apellido, Estudiante.Email
from Asistencia, Sesion_Academica, Curso, Estudiante
where Asistencia.ID_Estudiante=Estudiante.ID and Asistencia.ID_Sesion_Academica=Sesion_Academica.ID and Curso.ID_Sesion_Academica=Sesion_Academica.ID