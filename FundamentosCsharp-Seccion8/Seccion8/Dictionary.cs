using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.seccion8
{
    internal class Dictionary
    {
       /* static void Main(string[] args)
        {
            //Dictionary, se compone de un par "clave-valor" o "key-value" pair
            Dictionary<String, int> empleados = new Dictionary<String, int>();

            //Añadeindo key-value pairs a la colección
         empleados.Add("Hugo", 35);
         empleados.Add("Victor", 35);

            foreach (KeyValuePair<String, int> elemento in empleados)
            {
                Console.WriteLine("Key es: {0} su value es: {1}", elemento.Key ,elemento.Value);
            }

            //colección[Key ] = value;
            empleados["Diego"]= 45; //Con Add: empleado.Add("Miguel",45)

            //Despues de agregar un elemento con Item[]
            Console.WriteLine("\nDespues de agregar un elemento con Item[]");

            foreach (KeyValuePair<String, int> elemento in empleados)
            {
                Console.WriteLine("Key es: {0} su value es: {1}", elemento.Key, elemento.Value);
            }
            //Comprobando que Item[] reemplaza la "key"
            Console.WriteLine("\nComprobando que Item[] reemplaza la 'key' ");
            empleados["Hugo"] = 25;

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine("Key = {0}, Value = {1}", elemento.Key, elemento.Value);
            }

            //Usando el get de la propiedad Item[]
            Console.WriteLine("La edad de Diego es: {0}", empleados["Diego"]);
            Console.WriteLine("\nDespués de remover un elemento\n");

            empleados.Remove("Diego");

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine("Key = {0}, Value = {1}", elemento.Key, elemento.Value);
            }

            System.Console.WriteLine();

            if (empleados.ContainsKey("Diego"))
            {
                System.Console.WriteLine("la key se encunetra en la colección");
            }
            else
            {
                System.Console.WriteLine("La key no se encuentra en la colección");
            }
            System.Console.WriteLine();
            if (empleados.ContainsValue(50))
            {
                System.Console.WriteLine("Existe almenos alguie con esa edad");
            }
            else
            {
                System.Console.WriteLine("no se encontro nadie con esa edad");
            }
        }*/
    }
}