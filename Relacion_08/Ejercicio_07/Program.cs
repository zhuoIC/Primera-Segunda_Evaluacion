using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Concatenar("", "");
            Console.ReadLine();
        }

        static bool Concatenar(string ficheroDestino, string ficheroOrigen)
        {
            if (File.Exists(ficheroDestino) && File.Exists(ficheroOrigen))
            {
                FileInfo infoFichero = new FileInfo(ficheroDestino);
                using (StreamWriter flujoACopiar = infoFichero.AppendText())
                {
                    using (StreamReader flujoAConcatenar = new StreamReader(ficheroOrigen))
                    {
                        int asccii = 0;
                        while ((asccii = flujoAConcatenar.Read()) != -1) 
                        {
                            flujoACopiar.Write((char)asccii);
                        }
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
