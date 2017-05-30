using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeRefactorizacion
{
    public struct Solicitud
    {
        public int Tipo;
        public int Cantidad;
        public double Precio;
        public decimal Descuento;
    }

    public struct SolicitudEstudiante
    {
        public string Estudiante;
        public string Programa;
        public string Vacante;
        public string Ciclo;
    }

    public class Impuestos
    {
        public string ProcesoAEjecutar { get; set; }

        /// <summary>
        /// Calcula el impuesto a pagar
        /// </summary>
        /// <param name="nImpuesto">Numero de impuesto</param>
        /// <returns>Impuesto calculado según nImpuesto</returns>
        public double CalcularImpuesto(string nImpuesto)
        {
            return 0.0;
        }

        public void TratarSolicitud(Solicitud solicitud)
        {
            if (solicitud.Tipo == 2 && solicitud.Cantidad > 10 && solicitud.Precio < 100)
            {
                solicitud.Descuento = 0.5M;
            }
        }
        public void EjecutarProcesoAdmision(SolicitudEstudiante solicitud)
        {
            string estudiante = solicitud.Estudiante;
            string programa = solicitud.Programa;
            string vacante = solicitud.Vacante;
            string ciclo = solicitud.Ciclo;

            bool resultado = ValidarAdmision(estudiante, programa, vacante, ciclo);
        }

        public bool ValidarAdmision(string e, string p, string v, string c)
        {
            return true;
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
