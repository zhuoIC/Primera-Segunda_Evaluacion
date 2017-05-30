using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaz
{
    public delegate void Anotacion (string s);
    interface IPrueba
    {
        //Contiene los posibles miembros 
        void Mostrar();                         //Metodo
        string Anotacion { get; set; }          //Propiedad
        string this[int incide] { get; set; }   //Indizador
        event Anotacion Anadida;                //Evento
    }
}
