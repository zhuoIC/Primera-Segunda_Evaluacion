using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Basura\basura\salida.txt";
            FileStream fichero = new FileStream(ruta, FileMode.Open);
            ListaFichero(fichero);
            Console.ReadLine();
        }

        static void ListaFichero(Stream fichero)
        {
            int caracter;

            //Recorro el fichero desde el inicio hasta el fin leyendo byte a byte

            while ((caracter = fichero.ReadByte()) != -1)
            {
                if (caracter == 'e')
                {
                    continue;
                }
                Console.Write((char)caracter);
            }
        }
    }
}
