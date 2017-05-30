using System;

namespace Ejercicio_01
{
    class Program
    {
        enum Vehiculo
        {
            moto,
            triciclo,
            coche,
            cohete
        }

        static void Main(string[] args)
        {
            Console.Title = "Relacion 05. Ejercicio 01";
            TipoDeDatos();
        }

        static void TipoDeDatos()
        {
            #region Variables

            const int LONG = 10;
            int entero = 0;
            uint sinSigno = 0;
            float flotante = 0f;
            int[] array = new int[LONG];
            bool booleano = true;

            #endregion

            Console.WriteLine("\n\t\tTIPOS DE DATOS");

            Console.WriteLine("\n>ENTERO");
            Console.WriteLine(" tamaño en memoria: 32 bytes");
            Console.WriteLine("         valor máx: {0}", int.MaxValue);
            Console.WriteLine("         valor min: {0}", int.MinValue);
            Console.WriteLine("    tipo de objeto: {0}", entero.GetTypeCode());

            Console.WriteLine("\n>ENTERO SIN SIGNO");
            Console.WriteLine(" tamaño en memoria: 32 bytes");
            Console.WriteLine("         valor máx: {0}", uint.MaxValue);
            Console.WriteLine("         valor min: {0}", uint.MinValue);
            Console.WriteLine("    tipo de objeto: {0}", sinSigno.GetTypeCode());

            Console.WriteLine("\n>FLOTANTE");
            Console.WriteLine(" tamaño en memoria: 32 bytes");
            Console.WriteLine("         valor máx: {0}", float.MaxValue);
            Console.WriteLine("         valor min: {0}", float.MinValue);
            Console.WriteLine("    tipo de objeto: {0}", flotante.GetTypeCode());

            Console.WriteLine("\n>ARRAY");
            Console.WriteLine(" tamaño en memoria: {0:00} bytes", (1 + array.Length)*32);
            Console.WriteLine("          longitud: {0}", array.Length);
            Console.WriteLine("elemento valor máx: {0}", int.MaxValue);
            Console.WriteLine("         valor min: {0}", int.MinValue);
            Console.WriteLine("    tipo de objeto: {0}", array);

            Console.WriteLine("\n>BOOLEANO");
            Console.WriteLine(" tamaño en memoria:  8 bytes");
            Console.WriteLine("      primer valor: true");
            Console.WriteLine("     segundo valor: false");
            Console.WriteLine("    tipo de objeto: {0}", booleano.GetTypeCode());

            Console.WriteLine("\n>ENUMERACION");
            Console.WriteLine("nombre enumeracion:  Vehiculo");
            Console.WriteLine("      primer valor: {0}", (Vehiculo)1);
            Console.WriteLine("     segundo valor: {0}", (Vehiculo)2);
            Console.WriteLine("      tercer valor: {0}", (Vehiculo)3);
            Console.WriteLine("    tipo de objeto: {0}", typeof(Vehiculo).ToString());

            Salida();
        }

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
