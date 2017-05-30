using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] texto = { 'H', 'o', 'l', 'a', ' ', 'C', 'a', 'r', 'a', 'c', 'o', 'l', 'a' };
            string origen = "En un lugar de la mancha, de cuyo nombre... No me acuerdo. ¿Tú sí?";
            string cadena1 = "Adios";
            string cadena3 = new string('*', 55);

            // Console.WriteLine(EjemploString());
            // UsoCopyTo();
            /*
            string a = "aaaa";
            string b = "aaaa";
            Console.WriteLine("{0}", Comparar(a, b, true));
             */

            // Console.WriteLine(UsoSubString());

            UsoSplit(origen);

            Console.ReadLine();
        }

        static int Comparar(string a, string b)
        {
            int num = 0;
            
            // Num = 1 si a > b, 0 si son iguales y -1 si a > b

            if (a.Length > b.Length)
            {
                num = 1;
            }
            else if (a.Length < b.Length)
            {
                num = -1;
            }
            else
            {
                int contador = 0;

                while (contador < a.Length)
	            {
                    if (a[contador] > b[contador])
                    {
                        num = 1;
                        break;
                    }
                    if (a[contador] < b[contador])
                    {
                        num = -1;
                        break;
                    }
                    contador++;
	            }
                
            }
            return num;
        }

        static int Comparar(string a, string b, bool sin)
        {
            int num = 0;

            // Num = 1 si a > b, 0 si son iguales y -1 si a > b
            //sin se usa para indicar que no se destinga min-MAYU
            if (sin)
            {
                a = a.ToLower();
                b = b.ToLower();
            }

            if (a.Length > b.Length)
            {
                num = 1;
            }
            else if (a.Length < b.Length)
            {
                num = -1;
            }
            else
            {
                int contador = 0;

                while (contador < a.Length)
                {
                    if (a[contador] > b[contador])
                    {
                        num = 1;
                        break;
                    }
                    if (a[contador] < b[contador])
                    {
                        num = -1;
                        break;
                    }
                    contador++;
                }

            }
            return num;
        }

        static void UsoSplit(string s)
        {
            char[] separador = {' ', ',', ';', '?', '¿', '.'};
            string[] palabras = s.Split(separador, StringSplitOptions.RemoveEmptyEntries);
            foreach (var palabra in palabras)
            {
                Console.WriteLine(palabra);
            }
            Console.WriteLine("\r\nHay estas palabras: " + palabras.Length);
        }

        static string UsoSubString()
        {
            string subString = string.Empty;
            string origen = "En un lugar de la mancha de cuyo...";
            int posIni = 6;
            int nCar = 5;
            return origen.Substring(posIni, nCar);
        }

        static void UsoCopyTo()
        {
            char[] texto = { 'H', 'o', 'l', 'a', ' ', 'C', 'a', 'r', 'a', 'c', 'o', 'l', 'a' };
            int posIniOrigen = 6;
            int nPosIniDestino = 5;
            int nCaracteres = 5;
            string origen = "En un lugar de la mancha de cuyo...";

            // Copiar 'lugar' a texto a partir de la posicion 5
            origen.CopyTo(posIniOrigen, texto, nPosIniDestino, nCaracteres);
            Console.WriteLine(texto);
        }

        static string EjemploString()
        {
            double valor;
            string resultado = string.Empty;
            string nl = "\r\n";

            // Mostrar los resultados con formato
            valor = 123;
            resultado += valor.ToString("00000") + nl;          // Salida: 00123
            valor = 1234567890;
            resultado += valor.ToString("0,0") + nl;             // Salida: 1.234.567.890
            valor = 1234567890.12345;
            resultado += valor.ToString("0,0.00") + nl;          // Salida: 1.234.567.890,12

            return nl + resultado;
        }
    }
}
