package Ejercicio_11;

public class MainAlumno {
    public static void main(String[] args) {
        Bachillerato alumno = new Bachillerato("Patito","Lucas","Fisica",89);
        Universidad universitario=new Universidad("Patito","Miguel","Algebra",41);
        alumno.setNota(82);
        alumno.detalle();
       // universitario.setNota(82);
        universitario.detalle();

    }
}
