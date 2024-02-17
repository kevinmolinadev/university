package com.example.myapplication.series;

public class Numeros {
    public StringBuilder numerosImpares(int indice){
        StringBuilder cadena = new StringBuilder();
        int inicio=1;
        for (int i=0; i<indice;i++){
            cadena.append(inicio).append(",");
            inicio+=2;
        }
        return cadena;
    }
}
