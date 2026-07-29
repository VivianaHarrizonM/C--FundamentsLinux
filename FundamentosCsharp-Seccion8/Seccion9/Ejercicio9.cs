
using System.Text;

namespace Seccion9
{
  internal class Ejercicio9
  {
/*
    static void Main(string[] args)
    {
      string nombreUsuario, opcion, contraseña;
      (bool contraseñaValida, string mensajeError) verificarContraseña;

      Console.WriteLine("\t\tRegistro\n\n");
      Console.Write("Ingrese un nombre de usuario: ");
      nombreUsuario = Console.ReadLine();

      Console.Write("¿Desea que le generemos una contraseña segura? (si/no): ");
      opcion = Console.ReadLine();
      opcion = opcion.ToLower();

      switch (opcion)
      {
        case "si":
          Contraseña contraseña1 = new Contraseña();
          contraseña = contraseña1.GenerarContraseña();

          Console.WriteLine($"Esta es la contraseña que generamos para ti, guárdala en un lugar seguro: {contraseña}");

          Console.Write("\nPresiona cualquier tecla para terminar tu registro ");
          Console.ReadKey();
          break;
        case "no":
          Console.Write("\nIngrese una contraseña segura (La contraseña debe tener entre 8-20 caracteres, incluido un número, una letra mayúscula y una minúscula, al igual que uno de los siguientes caracteres especiales: $%#&!?): ");
          contraseña = Console.ReadLine();

          Contraseña contraseña2 = new Contraseña();
          verificarContraseña = contraseña2.ComprobarContraseña(contraseña);
          if (verificarContraseña.contraseñaValida)
          {
            Console.Write("\nPresiona cualquier tecla para terminar tu registro");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"\nTus datos de acceso son los siguientes:\n\tusuario: {nombreUsuario}\n\tcontraseña: {contraseña}");
          }
          else
          {
            Console.WriteLine(verificarContraseña.mensajeError + " Ingresa una contraseña válida");
          }
          break;
      }
    }
  }
*/
  //Se crea una clase específicamente para manejar los campos y métodos que van a generar la contraseña
  class Contraseña
  {
    //CAMPOS
    //4 colecciones de caracteres para escoger y generar la contraseña
    string numeros = "0123456789";
    string letrasMin = "abcdefghijklmnopqrstuvwxyz";
    string letrasMay = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string caracterEspecial = "$%#&!?";

    //Contadores para verificar el número de caracteres de cada grupo
    int numContiene = 0, minContiene = 0, mayContiene = 0, espContiene = 0;

    //Método para generar la contraseña
    public string GenerarContraseña()
    {
      //Aquí generamos la contraseña
      string contraseñaGenerada = "";

      //Instanciamos a la clase Random para usarla más adelante
      Random random = new Random();

      //Declaramos una variable que guarda el tamaño que tendrá la contraseña, generamos un número aleatorio para determinar una longitud de entre 8 y 20 caracteres y se los asignamos a la variable
      int longitudContraseña = random.Next(8, 21);

      //Variables que van a determinar el número de caracteres que se usarán de cada grupo. Basándose en un porcentaje de la longitud de la contraseña
      double numTener = longitudContraseña * .15; //El 15% de los caracteres serán números
      double minTener = longitudContraseña * .35; //El 35% de los caracteres letras minúsculas
      double mayTener = longitudContraseña * .35; //El 35% de los caracteres letras mayúsculas
      double espTener = longitudContraseña * .15; //El 15% de los caracteres especiales

      //Variable de tipo char que va a almacenar a cada uno de los caracteres que van a conformar la contraseña.
      char caracterEscogido;

      //Usamos la iteración while para ir colocando un carácter (de los 4 del grupo) hasta que completemos la longitud que se estableció anteriormente
      while (contraseñaGenerada.Length < longitudContraseña)
      {
        //Volvemos a usar un número aleatorio, esta vez para seleccionar uno de los 4 grupos de string que tenemos.
        switch (random.Next(0, 4))
        {
          case 0:
            //Si los caracteres numéricos que contiene la contraseña son menores a los que debe contener, entonces ingresa al bloque de código y los genera.
            if (numContiene < numTener)
            {
              /* A "caracterEscogido" se le va a asignar un carácter aleatorio de los contenidos en un string "numeros", basándose en el índice y apoyándose de la propiedad "Length" Ejemplo:
              caracterEscogido = numeros[random.Next(10)]  //*porque son 10 elementos
              caracterEscogido = numeros[3]  //*Toma el cuarto carácter  */
              caracterEscogido = numeros[random.Next(numeros.Length)];
              contraseñaGenerada += caracterEscogido;
              numContiene++;
            }
            break;
          case 1:
            if (minContiene < minTener)
            {
              caracterEscogido = letrasMin[random.Next(letrasMin.Length)];
              contraseñaGenerada += caracterEscogido;
              minContiene++;
            }
            break;
          case 2:
            if (mayContiene < mayTener)
            {
              caracterEscogido = letrasMay[random.Next(letrasMay.Length)];
              contraseñaGenerada += caracterEscogido;
              mayContiene++;
            }
            break;
          case 3:
            if (espContiene < espTener)
            {
              caracterEscogido = caracterEspecial[random.Next(caracterEspecial.Length)];
              contraseñaGenerada += caracterEscogido;
              espContiene++;
            }
            break;
        }
      }
      return contraseñaGenerada;
    }

