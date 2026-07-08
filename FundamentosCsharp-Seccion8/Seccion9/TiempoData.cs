using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Seccion9
{
    internal class TiempoData
    {
        static void Main(string[] args)
        {
            //Declarando un objeto DataTime
           /* DateTime fechaHoraPredeterminados = new DateTime();
            DateTime fecha = new DateTime(2007, 12, 08);
            DateTime fechaHora = new DateTime(2007, 12, 08, 18, 20, 8);

            Console.WriteLine(fechaHoraPredeterminados);
            Console.WriteLine(fecha);
            Console.WriteLine(fechaHora);*/

            DateTime fechaHora = new DateTime(2022, 01, 05, 13, 54, 10);

            Console.WriteLine($"El valor del objeto DateTime es : {fechaHora}");

            //*Convirtiendo el objeto DateTime en una cadena
            //Especificadores que requieren modificación: ("d", "f","F","g","h","H","K","m","M","s","t","y","z",":" o "/")
            string cadenaFechaHora = fechaHora.ToString("ddd dd MMM yyyy h m tt");
            

            //Imprimiendo la representación en cadena del objeto DateTime según la referencia cultural actual.
            Console.WriteLine($"La presentaxción en cadena es:  {cadenaFechaHora}");





        }
    }
}