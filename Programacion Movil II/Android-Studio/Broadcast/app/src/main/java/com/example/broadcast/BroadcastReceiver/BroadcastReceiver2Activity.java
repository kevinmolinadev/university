package com.example.broadcast.BroadcastReceiver;

import static com.example.broadcast.BroadcastReceiver.BroadcastReceiver3Activity.CONNECTION;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.IntentFilter;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import com.example.broadcast.Clases.CustomBroadcastReceiver;
import com.example.broadcast.R;

public class BroadcastReceiver2Activity extends AppCompatActivity {
    private TextView textView;
    private CustomBroadcastReceiver customBroadcastReceiver;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_broadcast_receiver2);
        textView=findViewById(R.id.textView);
        if (customBroadcastReceiver == null) {
            customBroadcastReceiver = new CustomBroadcastReceiver(textView, CONNECTION[2]);
            IntentFilter intentFilter = new IntentFilter(CONNECTION[2]);
            registerReceiver(customBroadcastReceiver, intentFilter);
        }
    }
    public void btnClick(View v){
        Intent intent=new Intent(BroadcastReceiver2Activity.this, BroadcastReceiver3Activity.class);
        startActivity(intent);
    }
}