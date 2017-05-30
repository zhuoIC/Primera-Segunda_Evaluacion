using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UsoPrograma
{
    class Pila:IPrograma, ICloneable
    {
        string msg = "soy el objeto de Pila origen..";
        public override string ToString()
        {
            return msg;
        }

        public void Copiar(object obj)
        {
            Console.WriteLine("Soy Copiar() de la Pila");  
        }

        // Miembros del interfaz
        public object Clone()
        {
            Pila unaPila = new Pila();
            unaPila.msg = this.msg + "hey";
            return unaPila;
        }
    }
}
