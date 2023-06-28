# Aplicación de consola para la gestión de tareas

Esta es una aplicación de consola en .NET que permite a los usuarios administrar una lista de tareas de manera interactiva. Los usuarios pueden agregar nuevas tareas, eliminar tareas existentes y marcar tareas como completadas.

## Estructura del proyecto

El proyecto sigue la estructura estándar de un proyecto en .NET:

- *Program.cs*: El punto de entrada del programa que contiene el método `Main`.
- *Tarea.cs*: Una clase que representa una tarea con propiedades como título, descripción y estado.
- *TaskManager.cs*: Una clase que maneja la lógica principal de la aplicación, como agregar, eliminar y mostrar tareas.
- *ConsoleHelper.cs*: Una clase que proporciona métodos de ayuda para la interacción con la consola.

## Compilación y ejecución

Para compilar y ejecutar el proyecto, sigue estos pasos:

1. Asegúrate de tener instalado el SDK de .NET en tu máquina.
2. Abre una terminal y navega hasta el directorio raíz del proyecto.
3. Ejecuta el siguiente comando para compilar el proyecto:
   
   dotnet build
   
4. Una vez compilado correctamente, ejecuta el siguiente comando para ejecutar la aplicación:
   
   dotnet run
   

## Funcionalidades

La aplicación implementa las siguientes funcionalidades:

- Agregar una nueva tarea: Permite al usuario ingresar un título y una descripción para crear una nueva tarea.
- Eliminar una tarea: El usuario puede seleccionar una tarea de la lista y eliminarla.
- Marcar una tarea como completada: El usuario puede marcar una tarea como completada, cambiando su estado.
- Mostrar lista de tareas: Muestra todas las tareas en la lista, indicando su estado actual.

## Paquetes NuGet utilizados

La aplicación utiliza los siguientes paquetes NuGet para mejorar su funcionalidad:

- *Colorful.Console*: Se utiliza para dar formato y aplicar colores en la salida de texto en la consola, mejorando la presentación visual de la aplicación.
- *ConsoleTables*: Se utiliza para generar tablas en la consola, lo que facilita la visualización de la lista de tareas en un formato tabular.

## Documentación

El código está documentado de manera adecuada utilizando comentarios descriptivos para explicar su funcionamiento. Cada clase y método tiene una breve descripción que ayuda a comprender su propósito y su uso.

Espero que esta versión actualizada del archivo "readme.md" sea de ayuda. Si tienes alguna otra pregunta, ¡no dudes en preguntar!