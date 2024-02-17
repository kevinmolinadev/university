package Ejercicio_2;

public class MainClase {
    public static void main(String[] args) {
        TarjetaCredito tarjetaCredito1=new TarjetaCredito(150,"Gold","15483");
        TarjetaCredito tarjetaCredito2=new TarjetaCredito(15,"Plata","15483");
        TarjetaCredito tarjetaCredito3=new TarjetaCredito(0,"Lito","15483");
        TarjetaDebito tarjetaDebito=new TarjetaDebito(0,"Lomo","18444");
        Cliente cliente = new Cliente();
        cliente.AddTarjeta(tarjetaCredito1);
        cliente.AddTarjeta(tarjetaCredito2);
        cliente.AddTarjeta(tarjetaCredito3);
        cliente.AddTarjeta(tarjetaDebito);
        System.out.println(cliente.obtenerNroTarjetaSaldoVacio());
    }
}
