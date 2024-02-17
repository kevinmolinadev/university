package Ejercicio_1;

import java.util.ArrayList;
import java.util.List;

public class Serie {
    public void showNumberPrime(int indice){
        List<Integer> primos = new ArrayList<>();
        int numero=2;
        for (int i = 0; numero < indice; i++) {
            boolean esPrimo = true;
            for (int divisor = 2; divisor <= Math.sqrt(numero); divisor++) {
                if (numero % divisor == 0) {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo) {
                primos.add(numero);
            }
            numero++;
        }
        System.out.println(primos);
    }
}
