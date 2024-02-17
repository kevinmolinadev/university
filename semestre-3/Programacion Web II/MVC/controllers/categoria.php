<?php 
class Categoria extends Controller{
    function __construct(){
        parent::__construct();
        $this->view->render("categoria");
        parent::Goty();
        //echo "Controlador Categorias";
    }
}
; ?>