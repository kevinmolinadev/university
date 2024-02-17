create table aeropuerto(
	id int primary key identity(1,1) not null,
	codigo varchar (5) not null,
	nombre varchar (50) not null,
	ciudad varchar (50) not null,
	pais varchar (50) not null,
)
create table programa_de_vuelo(
	id int primary key identity(1,1) not null,
	nro_vuelo int not null,
	aerolinea varchar (50) not null,
	id_aeropuerto int not null,
	constraint fk_aeropuerto_programa_de_vuelo foreign key(id_aeropuerto) references aeropuerto(id),
)
create table semana(
	id int primary key identity(1,1) not null,
	dia varchar (15) not null,
)
create table escala_tecnica(
	id int primary key identity(1,1) not null,
	orden int not null,
	ciudad varchar (50) not null,
	pais varchar (50) not null,
	id_programa_de_vuelo int not null,
	constraint fk_programa_de_vuelo_escala_tecnica foreign key(id_programa_de_vuelo) references programa_de_vuelo(id),
)

create table programa_semana(
	id int primary key identity(1,1) not null,
	id_programa_de_vuelo int not null,
	id_semana int not null,
	constraint fk_programa_de_vuelo_programa_semana foreign key(id_programa_de_vuelo) references programa_de_vuelo(id),
	constraint fk_semana_programa_semana foreign key(id_semana) references semana(id),
)

create table avion(
	id int primary key identity(1,1) not null,
	modelo varchar (50) not null,
	capacidad_plazas int not null
)
create table vuelo(
	id int primary key identity(1,1) not null,
	plazas_vacias int not null,
	id_avion int not null,
	constraint fk_avion_vuelo foreign key(id_avion) references avion(id),
)
create table detalle_vuelo(
	id int primary key identity(1,1) not null,
	fecha_vuelo date not null,
	salida int not null,
	destino int not null,
	constraint fk_salidaAeropuerto_detalle_vuelo foreign key(salida) references aeropuerto(id),
	constraint fk_destinoAeropuerto_detalle_vuelo foreign key(destino) references aeropuerto(id),
)

--PARA AGREGAR CAMPOS A LAS TABLAS 
alter table detalle_vuelo
add id_vuelo int not null 
constraint fk_vuelo_detalle_vuelo foreign key(id_vuelo) references vuelo(id);
