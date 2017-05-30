using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico.Carta
{
    class Carta: IComparable<Carta>
    {
        string _palo;       // El tipo de gizmo de la carta
        string _figura;     // Nombre de la figura
        int _valor;         // Valor

        /// <summary>
        /// Crea una carta con un palo, figura y valor determinado.
        /// </summary>
        /// <param name="_palo"></param>
        /// <param name="_figura"></param>
        /// <param name="_valor"></param>
        public Carta(string _palo, string _figura, int _valor)
        {
            this._palo = _palo;
            this._figura = _figura;
            this._valor = _valor;
        }

        #region Metodos

        public string GetPalo()
        {
            return _palo;
        }

        public string GetFigura()
        {
            return _figura;
        }

        public int GetValor()
        {
            return _valor;
        }

        public void SetPalo(string palo)
        {
            _palo = palo;
        }

        public void SetFigura(string figura)
        {
            _figura = figura;
        }

        public void SetValor(int valor)
        {
            _valor = valor;
        }

        #endregion

        public int CompareTo(Carta other)
        {
            int valor;
            int orden = this._palo.CompareTo(other._palo);
            if (orden != 0)
            {
                valor = orden;
            }
            else
            {
                valor = this._figura.CompareTo(other._figura);
            }


            /*
            if (this._valor == other._valor)
            {
                valor = 0;
            }
            else if (this._valor > other._valor)
            {
                valor = 1;
            }
            else
            {
                valor = -1;
            }
            */
            return valor;
        }
    }
}
