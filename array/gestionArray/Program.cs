using System;

namespace gestionArray
{
    class Program
    {
        static int nDatos = 0;
        static void Main(string[] args)
        {
            const int LONGITUD = 10;
            int[] array = new int[LONGITUD];
            int datosAnadidos;
            int datos = 25;
            datosAnadidos = Anadir(array, 50, datos);
            Listar(array);
            Borrar(array, nDatos-1);
            Listar(array);
            Console.WriteLine("\n>Insertar");
            Insertar(array, 3, 89);
            Listar(array);
            Console.WriteLine("\nMe has dicho {0} y yo he añadido {1}", datos, datosAnadidos);

            Salida();
        }

        #region Metodos Arrays

        static bool Anadir(int[] vector, int dato)
        {
            bool success;

            if (nDatos == vector.Length)
            {
                success = false;
            } 
            else
            {
                vector[nDatos++] = dato;
                success = true;   
            }
            return success;
        }

        static int Anadir(int[] vector, int maximo, int cuantosDatos)
        {
            int contador = 0;
            Random rnd = new Random();

            if (nDatos != vector.Length)
            {
                for (int i = 0; i < cuantosDatos; i++)
                {
                    if (Anadir(vector, rnd.Next(maximo)))
	                {
		                contador++;   
                    }
                }
            }
            return contador;
        }

        static void Listar(int[] vector)
        {
            if (nDatos == 0)
            {
                Console.WriteLine("No hay datos en el array");
            } 
            else
            {
                Console.WriteLine();
                for (int i = 0; i < nDatos; i++)
                {
                    Console.Write("{0}, \t", vector[i]);
                }
                Console.WriteLine("\nNo hay más datos que listar...");
            }
            
        }

        static bool Insertar(int[] vector, int indice, int dato)
        {
            bool success;

            if (nDatos <= indice || indice < 0 || nDatos == vector.Length)
            {
                success = false;
            } 
            else 
            {
                for (int i = nDatos; i > indice; i--) 
                {
                    vector[i] = vector[i - 1];

                }
                vector[indice] = dato;
                nDatos++;
                success = true;
            }
            return success;
        }


        static bool Borrar(int[] vector, int pos)
        {
            bool success;
            if (nDatos <= pos)
            {
                success = false;
            } 
            else
            {
                for (int i = pos; i < nDatos-1; i++)
                {
                    vector[i] = vector[i+1];
                }
                nDatos--;
                success = true;
            }
            return success;
        }

        #endregion

        static void Salida()
        {
            Console.Write("\nPulse cualquier tecla para salir: ");
            Console.ReadKey();
        }
    }
}
