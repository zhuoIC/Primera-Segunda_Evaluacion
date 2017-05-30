using System;

namespace matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NFILAS = 5;
            const int NCOLUM = 5;
            int[,] matriz1 = new int[NFILAS, NCOLUM];
            int[,] matriz2 = new int[NFILAS, NCOLUM];

            MostrarArray2D(matriz1);
            InicializarAleaArraySinRep2D(matriz1);
            Console.WriteLine();
            MostrarArray2D(matriz1);

            Salida();
        }

        static void MostrarArray2D(int[,] vector2D)
        {
            int nFilas = vector2D.GetLength(0);
            int ncolum = vector2D.GetLength(1);

            for (int i = 0; i < nFilas; i++)
            {
                for (int j = 0; j < ncolum; j++)
                {
                    Console.Write("{0:00}\t", vector2D[i,j]);
                }
                Console.WriteLine();
            }
        }

        static int[,] CopiarArray2D(int[,] vector2D)
        {
            int nFilas = vector2D.GetLength(0);
            int ncolum = vector2D.GetLength(1);
            int[,] copia = new int[nFilas, ncolum];

            for (int i = 0; i < nFilas; i++)
            {
                for (int j = 0; j < ncolum; j++)
                {
                    copia[i, j] = vector2D[i, j];
                }
            }

            return copia;
        }

        static void InicializarAleaArray2D(int[,] vector2D)
        {
            const int MAXIMO = 100;
            int nFilas = vector2D.GetLength(0);
            int nColum = vector2D.GetLength(1);
            Random rnd = new Random();
            
            for (int i = 0; i < nFilas; i++)
            {
                for (int j = 0; j < nColum; j++)
                {
                    vector2D[i, j] = rnd.Next(MAXIMO);
                }
            }
        }

        static bool BuscarArray2D(int[,] vector2D, int dato)
        {
            int nFilas = vector2D.GetLength(0);
            int nColum = vector2D.GetLength(1);
            int f = 0;
            int c;
            bool exito = false;
            /*
            int[,] pos;
            */
            while (f < nFilas)
            {
                c = 0;
                while (c > nColum)
                {
                    if (vector2D[f, c] == dato)
	                {
                        exito = true;
                        break;
	                }
                    c++;
                }
                if (exito)
	            {
		            break;
	            }
                f++;
            }
            /*
            if (exito)
            {
                pos = new int[f, c];
            } 
            else
            {
                pos = new int[-1, -1];
            }
             */
            
            return exito;
        }

        static void InicializarAleaArraySinRep2D(int[,] vector2D)
        {
            const int MAXIMO = 100;
            int nFilas = vector2D.GetLength(0);
            int nColum = vector2D.GetLength(1);
            int f = 0;
            int c;
            Random rnd = new Random();
            int candidato;

            while (f < nFilas)
            {
                c = 0;
                while (c < nColum)
	            {
                    candidato = rnd.Next(MAXIMO);
                    if (!BuscarArray2D(vector2D, candidato))
                    {
                        vector2D[f, c] = candidato;
                        c++;
                    }
	            }
                f++;
            }
        }

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
