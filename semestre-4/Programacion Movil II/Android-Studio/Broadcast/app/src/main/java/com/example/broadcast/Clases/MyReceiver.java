package com.example.broadcast.Clases;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.widget.TextView;

import com.example.broadcast.MainActivity;

public class MyReceiver extends BroadcastReceiver {
    private TextView textView;

    public MyReceiver(TextView textView){
        this.textView=textView;
    }

    @Override
    public void onReceive(Context context, Intent intent) {
        if (intent.getAction() != null && intent.getAction().equals(MainActivity.CUSTOM_BROADCAST_ACTION)) {
            textView.setText(intent.getStringExtra("message"));
        }
    }
}
