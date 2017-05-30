using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_ContenidoFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Basura\salida.txt";
            Console.WriteLine("Este texto se muestra en la pantalla");

            // Creo un flujo que apunta a mi fichero
            FileStream fs = new FileStream(ruta, FileMode.Create);

            // Guardo donde apunta el flujo actual, pantalla
            TextWriter tWTmp = Console.Out;

            // Creo el nuevo flujo de salida
            StreamWriter sw = new StreamWriter(fs);

            // Redirecciona la salida del flujo de la pantalla
            Console.SetOut(sw);

            Console.WriteLine("Listado de numero enteros menores de 100");
            Console.WriteLine("=".PadRight(70,'='));
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("\n Fin del listado");

            // Volver a la situacion inicial
            Console.SetOut(tWTmp);
            Console.WriteLine("Papi ha vuelto");
            sw.Close();

            Console.ReadLine();
        }
    }
}
