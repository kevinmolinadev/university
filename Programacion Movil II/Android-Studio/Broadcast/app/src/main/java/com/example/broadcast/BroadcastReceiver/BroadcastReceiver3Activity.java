package com.example.broadcast.BroadcastReceiver;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.IntentFilter;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import com.example.broadcast.Clases.CustomBroadcastReceiver;
import com.example.broadcast.Clases.MyReceiver;
import com.example.broadcast.R;

public class BroadcastReceiver3Activity extends AppCompatActivity {
    public static final  String CONNECTION="BroadcastReceiver";
    private EditText textView;
    private Intent customBroadcastIntent;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_broadcast_receiver3);
        textView=findViewById(R.id.editTextText2);
        customBroadcastIntent=new Intent(CONNECTION);
    }
    public void btnClick(View v){
        String sendText=textView.getText().toString();
        customBroadcastIntent.putExtra("message",sendText);
        sendBroadcast(customBroadcastIntent);
    }
}