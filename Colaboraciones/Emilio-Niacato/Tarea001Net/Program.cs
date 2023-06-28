/*
    Este programa es una aplicación de consola en .NET que permite a los usuarios gestionar una lista de tareas.
    Los usuarios pueden agregar, eliminar, marcar como completada y mostrar las tareas.
    La aplicación utiliza una lista de objetos de la clase "Tarea" para almacenar las tareas.
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using ConsoleTables;
using Console = Colorful.Console;

public class Tarea
{
    public string Titulo { get; set; } // Propiedad para el título de la tarea
    public string Descripcion { get; set; } // Propiedad para la descripción de la tarea
    public string Estado { get; set; } // Propiedad para el estado de la tarea
}

public class Program
{
    private static List<Tarea> tareas = new List<Tarea>(); // Lista para almacenar las tareas

    public static void Main(string[] args)
    {
        bool ejecutando = true;

        while (ejecutando)
        {
            Console.Clear(); // Limpiar la consola en cada iteración

            // Mostrar menú de opciones
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Eliminar tarea");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Mostrar tareas");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese el número de la opción deseada: ");
            string opcion = Console.ReadLine(); // Leer la opción ingresada por el usuario

            // Ejecutar la opción seleccionada
            switch (opcion)
            {
                case "1":
                    AgregarTarea(); // Llama al método para agregar una tarea
                    break;
                case "2":
                    EliminarTarea(); // Llama al método para eliminar una tarea
                    break;
                case "3":
                    MarcarTareaComoCompletada(); // Llama al método para marcar una tarea como completada
                    break;
                case "4":
                    MostrarTareas(); // Llama al método para mostrar las tareas
                    break;
                case "5":
                    ejecutando = false; // Finaliza el programa
                    break;
                default:
                    Console.WriteLine("Opción inválida"); // Opción inválida ingresada por el usuario
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    private static void AgregarTarea()
    {
        Console.Clear(); // Limpiar la consola

        // Solicitar al usuario el título y descripción de la tarea
        Console.Write("Ingrese el título de la tarea: ");
        string titulo = Console.ReadLine();
        Console.Write("Ingrese la descripción de la tarea: ");
        string descripcion = Console.ReadLine();

        // Crear una nueva tarea y agregarla a la lista de tareas
        tareas.Add(new Tarea { Titulo = titulo, Descripcion = descripcion, Estado = "Pendiente" });

        Console.WriteLine("Tarea agregada correctamente.");
    }

    private static void EliminarTarea()
    {
        Console.Clear(); // Limpiar la consola

        // Solicitar al usuario el índice de la tarea a eliminar
        Console.Write("Ingrese el índice de la tarea a eliminar: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < tareas.Count) // Verificar si el índice ingresado es válido
        {
            // Eliminar la tarea de la lista en el índice especificado
            tareas.RemoveAt(indice);
            Console.WriteLine("Tarea eliminada correctamente.");
        }
        else
        {
            Console.WriteLine("Índice inválido."); // Índice inválido ingresado por el usuario
        }
    }

    private static void MarcarTareaComoCompletada()
    {
        Console.Clear(); // Limpiar la consola

        // Solicitar al usuario el índice de la tarea a marcar como completada
        Console.Write("Ingrese el índice de la tarea a marcar como completada: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < tareas.Count) // Verificar si el índice ingresado es válido
        {
            // Actualizar el estado de la tarea en el índice especificado
            tareas[indice].Estado = "Completada";
            Console.WriteLine("Tarea marcada como completada correctamente.");
        }
        else
        {
            Console.WriteLine("Índice inválido."); // Índice inválido ingresado por el usuario
        }
    }

    private static void MostrarTareas()
    {
        Console.Clear(); // Limpiar la consola

        Console.WriteLine("Lista de tareas:");

        var table = new ConsoleTable("Índice", "Título", "Estado", "Descripción");

        // Recorrer la lista de tareas y mostrar los detalles en una tabla
        for (int i = 0; i < tareas.Count; i++)
        {
            // Colorear el estado de la tarea dependiendo de si está completada o no
            string estadoColoreado = tareas[i].Estado == "Completada" ? "Completada" : "Pendiente";
            table.AddRow(i, tareas[i].Titulo, estadoColoreado, tareas[i].Descripcion);
        }

        // Mostrar la tabla de tareas en la consola con formato y colores personalizados
        Console.WriteLine(table.Configure(o => o.EnableCount = false), Color.Pink);
    }
}
