package com.example.api.Pokemon.Image;

import com.google.gson.annotations.SerializedName;

import java.util.ArrayList;
import java.util.List;


public class Other
{
    @SerializedName("dream_world")
    private DreamWorld dream_world;
    @SerializedName("official-artwork")
    private OfficialArtwork official_artwork;
    @SerializedName("home")
    private Home home;

    public DreamWorld getDream_world() {
        return dream_world;
    }

    public void setDream_world(DreamWorld dream_world) {
        this.dream_world = dream_world;
    }

    public OfficialArtwork getOfficial_artwork() {
        return official_artwork;
    }

    public void setOfficial_artwork(OfficialArtwork official_artwork) {
        this.official_artwork = official_artwork;
    }

    public Home getHome ()
    {
        return home;
    }

    public void setHome (Home home)
    {
        this.home = home;
    }

    @Override
    public String toString() {
        return "Other{" +
                "official_artwork=" + official_artwork +
                '}';
    }
}