package com.example.broadcast.BroadcastReceiver;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.broadcast.R;

public class BroadcastReceiver2Activity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_broadcast_receiver2);
    }
    public void btnClick(View v){
        Intent intent=new Intent(BroadcastReceiver2Activity.this, BroadcastReceiver3Activity.class);
        startActivity(intent);
    }
}