public class Auto {
    private String Marca;
    private  String Año;
    private String TipoCaja;
    private  double Precio;
    private  boolean Nuevo;

    public Auto(String marca, String año, String tipoCaja, double precio, boolean nuevo) {
        this.Marca = marca;
        this.Año = año;
        this.TipoCaja = tipoCaja;
        this.Precio = precio;
        this.Nuevo = nuevo;
    }

    public String getMarca() {
        return this.Marca;
    }

    public void setMarca(String marca) {
        this.Marca = marca;
    }

    public String getAño() {
        return this.Año;
    }

    public void setAño(String año) {
        this.Año = año;
    }

    public String getTipoCaja() {
        return this.TipoCaja;
    }

    public void setTipoCaja(String tipoCaja) {
        this.TipoCaja = tipoCaja;
    }

    public double getPrecio() {
        return this.Precio;
    }

    public void setPrecio(double precio) {
        this.Precio = precio;
    }

    public boolean isNuevo() {
        return this.Nuevo;
    }

    public void setNuevo(boolean nuevo) {
        this.Nuevo = nuevo;
        if(nuevo==false){
            this.Precio=this.Precio*0.70;
        }
    }
    @Override
    public String toString() {
        return "Auto{" +
                "Marca='" + this.Marca + '\'' +
                ", Año='" + this.Año + '\'' +
                ", TipoCaja='" + this.TipoCaja + '\'' +
                ", Precio=" + this.Precio +
                ", Nuevo=" + this.Nuevo +
                '}';
    }
}
