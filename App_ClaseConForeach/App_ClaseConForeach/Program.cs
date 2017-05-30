using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ClaseConForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            MiLista lista = new MiLista();

            foreach (object tmp in lista)
            {
                Console.WriteLine(tmp);
            }

            foreach (object tmp in lista)
            {
                Console.WriteLine(tmp);
            }
            Console.ReadLine();
        }
    }
}
