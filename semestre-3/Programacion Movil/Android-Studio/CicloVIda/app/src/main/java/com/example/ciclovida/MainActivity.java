package com.example.ciclovida;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    EditText texto;
    Button btn;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        texto=findViewById(R.id.editTextTextPersonName2);
        btn=findViewById(R.id.button);
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String text=texto.getText().toString();
                Intent intent = new Intent(MainActivity.this, Main2Activity.class);
                intent.putExtra("text",text);
                startActivity(intent);
            }
        });
        System.out.println("Me acabo de crear");
    }

    @Override
    protected void onStart() {
        super.onStart();
        System.out.println("Iniciamos");
    }

    @Override
    protected void onResume() {
        super.onResume();
        System.out.println("Hola de nuevo");
        //Intent intent = new Intent(MainActivity.this, Main2Activity.class);
        //startActivity(intent);
    }

    @Override
    protected void onPause() {
        super.onPause();
        System.out.println("No se mueva");
    }

    @Override
    protected void onStop() {
        super.onStop();
        System.out.println("Adios");
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        System.out.println("Ya no volvemos");
    }
}