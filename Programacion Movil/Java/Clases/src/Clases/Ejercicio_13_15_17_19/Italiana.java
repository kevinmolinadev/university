public class Italiana extends TipoDeComida {

    boolean tienePasta;
    boolean esPizza;

    public Italiana(String nombreComida, int peso, boolean tienePasta, boolean esPizza) {
        super(nombreComida, peso);
        this.tienePasta = tienePasta;
        this.esPizza = esPizza;
    }

    public void esComidaItaliana() {
        if (tienePasta == true) {
            System.out.println("Es comida italiana, disfruta");
        }
        else {
            System.out.println("No es comida italiana");
        }
    }

    @Override
    public String toString() {
        return "Italiana{" +
                "tienePasta=" + tienePasta +
                ", esPizza=" + esPizza +
                ", nombreComida='" + nombreComida + '\'' +
                ", peso=" + peso +
                '}';
    }
}
