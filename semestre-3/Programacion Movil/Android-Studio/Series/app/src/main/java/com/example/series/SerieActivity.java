package com.example.series;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;

import com.example.series.Clases.Serie;

public class SerieActivity extends AppCompatActivity implements AdapterView.OnItemSelectedListener {
    String[] series={"Selecione una opcion","Serie 1","Serie 3","Serie 5","Serie 7","Serie 9","Serie 11","Serie 13","Serie 15","Serie 17","Serie 19"};
    Spinner opcionSeries;
    EditText inputNumero;
    Button btnSeries;
    TextView outputNumero;
    int indice;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_serie);
        opcionSeries=findViewById(R.id.spinner);
        opcionSeries.setOnItemSelectedListener(this);

        ArrayAdapter listaSeries = new ArrayAdapter(this, android.R.layout.simple_spinner_item, series);
        listaSeries.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        opcionSeries.setAdapter(listaSeries);

        inputNumero=findViewById(R.id.indice);
        btnSeries=findViewById(R.id.button);
        outputNumero=findViewById(R.id.textView);

        Serie serie= new Serie();
        btnSeries.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String salida="";
                if (!inputNumero.getText().toString().isEmpty()) {
                    int indiceSerie = Integer.parseInt(inputNumero.getText().toString());
                    serie.setIndice(indiceSerie);
                    switch (indice){
                    case 0:
                        outputNumero.setText("Opcion :D");
                        break;
                    case 1:
                        salida = serie.serie1();
                        outputNumero.setText(salida);
                        break;
                    case 2:
                        salida = serie.serie3();
                        outputNumero.setText(salida);
                        break;
                    case 3:
                        salida = serie.serie5();
                        outputNumero.setText(salida);
                        break;
                    case 4:
                        salida = serie.serie7();
                        outputNumero.setText(salida);
                        break;
                    case 5:
                        salida = serie.serie9();
                        outputNumero.setText(salida);
                        break;
                    case 6:
                        salida = serie.serie11();
                        outputNumero.setText(salida);
                        break;
                    case 7:
                        salida = serie.serie13();
                        outputNumero.setText(salida);
                        break;
                    case 8:
                        salida = serie.serie15();
                        outputNumero.setText(salida);
                        break;
                    case 9:
                        salida= serie.serie17();
                        outputNumero.setText(salida);
                        break;
                    case 10:
                        salida = serie.serie19();
                        outputNumero.setText(salida);
                        break;
                }
                } else {
                    outputNumero.setText("Ingrese un indice :D");
                }
            }
        });

    }

    @Override
    public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
        String aux = series[i];
        System.out.println(aux);
        indice=i;
    }

    @Override
    public void onNothingSelected(AdapterView<?> adapterView) {

    }
}