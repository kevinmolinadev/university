public class Jupiter extends Planeta implements IMetodos {

    int lejaniaSol;
    boolean planetaMasGrande;

    public Jupiter(String nombre, String sistemaSolar, int lejaniaSol, boolean planetaMasGrande) {
        super(nombre, sistemaSolar);
        this.lejaniaSol = lejaniaSol;
        this.planetaMasGrande = planetaMasGrande;
    }

    public void muchosMetodos() {
        System.out.println("No sé que más enseñar");
    }

    @Override
    public String toString() {
        return "Jupiter{" +
                "lejaniaSol=" + lejaniaSol +
                ", planetaMasGrande=" + planetaMasGrande +
                ", nombre='" + nombre + '\'' +
                ", sistemaSolar='" + sistemaSolar + '\'' +
                '}';
    }

    @Override
    public void metodoDeInterfaz() {
        System.out.println("Este es el metodo por interfaz");
    }
}
