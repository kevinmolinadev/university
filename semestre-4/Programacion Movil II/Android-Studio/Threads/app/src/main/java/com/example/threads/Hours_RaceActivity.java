package com.example.threads;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.ProgressBar;
import android.widget.TextView;

import com.example.threads.CallablesAndFutures.Horse;

public class Hours_RaceActivity extends AppCompatActivity {

    private static final int NUM_CABALLOS = 10;


    private Horse[] horses = new Horse[NUM_CABALLOS];
    ProgressBar progressBar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_hours_race);
        TextView numero=findViewById(R.id.editTextNumber);
        LinearLayout layout = findViewById(R.id.horsesLayout);
        for (int i = 0; i < NUM_CABALLOS; i++) {
            View horseView = getLayoutInflater().inflate(R.layout.horse_layout, layout, false);
            ImageView imagenCaballo = horseView.findViewById(R.id.horseImage);
            String nombreImagen = "horse" + (i + 1);
            int idImagen = getResources().getIdentifier(nombreImagen, "drawable", getPackageName());
            imagenCaballo.setImageResource(idImagen);
            horses[i] = new Horse(horseView);
            layout.addView(horseView);
        }

        Button startRaceButton = findViewById(R.id.startRaceButton);
        startRaceButton.setOnClickListener(v -> startRace());
        Button stopRaceButton = findViewById(R.id.stopRaceButton);
        stopRaceButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String caballo=numero.getText().toString();
                if(caballo.isEmpty()){
                    stopRace();
                }else {
                    int ncaballo=Integer.parseInt(caballo);
                    horses[ncaballo-1].setStart(false);
                }

            }
        });
    }

    private void startRace() {
        for (Horse horse : horses) {
            horse.setStart(true);
            new Thread(horse).start();
        }
    }
    private void stopRace(){
        try {
            for (Horse horse : horses) {
                horse.setStart(false);
            }
        }catch (Exception e){
            System.out.println(e);
        }
    }
}