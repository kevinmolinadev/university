<?php
// Establecer la conexión con la base de datos
$conexion = mysqli_connect("localhost", "root", "kevin2003", "web");

// Ejecutar la consulta de selección
$resultado = mysqli_query($conexion, "SELECT * FROM usuario");

// Mostrar los resultados en una tabla
echo '<table border="1">';
echo "<tr><th>Nombre</th><th>Apellido</th><th>Edad</th><th>Dirección</th><th>Teléfono</th><th>Estado</th></tr>";
while ($fila = mysqli_fetch_array($resultado)) {
    echo "<tr>";
    echo "<td>" . $fila["nombre"] . "</td>";
    echo "<td>" . $fila["apellido"] . "</td>";
    echo "<td>" . $fila["edad"] . "</td>";
    echo "<td>" . $fila["direccion"] . "</td>";
    echo "<td>" . $fila["telefono"] . "</td>";
    echo "<td>" . $fila["estado"] . "</td>";
    echo "</tr>";
}
echo "</table>";

// Cerrar la conexión
mysqli_close($conexion);
?>
