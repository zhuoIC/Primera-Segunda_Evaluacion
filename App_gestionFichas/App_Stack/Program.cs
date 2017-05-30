using System;
using System.Collections;
namespace App_Stack
{
    class Program
    {
        static Pila pila = new Pila();
        static void Main(string[] args)
        {
            pila.SetMeter(1);
            pila.SetMeter(2);
            pila.SetMeter(3);
            Console.WriteLine("Hay {0} datos", pila.GetContar());
            pila.MostrarPila();
            // Preguntar por el dato de la cima
            Console.WriteLine("Dato de la cima: {0}",pila.GetPreguntar());
            Console.WriteLine("Sacar de la cima: {0}", pila.GetSacar());
            Console.WriteLine("Sacar de la cima: {0}", pila.GetSacar());
            Console.WriteLine("Sacar de la cima: {0}", pila.GetSacar());
            
            Console.ReadLine();
        }
    }

    class Pila 
    {
        // Meter, Sacar, Contar, Preguntar, etc
        // Campos
        private object[] _pila;
        private int _nDatos;


        public Pila()
        {
            _pila = new object[16];
            _nDatos = 0;
        }

        public Pila(int capacidad)
        {
            _pila = new object[capacidad];
            _nDatos = 0;
        }

        public int GetContar()
        {
            return _nDatos;
        }

        public int GetCapacidad()
        {
            return _pila.Length;
        }

        public object GetPreguntar()
        {
            return _pila[_nDatos - 1];
        }

        public object GetSacar()
        {
            return _pila[--_nDatos];
        }

        public void SetMeter(object obj)
        {
            if (_nDatos == _pila.Length)
            {
                AumentarCapacidad();
            }
            else
            {
                _pila[_nDatos++] = obj;
            }
        }

        private void AumentarCapacidad()
        {
            const int AMPLICACION = 16;
            object[] nuevaPila = new object[_pila.Length + AMPLICACION];
            for (int i = 0; i < _pila.Length; i++)
            {
                nuevaPila[i] = _pila[i];
            }
            _pila = nuevaPila;
        }

        public void MostrarPila()
        {
            for (int i = _nDatos -1; i >= 0; i--)
            {
                Console.WriteLine("Elemento {0}: {1}", i+1, _pila[i].ToString());
            }
        }
    }
}
