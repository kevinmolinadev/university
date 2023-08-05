package Ejercicio_7;

public class Mesa extends Mueble implements Calidad{

    public Mesa(String material, String color, int precio) {
        super(material, color, precio);
    }

    @Override
    public void descripcion() {
        System.out.println("Esta mesa está hecha de " + getMaterial() + " y es de color " + getColor() + ".");

    }

    @Override
    public void descuento() {
        int total=getPrecio();
        if(getPrecio()>1000){
            total-=total*0.15;
        }else {
            total-=total*0.05;
        }
        System.out.println("El precio de la mesa es:"+total);
    }
}
