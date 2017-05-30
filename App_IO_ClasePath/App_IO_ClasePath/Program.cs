using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_IO_ClasePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = Path.VolumeSeparatorChar.ToString() +Path.DirectorySeparatorChar + "Carpetaaaaa" + Path.DirectorySeparatorChar + "datos.dat";
            string rutaW = @"C:\mio\datos\fichero.txt"; //Con @ el string lo interpreta de forma literal

            Console.WriteLine("RUTA ORIGEN: " + rutaW);
            rutaW = Path.ChangeExtension(rutaW, "zhuo");
            Console.WriteLine("RUTA: " + rutaW);
            rutaW = Path.Combine(rutaW, "segunda");
            Console.WriteLine("RUTA COMBINE: " + rutaW);
            Console.WriteLine("NOMBRE DIRECTORIO: "+ Path.GetDirectoryName(rutaW));
            Console.WriteLine("NOMBRE FICHERO: " + Path.GetFileName(rutaW));
            Console.WriteLine(Path.GetFullPath(@".\mio\texto.txt"));
            Console.WriteLine(Path.GetPathRoot(rutaW));

            Console.ReadLine();
        }
    }
}
