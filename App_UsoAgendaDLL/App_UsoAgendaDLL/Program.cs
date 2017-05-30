using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHJ.App_Aplicacion;

namespace App_UsoAgendaDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda miAgenda = new Agenda();
            bool que = false;
            miAgenda.AddAnotacion("Hoy es lunessss, ufffff");
            que = miAgenda + "Hoy es VIERNES, bieeen";
            miAgenda.Mostrar();

        }
    }
}
