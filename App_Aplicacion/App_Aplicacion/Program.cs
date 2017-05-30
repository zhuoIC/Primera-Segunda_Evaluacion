using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHJ.App_Aplicacion;

namespace App_Aplicacion
{
    class Aplicacion
    {
        static void Main(string[] args)
        {
            bool exito = false;
            string _anotacion = "Hola caracola";
            Agenda miAgenda = new Agenda();

            do
            {
                exito = miAgenda + _anotacion;
            } while (exito);
            

            miAgenda.Mostrar();
            miAgenda[1000] = "hola";
            miAgenda.Mostrar();

            for (int i = 0; i < miAgenda.NDatos; i++)
            {
                Console.WriteLine(miAgenda[i]);
            }
            Console.ReadLine();
        }
    }
}
