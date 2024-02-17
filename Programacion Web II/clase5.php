<!-- ARRAYS -->
<?php 
$A=["uno",2,3.0,4,"cinco"];//Array definido
$B=["uno"=>1,2=>"dos",3.0,4,"cinco"];//Array definido
/* for($a=0;$a<5;$a++){
    print("$B[$a]\n");
} */
//print_r($A);
//print_r($B);
//unset($B);
if(isset($B)){
    //print("Variable definida\n");
    foreach($B as $valor){
        print("$valor\n");
    }
}else{
    print("Variable no definida\n");
}

$C=[1,5,7,63,4];
asort($C);
print_r($C);
ksort($C);
print_r($C);
//Ordenamiento de array de forma artesanal
$D=["hola","como","estan","univalle","jeje"];
$limite=count($D);
for ($i = 0; $i < $limite; $i++) {
    for ($j = $i+1; $j < $limite; $j++) {
        if ($D[$i] > $D[$j]) {
            $temp = $D[$i];
            $D[$i] = $D[$j];
            $D[$j] = $temp;
        }
    }
}
print_r($D);
; ?>