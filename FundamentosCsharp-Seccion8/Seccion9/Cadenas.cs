
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.seccion8
{
    internal class Cadenas
    {
      /*  static void Main(string[] args)
        {
             /*Instanciando a String por medio del alias "string"
            string cadena1 = "";
            string cadena2 = " ";
            string cadena3 = "Hola Mundo";

            char[] caracteres = {'H', 'o', 'l', 'a'};
            */ 

            //Concatenación
            /*
            string texto1 = "Hola";
            string texto2 = "a";
            string texto3 = "todos";

            string texto4 = "Hola a todos";

            string texto5 = "hola " + "a" + " todos";

            String texto6 = "El momento de la decisión es el más solitario "+
                "de la vida humana. Debe afrontarse en quietud, " + 
                "oscuridad, pensamientos sombríos y dudas arrancadas" +
                " de lo más profundo del alma";

            Console.WriteLine($"Primeros 3 textos: {texto1} {texto2} {texto3}");
            Console.WriteLine($"Texto 4: {texto4}");
            Console.WriteLine($"Texto 5: {texto5}");
            Console.WriteLine($"Texto libro: {texto6}");

            texto6 += " No lo te";
            Console.WriteLine(texto6); */

            //Metodo CONCAT
            /*
            string[] palabras = { "Hola", " a ", "todos"};

            string texto = string.Concat(palabras);
            Console.WriteLine(texto);

            string palabra1 = "Hola", palabra2 = " a ", palabra3 = "todos";
            Console.WriteLine();
            Console.WriteLine(string.Concat(palabra1, palabra2, palabra3));

            string textoSeparado = string.Join(" ", palabras);
            Console.WriteLine(textoSeparado);*/

            //METODO SPLIT
            /*string parrafo = "Digamos muchas cosas sin sentido nada más para prueba";

            string[] palabras = parrafo.Split(' ');
            //Console.WriteLine(palabras[0]);
           // Console.WriteLine(palabras[1]);

            foreach (string elemento in palabras)
            {
                Console.WriteLine("Palabra sustraida: |{0}|", elemento);   
            }*/

            //"Contains", "starsWith", "EndsWith", "IndexOf" y "LastIndexOf"
/*
              String parrafo = "El momento de la decisión es el más solitario  de la vida humana. Debe afrontarse en quietud, oscuridad, pensamientos sombríos y dudas arrancadas de lo más profundo del alma";

              Console.WriteLine("Extracto del libro: \n\n{0}\n", parrafo);

              Console.Write("\nIngresar el texto a buscar: ");
              string buscarTexto = Console.ReadLine();  

              if (parrafo.Contains(buscarTexto))
            {
                Console.WriteLine("El texto ({0}) fue encontrado", buscarTexto);
            }
            else
            {
                Console.WriteLine("No se encontró el texto ({0}) en la cadena", buscarTexto);
            }
            char caracterBucado = 'a';
            int primeraAparicion = parrafo.IndexOf(caracterBucado);
            int ultimaAparcion = parrafo.LastIndexOf(caracterBucado);

            Console.WriteLine("La primera aparición del caracter ({0}) en la cadena ({1}) es en la posición ({2}) y la ultima aparición es ({3})", caracterBucado, parrafo, primeraAparicion, ultimaAparcion); */

          /*  int[] numeros = { 5, 12, 8, 20, 3, 15 };
            int contadorMayores = 0;
            int sumaTotal = 0;
            int numeroMayor = numeros[0];

            foreach (int numero in numeros)
            
            {
             if (numero > numeroMayor)
            {
                numeroMayor = numero;
            }
            if (numero > 10)
            {
                contadorMayores++;
            }
            
            sumaTotal+= numero;
            }
            
            Console.WriteLine($"Cantidad mayores a 10: {contadorMayores}");
            Console.WriteLine($"Suma total: {sumaTotal}");
            Console.WriteLine($"Número mayor: {numeroMayor}");
        }*/
    }
}