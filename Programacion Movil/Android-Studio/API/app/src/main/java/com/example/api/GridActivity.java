package com.example.api;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import android.os.Bundle;
import android.widget.GridView;

import com.example.api.Adapters.PokemonAdapter;
import com.example.api.Adapters.PokemonAdapterGrid;
import com.example.api.ConexionAPI.ConectionAPI;
import com.example.api.ConexionAPI.PokemonResponsive;
import com.example.api.Pokemon.Pokemon;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class GridActivity extends AppCompatActivity {
    private GridView layout;
    private  List<Pokemon> pokemonList;
    private PokemonAdapterGrid pokemonAdapterGrid;
    private  Pokemon p;
    private int limite;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_grid);
        pokemonList = new ArrayList<>();
        System.out.println("INICIAMOS EL GRID");
        limite=10;
        for (int i=1;i<=limite;i++){
            getPokemonID(i);
            System.out.println(pokemonList);
        }
    }
    public void initAdapter() {
        layout=findViewById(R.id.grid_layout);
        System.out.println("ADAPTER");
        System.out.println(pokemonList);
        PokemonAdapterGrid grid= new PokemonAdapterGrid(this,R.layout.grid_layout_pokemon,pokemonList);
        layout.setAdapter(grid);
    }
    public void getPokemonID(int id){
        Call<PokemonResponsive> pokemon = ConectionAPI.getAPI().getPokemonID(id);
        pokemon.enqueue(new Callback<PokemonResponsive>() {
            @Override
            public void onResponse(Call<PokemonResponsive> call, Response<PokemonResponsive> response) {
                if (response.isSuccessful()){
                    //pokemonList.clear();
                    p=response.body().getPokemon();
                    pokemonList.add(p);
                }
                if (pokemonList.size()==limite){
                    initAdapter();
                }
                //pokemonAdapterGrid.notifyDataSetChanged();
            }
            @Override
            public void onFailure(Call<PokemonResponsive> call, Throwable t) {
                System.out.println("Error de red: " + t.getMessage());
            }
        });
    }
}