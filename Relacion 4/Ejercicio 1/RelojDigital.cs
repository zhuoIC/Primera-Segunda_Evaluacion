/*
 *PROGRAMA: RelojDigital
 *AUTOR: Nicolás Hernández Jiménez
 *FUNCION: Muestra un reloj digital por pantalla
 *FECHA: 03/11/2016
 *COMENTARIOS: Obtengo la hora del sistema y mediante los for creo el reloj
 */

using System;
using System.Threading;

namespace Ejercicio_1
{
    class RelojDigital
    {
        static void Main(string[] args)
        {
            Reloj();
        }

        static void Reloj()
        {
            #region Variables

            DateTime time = DateTime.Now;
            int hora = time.Hour;
            int minuto = time.Minute;
            int segundo = time.Second;

            const int HOR = 24;
            const int MIN = 60;
            const int SEG = 60;

            #endregion

            Console.WriteLine("\n");
            Console.CursorVisible = false;

            for (int h = hora; h < HOR; h++)
            {
                for (int m = minuto; m < MIN; m++)
                {
                    for (int s = segundo; s < SEG; s++)
                    {
                        Console.SetCursorPosition(30, 10);
                        Console.Write("{0:00}:{1:00}:{2:00}", h, m, s);
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
