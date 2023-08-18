package com.example.broadcast.Clases;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.widget.TextView;

import com.example.broadcast.BroadcastReceiver.BroadcastReceiver3Activity;
import com.example.broadcast.BroadcastReceiver.BroadcastReceiverActivity;
import com.example.broadcast.MainActivity;

public class CustomBroadcastReceiver extends BroadcastReceiver {
    private TextView textView;

    public CustomBroadcastReceiver(TextView textView) {
        this.textView = textView;
    }

    @Override
    public void onReceive(Context context, Intent intent) {
        if (intent.getAction() != null && intent.getAction().equals(BroadcastReceiver3Activity.CONNECTION)) {
            textView.setText(intent.getStringExtra("message"));
        }
    }
}
