public class Mascota {

    public String nombre;
    public int peso;

    public Mascota(String nombre, int peso) {
        this.nombre = nombre;
        this.peso = peso;
    }

    public void tuMascotaTeAcompanha() {
        System.out.println("Tu mascota " + nombre + " se sienta a tu lado");
    }
}