using System;
using System.Collections.Generic;

namespace App_gestionFichas
{
    
    public enum Categoria { Aprendiz, Peon, Encargado, Gerente}

    public struct Persona 
    {
        string _dni;
        string _nombre;
        DateTime _fNac;
        Categoria _categoria;

        public Persona(string dni, string nombre, DateTime fNac, Categoria categoria)
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

    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.Title = "App Gestion Fichas";

            List<Persona> empleados = new List<Persona>();

            for (int i = 0; i < 10; i++)
            {
                AnadirAlea(5, empleados);
            }
            ListarEmpleado(empleados);

            BorrarFicha(empleados, -1);

            Console.Write("\n\nPulsa una tecla: ");
            Console.ReadLine();
        }

        static Persona LeerPersona()
        {
            // Lee desde teclado los datos de la ficha
            Persona tmp;

            tmp = new Persona("12345678E", "pepe", DateTime.Now, Categoria.Gerente);
            return tmp;
        }

        static bool BorrarFicha(List<Persona> lista, int pos)
        {
            bool borrado = false;
            if (!(pos < 0 || pos > lista.Count))
            {
                MostrarFichaEmpleado(lista, pos);
                Console.WriteLine("Está a punto de borrar la ficha con DNI {0}", lista[pos].GetDni());
                Console.WriteLine("¿Seguro que desea borrarla? [B/b] Confirmar [Cualquier otra tecla] Cancelar");
                if (Console.ReadKey().Key == ConsoleKey.B)
                {
                    lista.RemoveAt(pos);
                    borrado = true;
                }
            }
            return borrado;
        }


        static void MostrarFichaEmpleado(List<Persona> lista, int pos)
        {
            Persona tmp;
            if(!(pos < 0 || pos > lista.Count))
            {
                tmp = lista[pos];
                Console.WriteLine("".PadRight(45, '-'));
                Console.WriteLine("D A T O S   P E R S O N A L E S");
                Console.WriteLine("".PadRight(45, '-'));
                Console.WriteLine("NIF: " + tmp.GetDni());
                Console.WriteLine("Nombre: " + tmp.GetNombre());
                Console.WriteLine("F.Nacimiento: " + tmp.GetFNac().ToShortDateString());
                Console.WriteLine("Categoria: " + tmp.GetCategoria());
                Console.WriteLine("\n>FICHA CARGADA");
                
            }
        }

        static void AnadirAlea(int nFichas, List<Persona> lista)
        {
            string[] nombres = { "Pepe", "Juan", "Manolo", "Marta", "Julia", "Bruno" };
            char letraDni = ' ';
            string dni = string.Empty;
            for (int i = 0; i < nFichas; i++)
            {
                letraDni = (char)rnd.Next((int)'A', (int) 'Z' + 1);
                dni = rnd.Next(10000000, 99999999).ToString() + letraDni;
                Persona tmp = new Persona(dni, nombres[rnd.Next(nombres.Length)], DateTime.Now.AddDays(rnd.Next(12121)), (Categoria)rnd.Next(4));
                AnadirFicha(tmp, lista);
            }
        }

        static void ListarEmpleado(List<Persona> empleados)
        {
            Console.WriteLine("LISTADO EMPLEADOS\n");
            Console.WriteLine("".PadRight(70, '='));
            Console.Write("DNI".PadRight(13, ' '));
            Console.Write("NOMBRE".PadRight(28, ' '));
            Console.Write("F. NACIMIENTO".PadRight(18, ' '));
            Console.Write("CATEGORIA");
            Console.WriteLine();
            Console.WriteLine("".PadRight(70, '='));
            foreach (Persona empleado in empleados)
            {
                Console.Write(empleado.GetDni().PadRight(13, ' '));
                Console.Write(empleado.GetNombre().PadRight(28, ' '));
                Console.Write(empleado.GetFNac().ToShortDateString().PadRight(18, ' '));
                Console.Write(empleado.GetCategoria().ToString());
                Console.WriteLine();
            }            
        }

        static int BuscarFicha(Persona ficha, List<Persona> empleados)
        {
            int encontrado = -1;
            int contador = 0;
            while (contador < empleados.Count)
            {
                if (empleados[contador].GetDni() == ficha.GetDni())
                {
                    encontrado = contador;
                    break;
                }
                contador++;
            }
            return encontrado;
        }

        static bool AnadirFicha(Persona ficha, List<Persona> empleados)
        {
            bool exito = false;
            if (BuscarFicha(ficha, empleados) == -1)
            {
                empleados.Add(ficha);
                exito = true;
            }
            return exito;
        }
    }
}
