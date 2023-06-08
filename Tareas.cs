namespace EspacioTarea;

public class Tarea
{
    private int tareaID;
    private string descripcion = String.Empty;
    private int duracion;

    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

    public Tarea()
    {

    }

    public Tarea(int tareaID, string descripcion, int duracion)
    {
        TareaID = tareaID;
        Descripcion = descripcion;
        Duracion = duracion;
    }

    public String MostrarTarea()
    {
        return ("\n\nTarea ID: " + tareaID + "\nDescripcion: " + descripcion + "\nDuracion: " + duracion);
    }

}
