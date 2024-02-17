<?php
$HOST = "localhost";
$USUARIO = "root";
$PASS = "kevin2003";
$DB = "web";
$conection = new mysqli($HOST, $USUARIO, $PASS, $DB);

if ($conection->connect_error) {
    die("Error de conexión: $connection->connect_error");
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = $_POST["name"];
    $lastName = $_POST["lastName"];
    $age = $_POST["age"];
    $address = $_POST["address"];
    $phone = $_POST["phone"];
    $state = $_POST["state"];
    if(empty($name)){
        echo "debe completar los campos";
    }else{
        $sql = "INSERT INTO usuario (nombre, apellido, edad, direccion, telefono, estado) VALUES ('$name', '$lastName', '$age', '$address', '$phone', '$state')";
        
        if ($conection->query($sql) === TRUE) {
            header("Location: index.php");
        } else {
            echo "Error: " . $sql . "<br>" . $conection->error;
        }
        $conection->close();
    }
}

