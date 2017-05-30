using System;
using System.Collections.Generic;

namespace App_Diccionario
{
    class Program
    {
        static Random rnd = new Random();

        public enum Categoria { Aprendiz, Peon, Encargado, Gerente}

        public struct Ficha 
        {
            string _dni;
            string _nombre;
            DateTime _fNac;
            Categoria _categoria;

            public Ficha(string dni, string nombre, DateTime fNac, Categoria categoria)
            {
                _dni = dni;
                if (nombre.Length > 27)
                {
                    _nombre = nombre.Substring(0, 25) + "..."; 
                }
                else
                {
                    _nombre = nombre;
                }
                _fNac = fNac;
                _categoria = categoria;
            }

            public string GetDni()
            {
                return _dni;
            }

            public string GetNombre()
            {
                return _nombre;
            }

            public DateTime GetFNac()
            {
                return _fNac;
            }

            public Categoria GetCategoria()
            {
                return _categoria;
            }

        }

        static Dictionary<string, Ficha> _dicFichas = new Dictionary<string, Ficha>();

        static void Main(string[] args)
        {
            AnadirAlea(20, _dicFichas);
            MostrarDatos(_dicFichas);
            Console.ReadLine();
        }

        static void MostrarDatos(Dictionary<string, Ficha> disc)
        {
            Console.WriteLine("LISTADO EMPLEADOS\n");
            Console.WriteLine("".PadRight(70, '='));
            Console.Write("DNI".PadRight(13, ' '));
            Console.Write("NOMBRE".PadRight(28, ' '));
            Console.Write("F. NACIMIENTO".PadRight(18, ' '));
            Console.WriteLine("CATEGORIA");
            Console.WriteLine("".PadRight(70, '='));
            foreach (KeyValuePair<string, Ficha> item in disc)
            {
                Console.Write(item.Value.GetDni().PadRight(13, ' '));
                Console.Write(item.Value.GetNombre().PadRight(28, ' '));
                Console.Write(item.Value.GetFNac().ToShortDateString().PadRight(18, ' '));
                Console.WriteLine(item.Value.GetCategoria());
            }
        }

        static void AnadirAlea(int nFichas, Dictionary<string, Ficha> disc)
        {
            string[] nombres = { "Pepe", "Juan", "Manolo", "Marta", "Julia", "Bruno" };
            char letraDni = ' ';
            string dni = string.Empty;
            for (int i = 0; i < nFichas; i++)
            {
                letraDni = (char)rnd.Next((int)'A', (int)'Z' + 1);
                dni = rnd.Next(10000000, 99999999).ToString() + letraDni;
                Ficha tmp = new Ficha(dni, nombres[rnd.Next(nombres.Length)], DateTime.Now.AddDays(rnd.Next(12121)), (Categoria)rnd.Next(4));
                disc.Add(tmp.GetDni(), tmp);
            }
        }
    }
}
