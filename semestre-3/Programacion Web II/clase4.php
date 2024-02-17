<?php 
$message="Buenos Dias\n";
function mifuncion(){
    print("Se llama a mi funcion\n");
    global $message;
    $message = "Amigo";
    
}
print($message);
mifuncion();
print($message)
; ?>