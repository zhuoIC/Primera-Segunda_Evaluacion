using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_IO_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] unidades = DriveInfo.GetDrives();

            Console.WriteLine("UNIDADES: ");
            foreach (DriveInfo unidad in unidades)
            {
                Console.WriteLine("\n         NOMBRE: " + unidad.Name);
                Console.WriteLine("    TIPO UNIDAD: " + unidad.DriveType);
                Console.WriteLine("=".PadRight(70, '='));
                if (unidad.IsReady)
                {
                    Console.WriteLine("         VOLUMEN: " + unidad.VolumeLabel);
                    Console.WriteLine("SISTEMA ARCHIVOS: " + unidad.DriveFormat);
                    Console.WriteLine("  ESPACIO LIBRE: " + unidad.AvailableFreeSpace);
                    Console.WriteLine("  TAMAÑO UNIDAD: " + unidad.TotalSize);
                }                
            }
            Console.ReadLine();
        }
    }
}
