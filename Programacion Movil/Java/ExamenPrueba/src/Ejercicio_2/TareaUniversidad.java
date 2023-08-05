package Ejercicio_2;

public class TareaUniversidad extends TareaCasa implements Itarea{
    public TareaUniversidad(int prioridad, String nombre) {
        super(prioridad, nombre);
    }

    @Override
    public String ObtnerNombre() {
        return getNombre();
    }

    @Override
    public int ObtenerPrioridad() {
        return getPrioridad();
    }
}
