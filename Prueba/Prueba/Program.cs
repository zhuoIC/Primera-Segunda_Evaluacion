using System;
using System.Threading;

namespace Prueba
{
    class Program
    {
        
        static int altoMaximo = Console.LargestWindowHeight;
        static int anchoMaximo = Console.LargestWindowWidth;
        static int alto = Console.WindowHeight;
        static int ancho = Console.WindowWidth;
        static char[,] matriz = new char[alto, ancho];
        static char[,] auxiliar = new char[matriz.GetLength(0), matriz.GetLength(1)];
        static Random rnd = new Random();
        static char caracter = '☻';
        static char vacio = ' ';

        static void Main(string[] args)
        {
            int n = 0;
            Console.WindowHeight = matriz.GetLength(0);
            Console.WindowWidth = matriz.GetLength(1);

            Console.CursorVisible = false;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    n = rnd.Next(2);
                    if (n > 0)
                    {
                        Console.Write(matriz[i, j] = caracter);
                    } else
                        Console.Write(matriz[i, j] = vacio);
                    
                }
            }

            while (true)
            {
                //Console.Clear();
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(Comprobar(i,j));
                        
                        
                    }
                }
                Thread.Sleep(1000);

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz[i, j] = auxiliar[i, j];
                    }
                }
            }
        }

        static char Comprobar(int i, int j)
        {
            int vivos = 0;

            if (matriz[(i - 1 + matriz.GetLength(0)) % matriz.GetLength(0), (j - 1 + matriz.GetLength(1)) % matriz.GetLength(1)] == caracter)
                vivos++;

            if (matriz[(i + 1 + matriz.GetLength(0)) % matriz.GetLength(0), (j - 1 + matriz.GetLength(1)) % matriz.GetLength(1)] == caracter)
                vivos++;
            
            if (matriz[(i + 1 + matriz.GetLength(0)) % matriz.GetLength(0), (j + 1 + matriz.GetLength(1)) % matriz.GetLength(1)] == caracter)
                vivos++;

            if (matriz[(i - 1 + matriz.GetLength(0)) % matriz.GetLength(0), (j + 1 + matriz.GetLength(1)) % matriz.GetLength(1)] == caracter)
                vivos++;

            if (vivos > 1 && vivos != 4 && vivos != 3)
            {
                return auxiliar[i,j] = caracter;
            } 
            else
                return auxiliar[i, j] = vacio;
        }

    }
}
