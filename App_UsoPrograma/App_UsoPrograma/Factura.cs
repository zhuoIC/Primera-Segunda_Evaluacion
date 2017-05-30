using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UsoPrograma
{
    class Factura:IPrograma, ICloneable
    {
        string msg = "soy el objeto de FActura origen..";
        public override string ToString()
        {
            return msg;
        }

        public void Copiar(object obj)
        {
            Console.WriteLine("Soy Copiar() de la Factura");
        }

        public object Clone()
        {
            Factura unaFactura = new Factura();
            unaFactura.msg = this.msg + "hey";
            return unaFactura;
        }
    }
}
