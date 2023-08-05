package com.example.api.Pokemon;


import com.google.gson.annotations.SerializedName;

public class Stat
{
        @SerializedName("name")
        private String name;
        @SerializedName("url")
        private String url;

        public String getName ()
        {
            return name;
        }

        public void setName (String name)
        {
            this.name = name;
        }

        public String getUrl ()
        {
            return url;
        }

        public void setUrl (String url)
        {
            this.url = url;
        }

        @Override
        public String toString()
        {
            return "name = "+name+", url = "+url;
        }
}
