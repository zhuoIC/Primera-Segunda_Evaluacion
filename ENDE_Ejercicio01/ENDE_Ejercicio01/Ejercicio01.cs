using System;
using System.Collections.Generic;

namespace Refactorizar
{
    public class Persona
    {
        public string numeroDeTelefono;
        public Persona()
        {
            Console.WriteLine("Error: este constructor " + "no deberia ser llamado");
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
    }
    public class Empleado : Persona
    {
        public string str;
        public int edad;
        public string numTelefono;
        public List<string> moviles;
        public Empleado(string telefono)
            : base(telefono)
        {
            moviles.Add("<desconocido>");
        }
        public void ImprimeInfoPersonal()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}, Telefono: {2}", str, edad, numTelefono);
        }
        public void ImprimeTodo()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}, Telefono: {2}", str, edad, numTelefono);
            Console.WriteLine("Telefonos moviles: ");
            foreach (string s in moviles)
            {
                Console.WriteLine("Movil: {0}", s);
            }
        }
    }
}