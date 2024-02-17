<?php

$HOST="localhost";
$USUARIO="root";
$PASS="kevin2003";
$DB="web";

//Conexion msqli
$conection= new mysqli($HOST, $USUARIO, $PASS, $DB);
if($conection->connect_error){
    die("Error de conexion: $connection->connect_error");
}else{
    echo "Conexion exitosa";
}

$sql= "INSERT INTO TABLE(nombre,direccion,telefono,estado) VALUES ('Rosa','Calle H','71122','0')"
; ?>