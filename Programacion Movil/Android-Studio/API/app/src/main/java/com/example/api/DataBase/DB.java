package com.example.api.DataBase;


import androidx.room.Database;
import androidx.room.RoomDatabase;

import com.example.api.DAO.PokemonDao;
import com.example.api.Pokemon.Pokemon;

@Database(entities = {Pokemon.class}, version = 1)
public abstract class DB extends RoomDatabase {
    public abstract PokemonDao pokemonDao();
}