package com.example.threads;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    private Handler hilo= new Handler(Looper.getMainLooper());
    private TextView count;
    private Button message;
    private Button stop;
    private boolean runThread=true;
    private int i=0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        count=findViewById(R.id.view);
        message=findViewById(R.id.button2);
        stop=findViewById(R.id.button1);
        new Thread(new Runnable() {
            @Override
            public void run() {
                if(runThread){
                    while (i<100){
                        i++;
                        count.post(new Runnable() {
                            @Override
                            public void run() {
                                count.setText("contador:"+i);
                            }
                        });
                        try {
                            Thread.sleep(1000);
                        }catch (InterruptedException e){
                            System.out.println(e);;
                        }
                    }
                }else{
                    synchronized (this) {
                        try {
                            wait();
                        } catch (InterruptedException e) {
                            e.printStackTrace();
                        }
                    }
                }
            }
        }).start();
    }
    public void message(View v){
        new Thread(new Runnable() {
            @Override
            public void run() {
                try {
                    Thread.sleep(5000);
                    message.post(new Runnable() {
                        @Override
                        public void run() {
                            Toast.makeText(getApplicationContext(), "HOLA MUNDO :D", Toast.LENGTH_SHORT).show();
                        }
                    });
                }catch (InterruptedException e){
                    System.out.println(e);
                }
            }
        }).start();
    }
    public void stop(View v){
        runThread=false;
        System.out.println(runThread);
    }
}