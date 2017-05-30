using System;

namespace Matematicas
{
    #region Excepciones
    public class FaltanParametroException : Exception { }
    public class DemasiadosParametrosException: Exception { }
    public class NoNumeroException : Exception { }
    public class FueraDeRangoException : Exception { }
    public class NumeroNoPositivoException : Exception { }
    #endregion

    public class CalculoMatematico
    {
        public static bool EsPrimo(string[] argumentos)
        {
            if (argumentos == null || argumentos.Length == 0)
            {
                throw new FaltanParametroException();
            }
            else if (argumentos.Length > 1)
            {
                throw new DemasiadosParametrosException();
            } 
            else
            {
                try 
	            {
                    int num = int.Parse(argumentos[0]);
                    if (num <= 0)
                    {
                        throw new NumeroNoPositivoException();
                    } 
                    else
                    {
                        if (num == 1)
                        {
                            return false;
                        }
                        for (int i = 2; i < (num / 2) + 1; i++)
                        {
                            if (num % 1 == 0)
                            {
                                return false;
                            }
                        }
                    }
	            }
	            catch (FormatException)
	            {
		
		            throw new NoNumeroException();
	            }
                catch (OverflowException)
                {
                    throw new FueraDeRangoException();
                }
            }

            return true;
        }

        static bool EsPrimo(uint numero)
        {
            bool encontradodivisor = false;

            if (numero < 2)
            {
                encontradodivisor = true;
            } 
            else
            {
                for (int i = 2; i < ((numero/2)+1); i++)
                {
                    if (numero % i == 0)
                    {
                        encontradodivisor = true;
                        break;
                    }
                }
            }
            return !encontradodivisor;
        }

        static double Potencia(double bas, float exp)
        {
            if (exp == 0)
            {
                return 1;
            }
            if (exp < 0)
            {
                return Potencia( 1/ bas, (float)-exp);
            }
                
            return bas * Potencia(bas, (float)(exp - 1));

        }

        static void Main(string[] args)
        {
            /*
            string n = "p";
            int r = int.MaxValue;
            Console.WriteLine("Hola desde el main de MATEMATICAS"+ n.PadLeft(34));
            //Console.WriteLine("{0:N}",Potencia(2,(float)(-0.9)));
            for (int num = 0; num < r; num++)
            {
                if (EsPrimo(num))
                {
                    Console.Write(num);
                }  
            }
            
            Console.ReadLine();
             */
        }
    }
}
