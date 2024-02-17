public class Triangulo extends Figura  implements Idibujo {
    public Triangulo(String color, int lados) {
        super(color, lados);
    }

    @Override
    public String toString() {
        return "triangulo{" +
                "Color='" + this.Color + '\'' +
                ", Lados=" + this.Lados +
                '}';
    }

    @Override
    public void saludo() {
        System.out.println("Hola soy un triangulo");
    }
}