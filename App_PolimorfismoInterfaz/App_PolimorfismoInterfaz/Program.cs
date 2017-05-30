using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PolimorfismoInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            IComun[] comunes = new IComun[3]
            {
                new Persona(), 
                new Coche(),
                new Animal()         
            };

            for (int i = 0; i < comunes.Length; i++)
            {
                comunes[i].Mostrar();
            }

            Console.ReadLine();
        }
    }

    class Persona : IComun
    {
        public void Mostrar()
        {
            Console.WriteLine("Persona: Mostrar()...");       
        }

        public string Nombre
        {
            get
            {
                return "Persona: PropiedadNombre...";
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    class Coche : IComun
    {
        public void Mostrar()
        {
            Console.WriteLine("Coche: Mostrar()...");
        }

        public string Nombre
        {
            get
            {
                return "Coche: PropiedadNombre...";
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    class Animal : IComun
    {
        public void Mostrar()
        {
            Console.WriteLine("Animal: Mostrar()...");
        }

        public string Nombre
        {
            get
            {
                return "Animal: PropiedadNombre...";
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    interface IComun
    {
        void Mostrar();
        string Nombre { get; set; }
    }

}
