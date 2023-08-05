create table categoria(
	id int primary key identity(1,1) not null,
	tipo varchar (50) not null,
)
create table ubicacion(
	id int primary key identity(1,1) not null,
	nombre varchar (50) not null,
)
create table carretera(
	id int primary key identity(1,1) not null,
	nombre varchar (50) not null,
	id_categoria int not null,
	id_ubicacion int not null,
	constraint fk_categoria_carretera foreign key(id_categoria) references categoria(id),
	constraint fk_ubicacion_carretera foreign key(id_ubicacion) references ubicacion(id),
)
create table tramo(
	id int primary key identity(1,1) not null,
	nombre varchar (50) not null,
	km_carretera_inicio int not null,
	km_carretera_fin int not null,
	id_carretera int not null,
	constraint fk_carretera_tramo foreign key(id_carretera) references carretera(id),
)
create table comuna(
	id int primary key identity(1,1) not null,
	nombre varchar (50) not null,
	latitud varchar(50) not null,
	longuitud varchar(50) not null,
)
create table tipo_comuna(
	id int primary key identity(1,1) not null,
	tipo varchar (50) not null,
)
create table tramo_comuna(
	id int primary key identity(1,1) not null,
	id_tipo_comuna int not null,
	id_tramo int not null,
	id_comuna int not null,
	constraint fk_tipo_comuna_tramo_comuna foreign key(id_tipo_comuna) references tipo_comuna(id),
	constraint fk_tramo_tramo_comuna foreign key(id_tramo) references tramo(id),
	constraint fk_comuna_tramo_comuna foreign key(id_comuna) references comuna(id)
)