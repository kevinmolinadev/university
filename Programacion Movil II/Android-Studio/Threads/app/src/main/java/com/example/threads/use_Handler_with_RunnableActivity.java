package com.example.threads;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.view.View;
import android.widget.Toast;

import java.util.ArrayList;

public class use_Handler_with_RunnableActivity extends AppCompatActivity {
    private ArrayList<Runnable> chat;
    private Handler handler;
    private Runnable runnable;
    private Runnable runnableTwo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_use_handler_with_runnable);
        chat=new ArrayList<>();
        handler=new Handler(Looper.getMainLooper());
        loadChat(10);
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
            time+=1;
            final int delayMillis=time;
            Runnable r=new Runnable() {
                @Override
                public void run() {
                    ShowToast("Tiempo: "+delayMillis);
                }
            };
            chat.add(r);
        }
        for (Runnable runnable: chat){
            System.out.println(runnable);
        }
    }
    public void initChat(View v){
        for (Runnable runnable : chat) {
            handler.post(runnable);
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

    @Override
    protected void onDestroy() {
        super.onDestroy();
        stopProccess();
    }
}
