using System.Text;

namespace Seccion9
{
    
    internal class Ejercicio9
    {
           static void Main(string[] args)
        {
            string nombreUsuario, opcion, contraseña;

            Console.WriteLine("\t\tRegistro\n\n");
            Console.Write("Ingrese un nombre de usuario: ");
            nombreUsuario = Console.ReadLine();

            Console.Write("¿Desea que le generemos una contraseña segura? (si/no): ");
            opcion = Console.ReadLine();
            opcion = opcion.ToLower();

            switch (opcion)
            {
                case "si":
                    Contraseña contraseña2 = new Contraseña(); contraseña = contraseña2.GenerarContraseña();

                    Console.WriteLine($"Esta es la contraseña que generamos para ti, guardala en un lugar seguro: {contraseña}");

                    Console.Write("\nPresiona cualquier tecla para terminar tu registro ");
                    Console.ReadKey();
                    break;
                case "no":

                    break;
            }
            
        }
    } 
       //Se crea una clase especificamente para manejar los campos y metodos ue van a generar la contraseña
    class Contraseña{
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
            Random random = new Random();

            //Declaramos una variable que guarda el tamaño que tendrá la contraseña, generamos un número aleatorio para determinar una longitus de entre 8 y 20 caracteres y se los asignamos a la variable
            int longitudContraseña = random.Next(8, 21);

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
                //volve mos a usar un número aleatorio, esta vez para seleccionar uno de los 4 grupos de string que tenemos.
                switch (random.Next(0,4))
                {
                    case 0:
                        //Si los caracteres numéricos que contienen la contraseña son menores a los que debe contener, entonces ingresa al bloque de código y los genera.
                        if (numContiene < numTener)
                        {
                            /* A "caracterEscohido" se le va a asignar un caracter aleatorio de los contenido en un string "numeros", basándose en el índice y apoyandose de la propiedad "Lenght" Ejemp
                            caracterEscogido = numeros[random.Next(10)]  //*porque son 10 elementos
                            caracterEscogido = numero[3]  //*Toma el cuarto caracter  */
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
    }    
}
