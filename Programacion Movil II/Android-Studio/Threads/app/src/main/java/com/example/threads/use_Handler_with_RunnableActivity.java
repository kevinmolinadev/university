package com.example.threads;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.view.Gravity;
import android.view.View;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class use_Handler_with_RunnableActivity extends AppCompatActivity {
    private List<String> people;
    private List<Runnable> chat;
    private Handler handler;
    private Runnable runnable;
    private Runnable runnableTwo;
    private LinearLayout layout;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_use_handler_with_runnable);
        layout=findViewById(R.id.layout);
        chat=new ArrayList<>();
        people=new ArrayList<>();
        handler=new Handler(Looper.getMainLooper());
        loadChat(10);
        loadPeople();
        System.out.println(chat.size());
    }
    public void initProccess(View v){
        runnable=new Runnable() {
            @Override
            public void run() {
                ShowToast("Hola :D");
                handler.postDelayed(this,5000);
            }
        };
        runnableTwo=new Runnable() {
            @Override
            public void run() {
                ShowToast("Amigos");
                handler.postDelayed(this,2000);
            }
        };
        handler.post(runnable);
        handler.post(runnableTwo);
    }
    public void stopProccess(){
        handler.removeCallbacks(runnable);
        handler.removeCallbacks(runnableTwo);
        for (Runnable runnable:chat){
            handler.removeCallbacks(runnable);
        }
    }
    public void loadChat(int limit){
        int time=0;
        for (int i=0; i<limit;i++){
            time+=1000;
            final int message=i;
            final int delayMillis=time;
            TextView text=new TextView(this);
            text.setGravity(Gravity.CENTER);
            Runnable r=new Runnable() {
                @Override
                public void run() {
                    try {
                        layout.removeView(text);
                        text.setText(people.get(message)+": "+"Hola "+(message+1));
                        layout.addView(text);
                        handler.postDelayed(this,delayMillis);
                    }catch (Exception e){
                        System.out.println(e);
                    }
                }
            };
            chat.add(r);
        }
    }
    public void initChat(View v){
        int delay=1000;
        for (Runnable runnable : chat) {
            handler.postDelayed(runnable,delay);
            delay+=1000;
        }
    }
    public void stopChat(View v){
        for (Runnable runnable : chat) {
           handler.removeCallbacks(runnable);
        }
    }
    public void ShowToast(String message){
        Toast.makeText(this,message,Toast.LENGTH_SHORT).show();
    }
    public void loadPeople(){
       people.add("María");
       people.add("Juan");
       people.add("Ana");
       people.add("Carlos");
       people.add("Sofía");
       people.add("Pedro");
       people.add("Laura");
       people.add("Alejandro");
       people.add("Valentina");
       people.add("Manuel");
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        stopProccess();
    }
}
