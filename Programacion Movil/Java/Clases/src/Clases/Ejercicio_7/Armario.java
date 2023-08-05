package Ejercicio_7;

public class Armario extends Mueble implements  Calidad{

    public Armario(String material, String color, int precio) {
        super(material, color, precio);
    }

    @Override
    public void descripcion() {
        System.out.println("Este armario está hecho de " + getMaterial() + " y es de color " + getColor() + ".");
    }
    @Override
    public void descuento() {
        int total=getPrecio();
        if(getPrecio()>1000){
            total-=total*0.30;
        }else {
            total-=total*0.10;
        }
        System.out.println("El precio del Armario es:"+total);
    }
}






