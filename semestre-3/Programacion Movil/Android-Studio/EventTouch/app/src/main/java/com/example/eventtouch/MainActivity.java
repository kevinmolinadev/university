package com.example.eventtouch;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Color;
import android.os.Bundle;
import android.view.Gravity;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewTreeObserver;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        img();
    }
    public void img(){
        LinearLayout Pantalla=new LinearLayout(this );
        Pantalla.setOrientation(LinearLayout.HORIZONTAL);
        Pantalla.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT,LinearLayout.LayoutParams.MATCH_PARENT));
        Pantalla.setGravity(Gravity.CENTER);
        ImageView profile=new ImageView(this);
        profile.setImageResource(R.drawable.profile);
        profile.setLayoutParams(new LinearLayout.LayoutParams(200, 200));
        ImageView profile2=new ImageView(this);
        profile2.setImageResource(R.drawable.profile);
        profile2.setLayoutParams(new LinearLayout.LayoutParams(200, 200));
        ImageView profile3=new ImageView(this);
        profile3.setImageResource(R.drawable.profile);
        profile3.setLayoutParams(new LinearLayout.LayoutParams(200, 200));
        ImageView profile4=new ImageView(this);
        profile4.setImageResource(R.drawable.profile);
        profile4.setLayoutParams(new LinearLayout.LayoutParams(200, 200));
        profile.setOnTouchListener(new View.OnTouchListener() {
            float dX, dY;
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                System.out.println("1");
                switch (event.getAction()) {
                    case MotionEvent.ACTION_DOWN:
                        dX = v.getX() - event.getRawX();
                        dY = v.getY() - event.getRawY();
                        break;
                    case MotionEvent.ACTION_MOVE:
                        float newX = event.getRawX() + dX;
                        float newY = event.getRawY() + dY;
                        // Limitar la posición de la imagen dentro del lienzo Pantalla
                        newX = Math.max(0, newX);
                        newY = Math.max(0, newY);
                        newX = Math.min(Pantalla.getWidth()/2 - v.getWidth(), newX);
                        newY = Math.min(Pantalla.getHeight() - v.getHeight(), newY);
                        // Actualizar la posición de la imagen
                        v.setX(newX);
                        v.setY(newY);
                        break;
                    default:
                        return false;
                }
                return true;
            }
        });
        profile2.setOnTouchListener(new View.OnTouchListener() {
            float dX, dY;
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                System.out.println("2");
                switch (event.getAction()) {
                    case MotionEvent.ACTION_DOWN:
                        dX = v.getX() - event.getRawX();
                        dY = v.getY() - event.getRawY();
                        break;
                    case MotionEvent.ACTION_MOVE:
                        float newX = event.getRawX() + dX;
                        float newY = event.getRawY() + dY;
                        // Limitar la posición de la imagen dentro del lienzo Pantalla
                        newX = Math.max(0, newX);
                        newY = Math.max(0, newY);
                        newX = Math.min(Pantalla.getWidth()/2 - v.getWidth(), newX);
                        newY = Math.min(Pantalla.getHeight() - v.getHeight(), newY);
                        // Actualizar la posición de la imagen
                        v.setX(newX);
                        v.setY(newY);
                        break;
                    default:
                        return false;
                }
                return true;
            }
        });
        profile3.setOnTouchListener(new View.OnTouchListener() {
            float dX, dY;
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                System.out.println("3");
                switch (event.getAction()) {
                    case MotionEvent.ACTION_DOWN:
                        dX = v.getX() - event.getRawX();
                        dY = v.getY() - event.getRawY();
                        break;
                    case MotionEvent.ACTION_MOVE:
                        float newX = event.getRawX() + dX;
                        float newY = event.getRawY() + dY;
                        // Limitar la posición de la imagen dentro del lienzo Pantalla
                        newX = Math.max(Pantalla.getWidth()/2, newX);
                        newY = Math.max(0, newY);
                        newX = Math.min(Pantalla.getWidth() - v.getWidth(), newX);
                        newY = Math.min(Pantalla.getHeight() - v.getHeight(), newY);
                        // Actualizar la posición de la imagen
                        v.setX(newX);
                        v.setY(newY);
                        break;
                    default:
                        return false;
                }
                return true;
            }
        });
        profile4.setOnTouchListener(new View.OnTouchListener() {
            float dX, dY;
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                System.out.println("4");
                switch (event.getAction()) {
                    case MotionEvent.ACTION_DOWN:
                        dX = v.getX() - event.getRawX();
                        dY = v.getY() - event.getRawY();
                        break;
                    case MotionEvent.ACTION_MOVE:
                        float newX = event.getRawX() + dX;
                        float newY = event.getRawY() + dY;
                        // Limitar la posición de la imagen dentro del lienzo Pantalla
                        newX = Math.max(Pantalla.getWidth()/2, newX);
                        newY = Math.max(0, newY);
                        newX = Math.min(Pantalla.getWidth() - v.getWidth(), newX);
                        newY = Math.min(Pantalla.getHeight() - v.getHeight(), newY);
                        // Actualizar la posición de la imagen
                        v.setX(newX);
                        v.setY(newY);
                        break;
                    default:
                        return false;
                }
                return true;
            }
        });
        Pantalla.addView(profile);
        Pantalla.addView(profile2);
        Pantalla.addView(profile3);
        Pantalla.addView(profile4);
        setContentView(Pantalla);
    }
}