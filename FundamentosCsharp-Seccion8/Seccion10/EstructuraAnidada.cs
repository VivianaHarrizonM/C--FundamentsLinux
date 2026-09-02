namespace Seccion10
{
  internal class EstructuraAnidada
  {
    
    static void Main(string[] args)
    {
      /*
      //*Una estructura anidada incrustada == Donde tenemos una estructura pincipal y dentrutura una instructura anidada.
      EstructuraPrincipal estructuraPrincipal = new EstructuraPrincipal();

      //*una estructura anidada separada === Dos estructuras declaradas de forma separada (Tomamos una de ellas y la instanciamos dentro de la otra).
      Empresa empresa1 = new Empresa();
      */
      
      ListaReproduccion listaReproduccion = new ListaReproduccion
      {
        Nombre = "Clasicos",
        cancion1 = { Titulo = "Bohemian Rhapsody", Artista = "Queen", Duracion = 355},
        cancion2 ={ Titulo = "Viva las vegas", Artista = "Elvis Presley", Duracion = 141},
      };

      

/*  
      listaReproduccion.Nombre = "clásicos";

      //Agregamos información  a las canciones contenidas en la lista de reproducción
      listaReproduccion.cancion1.Titulo = "Bohemian Rhapsody";
      listaReproduccion.cancion1.Artista = "Queen";
      listaReproduccion.cancion1.Duracion = 355;

      listaReproduccion.cancion2.Titulo = "Viva las vegas";
      listaReproduccion.cancion2.Artista = "Elvis Presley";
      listaReproduccion.cancion2.Duracion = 141;*/

      Console.WriteLine(listaReproduccion.ToString());

    }

    struct EstructuraPrincipal
    {
      struct EstructuraAnidada
      {
        
      }
    }

    //EStructura anidada separada
    struct Empleado
    {
      
    }
    struct Empresa
    {
      Empleado empleado1;
    }
  struct Cancion
    {
      //Campos
      string titulo;
      string artista;
      int duracion;

      //Propiedades
      public string Titulo { get => titulo; set => titulo = value; }
      public string Artista { get => artista; set => artista = value; }
      public int Duracion { get => duracion; set => duracion = value; }

      public override string ToString()
      {
        string mensaje = $"Titulo: {Titulo}\nArtista: {Artista}\nDuracion: {Duracion} segundos";
        return mensaje;
      }
    }

    struct ListaReproduccion
    {
      string nombre;

      public string Nombre { get => nombre; set => nombre = value; }

      //Anidando a la struct Cancion
      public Cancion cancion1;
      public Cancion cancion2;

      public override string ToString()
      {
        string mensaje = $"Lista de reproducción: {Nombre}\n\nCanción: {cancion1.ToString()}\n\nCanción 2: \n{cancion2.ToString()}";
        return mensaje;
      }
    }
  }
}