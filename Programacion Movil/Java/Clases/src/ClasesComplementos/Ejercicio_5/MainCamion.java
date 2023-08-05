public class MainCamion {
    public static void main(String[] args) {
        System.out.println("Hello world!");

        Camion camion1 = new Camion("Condor", 2017, 30000);
        Auto auto1 = new Auto("Corolla", 2020, 20000);

        System.out.println(camion1.toString());
        System.out.println(camion1.CalcularPrecioVenta());

        System.out.println(auto1.toString());
        System.out.println(auto1.CalcularPrecioVenta());
    }
}