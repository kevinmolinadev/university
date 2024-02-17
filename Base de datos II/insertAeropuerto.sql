insert into aeropuerto(codigo,nombre,ciudad,pais) values 
('85HN6','Viru Viru','Santa Cruz','Bolivia'),
('41CB8','Castor','Minesota','Canada')

insert into programa_de_vuelo(nro_vuelo,aerolinea,id_aeropuerto) values
(125,'APT',1),
(452,'LPT',2)

insert into avion(modelo,capacidad_plazas) values
('APT-853',230),
('LPT-10',450)

insert into vuelo(plazas_vacias,id_avion) values
(24,1),
(41,2)

insert into escala_tecnica(orden,ciudad,pais,id_programa_de_vuelo) values 
(1,'Buenos Aires','Argentina',1),
(3,'New York','Estados Unidos',1),
(2,'Caracas','Venezuela',1)

insert into semana(dia) values
('Lunes'),
('Martes'),
('Miercoles'),
('Jueves'),
('Viernes'),
('Sabado'),
('Domingo')

insert into programa_semana(id_programa_de_vuelo,id_semana) values
(1,1),
(1,3), 
(1,7)

insert into detalle_vuelo(fecha_vuelo,salida,destino,id_vuelo) values
('2023-04-20',1,2,2),
('2023-03-12',2,1,1)  

select * from  aeropuerto
select * from  avion
select * from  detalle_vuelo
select * from  escala_tecnica
select * from  programa_de_vuelo
select * from  programa_semana
select * from  semana
select * from  vuelo


