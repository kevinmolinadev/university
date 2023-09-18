void main(){
  var hola=1; 
  //Numeros
  int number=10;
  int number2=20;
  double number3=15.5;
  double result=++number3;
  print(result);
  print(number2);

  //String
  String cadena1="Hola $hola"; //interpolacion de datos con $<variable>
  String cadena2="Amigos";
  print(cadena1.toUpperCase());

  //List

  //Set

  //Map / 

  Map<dynamic,String> diccionario={
    "uno":"Hola",
    2:"Amigos",
    3:""
  };
  print(diccionario);
  Map<dynamic,String> diccionarioUpper=diccionario.map((key, value) => MapEntry(key, value.toUpperCase()));
  print(diccionarioUpper);
}