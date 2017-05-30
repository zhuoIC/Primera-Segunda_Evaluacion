using System;
using System.IO;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
	        {
                if (File.Exists(args[0]))
                {
                    FileInfo fichero = new FileInfo(args[0]);
                    MostrarFichero(fichero);
                }
                else if (args[0] == "-h")
                {
                    MostrarAyuda();
                }
	        }
	        catch (Exception e)
	        {

                Console.WriteLine("ERROR: "+e.Message);
                MostrarAyuda();
	        }
            Console.ReadLine();
        }

        static void MostrarFichero(FileInfo fichero)
        {
            using (StreamReader contenido = fichero.OpenText())
            {
                int m;
                while ((m = contenido.Read()) != -1) 
                {
                    Console.Write((char)m);
                }
            }
        }

        static void MostrarAyuda()
        {
            // Ayuda
        }
    }
}
