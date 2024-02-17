package Complemento;

import Ejercicio_2.GestionTareas;

import java.util.ArrayList;
import java.util.List;

public class Estudiante {
    private String Nombre;
    private String Edad;
    private double Promedio=0;
    private List<Materia> Materias=new ArrayList<>();
    public Estudiante(String nombre,String edad){
        this.Nombre=nombre;
        this.Edad=edad;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

    public String getEdad() {
        return Edad;
    }

    public void setEdad(String edad) {
        Edad = edad;
    }

    public double getPromedio() {
        return Promedio;
    }

    public void setPromedio(double promedio) {
        Promedio = promedio;
    }

    public List<Materia> getMaterias() {
        return Materias;
    }

    public void setMaterias(Materia materias) {
        Materias.add(materias);
    }

    public void CalcularPromedio(){
        for(Materia indice: this.Materias){
            this.Promedio+=indice.getNota();
        }
        /*for(int i=0;i<this.Materias.size();i++){
            resultado+=this.Materias.get(i).getNota();
        }*/
        this.Promedio/=this.Materias.size();
        System.out.println("El promedio de "+this.Nombre+" es "+this.Promedio);
    }
}
