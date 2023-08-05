package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.example.myapplication.series.Numeros;

public class MainActivity extends AppCompatActivity {
    EditText inputNumero;
    Button bntGenerar;
    TextView outputNumero;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        inputNumero=findViewById(R.id.inputNumero);
        bntGenerar=findViewById(R.id.button);
        outputNumero=findViewById(R.id.outputNumero);
        Numeros numeros= new Numeros();
        bntGenerar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int indice=Integer.valueOf(inputNumero.getText().toString());
                StringBuilder salida=numeros.numerosImpares(indice);
                outputNumero.setText(salida);

            }
        });

    }
}