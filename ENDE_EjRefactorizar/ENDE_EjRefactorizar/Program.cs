using System;
using System.Collections.Generic;

namespace Refactorizar
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string numeroDeTelefono;

        public Persona()
        {
            Console.WriteLine("Error: este constructor no deberia ser llamado");
        }

        public Persona(string nombre, int edad, string telefono)
        {
            this.numeroDeTelefono = telefono;
            this.nombre = nombre;
            this.edad = edad;
        }

        public Persona(string telefono)
        {
            this.numeroDeTelefono = telefono;
        }

        public string getNumeroDeTelefono()
        {
            return this.numeroDeTelefono;
        }

        public void setNumeroDeTelefono(string numero)
        {
            this.numeroDeTelefono = numero;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }

    public class Empleado: Persona 
    {
        public List<string> moviles;

        public Empleado (string telefono):base(telefono) 
        {
            moviles.Add("<desconocido>");
        }

        public void ImprimeInfoPersonal () 
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}, Telefono: {2}", Nombre, Edad, getNumeroDeTelefono());
        }

        public void ImprimeTodo () 
        {
            ImprimeInfoPersonal();
            ImprimeTelefonos();
        }

        public void ImprimeTelefonos()
        {
            Console.WriteLine("Telefonos moviles: ");
            foreach (string numero in moviles)
            {
                Console.WriteLine("Movil: {0}", numero);
            }
        }
    }
}
