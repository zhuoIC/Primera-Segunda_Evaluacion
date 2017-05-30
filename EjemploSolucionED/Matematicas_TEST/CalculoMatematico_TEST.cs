using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematicas;

namespace Matematicas_TEST
{
    [TestClass]
    public class CalculoMatematico_TEST
    {
        [TestMethod]
        public void EsPrimo_valor1_esFalso()
        {
            //arrange preparacion
            uint numero = 1;
            bool resultado;
            //act ejecucion 
            resultado = CalculoMatematico.EsPrimo(numero);
            //assert comprobacion de resultados
            Assert.IsFalse(resultado, "El número dado es primo");
        }
        [TestMethod]
        public void EsPrimo_valor2_esTrue()
        {
            //arrange preparacion
            uint numero = 2;
            bool resultado;
            //act ejecucion
            resultado = CalculoMatematico.EsPrimo(numero);
            //assert comprobacion de resultados
            Assert.IsTrue(resultado, "El número dado no es primo");
        }
        [TestMethod]
        public void EsPrimo_cualquierPAR_esFalse()
        {
            //arrange preparacion
            uint numero1 = 4;
            uint numero2 = 4294967294;
            //act ejecucion

            //assert comprobacion de resultados
            Assert.IsFalse(CalculoMatematico.EsPrimo(numero1), "Es Primo");
            Assert.IsFalse(CalculoMatematico.EsPrimo(numero2), "Es Primo");
        }
        [TestMethod]
        public void EsPrimo_valor5_esTrue()
        {
            //arrange preparacion
            uint numero = 5;
            bool resultado;
            //act ejecucion
            resultado = CalculoMatematico.EsPrimo(numero);
            //assert comprobacion de resultados
            Assert.IsFalse(resultado, "Es Primo");
        }
    }
}
