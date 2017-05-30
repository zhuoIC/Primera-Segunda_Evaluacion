using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UsoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaz basado en la pila/factura
            /*
            IPrograma pila = new Pila();
            IPrograma factura = new Factura();
            */
            /*
             * Pila unaPila = new Pila();
            Factura unaFactura = new Factura();
            unaPila.Copiar();
            unaPila.Clonar();
            unaFactura.Copiar();
            unaFactura.Clonar();
             * */
            // FACTURA
            Factura f1 = new Factura();
            Factura f2 = (Factura)Copiar(f1);
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());

            // FACTURA
            Pila p1 = new Pila();
            Pila p2 = (Pila)Copiar(p1);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Dibuja dibujando = new Dibuja();
            ILapiz lapiz = (ILapiz)dibujando;
            IBrocha brocha = (IBrocha)dibujando;

            // llamo a los pinta() de cada uno
            dibujando.Pinta();
            lapiz.Pinta();
            brocha.Pinta();
            Console.ReadLine();
        }

        /*static object Copiar(object obj)
        {
            Factura f;
            Pila p;
            if (obj is Factura)
            {
                f = (Factura)obj;
                return f.Clone() ;
            }
            else if (obj is Pila)
            {
                p = (Pila)obj;
                return p.Clone() ;
            }
            else
            {
                return null;
            }
        }
        */
        static object Copiar(ICloneable ic)
        {
            return ic.Clone();
        }

        class Dibuja : ILapiz, IBrocha
        {
            void ILapiz.Pinta()
            {
                Console.WriteLine("Metodo pinta de la clase ILapiz...");
            }

            void IBrocha.Pinta()
            {
                Console.WriteLine("Metodo pinta de la clase IBrocha...");
            }

            public void Pinta()
            {
                Console.WriteLine("Metodo pinta de la clase Dibuja...");
            }
        }

        interface ILapiz
        {
            void Pinta();
        }

        interface IBrocha
        {
            void Pinta();
        }
    }
}
