using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeRefactorizacion
{
    
    public enum TipoSolicitud
    {
        Tipo1 = 1,
        Tipo2 = 2, 
        Tipo3 = 3
    }
    public struct Solicitud
    {
        public TipoSolicitud Tipo;
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
        const int TOPECANTIDAD = 10;
        const int PRECIOMINIMO = 100;
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

        private bool CumpleCondiciones(Solicitud solicitud)
        {
            return solicitud.Tipo == TipoSolicitud.Tipo2 && solicitud.Cantidad > TOPECANTIDAD && solicitud.Precio < PRECIOMINIMO;
        }

        public decimal CalcularDescuento(Solicitud solicitud)
        {
            if (CumpleCondiciones(solicitud))
            {

                return 0.5M;
            }
            else
            {
                return 0.0M;
            }
        }

        public void TratarSolicitud(Solicitud solicitud)
        {
            solicitud.Descuento = CalcularDescuento(solicitud);
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
