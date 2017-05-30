using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaz
{
    class Agenda:OtraClase, IPrueba
    {

        public void Mostrar()
        {
            throw new NotImplementedException();
        }

        public string Anotacion
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string this[int incide]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public event Anotacion Anadida;
    }
}
