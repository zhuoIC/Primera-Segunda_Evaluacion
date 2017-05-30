using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nico.App_Clase
{
    class Class1        // Clase padre
    {
        private void MetodoPrivado()
        { }

        public void MetodoPublico() { }

        // No se aplica a clases. Si al contenido de sus miembros.
        // Indica que la visibilidad esta reducida a su clase como private pero en la herencia actua como publica
        protected void MetodoProtegido() { }
    }
    
    
    class Class2: Class1           // Clase derivada
    {
        

        static void M()
        {
            Class1 m = new Class1();
            Class2 n = new Class2();
            // m.MetodoProtegido(); <- No se ve
            n.MetodoProtegido();
        }
    }

    // Aplicable a la clase no a los miembros. Solo es visible en el ensamblado que la contiene
    internal class Class3
    { 

    }

    // De esta clase no se puede heredar
    sealed class ClassX         // Clase sellada o de uso final
    { }

    // No permite crear objetos de ella pero si se puede heredar
    // Si nuestra clase tiene un metodo abstracto la clase tiene q ser tambien abstracta
    abstract class ClassZ
    {
    }
}
