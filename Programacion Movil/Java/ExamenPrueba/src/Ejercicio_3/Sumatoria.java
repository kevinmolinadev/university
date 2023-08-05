package Ejercicio_3;

public class Sumatoria {
    public int Sumar(int indice){
        int resultado=0,ultimo=60,inicio=1,implemento=2;
        for(int i=1;i<=indice/2;i++){
            resultado+=ultimo+inicio;
            ultimo-=implemento;
            inicio+=implemento;
        }
        if(indice%2!=0){
            resultado+=ultimo;
        }
        return resultado;
    }
}
