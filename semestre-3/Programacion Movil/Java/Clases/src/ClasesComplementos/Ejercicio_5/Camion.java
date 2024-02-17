public class Camion extends Vehiculo {

    public Camion(String modelo, int anho, int precio) {
        super(modelo, anho, precio);
    }

    @Override
    public String toString() {
        return "Camion{" +
                "modelo='" + modelo + '\'' +
                ", anho=" + anho +
                ", precio=" + precio +
                '}';
    }
}
