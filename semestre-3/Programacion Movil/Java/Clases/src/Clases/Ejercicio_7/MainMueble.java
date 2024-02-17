package Ejercicio_7;
public class MainMueble {
    public static void main(String[] args) {
        Silla silla=new Silla("Roble","rojo",450);
        Armario armario=new Armario("Grafito","azul",1050);
        Mesa mesa=new Mesa("Metal","verde",900);
        //Calidad calidad=silla;
        //Calidad calidad1=armario;
        //Calidad calidad2=mesa;
        silla.descripcion();
        silla.descuento();
        armario.descripcion();
        armario.descuento();
        mesa.descripcion();
        mesa.descuento();
    }
}