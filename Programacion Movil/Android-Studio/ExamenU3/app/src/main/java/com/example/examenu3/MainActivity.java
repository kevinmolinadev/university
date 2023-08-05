package com.example.examenu3;

import static java.lang.Thread.sleep;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.widget.TextView;
import java.util.Timer;
import java.util.TimerTask;

public class MainActivity extends AppCompatActivity{
    TextView mensaje;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        mensaje=findViewById(R.id.Mensaje);
    }

    @Override
    protected void onStart() {
        super.onStart();
        //USANDO HANDLER
        /*Handler handler = new Handler();
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                mensaje.setText("AMIGOS");
                Intent intent = new Intent(MainActivity.this, Main2Activity.class);
                startActivity(intent);
            }
        }, 10000);*/

        //USANDO TIMER
        Timer timer = new Timer();
        TimerTask tarea = new TimerTask() {
            @Override
            public void run() {
                System.out.println("HOLA");
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        mensaje.setText("AMIGOS");
                    }
                });

                Intent intent = new Intent(MainActivity.this, Main2Activity.class);
                startActivity(intent);
            }
        };
        timer.schedule(tarea, 2000);
 }

}
