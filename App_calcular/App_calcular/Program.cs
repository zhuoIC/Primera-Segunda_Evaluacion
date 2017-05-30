using System;

namespace App_calcular
{
    class Program
    {
        /// <summary>
        /// App de la consola que calcula:
        /// - La longitud de la circunferencia
        /// - El volumen del cilindro
        /// - El area del circulo
        /// Los parametros se pasa desde la consola
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nparametros = args.Length;
            float radio;
            float altura;

            Console.Clear();
            if (nparametros == 0)       // faltan parametros
            {
                Console.WriteLine("Faltan parametros...\n");
                Ayuda();
            }
            if (nparametros == 1)       // faltan parametros
            {
                if (args[0] == "?")
                    Ayuda();
            }
            if (nparametros == 2)       // faltan parametros
            {
                bool flag = false;
                flag = float.TryParse(args[1], out radio);

                if (!flag)
                {
                    Ayuda();
                } 
                else
                {
                    if (args[0].ToLower() == "l")
                    {
                        Console.WriteLine("La longitud de la circunferencia de radio {0} es: {1:N2}", radio, Longitud(radio));
                    }
                    if (args[0].ToLower() == "a")
                    {
                        Console.WriteLine("El área de la circunferencia de radio {0} es: {1:N2}", radio, Area(radio));
                    } 
                }
            }
            if (nparametros == 3)
	        {
		        bool flag = false;
                flag = float.TryParse(args[1], out radio);
                flag = float.TryParse(args[2], out altura);

                if (!flag)
                {
                    Ayuda();
                } 
                else
                {
                    if (args[0].ToLower() == "v")
                    {
                        Console.WriteLine("El volumen del cilindro de radio {0} y altura {1} es: {2:N2}", radio, altura, Volumen(radio, altura));
                    }
                }
	        }
            if (nparametros > 3)        // demasiados parametros
            {
                
                Console.WriteLine("Demasiados parametros...\n");
                Ayuda();
            }

            Console.ReadLine();
        }

        static void Ayuda()
        {
            Console.WriteLine("=".PadLeft(30, '='));
            Console.WriteLine("Uso de App_calcular el area, longitud,...");
            Console.WriteLine("=".PadLeft(30, '='));
            Console.WriteLine("     SINTAXIS: App_calcular [l/L] radio, Para la longitud");
            Console.WriteLine("               App_calcular [a/A] radio, Para el area");
            Console.WriteLine("               App_calcular [v/V] radio altura para el volumen");
            Console.WriteLine();
            Console.WriteLine("App_Calcular ? para mostrar la ayuda");
        }

        #region Mis metodos
        static double Longitud(double radio)
        {
            return 2 * Math.PI * radio;
        }

        static double Area(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        static double Volumen(double radio, double altura)
        {
            return  Math.PI * Math.Pow(radio, 2) * altura;
        }
        #endregion
    }
}
