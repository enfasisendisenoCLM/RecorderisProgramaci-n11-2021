using System;

namespace Condicionales_y_Ciclo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            if (args.Length  == 0)
            {
                Console.WriteLine("Como te llamas?");
                nombre = Console.ReadLine();
                Console.WriteLine("Hola " + nombre.ToUpper());
            }
            else
            {
                for(int b = 0; b < args.Length; b++)
                {
                    Console.WriteLine("Hola " + args[b]);
                }
            }
            Console.ReadKey();
        }
    }
}
