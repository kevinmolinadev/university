<?php 
$a;
if(isset($a)){
    print("Variable con valor\n");
}else{
    print("sin valor\n");
}
$nombre="Kevin";
if(assert($nombre)){
    print("Hola ".$nombre."\n");
}
unset($a);
if(isset($a)){
    print("Variable con valor\n");
}else{
    print("Destruido\n");
}
$b=true;
if(empty($b)){
    print("no hay nada");
}else{
    print("Si esta lleno");
}
; ?>