public class Marte extends Planeta {

    String extensionMarte;
    int poblacionMarte;

    public Marte(String nombre, String sistemaSolar, String extensionMarte, int poblacionMarte) {
        super(nombre, sistemaSolar);
        this.extensionMarte = extensionMarte;
        this.poblacionMarte = poblacionMarte;
    }

    public void taFuerte() {
        if (poblacionMarte != 0) {
            System.out.println("¿Vida en marte?");
        }
    }

    @Override
    public String toString() {
        return "Marte{" +
                "extensionMarte='" + extensionMarte + '\'' +
                ", poblacionMarte=" + poblacionMarte +
                ", nombre='" + nombre + '\'' +
                ", sistemaSolar='" + sistemaSolar + '\'' +
                '}';
    }
}
