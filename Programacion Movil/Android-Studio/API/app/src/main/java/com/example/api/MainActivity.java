package com.example.api;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import androidx.room.Room;

import android.graphics.Color;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.example.api.Adapters.PokemonAdapter;
import com.example.api.ConexionAPI.ConectionAPI;
import com.example.api.ConexionAPI.PokemonResponsive;
import com.example.api.DataBase.DB;
import com.example.api.Pokemon.Image.Sprites;
import com.example.api.Pokemon.Pokemon;
import com.example.api.Pokemon.Stat;
import com.example.api.Pokemon.Stats;
import com.google.android.material.snackbar.Snackbar;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.Executors;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MainActivity extends AppCompatActivity {
    private RecyclerView recyclerView;
    private List<Pokemon> pokemonList;
    private PokemonAdapter pokemonAdapter;
    EditText idP;
    Button btnBuscar;
    Button btnGuardar;
    private Pokemon p;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        initAdapter();
        getPokemonID(17);
    }
    public void initAdapter(){
        pokemonList = new ArrayList<>();
        recyclerView = findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        idP=findViewById(R.id.buscar);
        btnBuscar=findViewById(R.id.btnBuscar);
        btnGuardar=findViewById(R.id.btnGuardar);
        btnBuscar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
            String numero=idP.getText().toString();
                if (numero.isEmpty()){
                    Snackbar.make(btnBuscar, "Ingrese un numero :D", Snackbar.LENGTH_SHORT).show();
                }else{
                    /*for (int i=1;i<=(Integer.parseInt(numero));i++){
                        getPokemonID(i);
                    }*/
                    getPokemonID(Integer.parseInt(numero));
                }
            }
        });
        btnGuardar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                savePokemon();
            }
        });

    }
    public void getPokemonID(int id){
        Call<PokemonResponsive> pokemon = ConectionAPI.getAPI().getPokemonID(id);
        pokemon.enqueue(new Callback<PokemonResponsive>() {
            @Override
            public void onResponse(Call<PokemonResponsive> call, Response<PokemonResponsive> response) {

                if (response.isSuccessful()){
                    File();
                    pokemonList.clear();
                    p=response.body().getPokemon();
                    pokemonList.add(p);
                    System.out.println(p);

                }else{
                    notFile();
                }
                pokemonAdapter.notifyDataSetChanged();

            }
            @Override
            public void onFailure(Call<PokemonResponsive> call, Throwable t) {
                System.out.println("Error de red: " + t.getMessage());
            }
        });
    }
    public void obtenerPokemons(int inicio, int ultimo) {
        for (int i = inicio; i <= ultimo; i++) {
            getPokemonID(i);
        }
    }
    public void savePokemon(){
        Executors.newSingleThreadExecutor().execute(new Runnable() {
            @Override
            public void run() {
                DB db = Room.databaseBuilder(getApplicationContext(), DB.class, "database-name").build();
                db.pokemonDao().insertAll(p);

                List<Pokemon> pokemones = db.pokemonDao().getAll();
                for (Pokemon pokemonx:pokemones) {
                    System.out.println(pokemonx.toString());
                }
            }
        });
    }
    public void File(){
        btnGuardar.setEnabled(true);
        pokemonAdapter = new PokemonAdapter(this,pokemonList,true);
        recyclerView.setAdapter(pokemonAdapter);
    }
    public void notFile(){
        btnGuardar.setEnabled(false);
        pokemonAdapter = new PokemonAdapter(this,pokemonList,false);
        recyclerView.setAdapter(pokemonAdapter);
    }
}