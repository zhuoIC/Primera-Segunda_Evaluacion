using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico.APP_Circunferencia
{
    public class Circunferencia:Figura
    {
        double _radio;
        double _longitud;
        double _area;

        public Circunferencia()
        {
            _radio = 0;
            _area = 0;
            _longitud = 0;
        }

        public Circunferencia(double radio)
        {
            Radio = radio;
        }

        public double Radio
        {
            get { return _radio; }
            set
            {
                _radio = Math.Abs(value);
            }
        }

        public override double Longitud
        {
            get
            {
                _longitud = 2 * Math.PI * _radio;
                return _longitud;
            }
        }

        public override double Area
        {
            get
            {
                _area = Math.PI * Math.Pow(_radio, 2);
                return _area;
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return "Radio: " + this.Radio.ToString("00000") + "\nArea: " + this.Area.ToString("00000") + "\nLongitud: " + this.Longitud.ToString("00000");
        }
    }
}
