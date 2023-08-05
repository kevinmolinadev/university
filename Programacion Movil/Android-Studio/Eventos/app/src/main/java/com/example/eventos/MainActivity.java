package com.example.eventos;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.text.InputType;
import android.view.Gravity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Spinner;

import com.example.eventos.Clases.Pantalla;
import com.google.android.material.snackbar.Snackbar;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    private Pantalla surfaceView;
    String[] colors = {"Linea", "Estrella", "Rectangulo", "Circulo"};
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Surface();
    }
    public void Surface(){
        LinearLayout lienzo= new LinearLayout(this);
        lienzo.setOrientation(LinearLayout.VERTICAL);
        lienzo.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT,LinearLayout.LayoutParams.MATCH_PARENT));
        lienzo.setGravity(Gravity.CENTER);
        lienzo.setBackgroundColor(Color.WHITE);
        Button btnM = new Button(this);
        btnM.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT));
        btnM.setText("LIMPIAR");
        Spinner spinner = new Spinner(this);
        spinner.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT));
        ArrayAdapter<String> spinnerAdapter = new ArrayAdapter<>(this, android.R.layout.simple_spinner_item, colors);
        spinner.setAdapter(spinnerAdapter);
        spinner.setX(320);
        spinner.setY(75);
        //colores();
        btnM.setOnClickListener(new View.OnClickListener() {
            //int i=0;
            @Override
            public void onClick(View view) {
                surfaceView.clear();
                //i = (i + 1) % colors.size();
                //surfaceView.canbio(colors.get(i));
            }
        });
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int position, long id) {
                System.out.println(position);
                switch (position){
                    case 0:
                        surfaceView.clear();
                        surfaceView.drawLine();
                        break;
                    case 1:
                        surfaceView.clear();
                        surfaceView.drawStar();
                        break;
                    case 2:
                        surfaceView.clear();
                        surfaceView.drawRectangle();
                        break;
                    case 4:
                        surfaceView.clear();
                        surfaceView.drawCircle();
                        break;
                }
            }
            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {
            }
        });
        lienzo.addView(spinner);
        lienzo.addView(btnM);
        surfaceView = new Pantalla(this);
        lienzo.addView(surfaceView);
        setContentView(lienzo);
    }
}