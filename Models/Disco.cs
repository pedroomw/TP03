namespace TP03.Models;

public class Disco
{
    public string nombre { get; private set; }
    public List<Cancion> canciones { get; private set; }
    public string artista { get; private set; }
    public string foto { get; private set; }

    public Disco(string nombre, List<Cancion> canciones, string artista, string foto)
    {
        this.nombre = nombre;
        this.canciones = canciones;
        this.artista = artista;
        this.foto = foto;
    }
}