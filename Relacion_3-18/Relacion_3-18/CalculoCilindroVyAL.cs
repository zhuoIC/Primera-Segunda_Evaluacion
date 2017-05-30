/********************************************************************************************
 *PROGRAMA:  CalculoCilindroVyAL                                                            *
 *FUNCION:	Calcula el volumen y el área lateral de un cilindro recto                       *
 *AUTOR:	Nicolas Hernandez Jimenez                                                       *
 *FECHA:	27/10/2016      VERSION: 1.0.0                                                  *
 *COMENTARIOS: Declaro las variables de los operandos usados para aplicar las formulas y    *
 *una vez guardadas en variables las muestro por pantalla                                   *
 ********************************************************************************************/

using System;

namespace Relacion_3_18
{
    class CalculoCilindroVyAL
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            const double PI = Math.PI;
            int altura = 0;
            int radio = 0;
            double volumen = 0;
            double areaL = 0;


            Console.WriteLine("Cálculo del volumen y el área lateral de un cilindro recto.");
            Console.Write("Introduce el valor del radio (cm): ");
            radio = int.Parse(Console.ReadLine());

            Console.Write("Introduce el valor de la altura (cm): ");
            altura = int.Parse(Console.ReadLine());

            // Aplicacion de las formulas del volumen y el area lateral
            volumen = PI * Math.Pow(radio, 2) * altura;
            areaL = 2 * PI * radio * altura;

            // Muestra por pantalla los resultados
            Console.WriteLine("\n  El volumen vale: {0:N2} cm cúbicos", volumen);
            Console.WriteLine("     El área vale: {0:N2} cm cuadrados", areaL);
            Console.Write("\nPulse una tecla para salir: ");

            Console.ReadLine();
        }
    }
}
