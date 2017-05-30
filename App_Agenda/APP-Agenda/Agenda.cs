using System;
using System.Collections;

namespace Nico.App_Agenda
{
    class Agenda
    {
        ArrayList anotaciones = new ArrayList();

        public ArrayList Anotaciones
        {
            get { return anotaciones; }
            set { anotaciones = value; }
        }

        public Agenda()
        {
            Anotacion _apunte = new Anotacion(DateTime.Now, "valor");
        }

        class Anotacion
        {
            // campos
            DateTime _fecha;
            string _descripcion;
            // Etc
            /*
            static Anotacion()  // Constructor de clase
            {
                Console.WriteLine("SOY ANOTACION DE LA CLASE ESTATICA");
            }
            */
            public Anotacion()
            {
                _fecha = DateTime.Now;
                _descripcion = "Sin datos";
            }
            
            public Anotacion(DateTime fecha, string descripcion)
            {
                _fecha = fecha;
                _descripcion = descripcion;
            }

            public bool AnadirAnotacion(DateTime fecha, string descripcion)
            {
                _fecha = fecha;
                _descripcion = descripcion;
                return true;
            }
            /*
            ~Anotacion()
            {
                Console.WriteLine("SOY ANOTACION DESTRUCTOR FFFFFFFUUUUUUU");
            }*/
        }
    }
}
