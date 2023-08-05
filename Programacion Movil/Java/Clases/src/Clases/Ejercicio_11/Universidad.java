package Ejercicio_11;

public class Universidad extends Alumno implements Registro {
    private int Nota;
    private boolean Estado;

    public Universidad(String nombre,String apellido,String materia,int nota) {
        super(nombre,apellido,materia);
        this.Nota=nota;
        this.Estado=false;
    }

    public int getNota() {
        return this.Nota;
    }

    public void setNota(int nota) {
        this.Nota = nota;
    }

    public boolean isEstado() {
        if(this.Nota>50){
            return this.Estado=true;

        }else {
            return this.Estado=false;
        }
    }

    @Override
    public void detalle() {
        System.out.println("El Universitario " + getNombre() + " " + getApellido() + " " + estado() + " la materia de " + getMateria());
    }

    @Override
    public String estado() {
        String estado = "";
        if (isEstado()) {
            estado = "aprobo";
        } else {
            estado = "reprobo";
        }
        return estado;
    }
}
