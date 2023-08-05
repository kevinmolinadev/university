package com.example.api.ConexionAPI;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;
import retrofit2.http.Query;

public interface API {
    @GET("/api/v2/pokemon")
    Call<PokemonResponsive> getPokemonAll();
    @GET("/api/v2/pokemon/{id}")
    Call<PokemonResponsive> getPokemonID(@Path("id") int id);
}
