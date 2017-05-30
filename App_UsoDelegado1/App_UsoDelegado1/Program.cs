using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UsoDelegado1
{
    delegate void MiDelegado (string mensaje);
    delegate int OtroDelegado(int n);

    class Program
    {


        static void Main(string[] args)
        {
            ClaseDeMetodos objeto = new ClaseDeMetodos();
            MiDelegado delegado1 = ClaseDeMetodos.Metodo1;
            delegado1("Soy delegado1 estatico de la clase");
            MiDelegado delegado2 = new MiDelegado(objeto.Metodo2);
            delegado2("Soy delegado2 de la clase");
            MiDelegado delegado3 = MetodoParaDelegado;
            delegado3("Soy MetodoParaDelegado");

            // Multidifusión
            MiDelegado todosLosDelegados = delegado1 + delegado2;
            todosLosDelegados += delegado3; // Se puede usar el += con los delegados
            todosLosDelegados -= delegado1;
            todosLosDelegados("Este mensaje es comun a todos");

            // Obtener el nº de referencia a metodos
            int nReferencia = todosLosDelegados.GetInvocationList().GetLength(0);
            Console.WriteLine("El numero de referencia es: "+ nReferencia);


            // Referencia a un método anónimo
            OtroDelegado _otroDelegado = delegate(int n)
            {
                return n * n;
            };

            Console.WriteLine(_otroDelegado(5));

            // Si hay una excepcion no se produce en el método sino a quien lo llama

            /*
            // Instancia el delegado llamado MiDelegado
            MiDelegado llamada = MetodoParaDelegado;
            //MiDelegado llamada = new MiDelegado(MetodoParaDelegado);

            MetodoConDevolucion(10, 5, llamada);
            /*
            llamada("Hola Caracola...");
            MetodoParaDelegado("Hola, otravez, caracola");
            */

            Console.ReadLine();
        }

        static void MetodoParaDelegado(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        static void MetodoConDevolucion(int x, int y, MiDelegado llamadaAtras)
        {
            llamadaAtras("La suma es: " + (x + y).ToString());
        }
    }

    class ClaseDeMetodos
    {
        public static void Metodo1(string texto)
        {
            Console.WriteLine(texto);
        }

        public void Metodo2(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
