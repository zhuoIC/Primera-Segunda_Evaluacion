using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENDE.Refactorizado
{
    public class Persona
    {
        private string _nombre;
        private DateTime _fNacimiento;
        private string _telefono;

        public Persona()
        {
            throw new UnauthorizedAccessException("Error: este constructor no deberia ser llamado");
        }

        public Persona(string nombre, DateTime fNacimiento, string telefono)
        {
            this._telefono = telefono;
            this._nombre = nombre;
            this._fNacimiento = fNacimiento;
        }

        public string getNumeroDeTelefono()
        {
            return this._telefono;
        }

        public void setNumeroDeTelefono(string numero)
        {
            this._telefono = numero;
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public int Edad
        {
            get 
            {
                int edad;
                DateTime ahora = new DateTime();
                ahora = DateTime.Now;
                edad = (_fNacimiento - ahora).Days/365;
                return edad; 
            }
        }
    }

    public class Empleado : Persona
    {
        private List<string> moviles;

        public Empleado(string nombre, DateTime fNacimiento, string telefono): base(nombre, fNacimiento, telefono)
        {
            moviles.Add("<desconocido>");
        }

        public void ImprimeInfoPersonal()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}, Telefono: {2}", Nombre, Edad, getNumeroDeTelefono());
        }

        public void ImprimeTodo()
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
