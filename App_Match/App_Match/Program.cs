using System;

namespace App_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            DateTime manana = new DateTime();
            manana = DateTime.Parse("01/01/2000");
            Randommizzed();
            Console.WriteLine(fecha.ToShortTimeString());


            Console.ReadLine();
        }

        static void Randommizzed()
        {
            while (true)
            {
                Random seed = new Random();
                int entero = seed.Next(int.MinValue, int.MaxValue);
                Random rnd = new Random(entero);
                Console.WriteLine("{0}----{1}", entero, rnd.Next(int.MinValue, int.MaxValue));
                Console.ReadLine(); 
            }
        }
    }
}
