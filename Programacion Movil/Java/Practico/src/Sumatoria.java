public class Sumatoria {
    public  int sumarPar(int indice){
        int suma=0;
        for (int i=1;i<=indice;i++){
            suma+=i*2;
        }
        return  suma;
    }
    public int sumarInpar(int indice){
        int suma=0;
        int recorido=1;
        for (int i=1;i<=indice;i++){
            suma+=recorido;
            recorido+=2;
        }
        return  suma;
    }
    //Ejercicio1
    public int  ejercicio1(int indice){
        //3 + 6 + 12 + 24 + 48.....
        int resultado=3;
        int aux=3;
        for (int i=0;i<indice-1;i++){
            aux=aux*2;
            resultado += aux;
        }
        return resultado;
    }
    //Ejercicio3
    public int  ejercicio3(int indice){
        //1 + 4 + 9 + 16 + 25.....
        int resultado=0;
        for (int i=1;i<=indice;i++){
            int aux=i*i;
            resultado += aux;
        }
        return resultado;
    }
    public int  ejercicio5(int indice){
        //1 + 2 – 3 + 4 – 5 + 6 – 7.....
        int resultado=0;
        int aux=0;
        for (int i = 1; i <= indice; i++) {
            aux++;
            if (i>1 && i%2!=0){
                resultado = resultado - aux;
            }else {
                resultado+=i;
            }
        }
        return resultado;
    }
}
