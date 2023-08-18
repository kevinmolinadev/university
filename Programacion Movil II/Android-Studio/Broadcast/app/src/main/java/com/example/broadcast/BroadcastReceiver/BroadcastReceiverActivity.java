package com.example.broadcast.BroadcastReceiver;

import static com.example.broadcast.BroadcastReceiver.BroadcastReceiver3Activity.CONNECTION;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.IntentFilter;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

import com.example.broadcast.Clases.CustomBroadcastReceiver;
import com.example.broadcast.MainActivity;
import com.example.broadcast.R;

public class BroadcastReceiverActivity extends AppCompatActivity {
    private TextView textView;
    private  CustomBroadcastReceiver customBroadcastReceiver;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_broadcast_receiver);
        textView=findViewById(R.id.textView);
        if (customBroadcastReceiver == null) {
            customBroadcastReceiver = new CustomBroadcastReceiver(textView);
            IntentFilter intentFilter = new IntentFilter(CONNECTION);
            registerReceiver(customBroadcastReceiver, intentFilter);
        }
    }
    public void btnClick(View v){
        Intent intent=new Intent(BroadcastReceiverActivity.this, BroadcastReceiver1Activity.class);
        startActivity(intent);
    }

}