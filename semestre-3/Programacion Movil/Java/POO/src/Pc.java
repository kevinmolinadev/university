public class Pc {
    private String Marca;
    private String Modelo;
    private int MemoriaRam;
    private int Almacenamiento;
    private boolean Encendida;

    public Pc(String marca, String modelo, int memoriaRam, int almacenamiento, boolean encendida) {
        this.Marca = marca;
        this.Modelo = modelo;
        this.MemoriaRam = memoriaRam;
        this.Almacenamiento = almacenamiento;
        this.Encendida = encendida;
    }

    public String getMarca() {
        return this.Marca;
    }

    public void setMarca(String marca) {
        this.Marca = marca;
    }

    public String getModelo() {
        return this.Modelo;
    }

    public void setModelo(String modelo) {
        this.Modelo = modelo;
    }

    public int getMemoriaRam() {
        return this.MemoriaRam;
    }

    public void setMemoriaRam(int memoriaRam) {
        this.MemoriaRam = memoriaRam;
    }

    public int getAlmacenamiento() {
        return this.Almacenamiento;
    }

    public void setAlmacenamiento(int almacenamiento) {
        this.Almacenamiento = almacenamiento;
    }

    public boolean isEncendida() {
        return this.Encendida;
    }

    public void setEncendida(boolean encendida) {
        this.Encendida = encendida;
    }

    @Override
    public String toString() {
        return "Pc{" +
                "Marca='" + this.Marca + '\'' +
                ", Modelo='" + this.Modelo + '\'' +
                ", MemoriaRam=" + this.MemoriaRam +
                ", Almacenamiento=" + this.Almacenamiento +
                ", Encendida=" + this.Encendida +
                '}';
    }
}

