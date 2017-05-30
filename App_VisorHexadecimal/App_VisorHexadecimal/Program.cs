using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_VisorHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("ERROR: Faltan argumentos");
            }
            else
            {
                FileInfo fichero = new FileInfo(args[0]);
                if (fichero.Exists)
                {
                    // Mostrar informacion del fichero
                    MostrarInfo(fichero);
                    MostrarContenido(fichero);

                    Console.ReadLine(); 
                }
            }
        }

        static void MostrarInfo(FileInfo fichero)
        {
            Console.WriteLine(" D A T O S   D E L  F I C H E R O");
            Console.WriteLine("=".PadRight(50,'='));
            Console.WriteLine("     Nombre: {0}", fichero.Name);
            Console.WriteLine("     Tamaño: {0}", fichero.Length);
            //Etc...
        }

        static void MostrarContenido(FileInfo fichero)
        {
            using (FileStream contenido = fichero.OpenRead())
            {
                if (fichero.Length == 0)
                {
                    Console.WriteLine("Fichero sin contenido");
                }
                else
                {
                    byte[] byteLeidos = new byte[16];
                    long nBytesLeidos = contenido.Read(byteLeidos, 0, 16);

                    while (nBytesLeidos != 0)
                    {
                        // Mostrar posiciones de lectura
                        Console.Write("\n{0:X8}", contenido.Position -16);

                        // Mostrar linea de contenido o bytes
                        for (int i = 0; i < nBytesLeidos; i++)
                        {
                            Console.Write(" {0:X2}", byteLeidos[i]);
                        }

                        // Rellenar de espacios si faltan bytes y que cuadre (estetico)
                        for (int i = 0; i < 16-nBytesLeidos; i++)
                        {
                            Console.Write("  ");
                        }
                        Console.Write("|");

                        // Mostrar el caracter del byte si procede (sino un punto)
                        for (int i = 0; i < nBytesLeidos; i++)
                        {
                            char caracterActual = (char)byteLeidos[i];
                            if (Char.IsControl(caracterActual))
                            {
                                Console.Write(".");
                            }
                            else
                            {
                                Console.Write(caracterActual);
                            }
                        }

                        nBytesLeidos = contenido.Read(byteLeidos, 0, 16);
                        Console.WriteLine();


                    }   // fin while

                } // fin using
            } // fin else
        }// fin MostrarContenido()
    }
}
