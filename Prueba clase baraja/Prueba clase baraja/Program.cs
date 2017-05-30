using System;
using System.Collections.Generic;
using Nico.Carta;

namespace Prueba_clase_baraja
{
    class Program
    {
        static List<Carta> Baraja = new List<Carta>();

        static void Main(string[] args)
        {
            Console.Title = "Prueba Baraja";

            Baraja.Add(new Carta("Oro", "Rey", 12));
            Baraja.Add(new Carta("Copa", "Sota", 10));
            Baraja.Add(new Carta("Oro", "Uno", 1));

            Console.WriteLine("Listado sin ordenar");
            ListarBaraja(Baraja);

            Baraja.Sort();
            Console.WriteLine("Listado ordenado");
            ListarBaraja(Baraja);
        }

        static private void ListarBaraja(List<Carta> Baraja)
        {
            foreach (Carta Carta in Baraja)
            {
                Console.WriteLine("{0}\t{1}\t{2}", Carta.GetPalo(), Carta.GetFigura(), Carta.GetValor());
                
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
