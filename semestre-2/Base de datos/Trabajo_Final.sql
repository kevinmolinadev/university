--BASE DE DATOS TRABAJO FINAL-- 

create table Tutor(--si
	ID int primary key identity(1,1) not null,
	Nombre varchar(20) not null,
	Apellido varchar(20) not null,
	Nombre_2 varchar(20) not null,
	Apellido_2 varchar(20) not null
)

create table Estudiante(--si
	ID int primary key identity(1,1) not null,
	Nombre varchar(20) not null,
	Apellido varchar(20) not null,
	Año_Registro varchar(20) not null,
	Email varchar(20) not null,
	ID_Tutor int not null,
	constraint fk_TutorEstudiante foreign key(ID_Tutor) references Tutor(ID)
)

create table Sesion_Academica(--si
	ID int primary key identity(1,1),
	Nombre varchar(20) not null
)

create table Asistencia(--si
	Numero_Dias_Asistidos int not null,
	Numero_Dias_libres int not null,
	Eligibilidad_examen varchar(30),
	ID_Estudiante int not null,
	ID_Sesion_Academica int not null,
	constraint fk_AsistenciaEstudiante foreign key(ID_Estudiante) references Estudiante(ID),
	constraint fk_AsistenciaSesion_Academica foreign key(ID_Sesion_Academica) references Sesion_Academica(ID)
)

create table Departamento(--si
	ID int primary key identity(1,1) not null,
	Nombre varchar(40)not null,
	Director varchar(40) not null
)

create table Virtual(--si
	ID_Login varchar (15) primary key not null,
	Contraseña varchar (10) not null
)

create table Presencial(--si
	ID int primary key identity(1,1) not null,
	Edificio varchar (20) not null,
	Curso varchar (20) not null,
	Fecha varchar (20) not null
)

create table Curso(--si
	ID int primary key identity(1,1) not null,
	Nombre varchar(30) not null,
	ID_Departamento int not null,
	constraint fk_CursoDepartamento foreign key(ID_Departamento) references Departamento(ID),
	ID_Sesion_Academica int not null,
	constraint fk_CursoSesion_Academica foreign key(ID_Sesion_Academica) references Sesion_Academica(ID),
	ID_Virtual varchar(15) not null,
	constraint fk_CursoVirtual foreign key(ID_Virtual) references Virtual (ID_login),
	ID_Presencial int not null,
	constraint fk_CursoPresencial foreign key(ID_Presencial) references Presencial (ID)
)

create table Detalle_Curso_Estudiante(--si
	Grado varchar(30) not null,
	ID_Estudiante int not null,
	constraint fk_Detalle_Curso_EstudianteEstudiante foreign key(ID_Estudiante) references Estudiante(ID),
	ID_Curso int not null,
	constraint fk_Detalle_Curso_EstudianteCurso foreign key(ID_Curso) references Curso(ID)
)

create table Docente(--si
	ID int primary key identity(1,1) not null,
	Nombre varchar(20) not null,
	Apellido varchar(20) not null,
	Email varchar(20) not null,
	Salario float,
	Plan_De_Seguro varchar(30),
	Pago_Hora float,
	Tipo_Docente varchar(20) not null,
	ID_Departamento int not null,
	constraint fk_Docente_Departamento foreign key(ID_Departamento) references Departamento(ID) 
)

create table Detalle_Curso_Docente(--si
	Horas_Trabajo varchar(30) not null,
	ID_Docente int not null,
	constraint fk_Detalle_Curso_DocenteDocente foreign key(ID_Docente) references Docente(ID),
	ID_Curso int not null,
	constraint fk_Detalle_Curso_DocenteCurso foreign key(ID_Curso) references Curso(ID)
)

create table Detalle_Login_Docente(--si
	Fecha_De_Inicio varchar (30) primary key not null,
	ID_Docente int not null,
	constraint fk_Detalle_login_DocenteDocente foreign key(ID_Docente) references Docente(ID)
)

create table Tipo_Examen(--si
    Tipo varchar(20) primary key not null,
    Nombre varchar (20) not null,
    Descripcion varchar(20)
)

create table Examen(--si
    ID int primary key identity(1,1) not null,
    Fecha_Comienzo varchar(20) not null,
    Tipo_Examen varchar(20) not null,
    constraint fk_Examen_Tipo foreign key(Tipo_Examen) references Tipo_Examen(Tipo)
)

create table Resultado_Examen(--si
	Grado varchar(30) not null,
	ID_Docente int not null,
	constraint fk_Resultado_ExamenDocente foreign key(ID_Docente) references Docente(ID),
	ID_Estudiante int not null,
	constraint fk_Resultado_ExamenEstudiante foreign key(ID_Estudiante) references Estudiante(ID)
)

