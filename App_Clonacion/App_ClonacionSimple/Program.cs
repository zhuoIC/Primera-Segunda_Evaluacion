using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace App_ClonacionSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Console.WriteLine("\np1-> " + p1.ToString());
            Persona p2 = p1.CopiarAuto();
            Console.WriteLine("\np2-> " + p2.ToString());
            p2.Id = 100;
            Console.WriteLine("\np1-> " + p1.ToString());
            Console.WriteLine("\np2-> " + p2.ToString());
            Console.ReadLine();
        }
    }

    class Persona: ICloneable
    {
        int _id;
        string _nombre;
        DateTime _fechaNac;

        public Persona()
        {
            _id = 0;
            _nombre = "******* Nombre *******";
           _fechaNac = DateTime.Now;
        }

        public Persona(int id, string nombre, DateTime fechaNac)
        {
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public Persona Copiar()
        {
            Persona copia = new Persona();

            copia.Id = this.Id;
            copia.Nombre = this.Nombre;
            copia.FechaNac = this.FechaNac;

            return copia;
        }

        public Persona CopiarAuto()
        {
            return (Persona) this.MemberwiseClone();
        }

        public object Clone()
        {
            return (Persona)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "DATOS PERSONA: " + 
                "\nID: " + Id + 
                "\nNombre: " + Nombre + 
                "\nFecha de nacimiento: " + FechaNac.Day + "/" + FechaNac.Month + "/" + FechaNac.Year;
        }
    }
}
