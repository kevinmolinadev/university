package com.example.programa;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.TextView;

import com.google.android.material.snackbar.Snackbar;

public class Main2Activity extends AppCompatActivity {
    CheckBox chbx;
    Button btn_chbx;
    TextView capicua;
    Button btn_moveT;
    Button btn_moveR;
    View imgC;
    Button btn_moveB;
    Button btn_moveL;
    Button btn_capicua;
    Button lista;
    androidx.constraintlayout.utils.widget.ImageFilterView img;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        chbx=findViewById(R.id.checkBox);
        btn_chbx=findViewById(R.id.btnCheck);
        imgC=findViewById(R.id.imgC);
        img=findViewById(R.id.imgMover);
        btn_moveT=findViewById(R.id.btnMoverT);
        btn_moveR=findViewById(R.id.btnMoverR);
        btn_moveB=findViewById(R.id.btnMoverB);
        btn_moveL=findViewById(R.id.btnMoverL);
        capicua=findViewById(R.id.textCapicua);
        btn_capicua=findViewById(R.id.btmCapicua);
        lista=findViewById(R.id.btnlista);
        /*int limiteX=imgC.getWidth();
        int limiteY=imgC.getHeight();*/
        btn_chbx.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(chbx.isChecked()){
                    Snackbar.make(btn_chbx,"El CheckBox esta selecionado",Snackbar.LENGTH_SHORT).show();
                }else{
                    Snackbar.make(btn_chbx,"El CheckBox no esta selecionado",Snackbar.LENGTH_SHORT).show();
                }
            }
        });

        btn_moveT.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(img.getY() >= 0){
                    img.setY(img.getY() - 10);
                }
            }
        });
        btn_moveR.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                if (img.getX() <=550){
                    img.setX(img.getX() + 10);
                }
            }
        });
        btn_moveB.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (img.getY() <= 550){
                    img.setY(img.getY() + 10);
                }
            }
        });
        btn_moveL.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (img.getX() >=0 ){
                    img.setX(img.getX() - 10);
                }
            }
        });
        btn_capicua.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String numero = capicua.getText().toString();
                String numeroReversado = new StringBuilder(numero).reverse().toString();
                /*CODIGO QUE HICE*/
                if (numero.isEmpty()) {
                    Snackbar.make(btn_capicua,"No se ingreso ningun numero",Snackbar.LENGTH_SHORT).show();
                    btn_capicua.setBackgroundColor(Color.parseColor("#ff9F56"));
                } else {
                    if(numero.equals(numeroReversado)){
                        btn_capicua.setBackgroundColor(Color.parseColor("#239B56"));
                        System.out.println(numero.equals(numeroReversado));
                    }else{
                        btn_capicua.setBackgroundColor(Color.parseColor("#A93226"));
                    }
                }
                /*CODIGO GPT*/
                /*int COLOR_CAPICUA = Color.parseColor("#239B56");
                int COLOR_NO_CAPICUA = Color.parseColor("#A93226");
                if (numero.isEmpty()) {
                    Snackbar.make(btn_capicua, "No se ingresó ningún número", Snackbar.LENGTH_SHORT).show();
                } else {
                    boolean esCapicua = numero.equals(numeroReversado);
                    int colorFondo = esCapicua ? COLOR_CAPICUA : COLOR_NO_CAPICUA;
                    btn_capicua.setBackgroundColor(colorFondo);
                }*/
            }
        });
        lista.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Main2Activity.this, Main3Activity.class);
                startActivity(intent);
            }
        });
    }
}