public class Tierra extends Planeta{

    int extension;
    boolean vida;

    public Tierra(String nombre, String sistemaSolar, int extension, boolean vida) {
        super(nombre, sistemaSolar);
        this.extension = extension;
        this.vida = vida;
    }

    public int extensionEntrePoblacion (int poblacion) {
        int resultado;
        resultado = extension / poblacion;
        return resultado;
    }

    @Override
    public String toString() {
        return "Tierra{" +
                "extension=" + extension +
                ", vida=" + vida +
                ", nombre='" + nombre + '\'' +
                ", sistemaSolar='" + sistemaSolar + '\'' +
                '}';
    }
}
