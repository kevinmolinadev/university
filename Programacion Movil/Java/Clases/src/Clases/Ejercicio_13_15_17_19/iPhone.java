public class iPhone extends Movil {

    String SO;
    int version;

    public iPhone(String idMovil, String nroTelefono, String SO, int version) {
        super(idMovil, nroTelefono);
        this.SO = SO;
        this.version = version;
    }

    public void seMuere() {
        System.out.println("Me quedé sin batería señor Stark");
    }

    @Override
    public String toString() {
        return "iPhone{" +
                "SO='" + SO + '\'' +
                ", version=" + version +
                ", idMovil='" + idMovil + '\'' +
                ", nroTelefono='" + nroTelefono + '\'' +
                '}';
    }
}
