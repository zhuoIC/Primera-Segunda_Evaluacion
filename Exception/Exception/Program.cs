using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // Excepciones
            double numerador = 1;
            double denominador = 1;
            Console.WriteLine("Soy un máquina dividiendo: ");
            Console.Write("Dime el numerador: ");
            try
            {
                numerador = double.Parse(Console.ReadLine());
                Console.Write("\n Dime el denominador: ");
                denominador = double.Parse(Console.ReadLine());
                Console.WriteLine("\n\n El valor de {0}/{1}={2}", numerador, denominador, numerador / denominador);
            } catch (System.Exception e)
            {
                Console.WriteLine("Error: "+ e.ToString());
                Console.WriteLine(e.Message);

            } finally
            {  
                Console.WriteLine("Soy finally...");
                Console.ReadLine();
            }
        }
    }
}
