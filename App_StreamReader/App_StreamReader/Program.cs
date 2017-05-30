using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:/basura/salida.txt";
            string todo;
            StreamReader lector = new StreamReader(ruta, Encoding.Default);
            //todo = lector.ReadToEnd();
            //Console.WriteLine(todo);

            while (!lector.EndOfStream)
            {
                Console.WriteLine(lector.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
