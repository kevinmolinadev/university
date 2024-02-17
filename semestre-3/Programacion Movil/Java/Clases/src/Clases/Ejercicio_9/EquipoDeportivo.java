package Ejercicio_9;

public abstract class EquipoDeportivo {
    private String Nombre;
    private int CantidadJugadores;

    public EquipoDeportivo(String nombre, int cantidadJugadores) {
        Nombre = nombre;
        CantidadJugadores = cantidadJugadores;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

    public int getCantidadJugadores() {
        return CantidadJugadores;
    }

    public void setCantidadJugadores(int cantidadJugadores) {
        CantidadJugadores = cantidadJugadores;
    }


    public abstract void detalle();
}
