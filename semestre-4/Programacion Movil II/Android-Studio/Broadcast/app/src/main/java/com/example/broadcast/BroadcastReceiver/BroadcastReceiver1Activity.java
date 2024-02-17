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

public class BroadcastReceiver1Activity extends AppCompatActivity {
    private TextView textView;
    private  CustomBroadcastReceiver customBroadcastReceiver;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_broadcast_receiver1);
        textView=findViewById(R.id.textView);
        if (customBroadcastReceiver == null) {
            customBroadcastReceiver = new CustomBroadcastReceiver(textView, CONNECTION[1]);
            IntentFilter intentFilter = new IntentFilter(CONNECTION[1]);
            registerReceiver(customBroadcastReceiver, intentFilter);
        }
    }
    public void btnClick(View v){
        Intent intent=new Intent(BroadcastReceiver1Activity.this, BroadcastReceiver2Activity.class);
        startActivity(intent);
    }
}