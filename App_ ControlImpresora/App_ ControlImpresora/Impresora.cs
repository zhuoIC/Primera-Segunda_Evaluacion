using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHJ.Impresora
{
    // 1. Crear clase impresora.
    // 2. Campos que va a contener el texto.
    // 3. Añado el constructor donde voy a inicializar el contenido del texto.
    // 4. Añado un metodo para mostrar desde la consola e contenido del texto.
    // 5. Creo un evento que se disparara cuando finalice el contenido del metodo que imprime el texto.
    // 6. voy a la clase principal y pruebo el evento.
    class Impresora
    {
        private string _texto;   // Contiene el texto a imprimir
        public event EventHandler FinalizoOK;
        public event EventHandler InicializandoOK;

        public Impresora(string texto)
        {
            _texto = texto;
        }

        // Mandar el texto a imprimir (Pantalla)
        public void VerTexto()
        {
            if (InicializandoOK != null)
            {
                InicializandoOK("NOTA: Voy a iniciar la impresión.", null);
            }
            Console.WriteLine(_texto);
            Console.WriteLine("...");
            if (FinalizoOK != null)
            {
                FinalizoOK(this, null); // this representa el objeto que ha lanzado el evento
            }

            Console.ReadLine();
        }
    }
}
