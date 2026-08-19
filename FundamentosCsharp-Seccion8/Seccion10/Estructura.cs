using System.Text;

namespace Seccion10
{
  internal class Estructura
  {
    static void Main(string[] args)
    {/*
      //!Tipos de referencia integrado
      //*Con palabra clave
      string cadena1;

      //*Con tipo .NET
      System.String cadena2;

      //*Co tipo .Net simplificado
      String cadena3;

        */ /*

      //*Instanciamos a la estructura 
      Alumno alumno1 = new Alumno();
      alumno1.Nombre = "Juan";

      Console.WriteLine($"El nombre del alumno es: {alumno1.Nombre}");

      Alumno alumno2 = alumno1;
      alumno1.Nombre = "Jaime";
     Console.WriteLine($"En nombre del alumno en la primera instancia es: {alumno1.Nombre}, y en la segunda es: {alumno2.Nombre}");*/

      /*
      *Contenedores
      *campos, const, props...
      *niveles de accesibilidad
      *interfaces
      *anidarse
      *instanciarse
      */

  //    Calculadora calculadora1 = new Calculadora();

  //!ESTRUCTURA DEBE llevar Conjunto de datos pequeños y especificos
/*
  Transferencia transferencia1 = new Transferencia();
  transferencia1.fecha = DateTime.Now;
  transferencia1.monto = 1000;
  transferencia1.destinatario = "Juan Perez";
  transferencia1.numerocuenta = "5543218907";
  transferencia1.concepto = "Pago del préstamo";

  Console.WriteLine(transferencia1.ToString());
*/
  //!CLASE DEBE llevar datos que formen parte de un onjeto aun más grande

    Alumno alumno1 = new Alumno("Manuel", 23);
    //Pedido pedido1 = new Pedido();


    } 


 /* struct Alumno
  {
      //Campos
      string nombre;
      string apellido;
      double calificaciones;
      bool alergias;
      string numeroTelefonico;

      //Creamos una propiedad nombre
      public string Nombre {get => nombre; set => nombre = value;}
    }
/*

    class Calculadora
    {
      
    }
    struct MiEstructura
    {
      
    }*/
  }
/*
  struct Transferencia
  {
    public DateTime fecha;
    public double monto;
    public string destinatario;
    public string numerocuenta;
    public string concepto;

    public override string ToString()
    {
      string mensaje;

      mensaje = $"Fecha: {fecha.ToString()} \nMonto: ${monto} \nDestinatario:{destinatario} \nNúmero de cuenta: {numerocuenta} \nConcepto:{concepto}";
      return mensaje;
    }
    
  }*/
/*
  class Jugador
  {
    string nombre;
    int vida;
    int puntaje;
    List<Item> inventario;
  }

  struct Item
  {
    string nombre;
    int tipo;
    int daño;
    int vida;

  }*/

  struct Pedido
  {
    public string numeroPedido;
    public bool statusPago;
    public string nombreCliente;
    public double precio;

    //COnstructor
    public Pedido(string numeroPedidoPa, bool statusPagoPa, string nombreClientePa, double precioPa)
    {
      numeroPedido = numeroPedidoPa;
      statusPago = statusPagoPa;
      nombreCliente = nombreClientePa;
      precio = precioPa;
    }
  }

  class Alumno
  {
    public string nombre;
    public int edad;

    //Constructor
    public Alumno( string nombrePa, int edadPa)
    {
      nombre = nombrePa;
      edad = edadPa;
    }

    public Alumno()
    {
      
    }
  }
}  