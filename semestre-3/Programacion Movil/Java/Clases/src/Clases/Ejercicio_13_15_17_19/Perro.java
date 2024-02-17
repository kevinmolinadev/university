public class Perro extends Mascota {

    String raza;
    int altura;

    public Perro(String nombre, int peso, String raza, int altura) {
        super(nombre, peso);
        this.raza = raza;
        this.altura = altura;
    }

    public int AlturaPeso() {
        int alturaPeso = altura / peso;
        return alturaPeso;
    }

    @Override
    public String toString() {
        return "Perro{" +
                "raza='" + raza + '\'' +
                ", altura=" + altura +
                ", nombre='" + nombre + '\'' +
                ", peso=" + peso +
                '}';
    }
}
