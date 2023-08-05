<?php
class App{
    function __construct()
    {
            //echo "<h1>Mi aplicacion en WEB II</h1>";
        if (isset($_GET['url'])) {
            $url=$_GET['url'];
            //echo "$url<br>";
            $url=explode("/", $url);
            //echo "$url[0]<br>";
            $ruta= "controllers/$url[0].php";
            //echo "$ruta<br>";
            if (file_exists($ruta)) {
                require_once $ruta;
                $c = new $url[0];
                if (isset($url[1]) /* && method_exists($c, $url[1]) */) {
                    $c->{$url[1]}();
                }
            } else {
                require_once "./controllers/errores.php";
                $error= new Errores();
            }
        }else{
            
        }
    }
}
?>