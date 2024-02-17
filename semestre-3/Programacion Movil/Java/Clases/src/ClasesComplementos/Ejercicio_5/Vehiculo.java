public abstract class Vehiculo {

    String modelo;
    int anho;
    double precio;

    public Vehiculo(String modelo, int anho, int precio) {
        this.modelo = modelo;
        this.anho = anho;
        this.precio = precio;
    }

    public double CalcularPrecioVenta() {
        double precioVenta = precio + precio * 0.1;
        return precioVenta;
    }
}
