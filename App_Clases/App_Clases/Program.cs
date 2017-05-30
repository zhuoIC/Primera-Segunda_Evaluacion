using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafico linea = new Derivada();
            

            Console.Read();
        }
    }

    abstract class Grafico
    {
        public void Pinta() 
        {
            Console.WriteLine("Dibujando con Dibuja de...> Grafico");
        }

        abstract public void Punto();
    }

    class Derivada: Grafico
    {
        public int valor = 0;
        public static int valorEstatico = 0;


        public Derivada()
        {
 
        }

        public Derivada(int valor, int valorEstatico) 
        {
            this.valor = valor;
            Derivada.valorEstatico = valorEstatico;
        }


        public static void MetodoEstatico() { }

        public override void Punto()
        {
            Console.WriteLine("Soy un punto...");
        }

        public new void Pinta()
        {
            Console.WriteLine("Dibujando con Dibuja de...> Derivada");
        }

        public override string ToString()
        {
            return "Soy ToString() de Derivada";
        }
    }

    class DerivadadeDerivada : Derivada
    {
        public new void Punto()
        { }
    }

    sealed class Final
    {
        public void Metodo() { }
    }
}
