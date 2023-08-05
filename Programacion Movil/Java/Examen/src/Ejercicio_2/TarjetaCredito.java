package Ejercicio_2;

public class TarjetaCredito implements Itarjeta{
    private int Saldo;
    private String Nombre;
    private String NumeroTarjeta;
    private String Fecha;

    public TarjetaCredito(int Saldo, String Nombre,String numeroTarjeta) {
        this.Saldo = Saldo;
        this.Nombre = Nombre;
        this.NumeroTarjeta=numeroTarjeta;
    }

    public int getSaldo() {
        return Saldo;
    }

    public void setSaldo(int Saldo) {
        this.Saldo = Saldo;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public String getNumeroTarjeta() {
        return NumeroTarjeta;
    }

    public void setNumeroTarjeta(String NumeroTarjeta) {
        this.NumeroTarjeta = NumeroTarjeta;
    }

    public String getFecha() {
        return Fecha;
    }

    public void setFecha(String Fecha) {
        this.Fecha = Fecha;
    }

    @Override
    public String obtenerNumero() {
        return this.NumeroTarjeta;
    }

    @Override
    public int obtenerSaldo() {
        return this.Saldo;
    }
}
