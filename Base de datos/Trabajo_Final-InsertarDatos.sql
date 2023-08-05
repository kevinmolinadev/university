--INSERTAR DATOS--

--Tutor--
insert into Tutor (Nombre,Apellido,Nombre_2,Apellido_2) values
('Denzel','Fuentez','Den','Fue'),
('Andres','Lopez','And','Lop'),
('Jose','Rodrigo','Jos','Rod')

--Estudiante--
insert into Estudiante(Nombre,Apellido,Año_Registro,Email,ID_Tutor) values
('Pablo','Toledo','2009','Pablo@gmail',1),
('Diego','Andres','2005','Diego@gmail',3),
('Cavani','Vallejos','2003','Cavani@gmail',2)

--Sesion Academica--
insert into Sesion_Academica(Nombre) values
('Sistemas'),
('Biomedica'),
('Arquitectura')

--Asistencia--
insert into Asistencia(Numero_Dias_Asistidos,Numero_Dias_libres,Eligibilidad_examen,ID_Estudiante,ID_Sesion_Academica) values
(12,2,'No',2,2),
(21,5,'Si',1,3),
(27,7,'Si',3,1)

--Departamento--
insert into Departamento(Nombre,Director) values
('ISI','Palito'),
('IBI','Mendoza'),
('ARQ','Paquito')

--Virtual--
insert into Virtual(ID_Login,Contraseña) values
('111','contra1'),
('222','contra2'),
('333','contra3')

--Presencial--
insert into Presencial(Edificio,Curso,Fecha) values
('Facultad IBI','T002','01/01/2019'),
('Facultad ARQ','T003','01/01/2020'),
('Facultad ISI','T001','01/01/2022')

--Curso--
insert into Curso(Nombre,ID_Departamento,ID_Sesion_Academica,ID_Virtual,ID_Presencial) values
('Ing Sistemas',2,2,'222',2),
('Ing Biomedica',1,1,'333',3),
('Ing Arquitectura',3,3,'111',1)

--Detalle curso estudiante--
insert into Detalle_Curso_Estudiante(Grado,ID_Estudiante,ID_Curso) values
('75',2,2),
('85',1,3),
('100',3,1)

--Docente--
insert into Docente(Nombre,Apellido,Email,Pago_Hora,Tipo_Docente,ID_Departamento) values
('Zuleica','Mariaca','Zuleica@gmail',10,'Medio Tiempo',2),
('Alderete','Nibroe','Alderete@gmail',10,'Medio Tiempo',3)
insert into Docente(Nombre,Apellido,Email,Salario,Plan_De_Seguro,Tipo_Docente,ID_Departamento) values
('Paco','Lopez','Paco@gmail',1000,'Total','Tiempo Completo',1)

--Detalle Docente--
insert into Detalle_Curso_Docente(Horas_Trabajo,ID_Docente,ID_Curso) values
('40',2,2),
('32',1,3),
('60',3,1)

--Detalle Login Docente--
insert into Detalle_Login_Docente(Fecha_De_Inicio,ID_Docente) values
('20/07/2022',1),
('05/04/2022',2),
('01/02/2022',3)

--Tipo Examen--
insert into Tipo_Examen(Tipo,Nombre,Descripcion) values
('Parcial','Programacion','Examen Parcial'),
('Examen Final','Sistemas Operativos','Examen Final'),
('Practico','Base De Datos','Examen Practico')

--Examen--
insert into Examen(Fecha_Comienzo,Tipo_Examen) values
('05/06/2022','Practico'),
('10/12/2022','Examen Final'),
('04/10/2022','Parcial')

--Resultado Examen--
insert into Resultado_Examen(Grado,ID_Docente,ID_Estudiante) values
('75',2,2),
('100',1,3),
('83',3,1)
