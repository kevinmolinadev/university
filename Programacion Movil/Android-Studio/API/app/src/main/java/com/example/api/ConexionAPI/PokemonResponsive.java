package com.example.api.ConexionAPI;

import com.example.api.Pokemon.Image.Sprites;
import com.example.api.Pokemon.Pokemon;
import com.example.api.Pokemon.Stats;
import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.util.ArrayList;
import java.util.List;

public class PokemonResponsive {
    @SerializedName("id")
    private int id;
    @SerializedName("sprites")
    private Sprites sprites;
    @SerializedName("name")
    private String name;
    @SerializedName("base_experience")
    private String base_experience;
    @SerializedName("stats")
    private List<Stats> stats = new ArrayList<>();

    @Expose(serialize = false, deserialize = false)
    public Pokemon pokemon;

    public Pokemon getPokemon() {
        pokemon = new Pokemon(this.id,this.sprites.getOther().getOfficial_artwork().getFront_default(), this.name,this.stats.get(0).getBase_stat()+" Hp",this.base_experience+" Exp",this.stats.get(1).getBase_stat(),this.stats.get(3).getBase_stat(),this.stats.get(2).getBase_stat());
        return pokemon;
    }
    @Override
    public String toString() {
        return "Pokemon{" +
                "id=" + id +
                ",sprites=" + sprites +
                ", name='" + name + '\'' +
                ", base_experience='" + base_experience + '\'' +
                ", stats='" + stats + '\'' +
                '}';
    }
}
