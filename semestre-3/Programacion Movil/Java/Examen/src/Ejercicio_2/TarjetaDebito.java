package Ejercicio_2;

public class TarjetaDebito extends TarjetaCredito{
    public TarjetaDebito(int Saldo, String Nombre, String numeroTarjeta) {
        super(Saldo, Nombre, numeroTarjeta);
    }

    @Override
    public String obtenerNumero() {
        return getNumeroTarjeta();
    }

    @Override
    public int obtenerSaldo() {
        return getSaldo();
    }
}
