/*************************************************************
 * PROGRAM:
 * AUTHOR:
 * FUNCTION:
 * DESCRIPTION:
 * DATE:              VERSION:
 *************************************************************/

using System;
using System.Threading;
namespace Proyecto_1
{
    class Program
    {
        Boolean flag = new Boolean();
        static void Main(string[] args)
        {

                    for (int segundo = 0; segundo < 60; segundo++)
                    {
                        
                        for (int i = 0; i < 100; i++)
                        {
                            Console.Title = Convert.ToString(segundo + ":"+i);
                            Thread.Sleep(10);
                        }

            }
            Console.WriteLine("HOLA");
            int posicion = Console.CursorSize;
            Console.WriteLine(posicion);
            Console.ReadLine();

        }
    }
}