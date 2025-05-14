namespace TP03.Models;

public class Disqueria
{
    public static Dictionary<string, Disco> Discos { get; private set; } = new Dictionary<string, Disco>();

    public static void InicializarDisqueria()
    {
        List<Cancion> canciones1 = new List<Cancion>();
        canciones1.Add(new Cancion("Come Together", 199));
        canciones1.Add(new Cancion("Something", 11));
        canciones1.Add(new Cancion("Oh! Darling", 123));

        Disco disco1 = new Disco("Abbey Road", canciones1, "The Beatles", "imagenes/AbbeyRoad.jpeg");
        Discos.Add(disco1.nombre, disco1);

        List<Cancion> canciones2 = new List<Cancion>();
        canciones2.Add(new Cancion("Billie Jean", 122));
        canciones2.Add(new Cancion("Beat It", 193));
        canciones2.Add(new Cancion("Thriller", 445));

        Disco disco2 = new Disco("Thriller", canciones2, "Michael Jackson", "imagenes/Thriller.webp");
        Discos.Add(disco2.nombre, disco2);

        List<Cancion> canciones3 = new List<Cancion>();
        canciones3.Add(new Cancion("Bohemian Rhapsody", 44));
        canciones3.Add(new Cancion("Love of My Life", 4423));
        canciones3.Add(new Cancion("You're My Best Friend", 44));

        Disco disco3 = new Disco("Opera Night", canciones3, "Queen", "imagenes/ANightAtTheOpera.jpg");
        Discos.Add(disco3.nombre, disco3);

        List<Cancion> canciones4 = new List<Cancion>();
        canciones4.Add(new Cancion("Smells Like Teen Spirit", 44));
        canciones4.Add(new Cancion("Come As You Are", 445));
        canciones4.Add(new Cancion("Lithium", 445));

        Disco disco4 = new Disco("Nevermind", canciones4, "Nirvana", "imagenes/Nevermind.jpg");
        Discos.Add(disco4.nombre, disco4);

        List<Cancion> canciones5 = new List<Cancion>();
        canciones5.Add(new Cancion("Imagine", 44));
        canciones5.Add(new Cancion("Jealous Guy", 44));
        canciones5.Add(new Cancion("Oh My Love", 44));

        Disco disco5 = new Disco("Imagine", canciones5, "John Lennon", "imagenes/Imagine.jpg");
        Discos.Add(disco5.nombre, disco5);

        List<Cancion> canciones6 = new List<Cancion>();
        canciones6.Add(new Cancion("Hells Bells", 44));
        canciones6.Add(new Cancion("Back in Black", 44));
        canciones6.Add(new Cancion("You Shook Me All Night Long", 44));

        Disco disco6 = new Disco("Back in Black", canciones6, "AC/DC", "imagenes/BackInBlack.png");
        Discos.Add(disco6.nombre, disco6);

        List<Cancion> canciones7 = new List<Cancion>();
        canciones7.Add(new Cancion("Like a Prayer", 44));
        canciones7.Add(new Cancion("Express Yourself", 44));
        canciones7.Add(new Cancion("Cherish", 44));

        Disco disco7 = new Disco("Like a Prayer", canciones7, "Madonna", "imagenes/LikeAPrayer.png");
        Discos.Add(disco7.nombre, disco7);

        List<Cancion> canciones8 = new List<Cancion>();
        canciones8.Add(new Cancion("One", 44));
        canciones8.Add(new Cancion("With or Without You", 44));
        canciones8.Add(new Cancion("Where the Streets Have No Name", 44));

        Disco disco8 = new Disco("The Joshua Tree", canciones8, "U2", "imagenes/TheJoshuaTree.jpg");
        Discos.Add(disco8.nombre, disco8);

        List<Cancion> canciones9 = new List<Cancion>();
        canciones9.Add(new Cancion("Lose Yourself", 44));
        canciones9.Add(new Cancion("Till I Collapse", 44));
        canciones9.Add(new Cancion("Without Me", 44));

        Disco disco9 = new Disco("The Eminem Show", canciones9, "Eminem", "imagenes/TheEminemShow.jpg");
        Discos.Add(disco9.nombre, disco9);

        List<Cancion> canciones10 = new List<Cancion>();
        canciones10.Add(new Cancion("Shivers", 44));
        canciones10.Add(new Cancion("Bad Habits", 44));
        canciones10.Add(new Cancion("Visiting Hours", 44));

        Disco disco10 = new Disco("Equals Ed", canciones10, "Ed Sheeran", "imagenes/=.jpg");
        Discos.Add(disco10.nombre, disco10);
    }
}