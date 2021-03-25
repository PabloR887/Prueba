using System;

namespace Ejemplo_1__Switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;

            do
            {
                Console.Write("Ingrese un valor entre 1 y 5:"); //Pedimos un numero al usuario
                int valor = int.Parse(Console.ReadLine());//se ingres el valor 

                switch (valor) //valor guarda ese numero que ingreso el usuario 
                {
                    case 1:
                        Console.Write("uno");
                        break;
                    case 2:
                        Console.Write("dos");
                        break;
                    case 3:
                        Console.Write("tres");
                        break;
                    case 4:
                        Console.Write("cuatro");
                        break;
                    case 5:
                        Console.Write("cinco");
                        break;
                    //Si el usuario ingresa un valor fuera del rango que pedimos entra default 
                    default:
                        Console.Write("Se ingreso un valor fuera de rango");
                        break;
                }
                Console.ReadKey();
                Console.WriteLine("Si desea regresar digite si,sino, digite no para salir :");
                respuesta = Console.ReadLine();
                Console.Clear();

            } while (respuesta == "si" && respuesta !="no");
        }

    }
}
