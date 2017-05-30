using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_AccesoADirectorios
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Users\Usuario\Downloads";
            string rutaAlternativa = @"C:\Basura\Ficheros\OTRO";
            DirectoryInfo directorio = new DirectoryInfo(rutaAlternativa);
            directorio.Create();
            
            /*
            ListaFicheros(ruta, "*.exe");
            Console.ReadLine();
            ListarSubdirectorios(ruta);
             * */
            Console.ReadLine();
        }

        // Obtener el listado de los ficheros del directorio
        static void ListaFicheros(string ruta, string filtro)
        {
            if (Directory.Exists(ruta))
            {
                FileInfo[] ficheros = new DirectoryInfo(ruta).GetFiles(filtro);
                int nFicheros = 0;
                Console.WriteLine("Listado de ficheros de la ruta {0}\n", ruta);
                foreach (FileInfo ficheroTmp in ficheros)
                {
                    Console.WriteLine("[{0}] {1}", ++nFicheros, ficheroTmp);
                }
                Console.WriteLine("\nFin del listado...");
            }
            else
            {
                ;
            }
        }

        // Obtener el listado de subdirectorios del directorio
        static void ListarSubdirectorios(string ruta)
        {
            if (Directory.Exists(ruta))
            {
                DirectoryInfo[] directorios = new DirectoryInfo(ruta).GetDirectories();
                int nDirectorios = 0;
                Console.WriteLine("Listado de directorios de la ruta {0}\n", ruta);
                foreach (DirectoryInfo directorioTmp in directorios)
                {
                    Console.WriteLine("[{0}] {1}", ++nDirectorios, directorioTmp);
                }
                Console.WriteLine("\nFin del listado...");
            }
            else
            {
                ;
            }
        }

        // Operaciones básicas de manipulación de directorios
        static void c()
        {
 
        }
    }
}
