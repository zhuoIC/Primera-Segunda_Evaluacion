using System;
using System.Text;
using System.Collections;
namespace App_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strb1 = new StringBuilder();
            StringBuilder strb2 = new StringBuilder(1000);
            StringBuilder strb3 = new StringBuilder("Hola caracola");

            InfoSb(strb3);
            //strb3.Append(strb3 + "---------------");
            strb3.Append('-', 120);
            InfoSb(strb3);
            strb3[20] = '*';
            InfoSb(strb3);
            for (int i = 0; i < strb3.Length; i++)
            {
                if (strb3[i] == '0')
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write(strb3[i]);
                }
            }
            Console.ReadLine();
        }

        static void InfoSb(StringBuilder sb)
        {
            Console.WriteLine("Datos del stringBuilder");
            Console.WriteLine("".PadRight(50, '='));
            Console.WriteLine(" Capacidad: " + sb.Capacity);
            Console.WriteLine("  Nº datos: " + sb.Length);
            Console.WriteLine(" Contenido: " + sb.Length);
        }

        static void ConstruirString(int longitud)
        {
            string s = string.Empty;
            for (int i = 0; i < longitud; i++)
            {
                s += "a";
            }
            
        }

        static void ConstruirStringBuilder(int longitud)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < longitud; i++)
            {
                s.Append("a");
            }

        }
    }
}
