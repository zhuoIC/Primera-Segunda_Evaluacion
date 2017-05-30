using System;

namespace App_parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            foreach (var item in args)
            {
                Console.WriteLine("Argumento {0}: {1}", contador, item);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
