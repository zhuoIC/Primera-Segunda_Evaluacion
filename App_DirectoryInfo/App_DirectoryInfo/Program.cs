using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\basura\Ficheros\mio.txt";
            DirectoryInfo d = new DirectoryInfo("C:\\");
            DirectoryInfo[] ficheros = d.GetDirectories();
            foreach (DirectoryInfo item in ficheros)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
