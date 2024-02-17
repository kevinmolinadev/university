public class Samsung extends Movil {

    String modelo;
    int bateria;

    public Samsung(String idMovil, String nroTelefono, String modelo, int bateria) {
        super(idMovil, nroTelefono);
        this.modelo = modelo;
        this.bateria = bateria;
    }

    public int menosBateria() {
        return bateria - 1;
    }

    @Override
    public String toString() {
        return "Samsung{" +
                "modelo='" + modelo + '\'' +
                ", bateria=" + bateria +
                ", idMovil='" + idMovil + '\'' +
                ", nroTelefono='" + nroTelefono + '\'' +
                '}';
    }
}
