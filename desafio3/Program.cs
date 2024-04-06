using System;


class Program
{
    static List<string> tarea = new List<string>();

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("===== Menú de Tareas =====");
            Console.WriteLine("1. Mostrar Tareas");
            Console.WriteLine("2. Agregar Tarea");
            Console.WriteLine("3. Eliminar Tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Mostrar();
                    break;
                case "2":
                    Agregar();
                    break;
                case "3":
                    Eliminar();
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("OPCION NO VALIDA! intenta con una nueva opcion");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Mostrar()
    {
        if (tarea.Count == 0)
        {
            Console.WriteLine("No hay tareas por realizar.");
        }
        else
        {
            Console.WriteLine("Tareas por Realizar");

            for (int i = 0; i < tarea.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarea[i]}");
            }
        }
    }

    static void Agregar()
    {
        Console.Write("Ingresa una nueva tarea para realizar: ");

        string TareaNueva = Console.ReadLine();

        tarea.Add(TareaNueva);

        Console.WriteLine("Tu tarea se agrego correctamente");
    }

    static void Eliminar()
    {
        Mostrar();

        if (tarea.Count == 0)
        {
            Console.WriteLine("No hay tareas para eliminar.");
        }
        else
        {
            Console.Write("la tarea se elimina ingresando el numero correspondiente, por favor ingresa el numero de la tarea: ");

            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tarea.Count)
            {
                tarea.RemoveAt(indice - 1);

                Console.WriteLine("TAREA ELIMINADA");
            }
            else
            {
                Console.WriteLine("Índice no válido. Por favor, ingrese un número de tarea válido.");
            }
        }
    }
}