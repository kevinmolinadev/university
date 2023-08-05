package com.example.api.Pokemon.Image;

import com.google.gson.annotations.SerializedName;

public class Home
{
    @SerializedName("front_default")
    private String front_default;
    @SerializedName("front_shiny")
    private String front_shiny;


    public String getFront_default ()
    {
        return front_default;
    }

    public void setFront_default (String front_default)
    {
        this.front_default = front_default;
    }

    public String getFront_shiny ()
    {
        return front_shiny;
    }

    public void setFront_shiny (String front_shiny)
    {
        this.front_shiny = front_shiny;
    }

}