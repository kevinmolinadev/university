public class Planeta {

    String nombre;
    String sistemaSolar;

    public Planeta(String nombre, String sistemaSolar) {
        this.nombre = nombre;
        this.sistemaSolar = sistemaSolar;
    }

    public void girar() {
        System.out.println("El planeta " + nombre + " está girando al rededor del sol");
    }
}
