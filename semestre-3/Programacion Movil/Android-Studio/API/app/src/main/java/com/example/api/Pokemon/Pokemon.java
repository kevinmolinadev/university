package com.example.api.Pokemon;

import androidx.room.Entity;
import androidx.room.PrimaryKey;

import com.example.api.Pokemon.Image.Sprites;

@Entity
public class Pokemon {
    @PrimaryKey(autoGenerate = true)
    private int id;
    private String image;
    private String name;
    private String hp;
    private String base_experience;
    private String ataque;
    private String ataqueEspecial;
    private String defensa;

    public Pokemon(int id, String image, String name, String hp, String base_experience, String ataque, String ataqueEspecial, String defensa) {
        this.id = id;
        this.image = image;
        this.name = name;
        this.hp = hp;
        this.base_experience = base_experience;
        this.ataque = ataque;
        this.ataqueEspecial = ataqueEspecial;
        this.defensa = defensa;
    }

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getImage() {
        return image;
    }

    public void setImage(String image) {
        this.image = image;
    }

    public String getBase_experience() {
        return base_experience;
    }

    public void setBase_experience(String base_experience) {
        this.base_experience = base_experience;
    }

    public String getHp() {
        return hp;
    }

    public void setHp(String hp) {
        this.hp = hp;
    }

    public String getAtaque() {
        return ataque;
    }

    public void setAtaque(String ataque) {
        this.ataque = ataque;
    }

    public String getAtaqueEspecial() {
        return ataqueEspecial;
    }

    public void setAtaqueEspecial(String ataqueEspecial) {
        this.ataqueEspecial = ataqueEspecial;
    }

    public String getDefensa() {
        return defensa;
    }

    public void setDefensa(String defensa) {
        this.defensa = defensa;
    }

    @Override
    public String toString() {
        return "Pokemon{" +
                "id=" + id +
                ", image=" + image +
                ", name='" + name + '\'' +
                ", hp='" + hp + '\'' +
                ", base_experience='" + base_experience + '\'' +
                ", ataque='" + ataque + '\'' +
                ", ataqueEspecial='" + ataqueEspecial + '\'' +
                ", defensa='" + defensa + '\'' +
                '}';
    }
}
