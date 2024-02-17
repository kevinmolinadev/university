package com.example.series.Clases;
public class Serie {
    private int indice;

    public int getIndice() {
        return indice;
    }

    public void setIndice(int indice) {
        this.indice = indice;
    }
    //Serie1
    public String serie1(){
        int [] num = {1,4};
        int resultado = 4;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < indice; i++) {
            num[1] = resultado;
            sb.append(resultado).append(",");
            resultado = num[0] + num[1];
            num[0] = num[1];
        }
        return sb.toString();
    }

    public String serie3(){
        int [] num = {1,1};
        int resultado = 0;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < indice; i++) {
            num[1] = resultado;
            resultado = num[0] + num[1];
            num[0] = num[1];
            sb.append(resultado).append(",");
        }
        return sb.toString();
    }

    public String serie5(){
        int resultado,numero = 0;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < indice; i++) {
            sb.append((numero+=i)*2).append(",");
        }
        return sb.toString();
    }

    // Genera la siguiente cadena 1,2,3,5,7,11,13,17...
    public  String serie7(){
        String numero = ""; int num = 1;
        int printedCount = 0; // El número de números primos que se han impreso
        while (printedCount < indice) {
            boolean isPrime = true; // Un indicador para almacenar si el número es primo o no

            // Verificar si el número es primo
            for (int i = 2; i <= Math.sqrt(num); i++) {
                if (num % i == 0) {
                    isPrime = false;
                    break;
                }
            }
            // Imprimir el número si es primo
            if (isPrime) {
                numero+=num + ",";
                printedCount++;
            }
            num++;
        }
        return numero;
    }
    //Generea 1,2,4,5,10,11,22
    public String serie9(){
        String numeros = ""; int num=1;
        for (int i = 0; i < indice; i++) {
            numeros+= String.valueOf(num) +"," ;
            num = (i % 2 != 0) ? num*2 : num+1;
        }
        return numeros;
    }

    //Generar 1,1,2,1,2,3,1,2,3,4,1,2,3,4,5,1,2,3,4,5,6
    public String serie11(){
        String Numeros = "";
        int num=0,limite =1;
        for (int i = 0; i < indice; i++){
            if (num==limite){
                limite +=1;
                num=1;
            }else{
                num+=1;
            }
            Numeros+= String.valueOf(num) +"," ;
        }
        return  Numeros;
    }
    //Serie 13
    public String  serie13(){
        //3, 8, 13, 18, 23, 28, 33, 38
        int resultado = 3;
        int integracion = 5;
        StringBuilder serie = new StringBuilder();
        serie.append(resultado);
        for (int i = 1; i < indice; i++) {
            resultado += integracion;
            serie.append(", ");
            serie.append(resultado);
            //forma simplificada serie.append(", ").append(resultado);
        }
        return serie.toString();
    }

    //Serie 15
    public String serie15() {
        //1, 8, 27, 64, 125, 216, 343, 512, 729
        StringBuilder serie = new StringBuilder();
        for (int i = 1; i <= indice; i++) {
            int resultado = i*i*i;
            serie.append(resultado);
            if (i < indice) {
                serie.append(", ");
            }
        }
        return serie.toString();
    }

    //serie 17
    public String serie17() {
        //si n = 8 generar 8, 1, 7, 2, 6, 3,5, 4
        int numero=8;
        StringBuilder serie = new StringBuilder();
        int integracion=1;
        int inicio=1;
        for (int i = 0; i < indice/2; i++) {
            if (numero%2==0) {
                serie.append(numero).append(", ");
                numero -= integracion;
                serie.append(inicio).append(", ");
                inicio+=integracion;
            }else {
                serie.append(numero).append(", ");
                numero -=integracion;
                serie.append(inicio).append(", ");
                inicio+=integracion;
            }

        }
        if(indice%2!=0){
            serie.append(numero);
        }
        return serie.toString();
    }

    //serie 19
    public String serie19(){
        //1, 20, 3, 18, 5, 16, 7, 14, 9, 12, 11, 10, 13, 8, 15, 6, 17, 4, 19, 2, 21, 0
        StringBuilder serie = new StringBuilder();
        int integracion=2;
        int numero=20;
        int inicio=1;
        for (int i = 0; i < indice/2; i++) {
            if (numero%2==0) {
                serie.append(inicio).append(", ");
                inicio+=integracion;
                serie.append(numero).append(", ");
                numero -= integracion;
            }else {
                serie.append(inicio).append(", ");
                inicio+=integracion;
                serie.append(numero).append(", ");
                numero -=integracion;
            }

        }
        if(indice%2!=0){
            serie.append(inicio);
        }
        return serie.toString();
    }

    //serie 24

    //serie 25
    public String serie25() {
        //1, 10, 100, 1000.....
        StringBuilder serie = new StringBuilder();
        int resultado = 1;
        serie.append(resultado).append(", ");
        for (int i = 1; i < indice; i++) {
            resultado *= 10;
            serie.append(resultado);
            if (i < indice-1) {
                serie.append(", ");
            }
        }
        return serie.toString();
    }
}

