package com.example.api.Adapters;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.utils.widget.ImageFilterView;

import com.example.api.Pokemon.Pokemon;
import com.example.api.R;
import com.squareup.picasso.Picasso;

import java.util.List;

public class PokemonAdapterGrid extends ArrayAdapter<Pokemon> {
    private Context context;
    private List<Pokemon> pokemonList;
    private int item;

    public PokemonAdapterGrid(@NonNull Context context, int resource,List<Pokemon> pokemonList) {
        super(context, resource);
        this.pokemonList=pokemonList;
        this.item=resource;
    }

    @Override
    public int getCount() {
        return pokemonList.size();
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        View view = convertView;
        Pokemon pokemon=pokemonList.get(position);
        if (view!=null){
            LayoutInflater inflater= (LayoutInflater)getContext().getSystemService(context.LAYOUT_INFLATER_SERVICE);
            view=inflater.inflate(item,null);
        }
        ImageFilterView image = view.findViewById(R.id.image);
        TextView name = view.findViewById(R.id.textName);
        TextView hp=view.findViewById(R.id.textHp);
        TextView experiencia=view.findViewById(R.id.textExperiencia);

        name.setText(pokemon.getName());
        hp.setText(pokemon.getHp());
        experiencia.setText(pokemon.getBase_experience());
        Picasso.get()
                .load(pokemon.getImage())
                .into(image);
        return view;
    }
}
