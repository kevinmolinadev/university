package Ejercicio_9;

public class RedBoley extends EquipoDeportivo implements Movimientos{
    private String Categoria;
    public RedBoley(String nombre, int cantidadJugadores) {
        super(nombre, cantidadJugadores);
        this.Categoria="Bolibol";
    }
    public String getCategoria() {
        return Categoria;
    }

    @Override
    public void detalle() {
        System.out.println("El equipo "+getNombre()+" tiene "+getCantidadJugadores()+" jugadores en la categoria "+this.Categoria);
    }

    @Override
    public void jugadas() {
        System.out.println("El equipo "+getNombre()+" realizo 10 jugadas en el partido");
    }
}
