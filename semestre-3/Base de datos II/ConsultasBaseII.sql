--consulta1
select Articulo.id ,Articulo.nombre, Articulo.ciudad from Articulo 
where ciudad='caceres';
--consulta2
select Proveedor.id, Proveedor.nombre,Proveedor.categoria, Proveedor.ciudad from Proveedor, Envio
where Proveedor.id = id_proveedor and Envio.id_articulo = 2 
--consulta3
select Articulo.id, Articulo.nombre, Articulo.ciudad from Articulo
where nombre like '%d' or nombre like '%e%' 
--consulta4
select Proveedor.id, Proveedor.nombre,Proveedor.categoria, Proveedor.ciudad from Proveedor, Envio
where Proveedor.id = id_proveedor and Envio.id_articulo = 1 and Envio.id_componente=1