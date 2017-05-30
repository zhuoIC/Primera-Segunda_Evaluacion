using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHJ.App_Aplicacion
{
    public class Agenda
    {
        const int NMAXENTRADAS = 100;
        string[] _anotaciones = new string[NMAXENTRADAS];
        int _ultAnotacion = 0;

        public int NDatos
        {
            get { return _ultAnotacion; }
        }

        // Añadir una anotacion con el operador +
        public static bool operator + (Agenda unaAgenda, string anotacion)
        {
            bool exito = false;

            if (unaAgenda._ultAnotacion < NMAXENTRADAS)
            {
                unaAgenda._anotaciones[unaAgenda._ultAnotacion++] = anotacion;
                exito = true;
            }

            return exito;
        }

        public bool AddAnotacion(string anotacion)
        {
            bool exito = false;

            if (this._ultAnotacion < NMAXENTRADAS)
            {
                this._anotaciones[this._ultAnotacion++] = anotacion;
                exito = true;
            }

            return exito;
        }


        public void Mostrar()
        {
            Console.WriteLine("Datos de la agenda..." + this.ToString());
            for (int i = 0; i < this._ultAnotacion; i++)
            {
                Console.WriteLine("[{0}] {1}", i + 1, _anotaciones[i]);
            }
            Console.WriteLine("\n\n Fin del listado ...");
            Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string this[int indice]
        {
            get 
            {
                if (indice >= _ultAnotacion || indice < 0)
	            {
                    throw new IndexOutOfRangeException("Índice no válido"); 
	            }
                else
	            {
                    return _anotaciones[indice];
	            }
            }
            set 
            {
                if (indice >= _ultAnotacion)
                {
                    AddAnotacion(value);
                }
                else
                {
                    _anotaciones[indice] = value;
                }
            }
        }
    }
}
