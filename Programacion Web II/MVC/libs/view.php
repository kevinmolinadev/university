<?php 

class View{

    function __construct(){
        //echo "<p>Bienvenidos a la vista</p>";
    }
    function render($vista){
        $ruta_vista = "views/$vista/index.php";
        //echo "ruta: $ruta_vista";
        require $ruta_vista;
    }
}

; ?>