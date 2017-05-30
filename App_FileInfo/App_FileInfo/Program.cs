using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\basura\Ficheros\mio.txt";
            try
            {
                FileInfo fichero = new FileInfo(ruta);
                fichero.Attributes = FileAttributes.Normal;
                MostrarInfo(fichero);
                Console.WriteLine("| de bits {0}", (FileAttributes)(8));
            }
            catch (FileNotFoundException excepcion)
            {
                
                throw;
            }
            Console.ReadLine();
        }

        static void MostrarInfo(FileInfo fichero)
        {
            if (!fichero.Exists)
            {
                Console.WriteLine("ERROR: El fichero no existe...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("INFORMACION DEL FICHERO");
                Console.WriteLine("-".PadRight(60, '-'));
                Console.WriteLine("                 Nombre completo: " + fichero.FullName);
                Console.WriteLine("                          Nombre: " + fichero.Name);
                Console.WriteLine("                       Extensión: " + fichero.Extension);
                Console.WriteLine("                 Tamaño en bytes: " + fichero.Length);
                Console.WriteLine("         Fecha del último acceso: " + fichero.LastAccessTime);
                Console.WriteLine(" Fecha de la última modificación: " + fichero.LastWriteTime);
                Console.WriteLine("                       Atributos: " + fichero.Attributes);

            }
        }
    }
}
