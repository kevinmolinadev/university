package Ejercicio_7;
public class Silla extends Mueble implements Calidad {

    public Silla(String material, String color, int precio) {
        super(material, color, precio);
    }

    @Override
    public void descripcion() {
        System.out.println("Esta silla está hecha de " + getMaterial() + " y es de color " + getColor() + ".");
    }
    @Override
    public void descuento() {
        int total=getPrecio();
        if(getPrecio()>800){
            total-=total*0.20;
        }else {
            total-=total*0.05;
        }
        System.out.println("El precio de la silla es:"+total);
    }
}
