<?php 
class Main extends Controller{
   
    function __construct()
    {
        parent::__construct();
        $this->view->render("main");                    
        //echo "<p>Bienvenidos al recurso Main</p>";
    }
    function saludar(){
        //echo "<p>Hola desde Main</p>";
    }
}
; ?>