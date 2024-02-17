package Complemento;

public class Materia{
    private String Nombre;
    private int Nota;

    public Materia(String nombre, int nota) {
        Nombre = nombre;
        Nota = nota;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

    public int getNota() {
        return Nota;
    }

    public void setNota(int nota) {
        Nota = nota;
    }
}
