package Ejercicio_9;

public class MainEquipos {
    public static void main(String[] args) {
        Pelota futbol=new Pelota("Aguilas",12);
        RedBoley bolibol=new RedBoley("Toritos",8);
        aroBaloncesto baloncesto=new aroBaloncesto("Patitos",5);
        futbol.detalle();
        futbol.jugadas();
        bolibol.detalle();
        bolibol.jugadas();
        baloncesto.detalle();
        baloncesto.jugadas();
    }
}
