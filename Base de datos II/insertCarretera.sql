insert into categoria (tipo) values 
('Local'),
('Comercial'),
('Regional'),
('Nacional')

insert into ubicacion(nombre) values 
('Santa cruz'),
('Cochabamba'),
('Tarija')

insert into carretera (nombre,id_categoria,id_ubicacion) values 
('Carretera Villa Santa',1,2),
('Carretera Buena Vista',4,1)

insert into tramo(nombre,km_carretera_inicio,km_carretera_fin,id_carretera) values 
('Chiquitos',0,85,1),
('Valen',85,325,1),
('Prado',325,484,1)

insert into comuna(nombre,latitud,longuitud) values 
('Sevilla','17.5029','63.1659'),
('Pradera','17.7800','60.7444'),
('Valle','18.3324','59.7526')

insert into tipo_comuna(tipo) values 
('Inicio'),
('Intermedio'),
('Fin') 

insert into tramo_comuna(id_tipo_comuna,id_comuna,id_tramo) values 
(1,1,1),
(2,2,1),
(3,3,1)

select * from categoria
select * from ubicacion
select * from carretera
select * from tramo
select * from comuna
select * from tipo_comuna
select * from tramo_comuna