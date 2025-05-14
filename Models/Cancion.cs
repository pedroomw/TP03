
namespace TP03.Models;

public class Cancion
{
    public string nombre { get; private set; }
    public int duracionSegundos { get; private set; }
   
    public Cancion(string nombre, int duracionSegundos)
    {
       this.nombre = nombre;
       this.duracionSegundos = duracionSegundos;
    }
}

