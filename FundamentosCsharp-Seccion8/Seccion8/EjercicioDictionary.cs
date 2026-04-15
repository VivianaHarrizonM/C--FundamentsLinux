using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.seccion8
{
    internal class EjercicioDictionary{
       /* static void Main(string[] args)
        {
            //Variables necesarias
            int opcion;
            string nombre;
            long numero;
            float gasto;

            //Instanciamos a la colección
            Dictionary<string, long> contactos = new Dictionary<string, long>();
            Stack<float> gastos = new Stack<float>();            

/*
            do
            {
                Console.WriteLine("----------Agenda-----------");
                Console.Clear();
                //Menú 
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Mostrar contactos");
                Console.WriteLine("5. Actualizar contacto");

                Console.WriteLine("\nEscoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Número: ");
                        numero = Convert.ToInt64(Console.ReadLine());
                        
                        contactos.Add(nombre, numero);
                        Console.WriteLine("\n({0}) se ha agregado con exito", nombre);

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();
                        
                        if (contactos.ContainsKey(nombre))
                        {
                           Console.Write("\n¡Contacto encontrado!");
                           Console.WriteLine("\n{0}: {1}", nombre, contactos[nombre]);

                           Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                           Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }    
                        break;
                    case 3:Console.Write("Contacto a eliminar: ");
                        nombre = Console.ReadLine();
                        
                        if (contactos.ContainsKey(nombre))
                        {
                           contactos.Remove(nombre);
                           Console.WriteLine("\n({0}) ha sido eliminado con exito",nombre);

                           Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                           Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }  
                        break;
                    case 4:
                            Console.Write("Contactos en tu agenda: \n ");
                        
                        foreach (KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine("\n{0}: {1}", elemento.Key, elemento.Value);
                        }

                           Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                           Console.ReadKey();
                        
                        break;
                    case 5:
                        Console.Write("Actualizar el contacto(escribir nombre): ");
                        nombre = Console.ReadLine();
                        
                        if (contactos.ContainsKey(nombre))
                        {
                           Console.Write("\n¡Escribir el nuevo numero!");
                           numero = Convert.ToInt64(Console.ReadLine());

                           contactos[nombre] = numero; //Actualizamos el "Value" del contacto sobrescribiendo la "key".

                           Console.WriteLine("\n¡Información actualizada!");
                           Console.WriteLine("{0}: {1}", nombre, contactos[nombre]);

                           Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                           Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n¡El contacto no existe!");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                            Console.ReadKey();
                        }   
                        break;
                }                
            }while(opcion >= 1 && opcion <= 5); */
       /*
            do
            {
                Console.WriteLine("----------App Bancaria-----------");
                Console.Clear();
                //Menú 
                Console.WriteLine("1. Ingresar un gasto");
                Console.WriteLine("2. Mostrar gastos del mes");
                Console.WriteLine("3. Pago para no generar intereses");

                Console.WriteLine("\nEscoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Monto: $");
                        gasto = Convert.ToSingle(Console.ReadLine());

                        gastos.Push(gasto);
                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                    break;
                    case 2:
                        Console.WriteLine("Gastos del mes: \n");

                        foreach (float elemento in gastos)
                        {
                            Console.WriteLine("{0}", elemento);
                        }
                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                    break;
                    case 3:
                        float total = 0;

                        foreach (float elemento in gastos)
                        {
                            total += elemento;
                        }
                        Console.WriteLine("Pago para no generar intereses: ${0}", total);

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                    break;
                }
            }while (opcion >= 1 && opcion <= 3);


        }
        */
    }
}