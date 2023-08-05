package com.example.programa;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.google.android.material.snackbar.Snackbar;

public class MainActivity extends AppCompatActivity {
    EditText userR;
    EditText passwordR;
    Button  login;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        userR=findViewById(R.id.text);
        passwordR=findViewById(R.id.textPassword);
        login=findViewById(R.id.btnlogin);
        login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String password = passwordR.getText().toString().trim();
                String user = userR.getText().toString().trim();
                if (password.length()>= 4 && password.length() <= 10 && password.matches("^[a-zA-Z0-9]*$") && user.matches("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$")) {
                    Intent intent = new Intent(MainActivity.this, Main2Activity.class);
                    startActivity(intent);
                } else {
                    Snackbar.make(login, "Debe ingresar un correo válido y una contraseña con un minimo de 4 y un máximo de 10 caracteres", Snackbar.LENGTH_SHORT).show();
                }
            }

        });
    }
}