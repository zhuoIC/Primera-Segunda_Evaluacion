using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Basura\Ficheros\mio.txt";
            string contenido = "En un lugar de la mancha...\r\n";
            StreamWriter fichero;
            FileInfo objFileInfo = new FileInfo(ruta);


            // Crea el fichero si no existe y le añade texto
            // Automaticamente cierra el archivo
            using (StreamWriter sw = File.CreateText(ruta))
            {
                sw.WriteLine("Esto es un línea para el fichero");
                sw.WriteLine("Y esta es la segunda" + sw.NewLine);
                sw.WriteLine("Por fin la última línea");
            }

            // Imprimir el contenido del fichero
            contenido = File.ReadAllText(ruta, Encoding.UTF8);
            Console.WriteLine(contenido);


            /*
            if (File.Exists(ruta))
            {
                fichero = File.CreateText(ruta);
                fichero.Close();
                File.Delete(ruta);
            }
            else
            {
                Console.WriteLine("No existe el fichero");
            }*/
            
            Console.ReadLine();
        }
    }
}
