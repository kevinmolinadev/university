public class Cuadrado extends Figura implements Idibujo {
    public Cuadrado (String color,int lados){
        super(color,lados);
    }

    @Override
    public String toString() {
        return "Cuadrado{" +
                "Color='" + this.Color + '\'' +
                ", Lados=" + this.Lados +
                '}';
    }

    @Override
    public void saludo() {
        System.out.println("Hola soy un cuadrado");
    }
}
