using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ExpresionLambda
{
    delegate int Delegado(int i);
    delegate string DelegadoBis(string s);

    class Program
    {
        static void Main(string[] args)
        {
            int j;
            Delegado miDelegado = x => x * x;
            j = miDelegado(4);
            Console.WriteLine(j);

            DelegadoBis otroDelegado = x => x + x;
            Console.WriteLine(otroDelegado("Hola"));

            Console.ReadLine();
        }
    }
}
