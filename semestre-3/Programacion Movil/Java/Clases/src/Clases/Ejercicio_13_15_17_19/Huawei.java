public class Huawei extends Movil implements IMetodos {

    String año;
    boolean bloqueadoAndroid = true;

    public Huawei(String idMovil, String nroTelefono, String año, boolean bloqueadoAndroid) {
        super(idMovil, nroTelefono);
        this.año = año;
        this.bloqueadoAndroid = bloqueadoAndroid;
    }

    public void UsarGoogle() {
        if (bloqueadoAndroid == true) {
            System.out.println("No puedes usar Google");
        }
        else {
            System.out.println("Puedes usar Google");
        }
    }

    @Override
    public String toString() {
        return "Huawei{" +
                "año='" + año + '\'' +
                ", bloqueadoAndroid=" + bloqueadoAndroid +
                ", idMovil='" + idMovil + '\'' +
                ", nroTelefono='" + nroTelefono + '\'' +
                '}';
    }

    @Override
    public void metodoDeInterfaz() {
        System.out.println("Este es el metodo por interfaz");
    }
}
