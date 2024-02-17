package Ejercicio_3;

import Ejercicio_3.Animal;

public class Perro extends Animal {
    public Perro(String nombre, int edad) {
        super(nombre, edad);
    }
    @Override
    public void sonido() {
        System.out.println("El perro "+getNombre()+" hace *sonido de perro* :D tiene "+getEdad()+" años");;
    }
}
