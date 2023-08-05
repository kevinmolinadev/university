public class Movil {

    String idMovil;
    String nroTelefono;

    public Movil(String idMovil, String nroTelefono) {
        this.idMovil = idMovil;
        this.nroTelefono = nroTelefono;
    }

    public void recibirLlamada(){
        System.out.println("Te están llamando al número " + nroTelefono);
    }
}
