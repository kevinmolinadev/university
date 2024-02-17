public class Gato extends Mascota implements IMetodos {

    String color;
    int vidas;

    public Gato(String nombre, int peso, String color, int vidas) {
        super(nombre, peso);
        this.color = color;
        this.vidas = vidas;
    }

    public int menosVidas() {
        return vidas - 1;
    }

    @Override
    public String toString() {
        return "Gato{" +
                "color='" + color + '\'' +
                ", vidas=" + vidas +
                ", nombre='" + nombre + '\'' +
                ", peso=" + peso +
                '}';
    }

    @Override
    public void metodoDeInterfaz() {
        System.out.println("Este es el metodo por interfaz");
    }
}
