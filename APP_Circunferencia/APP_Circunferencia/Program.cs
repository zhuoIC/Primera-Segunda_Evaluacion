using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico.APP_Circunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Circunferencia c1 = new Circunferencia();
            Circunferencia c2 = new Circunferencia(-10);
            Cuadrado q1 = new Cuadrado(5);
            Triangulo t1 = new Triangulo();
            t1.Base = 4;
            /*
            Console.WriteLine("Base: {0}, Area: {1}, Peri: {2}", t1.Base, t1.Area, t1.Perimetro);
            Console.WriteLine("Radio: {0}, Area: {1}, Long: {2}", c2.Radio, c2.Area, c2.Longitud);
            Console.WriteLine("Lado: {0}, Area: {1}, Long: {2}", q1.Lado, q1.Area, q1.Longitud);
            Console.WriteLine("Lado: {0}, Area: {1}, Long: {2}", q1.Lado, q1.Area, q1.Longitud);
            c2.MostrarDatos();*/
            NumAlea n = new NumAlea(78, 89);
            n.OrdenarDatos();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
