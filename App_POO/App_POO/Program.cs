using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nico.App_Clase;

namespace Nico.App_POO
{
    class Program
    {
        Class1 unaClase = new Class1();

        static void Main(string[] args)
        {
            Class1 unaClase = new Class1();
            Class2 otraClase = new Class2();
            otraClase.MetodoPublico();
        }
    }
}
