public class Mexicana extends TipoDeComida {

    boolean tieneTortilla = true;
    boolean tieneChile = true;

    public Mexicana(String nombreComida, int peso, boolean tieneTortilla, boolean tieneChile) {
        super(nombreComida, peso);
        this.tieneTortilla = tieneTortilla;
        this.tieneChile = tieneChile;
    }

    public void esMexicanaNot() {
        if (tieneChile == true && tieneTortilla == true) {
            System.out.println("Tiene tortilla y chile, es comida mexicana");
        }
        else {
            System.out.println("Le falta tortilla o chile, no es comida mexicanca");
        }
    }

    @Override
    public String toString() {
        return "Mexicana{" +
                "tieneTortilla=" + tieneTortilla +
                ", tieneChile=" + tieneChile +
                ", nombreComida='" + nombreComida + '\'' +
                ", peso=" + peso +
                '}';
    }
}
