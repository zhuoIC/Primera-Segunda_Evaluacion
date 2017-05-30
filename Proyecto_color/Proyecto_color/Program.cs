using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_color
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int col = 10;
            int fil = 8;
            Console.Clear();
            Console.Co
            // Cambio color de fondo
            Console.BackgroundColor = ConsoleColor.Cyan;

            // Cambio color texto
            Console.ForegroundColor = ConsoleColor.Red;

            //Cambio posicion cursor
            Console.SetCursorPosition(col, fil);

            Console.Clear();
            Console.WriteLine("Hola caracola");

            Console.ResetColor();
            Console.WriteLine("Adios");
            Console.ReadLine();
        }
    }
}
