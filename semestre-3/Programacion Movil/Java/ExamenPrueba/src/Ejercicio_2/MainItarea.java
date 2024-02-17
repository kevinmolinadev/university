package Ejercicio_2;

public class MainItarea {
    public static void main(String[] args) {
        TareaCasa tarea1 = new TareaCasa(8,"Limpiar");
        TareaCasa tarea2 = new TareaCasa(3,"Lavar los platos");
        TareaCasa tarea3 = new TareaCasa(9,"ordenar el cuarto");
        TareaCasa tarea4 = new TareaCasa(4,"Ordenar");
        TareaUniversidad tareaU5 = new TareaUniversidad(10,"Mesa");
        GestionTareas gestionTareas=new GestionTareas();
        gestionTareas.AddTarea(tarea1);
        gestionTareas.AddTarea(tarea2);
        gestionTareas.AddTarea(tarea3);
        gestionTareas.AddTarea(tarea4);
        gestionTareas.AddTarea(tareaU5);
        gestionTareas.ObtenerPrioridad();
    }
}
