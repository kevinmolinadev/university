package com.example.jueguito;

import androidx.appcompat.app.AppCompatActivity;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;


import com.google.android.material.snackbar.Snackbar;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;

public class MainActivity extends AppCompatActivity {
    ImageView imgTL;
    ImageView imgTR;
    ImageView imgBL;
    ImageView imgBR;
    Drawable anterior;
    Drawable despues;
    int posicion=0;
    Drawable []orden = new Drawable[4];
    Button mezclar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getSupportActionBar().hide();
        imgTL=findViewById(R.id.imageFilterView);
        imgTR=findViewById(R.id.imageFilterView2);
        imgBL=findViewById(R.id.imageFilterView3);
        imgBR=findViewById(R.id.imageFilterView4);
        mezclar=findViewById(R.id.button);
        Drawable []lista={imgTL.getDrawable(),imgTR.getDrawable(),imgBL.getDrawable(),imgBR.getDrawable()};
        mezclar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int[] numerosGenerados = new int[4];
                int i = 0;
                Random random = new Random();
                while (i < lista.length) {
                    int numeroA = random.nextInt(4) + 1;
                    boolean repetido = false;
                    for (int j = 0; j < i; j++) {
                        if (numerosGenerados[j] == numeroA) {
                            repetido = true;
                            break;
                        }
                    }
                    if (!repetido) {
                        numerosGenerados[i] = numeroA;
                        imgs(numeroA, lista[i]);
                        i++;
                    }
                }
            }
        });

        imgTL.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(anterior==null){
                    anterior=imgTL.getDrawable();
                    orden[0]=anterior;
                }else {
                    despues=imgTL.getDrawable();
                    imgTL.setImageDrawable(anterior);
                    imgs(posicion,despues);
                    anterior=null;
                }
                posicion=1;
                System.out.println(posicion);
                alerta(imgTL);
            }
        });
        imgTR.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(anterior==null){
                    anterior=imgTR.getDrawable();
                    orden[1]=anterior;
                }else {
                    despues=imgTR.getDrawable();
                    imgTR.setImageDrawable(anterior);
                    imgs(posicion,despues);
                    anterior = null;
                }
                posicion=2;
                System.out.println(posicion);
                alerta(imgTR);

            }
        });
        imgBL.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(anterior==null){
                    anterior=imgBL.getDrawable();
                    orden[2]=anterior;
                }else {
                    despues=imgBL.getDrawable();
                    imgBL.setImageDrawable(anterior);
                    imgs(posicion,despues);
                    anterior = null;
                }
                posicion=3;;
                System.out.println(posicion);
                alerta(imgBL);

            }
        });
        imgBR.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(anterior==null){
                    anterior=imgBR.getDrawable();
                    orden[3]=anterior;
                }else {
                    despues=imgBR.getDrawable();
                    imgBR.setImageDrawable(anterior);
                    imgs(posicion,despues);
                    anterior = null;
                }
                posicion=4;
                System.out.println(posicion);
                alerta(imgBR);
            }
        });
    }
    public void imgs(int indice, Drawable canbio){
        switch (indice){
            case 1:
                imgTL.setImageDrawable(canbio);
                break;
            case 2:
                imgTR.setImageDrawable(canbio);
                break;
            case 3:
                imgBL.setImageDrawable(canbio);
                break;
            case 4:
                imgBR.setImageDrawable(canbio);
                break;
            default:
                System.out.println("Índice no válido");
                break;
        }
    }
    public void alerta(View img){
        Snackbar.make(img, "GANASTE :D", Snackbar.LENGTH_SHORT).show();
    }
}