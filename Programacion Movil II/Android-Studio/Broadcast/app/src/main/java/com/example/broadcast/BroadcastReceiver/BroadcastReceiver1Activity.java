package com.example.broadcast.BroadcastReceiver;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.broadcast.R;

public class BroadcastReceiver1Activity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_broadcast_receiver1);
    }
    public void btnClick(View v){
        Intent intent=new Intent(BroadcastReceiver1Activity.this, BroadcastReceiver2Activity.class);
        startActivity(intent);
    }
}