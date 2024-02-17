public class Figura{
    public String Color;
    public int Lados;

    public Figura(String color, int lados) {
        Color = color;
        Lados = lados;
    }

    public String getColor() {
        return this.Color;
    }

    public void setColor(String color) {
        this.Color = color;
    }

    public int getLados() {
        return this.Lados;
    }

    public void setLados(int lados) {
        this.Lados = lados;
    }

    @Override
    public String toString() {
        return "Figura{" +
                "Color='" + this.Color + '\'' +
                ", Lados=" + this.Lados +
                '}';
    }
}
