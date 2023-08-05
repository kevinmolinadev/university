package com.example.api.ConexionAPI;

import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class ConectionAPI {
    private static final String BASE_URL = "https://pokeapi.co/";

    private static Retrofit retrofit = new Retrofit.Builder()
            .baseUrl(BASE_URL)
            .addConverterFactory(GsonConverterFactory.create())
            .build();

    private static API conectionAPI = retrofit.create(API.class);

    public static API getAPI() {
        return conectionAPI;
    }
}
