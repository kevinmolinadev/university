package Ejercicio_11;

public abstract class Alumno {
    private String Nombre;
    private String Apellido;
    private String Materia;

    public Alumno(String nombre,String apellido, String materia) {
        this.Nombre = nombre;
        this.Apellido=apellido;
        this.Materia=materia;
    }

    public String getNombre() {
        return this.Nombre;
    }

    public void setNombre(String nombre) {
        this.Nombre = nombre;
    }

    public String getApellido() {
        return this.Apellido;
    }

    public String getMateria() {
        return this.Materia;
    }

    public void setMateria(String materia) {
        this.Materia = materia;
    }

    public void setApellido(String apellido) {
        this.Apellido = apellido;
    }

    public abstract void detalle();
}
