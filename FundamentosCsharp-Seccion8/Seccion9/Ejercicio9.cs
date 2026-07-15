using System.Text;

namespace Seccion9
{
    internal class Ejercicio9
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

            //Instanciamos a la clase Ramdom para usarla más adelante
            Random ramdom = new Random();

            //Declaramos una variable que guarda el tamaño que tendrá la contraseña, generamos un número aleatorio para determinar una longitus de entre 8 y 20 caracteres y se los asignamos a la variable
            int longitudContraseña = ramdom.Next(8, 21);

            //Variables que van a determinar el número de caracteres que se usarán de cada grupo. Basandose en un procentaje de la longitud de la contraseña

            double numTener = longitudContraseña * .15; //El 15% de los carácteres serán números
            double minTener = longitudContraseña * .35; //El 35% de los carácteres letras minusculas
            double mayTener = longitudContraseña * .35; //El 35% de los carácteres letras mayusculas
            double espTener = longitudContraseña * .15; //El 15% de los carácteres especiales

            //variables de tipo char que va a almacenar a cada uno de los caracteres que van a conformar la contraseña.
            char caracterEscogido;

            //Usamos la iteración while para ir colocando un carácter (de los 4 del grupo) hasta que completemos la longitud que se estableció anteriormente

            while (contraseñaGenerada.Length < longitudContraseña)
            {
                
            }
        }
        static void Main(string[] args)
        {
            
            
        }
    }
}