package Ejercicio_2;
import java.util.ArrayList;
import java.util.List;

public class GestionTareas {
    public List<Itarea> Tareas = new ArrayList<>();

    public List<Itarea> getTareas() {
        return this.Tareas;
    }

    public void setTareas(List<Itarea> tareas) {
        this.Tareas = tareas;
    }

    public void ObtenerPrioridad(){
        for (Itarea indice : this.Tareas){
            if(indice.ObtenerPrioridad()>4){
                System.out.println(indice.ObtnerNombre());
            }
        }
    }
    public void AddTarea(Itarea itarea){
        this.Tareas.add(itarea);
    }
}