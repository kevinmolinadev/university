package com.example.broadcast.Clases;

import static com.example.broadcast.BroadcastReceiver.BroadcastReceiver3Activity.CONNECTION;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.widget.TextView;

import com.example.broadcast.BroadcastReceiver.BroadcastReceiver3Activity;
import com.example.broadcast.BroadcastReceiver.BroadcastReceiverActivity;
import com.example.broadcast.MainActivity;

public class CustomBroadcastReceiver extends BroadcastReceiver {
    private TextView textView;
    private final String item;

    public CustomBroadcastReceiver(TextView textView,String item) {
        this.textView = textView;
        this.item=item;
    }

    @Override
    public void onReceive(Context context, Intent intent) {
        System.out.println("se ejecuta");
        if (intent.getAction() != null) {
            System.out.println("Entramos");
            textView.setText(intent.getStringExtra(item));
        }
    }
}
