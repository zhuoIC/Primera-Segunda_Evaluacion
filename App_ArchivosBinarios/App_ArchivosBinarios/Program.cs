using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_ArchivosBinarios
{
    class Program
    {
        static FileStream flujo = null;
        static BinaryWriter salida = null;
        static BinaryReader entrada = null;

        static string nombre = "";
        static string apellidos = string.Empty;
        static float sueldo = 0F;
        static bool borrado = false;

        static void Main(string[] args)
        {
            string ruta = @"c:/basura/datosBinarios.dat";
            /*
            FileStream flujoEscritura = new FileStream(ruta, FileMode.Create, FileAccess.Write);
            using (BinaryWriter escritor = new BinaryWriter(flujoEscritura, Encoding.Default))
            {
                escritor.Write("Hola Caracola");
                escritor.Write(100);
                escritor.Write(22.33);
                escritor.Write(true);
            }

            flujoEscritura.Close();

            FileStream flujoLectura = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            using (BinaryReader lector = new BinaryReader(flujoLectura))
            {
                Console.WriteLine(lector.ReadString());
                Console.WriteLine(lector.ReadInt32());
                Console.WriteLine(lector.ReadDouble());
                Console.WriteLine(lector.ReadBoolean());
            }

            flujoLectura.Close();
            */




            //campor para almacenar en el fichero

            AnadirParaprueba(ruta, 20);
            Listar(ruta);
            Console.ReadLine();
        }

        static void AnadirDatos(string nombreFichero, string n, string a, float s)
        {
            flujo = new FileStream(nombreFichero, FileMode.Append); // Ya lo abre para escribir
            salida = new BinaryWriter(flujo);
            salida.Write(n);
            salida.Write(a);
            salida.Write(s);
            salida.Write(false);
            flujo.Close();
        }

        static void Listar(string nombreFichero)
        {
            flujo = new FileStream(nombreFichero, FileMode.Open);
            entrada = new BinaryReader(flujo);
            int nEspacios = 25;
            Console.Clear();
            Console.WriteLine("LISTADO DE DATOS DEL FICHERO..."+nombreFichero);
            Console.WriteLine("=".PadRight(50,'='));
            try
            {
                while (true)
                {
                    apellidos = entrada.ReadString();
                    nombre = entrada.ReadString();
                    sueldo = entrada.ReadSingle();
                    Console.Write(apellidos);
                    Console.Write("".PadRight(nEspacios));
                    Console.Write(nombre);
                    Console.Write("".PadRight(nEspacios));
                    Console.WriteLine(sueldo);
                }

            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("\n\n\n FIN DEL LISTADO...");
            }
        }

        static void AnadirParaprueba(string fichero, int nDatos)
        {
            for (int i = 0; i < nDatos; i++)
            {
                AnadirDatos(fichero, "Nombre_" + i.ToString(), "Apellido_" + i.ToString(), 0.33F * i);
            }
        }
    }
}
