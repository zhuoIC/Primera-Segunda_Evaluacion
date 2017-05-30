using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHJ.Impresora;

namespace App__ControlImpresora
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora ptr1 = new Impresora(GenerarTexto());
            ptr1.FinalizoOK += ptr1_FinalizoOk;
            ptr1.InicializandoOK += ptr1_Inicializando;
            ptr1.VerTexto();
        }

        static void ptr1_Inicializando(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        static void ptr1_FinalizoOk(object sender, EventArgs e)
        {
            Console.WriteLine("=".PadRight(70, '='));
            Console.WriteLine("\n\n\n FIN DE LA IMPRESION");
            Console.WriteLine("=".PadRight(70, '='));
        }

        static string GenerarTexto()
        {
            string fuente = "En un lugar de la mancha de cuyo nombre no quiero acordarme";
            return fuente;
        }
    }
}
