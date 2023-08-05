package com.example.api.Adapters;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import androidx.constraintlayout.utils.widget.ImageFilterView;

import android.widget.ImageView;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;
import com.example.api.Pokemon.Pokemon;
import com.example.api.R;
import com.squareup.picasso.Picasso;

import java.util.List;

public class PokemonAdapter extends RecyclerView.Adapter<PokemonAdapter.PokemonHolder> {
    private Context context;
    private List<Pokemon> pokemonList;
    private boolean file;
    public PokemonAdapter(Context context, List<Pokemon> pokemonList,boolean file) {
        this.context = context;
        this.pokemonList = pokemonList;
        this.file=file;
    }
    @NonNull
    @Override
    public PokemonHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        if (file){
            View itemView = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.layout_pokemon_list, parent, false);
            return new PokemonHolder(itemView);
        }else {
            View itemView = LayoutInflater.from(parent.getContext())
                    .inflate(R.layout.not_file, parent, false);
            return new PokemonHolder(itemView);
        }
    }

    public boolean isFile() {
        return file;
    }

    public void setFile(boolean file) {
        this.file = file;
    }

    @Override
    public void onBindViewHolder(@NonNull PokemonHolder holder, int position) {
        Pokemon pokemon = pokemonList.get(position);
        if(file){
            //holder.id.setText(String.valueOf(pokemon.getId()));
            holder.name.setText(pokemon.getName());
            holder.hp.setText(pokemon.getHp());
            holder.experiencia.setText(pokemon.getBase_experience());
            holder.ataque.setText(pokemon.getAtaque());
            holder.defensa.setText(pokemon.getDefensa());
            holder.ataqueEspecial.setText(pokemon.getAtaqueEspecial());
            Picasso.get()
                    .load(pokemon.getImage())
                    .into(holder.image);
        }else{
            Picasso.get()
                    .load("https://static.wikia.nocookie.net/sonicpokemon/images/b/b2/Psyduck_AG_anime.png")
                    .into(holder.image);
        }
    }

    @Override
    public int getItemCount() {
        return pokemonList.size();
    }

    static class PokemonHolder extends RecyclerView.ViewHolder {
        private ImageFilterView image;
        private TextView id;
        private TextView name;
        private TextView hp;
        private TextView experiencia;
        private TextView ataque;
        private TextView ataqueEspecial;
        private TextView defensa;

        public PokemonHolder(@NonNull View itemView) {
            super(itemView);
            image = itemView.findViewById(R.id.image);
            //id = itemView.findViewById(R.id.textId);
            name = itemView.findViewById(R.id.textName);
            hp = itemView.findViewById(R.id.textHp);
            experiencia = itemView.findViewById(R.id.textExperiencia);
            ataque = itemView.findViewById(R.id.textAtaque);
            ataqueEspecial = itemView.findViewById(R.id.textEspecial);
            defensa = itemView.findViewById(R.id.textDefensa);
        }
    }

}
