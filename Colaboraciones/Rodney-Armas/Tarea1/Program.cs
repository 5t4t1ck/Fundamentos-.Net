using System;
using ConsoleTables;

// Clase principal del programa.
public class Program
{
    private static TareaManager tareaManager = new TareaManager();

    public static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("=== Aplicacion de Tareas ===");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Eliminar tarea");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Mostrar todas las tareas");
            Console.WriteLine("5. Salir");
            Console.WriteLine();

            Console.Write("Ingrese el numero de la opcion: ");
            string opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    AgregarTarea();
                    break;
                case "2":
                    EliminarTarea();
                    break;
                case "3":
                    MarcarTareaComoCompletada();
                    break;
                case "4":
                    MostrarTareas();
                    break;
                case "5":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion invalida. Intente nuevamente.");
                    Console.WriteLine();
                    break;
            }
        }
    }

 // Método para agregar una tarea.
    private static void AgregarTarea()
    {
        Console.Write("Ingrese el titulo de la tarea: ");
        string titulo = Console.ReadLine();

        Console.Write("Ingrese la descripcion de la tarea: ");
        string descripcion = Console.ReadLine();

        Tarea tarea = new Tarea
        {
            Titulo = titulo,
            Descripcion = descripcion,
            Estado = false
        };

        tareaManager.AgregarTarea(tarea);

        Console.WriteLine("Tarea agregada con exito.");
        Console.WriteLine();
    }

 // Método para eliminar una tarea.
    private static void EliminarTarea()
    {
        MostrarTareas();

        Console.Write("Ingrese el numero de la tarea a eliminar: ");
        int indice;

        if (int.TryParse(Console.ReadLine(), out indice) && indice >= 1 && indice <= tareaManager.ObtenerTareas().Count)
        {
            Tarea tarea = tareaManager.ObtenerTareas()[indice - 1];
            tareaManager.EliminarTarea(tarea);

            Console.WriteLine("Tarea eliminada con exito.");
        }
        else
        {
            Console.WriteLine("Indice invalido. Intente nuevamente.");
        }

        Console.WriteLine();
    }

 // Método para marcar una tarea como completada.
    private static void MarcarTareaComoCompletada()
    {
        MostrarTareas();

        Console.Write("Ingrese el numero de la tarea a marcar como completada: ");
        int indice;

        if (int.TryParse(Console.ReadLine(), out indice) && indice >= 1 && indice <= tareaManager.ObtenerTareas().Count)
        {
            Tarea tarea = tareaManager.ObtenerTareas()[indice - 1];
            tareaManager.MarcarTareaComoCompletada(tarea);

            Console.WriteLine("Tarea marcada como completada con exito.");
        }
        else
        {
            Console.WriteLine("Indice invalido. Intente nuevamente.");
        }

        Console.WriteLine();
    }

// Método para mostrar todas las tareas sin NuGet.
    // private static void MostrarTareas()
    // {
    //     List<Tarea> tareas = tareaManager.ObtenerTareas();

    //     if (tareas.Count > 0)
    //     {
    //         Console.WriteLine("=== Lista de Tareas ===");

    //         for (int i = 0; i < tareas.Count; i++)
    //         {
    //             Tarea tarea = tareas[i];
    //             string estado = tarea.Estado ? "Completada" : "Pendiente";

    //             Console.WriteLine($"{i + 1}. {tarea.Titulo} - {tarea.Descripcion} - Estado: {estado}");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("No hay tareas para mostrar.");
    //     }

    //     Console.WriteLine();
    // }

// Método para mostrar todas las tareas con ConsoleTables libreria NuGet.
    private static void MostrarTareas()
{
    List<Tarea> tareas = tareaManager.ObtenerTareas();

    if (tareas.Count > 0)
    {
        Console.WriteLine("=== Lista de Tareas ===");

        var table = new ConsoleTable("Título", "Descripción", "Estado");

        foreach (var tarea in tareas)
        {
            string estado = tarea.Estado ? "Completada" : "Pendiente";
            table.AddRow(tarea.Titulo, tarea.Descripcion, estado);
        }

        table.Write();
    }
    else
    {
        Console.WriteLine("No hay tareas para mostrar.");
    }

    Console.WriteLine();
}
}

