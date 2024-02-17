void main(){
  //Person person = Person('kevin',null,'Molina');
  //print(person);
    int? edad;
    List<int>? edades;
    edad=edades?:"";
}

void changeString(String string){
  string.toUpperCase();
}
class Person {
  String? nombre;
  String? apellido;
  int? edad;
  List<int>? edades;
  Person(String nombre,int? edad,String? apellido){
    this.nombre=nombre;
    this.edad=edad??0;
    this.apellido=apellido??"Sin apellido";
  }
  @override
  String toString() {

    edad=edades?[0];
    return '$nombre - $edad - $apellido';
  }

}