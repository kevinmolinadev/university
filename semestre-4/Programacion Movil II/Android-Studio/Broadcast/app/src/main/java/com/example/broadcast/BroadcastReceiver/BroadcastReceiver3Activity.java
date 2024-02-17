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
    public static final  String[] CONNECTION= {"cm","ca","cb"};
    private EditText textView;
    private EditText textView2;
    private EditText textView3;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_broadcast_receiver3);
        textView=findViewById(R.id.editTextTextPM);
        textView2=findViewById(R.id.editTextTextP1);
        textView3=findViewById(R.id.editTextTextP2);
    }
    public void btnClick(View v){
        String cm=CONNECTION[0];
        String ca=CONNECTION[1];
        String cb=CONNECTION[2];
        String sendText=textView.getText().toString();
        String sendText2=textView2.getText().toString();
        String sendText3=textView3.getText().toString();
        if(!sendText.isEmpty() && !sendText2.isEmpty() && !sendText3.isEmpty()){
            Intent intent = new Intent(cm);
            Intent intent2 = new Intent(ca);
            Intent intent3 = new Intent(cb);

            intent.putExtra(cm,sendText);
            intent2.putExtra(ca,sendText2);
            intent3.putExtra(cb,sendText3);

            sendBroadcast(intent);
            sendBroadcast(intent2);
            sendBroadcast(intent3);
        }
    }
}