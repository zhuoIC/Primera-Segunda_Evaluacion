using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Excepciones
{
    class Program
    {
        static int zero = 0;
        static List<int> lista;


        static void Main(string[] args)
        {
            
            try
            {
                lista.Add(5);
                throw new DivideByZeroException("Repasa las mates");
                int j = 22 / zero;
            }
            catch (Exception e)
            {

                Console.WriteLine("     Mensaje: " + e.Message);
                Console.WriteLine("  Aplicacion: " + e.Source);
                Console.WriteLine("      Metodo: " + e.TargetSite);
                Console.WriteLine("        Tipo: " + e.GetType());
            }
            Console.ReadLine();
        }
    }
}
