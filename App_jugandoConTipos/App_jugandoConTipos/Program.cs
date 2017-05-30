using System;
using System.Collections.Generic;

namespace App_jugandoConTipos
{
    class Program
    {
        [Flags]
        public enum Asignaturas
        {
            Prog    = 0x00000001,
            BADA    = 0x00000002,
            SINF    = 0x00000004,
            FOL     = 0x00000008,
            LM      = 0x00000010,
        }

        static void Main(string[] args)
        {
            Asignaturas unaAsignatura;
            unaAsignatura = Asignaturas.BADA;

            Console.WriteLine("Una asignatura {0} -> {1}", unaAsignatura, Enum.GetName(typeof(Asignaturas), 10));

            string[] contenido = Enum.GetNames(typeof(ConsoleKey));

            foreach (string tmp in contenido)
            {
                Console.WriteLine(tmp);
            }

            /*
            object numero = 10;         // Un objeto que representa un entero
            object letra = 'a';
            object texto = "Hola";
            int entero = 5;             // Un entero

            Simple miSimple = new Simple();

            miSimple.Cambia(entero);

            Asignaturas aprobada;

            aprobada = (Asignaturas)3;

            Console.Write(aprobada);

            
            for (int i = (int)Asignaturas.Prog; i <= (int)Asignaturas.ENDE; i++)
            {
                Console.WriteLine((Asignaturas)i);
            }
            */
            Console.ReadLine();
             
        }
    }

    class Simple
    {
        // campo de tipo entero
        int numero = 0;



        public int Cambia(int dato)
        {
            // Cambia el valro del dato al doble y lo devuelve

            
            return dato * 2;
        }


    }
}
