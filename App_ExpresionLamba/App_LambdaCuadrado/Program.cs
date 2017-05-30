using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_LambdaCuadrado
{
    delegate int dlgCuadrado (int x);           // Declaro un delegado
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;

            // C# ver 1.0 Uso de delegados
            Console.WriteLine("\n === C# ver 1.0 Uso de delegados ===");
            // Creo una instancia del delegado que apunta al método cuadrado
            dlgCuadrado dc1 = new dlgCuadrado(Cuadrado);
            // Llamo al objeto del delegado y le paso un parámetro. CUMPLO la firma
            Console.WriteLine("\t{0}\n", dc1(numero));

            // C# ver 2.0 Delegado con código de inicialización (método anónimo)
            Console.WriteLine("\n === C# ver 2.0 Delegado con código de inicialización (método anónimo) ===");
            dlgCuadrado dc2 = delegate(int x)
            {
                return x* x;
            };
            Console.WriteLine("\t{0}\n", dc2(numero));

            // C# ver 3.0 Delegado con expresión lambda
            Console.WriteLine("\n === C# ver 3.0 Delegado con expresión lambda ===");
            dlgCuadrado dc3 = x => x * x;
            Console.WriteLine("\t{0}\n", dc3(numero));

            // C# ver 3.0 Delegado genérico integrado con expresión lambda
            Console.WriteLine("\n === C# ver 3.0 Delegado genérico integrado con expresión lambda ===");
            Func<int, int> dc4 = x => x * x;
            Console.WriteLine("\t{0}\n", dc4(numero));

            Console.ReadLine();
        }

        static int Cuadrado(int x)
        {
            return x * x;
        }
    }


}
