using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace App_ClaseConForeach
{
    class MiLista: IEnumerable, IEnumerator
    {
        int[] numeros = { 4, 2, 3, 40, 2, 3, 7, 4, 8, 2, 3, 71, 0, 4, 8, 7, 1, 2, 3, 07, 4, 8, 2, 31 };
        int posicion = -1;

        // Devuelve un objeto de este tipo
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public void Reset()
        {
            posicion = -1;
        }

        // Obtiene el objeto de la posicion actual
        public object Current
        {
            get { return numeros[posicion]; }
        }

        // Desplaza el enumerator al siguiente elemento de la lista
        public bool MoveNext()
        {
            bool exito;
            
            if (posicion < numeros.Length-1)
            {
                posicion++;
                exito = true;
            }
            else
            {
                exito = false;
            }

            return exito;
        }
        

    }
}
