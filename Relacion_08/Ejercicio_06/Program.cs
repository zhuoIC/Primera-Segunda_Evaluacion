using System.IO;

namespace Ejercicio_06
{
    class Program
    {
        static int Mostrar(char caracter, string ruta)
        {
            int nVeces = 0;

            using (StreamReader fichero = new StreamReader(ruta))
            {
                int ascii;
                while ((ascii = fichero.Read()) != -1) 
                {
                    if (ascii == caracter)
                    {
                        nVeces++;
                    }
                }
            }

            return nVeces;
        }
    }
}
