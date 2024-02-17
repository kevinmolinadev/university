public class TipoDeComida {

    String nombreComida;
    int peso;

    public TipoDeComida(String nombreComida, int peso) {
        this.nombreComida = nombreComida;
        this.peso = peso;
    }

    public void disfrutar() {
        System.out.println("La comida está deliciosa");
    }
}
