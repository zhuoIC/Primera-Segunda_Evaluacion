using System;
using System.Collections.Generic;

namespace App_Colleciones
{
    class ClaseArrayList
    {

        public enum Palos
        {
            Bastos = 0,
            Espadas,
            Oros,
            Copas
        }

        public enum Numeros
        {
            Uno = 1,
            Dos,
            Tres,
            Cuatro,
            Cinco,
            Seis,
            Siete,
            Ocho,
            Nueve,
            Sota,
            Caballo,
            Rey

        }

        public struct Carta
        {
            int _palo;
            int _numero;

            public int Palo
            {
                get
                {
                    return _palo;
                }
                set
                {
                    int minPalo = 0;
                    int maxPalo = 3;

                    if (value < minPalo)
                    {
                        value = minPalo;
                    }
                    else if (value > maxPalo)
                    {
                        value = maxPalo;
                    }
                    _palo = value;
                }
            }

            public int Numero
            {
                get
                {
                    return _numero;
                }
                set
                {
                    int minNumero = 1;
                    int maxNumero = 12;

                    if (value < minNumero)
                    {
                        value = minNumero;
                    }
                    else if (value > maxNumero)
                    {
                        value = maxNumero;
                    }
                    _numero = value;
                }
            }
        }

        static void Main(string[] args)
        {
            List<Carta> baraja = new List<Carta>(40);
            CrearBaraja(baraja);
        }

        static void CrearBaraja(List<Carta> baraja)
        {
            
            
            for (int i = 0; i < baraja.Capacity; i++)
            {
                Carta tmp = new Carta();
                tmp.Numero = 1;
                tmp.Palo = (int)Palos.Oros;
                baraja.Add(tmp);
            }

        }
    }
}
