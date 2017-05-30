using System;

namespace EjemplosDeFactorizacion
{
    class Refactorizar : IRefactorizar
    {
        private string _direccion;
        private string _nombre;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public void imprimirTodo()
        {
            imprimirBanner();
            //detalles de impresión
            ImprimirDetalles("P1", "C1");
        }

        public void ImprimirDetalles(string pie, string cabecera)
        {
            Console.WriteLine(cabecera);
            Console.WriteLine("nombre: " + _nombre);
            Console.WriteLine("cantidad " + getCargoPendiente());
            Console.WriteLine(pie);
        }

        private string getCargoPendiente()
        {
            throw new NotImplementedException();
        }

        private void imprimirBanner()
        {
            throw new NotImplementedException();
        }


        static void Main(string[] args)
        {
            Refactorizar pepe = new Refactorizar();
            
        }


    }
}
