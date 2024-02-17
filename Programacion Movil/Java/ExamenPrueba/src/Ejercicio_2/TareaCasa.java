package Ejercicio_2;

public class TareaCasa implements Itarea{
    private String Nombre;
    private String Fecha;
    private int Prioridad;
    private boolean Estado=false;

    public TareaCasa( int prioridad,String nombre) {
        Nombre = nombre;
        Prioridad = prioridad;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

    public String getFecha() {
        return Fecha;
    }

    public void setFecha(String fecha) {
        Fecha = fecha;
    }

    public int getPrioridad() {
        return Prioridad;
    }

    public void setPrioridad(int prioridad) {
        Prioridad = prioridad;
    }

    public boolean isEstado() {
        return Estado;
    }

    public void setEstado(boolean estado) {
        Estado = estado;
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
