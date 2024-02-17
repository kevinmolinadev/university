--BASE DE DATOS-- 

create table Proveedor(
	id int primary key identity(1,1) not null,
	nombre varchar(50) not null,
	categoria varchar(50) not null,
	ciudad varchar(50) not null
)

create table Componente(
	id int primary key identity(1,1) not null,
	nombre varchar(50) not null,
	color varchar(50) not null,
	peso varchar(50) not null,
	ciudad varchar(50) not null
)

create table Articulo(
	id int primary key identity(1,1) not null,
	nombre varchar (50) not null,
	ciudad varchar(50) not null
)

create table Envio(
	cantidad varchar(50) not null,
	id_proveedor int not null,
	id_componente int not null,
	id_articulo int not null,
	constraint fk_proveedor_envio foreign key(id_proveedor) references Proveedor(id),
	constraint fk_componente_envio foreign key(id_componente) references Componente(id),
	constraint fk_articulo_envio foreign key(id_articulo) references Articulo(id)
)

insert into Proveedor (nombre,categoria,ciudad) values
('carlos','20','sevilla'),
('juan','10','madrid'),
('jose','30','sevilla')
('inma','20','sevilla')
('eva','30','caceres')

insert into Componente(nombre, color, peso, ciudad) values 
('X3A','rojo','12','sevilla'),
('B85','verde','17','madrid'),
('C4B','azul','17','malaga')
('C4B','rojo','14','sevilla')
('VT8','azul','12','madrid')
('C30','rojo','19','caceres')

insert into Articulo(nombre, ciudad) values 
('clasificadora','madrid'),
('perforadora','malaga'),
('lectora','caceres'),
('consola','caceres'),
('mezcladora','sevilla'),
('terminal','barcelona'),
('cinta','sevilla')
insert into Envio(id_proveedor,id_componente, id_articulo, cantidad) values 
(1,1,1,'200'),
(1,1,4,'700'),
(2,3,1,'400'),
(2,3,2,'200'),
(2,3,3,'200'),
(2,3,4,'500'),
(2,3,5,'600'),
(2,3,6,'400'),
(2,3,7,'800'),
(2,5,2,'100'),
(3,3,1,'200'),
(3,4,2,'500'),
(4,6,3,'300'),
(4,6,7,'300'),
(5,2,2,'200'),
(5,2,4,'100'),
(5,5,4,'500'),
(5,5,7,'100'),
(5,6,2,'200'),
(5,1,4,'100'),
(5,3,4,'200'),
(5,4,4,'800'),
(5,5,5,'400'),
(5,6,4,'500'),

select * from Cliente
select * from Boleto
select * from Concierto
select * from Detalle_Compra_Boleto