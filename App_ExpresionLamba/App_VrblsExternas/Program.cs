using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_VrblsExternas
{
    class Program
    {
        static void Main(string[] args)
        {
            int local = 0;
            Func<int> funcionDelegada = () => local++;
            Console.WriteLine(funcionDelegada());
            Console.WriteLine(funcionDelegada());
            Console.WriteLine(funcionDelegada());
            Console.WriteLine(local);
            Console.ReadLine();

            Func<int, int> otraFuncionDelegada = x => local++;
            Console.WriteLine(otraFuncionDelegada);
            Console.WriteLine(otraFuncionDelegada);
            Console.WriteLine(otraFuncionDelegada);
            Console.WriteLine(local);
            Console.ReadLine();

            int[] numeros = { 12, 3, 3, 3, 4, 2, 33, 4543, 234, 55, 4, 23, 45 };
            Console.WriteLine("El nº de impares es {0}", Contar(numeros));
            Console.WriteLine("El nº de impares es {0}", numeros.Count(n => n % 2 == 1));
            Console.ReadLine();

        }

        static int Contar(int[] a)
        {
            int nImp = 0;
            foreach (int tmp in a)
            {
                if (tmp % 2 != 0)
                {
                    nImp++;
                }
            }
            return nImp;
        }
    }
}
