public class Pato extends Mascota{

    String raza;
    boolean volador = true;

    public Pato(String nombre, int peso, String raza, boolean volador) {
        super(nombre, peso);
        this.raza = raza;
        this.volador = volador;
    }

    public void huyeCazador() {
        if (volador == true) {
            System.out.println("El pato huye del cazador volando");
        }
        else {
            System.out.println("El cazador lo caza por no poder volar");
        }
    }

    @Override
    public String toString() {
        return "Pato{" +
                "raza='" + raza + '\'' +
                ", volador=" + volador +
                ", nombre='" + nombre + '\'' +
                ", peso=" + peso +
                '}';
    }
}
