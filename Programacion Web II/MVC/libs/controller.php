<?php 

class Controller{
    public $view;
    function __construct(){
        //echo "<p>Soy el controlador base</p>";
        $this->view=new View();
    }

    function Goty(){
        //echo "<p>SEKIRITO GOTY DE TODA LA VIDA</p>";
    }


}
; ?>