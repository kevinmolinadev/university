package com.example.broadcast;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.IntentFilter;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.example.broadcast.Clases.MyReceiver;


public class MainActivity extends AppCompatActivity {
    public  static  final String CUSTOM_BROADCAST_ACTION="com.example.broadcast";
    Intent customBroadcastIntent;
    private MyReceiver myReceiver;
    public TextView textView;
    public EditText text;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        customBroadcastIntent=new Intent(CUSTOM_BROADCAST_ACTION);
        Button broadcastButton = findViewById(R.id.broadcast_button);
        textView = findViewById(R.id.result_text);
        text = findViewById(R.id.editTextText);
        broadcastButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String sendText=text.getText().toString();
                customBroadcastIntent.putExtra("message",sendText);
                sendBroadcast(customBroadcastIntent);
            }
        });
        if (myReceiver == null) {
            myReceiver = new MyReceiver(textView);
            IntentFilter intentFilter = new IntentFilter(CUSTOM_BROADCAST_ACTION);
            registerReceiver(myReceiver, intentFilter);
        }
    }
}