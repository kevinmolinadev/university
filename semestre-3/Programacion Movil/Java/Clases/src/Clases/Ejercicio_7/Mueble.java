package Ejercicio_7;

public abstract class Mueble {
    private   String Material;
    private String Color;
    private int Precio;

    public Mueble(String material, String color, int precio) {
        this.Material = material;
        this.Color = color;
        this.Precio = precio;
    }

    public String getMaterial() {
        return Material;
    }

    public void setMaterial(String material) {
        Material = material;
    }

    public String getColor() {
        return Color;
    }

    public void setColor(String color) {
        Color = color;
    }

    public int getPrecio() {
        return this.Precio;
    }

    public void setPrecio(int precio) {
        this.Precio = precio;
    }

    public abstract void descripcion();
}

