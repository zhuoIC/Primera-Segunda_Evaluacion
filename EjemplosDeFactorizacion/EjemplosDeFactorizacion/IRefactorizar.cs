using System;
namespace EjemplosDeFactorizacion
{
    interface IRefactorizar
    {
        string Direccion { get; set; }
        void imprimirTodo();
        string Nombre { get; set; }
    }
}
