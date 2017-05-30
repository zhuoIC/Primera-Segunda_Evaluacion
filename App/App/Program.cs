using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables para las dimensiones actuales
            int altoAct = Console.WindowWidth;
            int anchoAct = Console.WindowHeight;

            Console.WriteLine("Características de l consola de salida");
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine("Ancho máximo posible: {0}", Console.LargestWindowWidth);
            Console.WriteLine(" Alto máximo posible: {0}\n", Console.LargestWindowHeight);
            Console.WriteLine("        Ancho actual: {0}", Console.WindowWidth);
            Console.WriteLine("         Alto actual: {0}", Console.WindowHeight);

            Console.WriteLine("\n\n\n            .nd888bn.          ");
            Console.WriteLine("          .d888888888b.           ");
            Console.WriteLine("         .d88888888888b.            ");
            Console.WriteLine("         888888888888888            ");
            Console.WriteLine("         888888888888888             ");
            Console.WriteLine("         888888888888888            ");
            Console.WriteLine("         '8888888888888'           ");
            Console.WriteLine("          `+888888888+'             ");
            Console.WriteLine("            `\"+888+\"'              ");
            Console.WriteLine("                          ");


            // Cambiar las dimensiones de la pantalla
            Console.CursorTop = Console.CursorTop - 7;
           
            Console.ReadLine();
        }
    }
}
