package Parte_1;

public class Estudiante {
    private String Nombre;
    private int Edad;
    private double Promedio;
    private String[] Materia;

    public Estudiante(String nombre, int edad, double promedio, String[] materia) {
        Nombre = nombre;
        Edad = edad;
        Promedio = promedio;
        Materia = materia;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

    public int getEdad() {
        return Edad;
    }

    public void setEdad(int edad) {
        Edad = edad;
    }

    public double getPromedio() {
        return Promedio;
    }

    public void setPromedio(double promedio) {
        Promedio = promedio;
    }

    public String[] getMateria() {
        return Materia;
    }

    public void setMateria(String[] materia) {
        Materia = materia;
    }
}
