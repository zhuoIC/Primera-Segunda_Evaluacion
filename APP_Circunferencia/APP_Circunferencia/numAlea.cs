using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico.APP_Circunferencia
{
    class NoCabeException : Exception { }
    class NumAlea
    {
        private int _capacidad;
        private int _limite;
        const int MAX = 10;
        const int LIM = 100;
        private int[] _numeros;

        /// NumAlea
        /// <summary>
        /// Instancia un array de enteros aleatorios sin repeticion
        /// </summary>
        /// <param name="capacidad">Número de enteros a representar</param>
        /// <param name="limite">Numero máximo del valor del entero</param>
        public NumAlea(int capacidad, int limite)
        {
            if (capacidad > limite)
            {
                throw new NoCabeException();
            }
            else
            {
                _capacidad = capacidad;
                _limite = limite;
                _numeros = GenArray();
            }
        }

        public int Capacidad
        {
            get { return _capacidad; }
        }

        public int Limite
        {
            get { return _limite; }
        }

        public int[] Numeros
        {
            get { return _numeros; }
        }

        private int[] GenArrayApoy()
        {
            int[] apoyo = new int[this._limite];
            for (int i = 0; i < this._limite; i++)
			{
			    apoyo[i] = i+1;
			}
            return apoyo;
        }

        private int[] GenArray()
        {
            Random rnd = new Random();
            int[] array = new int[_capacidad];
            int[] apoyo = GenArrayApoy();
            int aLong = apoyo.Length;
            int alea;

            for (int i = 0; i < Capacidad; i++)
            {
                alea = rnd.Next(aLong);
                array[i] = apoyo[alea];

                int tmp = 0;

                tmp = apoyo[aLong-1];
                apoyo[aLong-1] = apoyo[alea];
                apoyo[alea] = tmp;
                
                aLong--;
            }

            return array;
        }

        public void OrdenarDatos()
        {
            int tmp = 0;
            for (int i = 0; i < _numeros.Length; i++)
            {
                for (int j = (_numeros.Length -1); j > 0; j--)
                {
                    if (_numeros[j] < _numeros[j - 1])
                    {
                        tmp = _numeros[j];
                        _numeros[j] = _numeros[j - 1];
                        _numeros[j - 1] = tmp;
                    }
                }
            }

            MostrarDatos();
        }

        public void MostrarDatos()
        {
            int[] numeros = this._numeros;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
