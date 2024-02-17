public class Circulo extends Figura implements Idibujo{
    private int Radio;
    public Circulo (String color, int radio){
        super(color,0);
        this.Radio=radio;
    }

    public int getRadio() {
        return this.Radio;
    }

    public void setRadio(int radio) {
        this.Radio = radio;
    }

    @Override
    public String toString() {
        return "Circulo{" +
                "Color='" + this.Color + '\'' +
                ", Radio=" + this.Radio +
                '}';
    }

    @Override
    public void saludo() {
        System.out.println("Hola soy un circulo");
    }
}
