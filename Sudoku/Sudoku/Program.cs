using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[0])
            {

                case "1":
                    Console.WriteLine("   ║");
                    Console.WriteLine("   ║");
                    Console.WriteLine("   ║");
                    break;
                case "2":
                    Console.WriteLine("═══╗");
                    Console.WriteLine("╔══╝");
                    Console.WriteLine("╚═══");
                    break;
                case "3":
                    Console.WriteLine("═══╗");
                    Console.WriteLine("═══╣");
                    Console.WriteLine("═══╝");
                    break;
                case "4":
                    Console.WriteLine("║  ║");
                    Console.WriteLine("╚══╣");
                    Console.WriteLine("   ║");
                    break;
                case "5":
                    Console.WriteLine("╔═══");
                    Console.WriteLine("╚══╗");
                    Console.WriteLine("═══╝");
                    break;
                case "6":
                    Console.WriteLine("╔═══");
                    Console.WriteLine("╠══╗");
                    Console.WriteLine("╚══╝");
                    break;
                case "7":
                    Console.WriteLine("═══╗");
                    Console.WriteLine("   ║");
                    Console.WriteLine("   ║");
                    break;
                case "8":
                    Console.WriteLine("╔══╗");
                    Console.WriteLine("╠══╣");
                    Console.WriteLine("╚══╝");
                    break;
                case "9":
                    Console.WriteLine("╔══╗");
                    Console.WriteLine("╚══╣");
                    Console.WriteLine("═══╝");
                    break;
                default:
                    Console.WriteLine("    ");
                    Console.WriteLine("    ");
                    Console.WriteLine("    ");
                    break;
            }
            Console.ReadLine();

        }
    }
}
