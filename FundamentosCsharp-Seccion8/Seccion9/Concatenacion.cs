using System.Text;

namespace Seccion9
{
    class Concatenacion
    {
        static void Main(string[] args)
        {
           /*  //Concatenación
            String palabra1 = "Hola"; //Creamos un objeto y se lo asignamos a la referencia "palabra1";
            String palabra2 = palabra1; // Creamos otra referencia (palabra2) que contiene el objeto de arriba

            //Imprimimos el valor de ambas referencias
            Console.WriteLine("Referencia 1: " + palabra1);
            Console.WriteLine("Referencia 2: " + palabra2);

            palabra1 += "a todos";

            Console.WriteLine("\nDespues de la concatenación\n");

            Console.WriteLine("Referencia 2: " + palabra2);*/

             /*
            string texto_original = "--------Cada libro, cada volumen que ves aquí, tiene un alma. El alma de la persona que lo escribió y de aquellos que lo leyeron, vivieron y soñaron con él. Cada vez que un libro cambia de manos, cada vez que alguien baja sus ojos a las páginas, su espíritu crece y se fortalece (La Sombra del Viento, Carlos Ruiz Zafón)";

            //Reemplazamos "libro" por "Libro" en una nueva cadena
            string textoRemplazo = texto_original.Replace("libro", "Libro");

            Console.WriteLine(texto_original);
            Console.WriteLine();
            Console.WriteLine(textoRemplazo);

            //Quitamos los guiones
            string textoReemplazo = texto_original.Trim('-');

            Console.WriteLine(texto_original);
            Console.WriteLine();
            Console.WriteLine(textoReemplazo);

            //Quitamos la palabra "cada"
            string textoRemplazo2 = texto_original.Remove(21, 5);
            
            Console.WriteLine(texto_original);
            Console.WriteLine();
            Console.WriteLine(textoRemplazo2);
            */

/*
            string numeros = "";

            for (int i = 0; i < 100; i++)
            {
                numeros += i + ",";
            }
            Console.WriteLine(numeros);*/

            StringBuilder numeros = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                numeros.Append(i);
                numeros.Append(", ");

            }

            string cadenaNumeros = numeros.ToString();
            Console.WriteLine(cadenaNumeros);

        }
    }
}