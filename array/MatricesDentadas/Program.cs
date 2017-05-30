using System;

namespace MatricesDentadas
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            const int DIM1 = 2;   
            int[][] m = new int[DIM1][];
            m[0] = new int[3];
            m[1] = new int[] { 1, 2, 3, 4 };

            char[][] c = new char[2][]
            {
                new char[3],
                new char[4]
            };

            int[][] n = new int[2][]
            {
                new int[2],
                new int[3]
            };

            int[] dim2 = { 4, 6 };

            int[][] otraN = CrearMatriz(DIM1, dim2);
            PintarDentada(otraN);

            CrearDentada(n);
            PintarDentada(n);
            Salida();
        }

        static void CrearDentada(int[][] matriz)
        {
            int dimensiones = matriz.Length;
            int minimo = 10;
            int maximo = 99;

            for (int i = 0; i < dimensiones; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = rnd.Next(minimo, maximo + 1);
                }
            }
        }

        static void PintarDentada(int[][] matriz)
        {
            int dimensiones = matriz.Length;

            for (int i = 0; i < dimensiones; i++)
            {
                Console.Write("M[{0}] ->", i);
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write(matriz[i][j] + ",\t");
                }
                Console.WriteLine();
            }
        }

        static int[][] CrearMatriz(int dim1, int[] dim2)
        {
            int[][] dentada = new int[dim1][];
            int minimo = 10;
            int maximo = 99;

            for (int i = 0; i < dim1; i++)
            {
                dentada[i] = new int[dim2[i]];
                for (int j = 0; j < dim2[i]; j++)
                {
                    dentada[i][j] = rnd.Next(minimo, maximo + 1);
                }
            }

            return dentada;
        }

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
