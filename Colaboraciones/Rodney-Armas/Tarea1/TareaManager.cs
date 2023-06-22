using System.Collections.Generic;

// Clase que administra las tareas utilizando una lista.
public class TareaManager
{
    private List<Tarea> tareas;

    public TareaManager()
    {
        tareas = new List<Tarea>();
    }

    // Agregar una nueva tarea a la lista
    public void AgregarTarea(Tarea tarea)
    {
        tareas.Add(tarea);
    }

    // Eliminar una tarea de la lista
    public void EliminarTarea(Tarea tarea)
    {
        tareas.Remove(tarea);
    }

    // Marcar una tarea como completada
    public void MarcarTareaComoCompletada(Tarea tarea)
    {
        tarea.Estado = true;
    }

    // Obtener todas las tareas
    public List<Tarea> ObtenerTareas()
    {
        return tareas;
    }
}
