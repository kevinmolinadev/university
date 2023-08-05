package Ejercicio_2;

import java.util.ArrayList;
import java.util.List;

public class Cliente {
    private List<Itarjeta> Tarjetas = new ArrayList<>();
    public String obtenerNroTarjetaSaldoVacio(){
        String Detalle="";
        for (Itarjeta indice: this.Tarjetas){
            if(indice.obtenerSaldo()==0){
                Detalle+=indice.obtenerNumero()+"\n";
            }
        }
        return Detalle;
    }
    public void AddTarjeta(Itarjeta tarjeta){
        this.Tarjetas.add(tarjeta);
    }
}
