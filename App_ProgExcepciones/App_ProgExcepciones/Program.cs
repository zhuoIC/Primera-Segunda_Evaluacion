using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ProgExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ContadorCeroException("La has liado parda");
            }
            catch (ContadorCeroException e)
            {
                Console.WriteLine("Catch del MAIN nivel 0");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }

    class ContadorCeroException : Exception
    {
        public ContadorCeroException()
            :base("El contador no puede ser CERO")
        { 
        }

        public ContadorCeroException(string msg)
            :base(msg)
        { 
        }
    }
}
