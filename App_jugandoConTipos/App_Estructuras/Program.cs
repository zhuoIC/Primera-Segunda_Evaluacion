using System;

namespace App_Estructuras
{
    class Program
    {
        struct FichaPersona
        {
            string _nombre;
            float _altura;
            int _edad;
            //etc..

            public FichaPersona(string n, float a, int e)
            {
                _nombre = n;
                _altura = a;

                if (e > 120)
                {
                    e = 120;
                }
                if (e < 18)
	            {
                    e = 18;
	            }
                
                _edad = e;
            }

            // Leer datos
            public string GetName()
            {
                return _nombre;
            }
            public float GetHight()
            {
                return _altura;
            }
            public int GetAge()
            {
                return _edad;
            }

            public string GetPerson()
            {
                return _nombre + ", " + _altura.ToString() + ", " + _edad.ToString();  
            }
            public override string ToString()
            {
                return _nombre + ", " + _altura.ToString() + ", " + _edad.ToString();  
            }


            // Escribir datos
            public string SetName(string n)
            {
                _nombre = n;
                return _nombre;
            }
            public float SetHight(float a)
            {
                _altura = a;
                return _altura;
            }
            public int SetAge(int e)
            {
                if (e > 120)
                {
                    e = 120;
                }
                if (e < 18)
                {
                    e = 18;
                }

                _edad = e;
                return _edad;
            }

        }
        static void Main(string[] args)
        {
            FichaPersona alumno1;   // No se puede hacer con las clases
            FichaPersona alumno2 = new FichaPersona("Pepito", 198.22F, 26);

            Console.WriteLine("nombre: " + alumno2.GetName());
            Console.WriteLine("altura: " + alumno2.GetHight());
            Console.WriteLine("edad: " + alumno2.GetAge());

            FichaPersona p1 = new FichaPersona("Pepe", 12.33F, 120);
            FichaPersona p2 = new FichaPersona("Pepeaaa", 112.33F, 120);
            FichaPersona p3 = new FichaPersona("Pepe44", 124.33F, 120);
            FichaPersona p4 = new FichaPersona("Pepe22", 12.33F, 120);
            FichaPersona p5 = new FichaPersona("Pepe22", 82.33F, 120);
            FichaPersona p6 = new FichaPersona("Pepe22", 42.33F, 120);

            Console.WriteLine("Datos de p3: {0}", p3.ToString());


            Console.ReadLine();
        }
    }
}
