<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario</title>
</head>
<body>
    <h2>Formulario</h2>
    <form action="create.php" method="post">
        <label>Nombre:</label>
        <input type="text" name="name">
        <br><br>
        <label>Apellido:</label>
        <input type="text" name="lastName">
        <br><br>
        <label>Edad:</label>
        <input type="text" name="age">
        <br><br>
        <label>Dirección:</label>
        <input type="text" name="address">
        <br><br>
        <label>Teléfono:</label>
        <input type="text" name="phone">
        <br><br>
        <label>Estado:</label>
        <input type="text" name="state">
        <br><br>
        <input type="submit" value="Agregar">
    </form>
    <br><br>
    <form action="read.php" method="post">
        <input type="submit" name="informacion" value="Mostrar información">
    </form>
</body>
</html>
