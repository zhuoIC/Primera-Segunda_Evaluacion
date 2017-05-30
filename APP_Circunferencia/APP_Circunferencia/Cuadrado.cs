using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico.APP_Circunferencia
{
    class Cuadrado:Figura
    {
        private double _area;
        private double _longitud;
        private double _lado;



        public Cuadrado(double lado)
        {
            Lado = lado;
            _area = Area;
            _longitud = Longitud;
        }

        public double Lado
        {
            get { return _lado; }
            set 
            {
                double lado = value;
                if (value <= 0)
                {
                    lado = 0;
                }
                if (value >= 1000)
                {
                    lado = 1000;
                }
                _lado = lado;
                _area = Math.Pow(_lado, 2);
                _longitud = _lado * 4;
            }
        }

        public override double Area
        {
            get 
            {
                return _area;
            }
        }

        public override double Longitud
        {
            get 
            {
                return _longitud;
            }
        }

        public override string Color()
        {
            return "Amarillo";
        }
    }
}