    //Método para comprobar la contraseña
    public (bool, string) ComprobarContraseña(string contraseñaPa)
    {
      //Variable que guardará el valor bool cuando compruebe todas las características de la contraseña
      bool contraseñaValida = false;

      //Variables para cada criterio de la contraseña
      bool hayNumero = false, hayMinuscula = false, hayMayuscula = false, hayEspecial = false;
      //Variable que contendrá el mensaje de error
      string mensajeError = "";

      //Verificar primero que se cumpla la longitud
      if (contraseñaPa.Length >= 8 && contraseñaPa.Length <= 20)
      {
        //Verificamos que contenga al menos un número
        foreach (char elemento in numeros)
        {
          //Si el elemento de "numeros" se encuentra en la contraseña dada por el usuario entonces se ingresa al "if" y "hayNumero" se convierte en "true"
          if (contraseñaPa.IndexOf(elemento) >= 0)
          {
            hayNumero = true;
            break; //Fuerza la terminación de foreach
          }
          else
          {
            hayNumero = false;
            mensajeError = "La contraseña debe contener al menos un número";
          }
        }

        //Verificamos que haya existido un número en la contraseña
        if (hayNumero)
        {
          //Verificamos que contenga al menos una letra minúscula
          foreach (char elemento in letrasMin)
          {
            if (contraseñaPa.IndexOf(elemento) >= 0)
            {
              hayMinuscula = true;
              break; //Fuerza la terminación de foreach
            }
            else
            {
              hayMinuscula = false;
              mensajeError = "La contraseña debe contener al menos una letra minúscula";
            }
          }

          if (hayMinuscula)
          {
            //Verificamos que contenga al menos una letra mayúscula
            foreach (char elemento in letrasMay)
            {
              if (contraseñaPa.IndexOf(elemento) >= 0)
              {
                hayMayuscula = true;
                break; //Fuerza la terminación de foreach
              }
              else
              {
                hayMayuscula = false;
                mensajeError = "La contraseña debe contener al menos una letra mayúscula";
              }
            }

            if (hayMayuscula)
            {
              //Verificamos que contenga al menos un carácter especial
              foreach (char elemento in caracterEspecial)
              {
                if (contraseñaPa.IndexOf(elemento) >= 0)
                {
                  hayEspecial = true;
                  break; //Fuerza la terminación de foreach
                }
                else
                {
                  hayEspecial = false;
                  mensajeError = "La contraseña debe contener al menos un carácter especial ($%#&!?)";
                }
              }
            }
          }
        }

        //Verificamos que exista un número, una letra minúscula y una mayúscula al igual que un carácter especial
        if (hayNumero && hayMinuscula && hayMayuscula && hayEspecial)
        {
          //Si la contraseña cumple con todos los requisitos mínimos, entonces devolvemos un "true".
          contraseñaValida = true;
          mensajeError = "La contraseña es válida";
        }
      }
      else
      {
        //Si la contraseña no cumple si quiera con la longitud requerida, entonces se lo indicamos al usuario.
        mensajeError = "La contraseña debe contener entre 8-20 caracteres";
        contraseñaValida = false;
      }

      return (contraseñaValida, mensajeError);
    }
  }
}
}