using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico.APP_Circunferencia
{
    abstract public class Figura
    {
        public Figura()
        {
            ;
        }
        public abstract double Area
        {
            get;
        }

        public abstract double Longitud
        {
            get;
        }

        public virtual string Color()
        {
            return "Rojo";
        }
    }
}
