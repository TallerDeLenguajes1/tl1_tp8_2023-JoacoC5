using EspacioTarea;

internal class Program
{
    private static void Main(string[] args)
    {
        var ListaDeTareasPendientes = new List<Tarea>();
        var ListaDeTareasRealizadas = new List<Tarea>();

        int cantTareas;

        Console.WriteLine("Ingrese la cantidad de tareas a generar: ");
        bool control = int.TryParse(Console.ReadLine(), out cantTareas);

        if (control)
        {
            CrearTareas(ListaDeTareasPendientes, cantTareas);
            EstadoTareas(ListaDeTareasPendientes, ListaDeTareasRealizadas);
            Console.WriteLine("\n\n-----TAREAS PENDIENTES-----");
            MostrarTareas(ListaDeTareasPendientes);
            Console.WriteLine("\n\n-----TAREAS REALIZADAS-----");
            MostrarTareas(ListaDeTareasRealizadas);
            BuscarTareaPorDescripcion(ListaDeTareasPendientes);
        }


    }

    private static void CrearTareas(List<Tarea> ListaDeTarea, int cant)
    {
        for (int i = 0; i < cant; i++)
        {
            var TareaP = new Tarea(i + 1, "Tarea: " + i, i);
            ListaDeTarea.Add(TareaP);
        }
    }

    private static void EstadoTareas(List<Tarea> Pendientes, List<Tarea> Realizadas)
    {
        int estado, j = 0;
        for (int i = 0; i < Pendientes.Count; i++)
        {
            Console.WriteLine(Pendientes[i].MostrarTarea());
            Console.WriteLine("\nSe realizo esta tarea: //1=si - 0 = no//");
            int.TryParse(Console.ReadLine(), out estado);

            if (estado == 1)
            {
                var TareaR = new Tarea();
                TareaR = Pendientes[i];
                Realizadas.Add(TareaR);
                Pendientes.RemoveAt(i);
                j++;
                i--;
            }
        }
    }

    private static void MostrarTareas(List<Tarea> Tareas)
    {
        foreach (Tarea TareaX in Tareas)
        {
            Console.WriteLine(TareaX.MostrarTarea());
        }
    }

    private static void BuscarTareaPorDescripcion(List<Tarea> Pendientes)
    {
        Console.WriteLine("\n\n---BUSCADOR POR DESCRIPCION---");
        string descripcionBuscada = String.Empty;
        Console.WriteLine("Ingrese la descripcion que busca: ");
        descripcionBuscada = Console.ReadLine();

        foreach (Tarea TareaP in Pendientes)
        {
            if (TareaP.Descripcion.Contains(descripcionBuscada))
            {
                Console.WriteLine("---TAREA ENCONTRADA---");
                Console.WriteLine(TareaP.MostrarTarea());
            }
        }
    }
}

