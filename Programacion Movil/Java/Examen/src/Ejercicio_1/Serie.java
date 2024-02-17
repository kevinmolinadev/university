package Ejercicio_1;

import java.util.ArrayList;
import java.util.List;

public class Serie {
    public void serie(int indice){
        List<Integer> serie = new ArrayList<>();
        int inicio=1;
        if(indice==0){serie.add(0);}
        for (int i=0;i<indice;i++){
                inicio*=2;
                serie.add(inicio);
        }
        System.out.println(serie);
    }
}
