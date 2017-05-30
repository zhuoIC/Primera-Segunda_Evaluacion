using System;
using System.Threading;

namespace Pecera
{
    class Program
    {
        static Random rnd = new Random();
        static int limiteAlto = Console.WindowHeight;
        static int limiteAncho = Console.WindowWidth;
        static int alto = rnd.Next(3, Console.LargestWindowHeight);
        static int ancho = rnd.Next(3, Console.LargestWindowWidth);
        static int[,] pecera = new int[alto, ancho];
        static int bordePeceraAlto = pecera.GetLength(0) - 1;
        static int bordePeceraAncho = pecera.GetLength(1) - 1;
        static char caracterPez = '☻';
        static char caracterCola;
        static char caracterBordeLateral = '║';
        static char caracterBordeInferior = '═';
        static char caracterEsquinaIzq = '╚';
        static char caracterEsquinaDer = '╝';
        static char vacio = ' ';
        static ConsoleColor fondoInicio = Console.BackgroundColor;
        static ConsoleColor letraInicio = Console.ForegroundColor;


        static void Main(string[] args)
        {
            int[] pez = new int[] { rnd.Next(1, bordePeceraAlto), rnd.Next(1, bordePeceraAncho) };
            int[] mover = new int[2];
            int[] cola = new int[2];
            
            bool arriba;
            bool abajo;
            bool izquierda;
            bool derecha;


            Console.Title = "Pecera";
            Console.CursorVisible = false;
            Console.WindowHeight = alto;
            Console.WindowWidth = ancho;

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight);

            

            Dibujar(pez);

            while (true)
            {
                Console.SetCursorPosition(0, 0);

                if (pez[0] == 1 || pez[0] == bordePeceraAlto - 1)
                {
                    if (pez[0] == 1)
                    {
                        if (pez[0] == bordePeceraAlto - 1)
                            mover[0] = 1;
                        else
                            mover[0] = rnd.Next(1, 3);
                    } 
                    else
                        mover[0] = rnd.Next(0, 2);                      
                }
                else
                    mover[0] = rnd.Next(0, 3);

                if (pez[1] == 1 || pez[1] == bordePeceraAncho - 1)
                {
                    if (pez[1] == 1)
                    {
                        if (pez[1] == bordePeceraAncho - 1)
                            mover[1] = 1;
                        else 
	                        mover[1] = rnd.Next(1,3);      
                    } 
                    else
                        mover[1] = rnd.Next(0, 2);
                } 
                else
                    mover[1] = rnd.Next(0, 3);

                arriba = mover[0] == 0;
                abajo = mover[0] == 2;
                izquierda = mover[1] == 0;
                derecha = mover[1] == 2;

                if (derecha)
                {
                    if (abajo && derecha)
                        caracterCola = '\\';
                    else
                    {
                        if (arriba && derecha)
                            caracterCola = '/';
                        
                        else
                            caracterCola = '—';
                    }
                }

                if (izquierda)
                {
                    if (arriba && izquierda )
                        caracterCola = '\\';
                    else
                    {
                        if (abajo && izquierda)
                            caracterCola = '/';
                        else
                            caracterCola = '-';
                    }
                }

                if ((abajo || arriba) && !(derecha || izquierda))
                    caracterCola = '│';

                cola[0] = pez[0];
                cola[1] = pez[1];

                if (arriba)
                    pez[0]--;
                if (abajo)
                    pez[0]++;
                if (izquierda)
                    pez[1]--;
                if (derecha)
                    pez[1]++;
                
                if (mover[0] == 1 && mover[1] == 1)
                    Dibujar(pez);
                else
                    Dibujar(pez, cola);

                Thread.Sleep(100);
            }
        }


        static void Dibujar(int[] pez)
        {
            for (int fila = 0; fila < pecera.GetLength(0); fila++)
            {
                for (int columna = 0; columna < pecera.GetLength(1); columna++)
                {
                    if (fila == bordePeceraAlto)
                    {
                        if (columna == 0)
                            Console.Write(caracterEsquinaIzq);
                        if (columna == bordePeceraAncho)
                            Console.Write(caracterEsquinaDer);
                        if (!(columna == 0) && !(columna == bordePeceraAncho))
                            Console.Write(caracterBordeInferior);
                    } 
                    else
                    {
                        if (columna == bordePeceraAncho || columna == 0)
                                Console.Write(caracterBordeLateral); 
                        else
                        {
                            if (fila >= 1)
                                Console.BackgroundColor = ConsoleColor.Cyan;
                            if (pez[0] == fila && pez[1] == columna)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(caracterPez);
                            } else
                                    Console.Write(vacio);
                        } 
                    }

                    if (columna <= limiteAncho && columna == bordePeceraAncho)
                        Console.Write("\n");
                    
                    Console.BackgroundColor = fondoInicio;
                    Console.ForegroundColor = letraInicio;
                }
            }
        }

        static void Dibujar(int[] pez, int[] cola)
        {
            for (int fila = 0; fila < pecera.GetLength(0); fila++)
            {
                for (int columna = 0; columna < pecera.GetLength(1); columna++)
                {
                    if (fila == bordePeceraAlto)
                    {
                        if (columna == 0)
                            Console.Write(caracterEsquinaIzq);
                        if (columna == bordePeceraAncho)
                            Console.Write(caracterEsquinaDer);
                        if (!(columna == 0) && !(columna == bordePeceraAncho))
                            Console.Write(caracterBordeInferior);
                    } 
                    else
                    {
                        if (columna == bordePeceraAncho || columna == 0)
                                Console.Write(caracterBordeLateral); 
                        else
                        {
                            if (fila >= 1)
                                Console.BackgroundColor = ConsoleColor.Cyan;
                            if (pez[0] == fila && pez[1] == columna)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(caracterPez);
                            } else
                            {
                                if (cola[0] == fila && cola[1] == columna)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(caracterCola);
                                }
                                else
                                    Console.Write(vacio);
                            }
                        } 
                    }

                    if (columna <= limiteAncho && columna == bordePeceraAncho)
                        Console.Write("\n");

                    Console.BackgroundColor = fondoInicio;
                    Console.ForegroundColor = letraInicio;
                }
            }
             
            
        }


    }
}
