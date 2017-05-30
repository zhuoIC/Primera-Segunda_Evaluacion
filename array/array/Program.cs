using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion
            //tipo [] nombre
            const int LONGITUD = 10;
            int[] enteros;
            int[] cincoEnteros = new int[5];
            char[,] caracteres = new char[,] {{ 'a', 'e', 'i' },
                                              { 'a', 'e', 'i' },
                                              { 'a', 'e', 'i' }};
            string[] textos = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };

            enteros = new int[LONGITUD];

            Console.Title = "Array";

            AnadirNumDif(enteros);
            MostrarDatos(enteros);
            Ordenar(enteros);
            MostrarDatos(enteros);

            if (BuscarBinaria(enteros, 5) == -1)
            {
                Console.WriteLine("NO");
            } 
            else
            {
                Console.WriteLine("YES");
            }

            int maximo = 20;
            int indice = 0;
            int posIni = 2;
            int posFin = 4;
            int nDatos = posFin - posIni + 1;

            
           
            for (int i = 0; i < maximo; i++)
            {
                indice = (i % nDatos) + posIni;
                Console.Write("[{1}]{0}\t", enteros[indice], indice);
                if (indice == posFin)
                {
                    Console.WriteLine();
                }
            }

            InfoArray(caracteres);

            Salida();
        }

        static void MostrarDatos(int[] datos)
        {
            foreach (var tmp in datos)
            {
                Console.Write("{0}\t", tmp);
            }
            Console.WriteLine();
        }

        static void AnadirNumDif(int[] datos)
        {
            int nDatos = 0;
            Random rnd = new Random();
            int candidato = 0;
            while (nDatos < datos.Length)
            {
                candidato = rnd.Next(15);
                if (BuscarSecuencial(candidato, nDatos, datos) == -1)
                {
                    datos[nDatos++] = candidato;
                }
            }
        }

        static void InfoArray(Array vector)
        {
            // Muestra la informacion del array vector
            byte dimensiones;
            if (vector is Array)
            {
                Console.WriteLine("\nD A T O S   D E L   A R R A Y");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("  Tipo de array: {0}", vector.GetType());
                Console.WriteLine("     IsReadOnly: {0}", vector.IsReadOnly);
                dimensiones = (byte)vector.Rank;
                Console.WriteLine("Eres de {0} Dim:", dimensiones);

                for (int i = 0; i < dimensiones; i++)
                {
                    Console.WriteLine("Dimension {0}", i + 1);
                    for (int j = 0; j < vector.GetLength(i); j++)
                    {
                        /* Console.Write("[{0}] -> {1}", j, vector<i>) */;
                    }
                }
            }
            
        }

        static int BuscarSecuencial(int numero, int nDatos, int[] datos)
        {
            int posicion = 0;
            while (posicion < nDatos)
	        {
                if (datos[posicion] == numero)
	            {
		            break;
	            }
                posicion++;
	        }

            if (posicion == nDatos)
	        {
		        posicion = -1;
	        }

            return posicion;
        }

        static int BuscarBinaria(int[] array, int numero)       // tiene que estar ordenado y lleno
        {
            int posIni = 0;
            int posFin = array.Length;
            int mitad = 0;

            while (posIni < posFin)
            {
                mitad = (posIni + posFin) / 2;
                if (array[mitad] == numero)
                {
                    break;
                } 
                else if (numero > array[mitad])
                {
                    posIni = mitad + 1;
                } 
                else
                {
                    posFin = mitad - 1;
                }
            }

            if (posIni == posFin)
            {
                mitad = -1;
            }
            return mitad;
        }


        static void MostrarDatosCircular(int[] datos)
        {
            int maximo = 20;
            for (int i = 0; i < maximo; i++)
            {
                Console.Write("{1}->{0}\t", datos[i % datos.Length], i);
            }
        }

        static void Inicializa(int[] datos)
        {
            Random rnd = new Random();
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = rnd.Next(10);
            }
        }

        static void Ordenar(int[] datos)
        {
            for (int i = datos.Length-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    int tmp = 0;

                    if (datos[j] > datos[j + 1])
                    {
                        tmp = datos[j + 1];
                        datos[j + 1] = datos[j];
                        datos[j] = tmp;
                    }
                }
            }
        }

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
