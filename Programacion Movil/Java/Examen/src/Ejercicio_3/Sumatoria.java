package Ejercicio_3;

import javax.naming.Binding;
import java.util.ArrayList;
import java.util.List;

public class Sumatoria {
    public int ShowNumber(int indice){
        int resultado=0;
        List<Integer> sumatoria = new ArrayList<>();
        for(int i=1;i<=indice;i++){
            for(int j=1;j<=i;j++){
                sumatoria.add(i);
            }
        }
        System.out.println(sumatoria);
        /*int index=indice-1;
        System.out.println(index);
        sumatoria.remove(sumatoria.size()-(indice));
        for(int i:sumatoria){
            resultado+=i;
        }*/
        for(int i=0;i<indice;i++){
            resultado+=sumatoria.get(i);
        }
        return resultado;
    }
}
