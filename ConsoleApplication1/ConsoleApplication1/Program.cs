using System;

namespace ConsoleApplication1 
{
    class Program 
    {
        static string texto = "Hola caracola";        
        static void Main(string[] args) 
        {
            Escribe();
            SaltoLinea(1);
            Console.ReadLine();
        }

        static void Escribe()
        {
            Console.Write(texto);
        }
        static void SaltoLinea(int saltos)
        {
            for (int i = 0; i < saltos; i++)
                Console.WriteLine();
        }
    }
}
