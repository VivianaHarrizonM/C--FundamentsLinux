using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FundamentosC_.seccion8
{
    internal class Cadena
    {
        static void Main(string[] args)
        {
/*            string numero = "976543";

            Console.Write("Memoriza el siguiente numero: {0} y presiona enter cuando estés listo ", numero);

            Console.Clear();

            Console.Write("¿ Igresa el número, probemos que tan buena memoria tienes!: ");
            string numero2 = Console.ReadLine();
            
            if (numero.Equals(numero2))
            {
                Console.WriteLine("¡Acertaste!");
            }
            else
            {
                Console.WriteLine("¡Lo siento ! suerte para la proxima");
            }*/

 /*  Console.Write("Ingresa tu correo: ");
            string correo = Console.ReadLine();

            Console.Write("Ingresa tu correo nuevamente: ");
            string correoConfirmar = Console.ReadLine();

            bool coincideCorreo;

            coincideCorreo = correo.Equals(correoConfirmar, StringComparison.OrdinalIgnoreCase);

            if (coincideCorreo)
            {
                Console.WriteLine("Registrado con éxito");
            }
            else
            {
                Console.WriteLine("Error");
            }*/
/*
            Console.WriteLine("Registro para nuevo ingreso\n");

            Console.Write("Ingresa tu nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu correo electronico: ");
            string email = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Verifica tu información: \n");

            Console.WriteLine("Nombre: {0}", nombre.ToUpper());        
            Console.WriteLine("Correo: {0}", email.ToLower());  

            //Char.ToUpper 
            // //Char.ToLower  
*/
/*
    //Entero negativo (Primera cadena < Segunda cadena)
    //Cero (Primero cadena == Segunda cadena)
    //Entero positivo (Primera cadena > segunda cadena)

        string cadena1 = "z";
        string cadena2 = "ö";

        int ordenar;

        ordenar = string.Compare(cadena1, cadena2, new CultureInfo("de-DE"), CompareOptions.None);
        //ordenar = string.Compare(cadena1, cadena2, new CultureInfo("sv-SE"), CompareOptions.None);

        switch (ordenar)
        {
            case -1:
                Console.WriteLine("({0}) es menor que ({1}) según el criterio ordenación", cadena1, cadena2);
                break;
            case 0:
                Console.WriteLine("({0}) y ({1}) son iguales según el criterio de ordenación ", cadena1, cadena2);
                break;
            case 1:
                Console.WriteLine("({0}) es mayor que ({1}) según el criterio de ordenación ", cadena1, cadena2);
                break;
        }

*/
/*
        string cadena1 = "Hola a todos";

        Console.WriteLine(cadena1);

        //Después de PadLeft
        Console.WriteLine(cadena1.PadLeft(14));
        //Después de PadRigth
        Console.WriteLine(cadena1.PadRight(15, '#'));

*/
    //Secuencia de escape "Alerta" \a
      //  Console.WriteLine("Presiona cualquier tecla para confirmar: ");
    //    Console.ReadKey();
    //Secuencias de escape de carácteres
       // Console.WriteLine("Cuando \testás aprendiendo un lenguaje,\n conviene eliminar todo lo que no aporte d\0irectamente al tema que estudias.\n\nSi el curso es de fundamentos de C#, lo \nimport\bante es que \nentiend\ras");

//Secuencia de escape "Comilla \" "
        Console.WriteLine("La segunda tiene más personalidad y hace que ambos roles tengan nombres equivalentes dentro de la plataforma:\n \"Contratante además encaja muy bien porque no todos los usuarios serán empresas; puede ser cualquier persona que necesite una chambita.\" ");

//Secuencia de escape "Comilla simple \' "
        Console.WriteLine("El problema es encontrar el equivalente para quien solicita el servicio.\' Algunas ideas\' ");

//SEcuencia de escape "Barra diagonal inversa \\ "
        Console.WriteLine("encaja muy bien porque mantiene la identidad de la marca y se entiende \\inmediatamente\\.");


        }   

    }

}