using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long grano = 1;
            long granoAnterior = 0;

            Environment.Exit(Environment.ExitCode);

            for (int n = 1; n <= 64; n++)
            {
                grano = 2* grano + granoAnterior;
                if (n%8==0)
                {
                    Console.WriteLine(grano);
                }
                granoAnterior = grano;
            }
            
            
            Console.ReadLine();
        }

        static double Granos(double grano, int casilla)
        {

            if (casilla == 1)
                return grano;
            if (casilla > 0)
	        {
                casilla--;
		        return grano + Granos(2*grano, casilla);
	        }
            return 0;

        }
    }
}
