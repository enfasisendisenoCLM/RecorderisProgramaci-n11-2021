using System;

namespace Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
        
            nombre = Console.ReadLine();
            //Salida de información
            Console.WriteLine("Hello " + nombre + "!");
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }
    }
}
