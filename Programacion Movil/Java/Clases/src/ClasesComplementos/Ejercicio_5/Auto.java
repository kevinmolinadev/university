public class Auto extends Vehiculo {

    public Auto(String modelo, int anho, int precio) {
        super(modelo, anho, precio);
    }

    @Override
    public String toString() {
        return "Auto{" +
                "modelo='" + modelo + '\'' +
                ", anho=" + anho +
                ", precio=" + precio +
                '}';
    }
}
