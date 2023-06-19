using System.IO;

string? rutaBusqueda;

Console.WriteLine("Ingrese la ruta de una carpeta: ");
rutaBusqueda = Console.ReadLine();

List<string> archivos = Directory.GetFiles(@rutaBusqueda).ToList();

string? rutaGuardado = @"C:\Repos\TP08\tl1_tp8_2023-JoacoC5\";
StreamWriter index = new StreamWriter(rutaGuardado + "index.csv", true);

Console.WriteLine("\n");
foreach (var item in archivos)
{
    Console.WriteLine(item);
}

int j = 1;
for (int i = 0; i < archivos.Count(); i++)
{
    string[] separado = archivos[i].Split(@"\");
    string[] extension = separado[4].Split(".");
    index.WriteLine("Indice: " + j + "," + "Nombre del archivo: " + extension[0] + "," + "Extension: " + extension[1]);
    j++;
}

index.Close();


