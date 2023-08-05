--BASE DE DATOS-- 

create table Cliente(
	id int primary key identity(1,1) not null,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	fecha_nacimiento date not null,
	telefono varchar (15) not null,
	email varchar (100) not null
)

create table Boleto(
	id int primary key identity(1,1) not null,
	tipo_boleto varchar(50) not null,
	precio_boleto float not null
)

create table Concierto(
	id int primary key identity(1,1) not null,
	nombre varchar (50) not null,
	capacidad_personas int not null,
	ubicacion varchar (100) not null
)

create table Detalle_Compra_Boleto(
	id int primary key identity(1,1) not null,
	fecha date not null,
	metodo_pago varchar (50) not null,
	descuento float not null,
	total float not null,
	id_cliente int not null,
	id_boleto int not null,
	id_concierto int not null,
	constraint fk_cliente_detalleCB foreign key(id_cliente) references Cliente(id),
	constraint fk_boleto_detalleCB foreign key(id_boleto) references Boleto(id),
	constraint fk_concierto_detalleCB foreign key(id_concierto) references Concierto(id)
)

create table Artista(
	id int primary key identity(1,1) not null,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	email varchar (100) not null,
	hora_presentacion time not null,
	id_concierto int not null,
	constraint fk_concierto_artista foreign key(id_concierto) references Concierto(id)
)
