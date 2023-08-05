package com.example.pokeapi;

import android.os.Bundle;
import android.widget.ImageView;
import androidx.appcompat.app.AppCompatActivity;

public class pokeList_element extends AppCompatActivity {

    ImageView pokemonView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_poke_list_element);
        //pokemonView = findViewById(R.id.imageView);
    }
}