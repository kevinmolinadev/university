package Ejercicio_3;

import Ejercicio_3.Animal;

public class Gato extends Animal {

    public Gato(String nombre, int edad) {
        super(nombre, edad);
    }

    @Override
    public void sonido() {
        System.out.println("El gato "+getNombre()+" hace *sonido de gato* :D tiene "+getEdad()+" años");

    }
}
