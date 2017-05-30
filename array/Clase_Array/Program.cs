using System;
using System.Collections.Generic;

namespace Clase_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m1 = { 1, 5, 7 };
            char[] m2 = null;
            int[] m3 = { 1, 5, 7 };

            m2 = (char[])m1.Clone();

            

            Console.WriteLine("m1 == m2 {0}", Array.Equals(m1, m2));

            Salida();
        }

        


        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
