<?php 
define("HOST","localhost");
define("PORT","8081");
define("PI",3.1416);
if(defined("HOST")){
    print("Constante definida\n");
}else{
    print("No se definio nada\n");
}
if(defined("PASS")){
    print("Constante definida\n");
}else{
    print("No se definio nada\n");
}
//Concatenacion de texto con variables
$universidad="Univalle";
print("Dando clases en $universidad\n");
//pedir datos al usuario
$dato=readline("Ingrese su nombre completo: ");
print("hola $dato\n");
$edad=readline("Ingrese su edad: ");
if($edad>18){
    print("Ya podemos ir de minusas");
}else{
    print("Aun no hay minusas");
}
; ?>