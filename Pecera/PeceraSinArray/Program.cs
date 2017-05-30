using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeceraSinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int anchoPecera = 5;
            int anchoPeceraMax = Console.WindowWidth;
            int altoPecera = 5;
            int altoPeceraMax = Console.WindowHeight;
            int anchoPez = 0;
            int anchoPezMax = 0;
            int altoPez = 0;
            int altoPezMax = 0;

           


            for (int alto = 0; alto < altoPecera; alto++)
            {
                for (int ancho = 0; ancho < anchoPecera; ancho++)
                {
                    if (alto == 0 || alto == (altoPecera - 1) || ancho == 0 || ancho == (anchoPecera - 1))
                    {
                        Console.Write("*");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
