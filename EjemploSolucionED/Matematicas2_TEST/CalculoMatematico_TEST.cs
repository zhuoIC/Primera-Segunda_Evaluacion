using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematicas;

namespace Matematicas2_TEST
{
    [TestClass]
    public class CalculoMatematico_TEST
    {
        // camino 1a: 1-E1-13
        [TestMethod]
        [ExpectedException(typeof (FaltanParametroException))]
        public void EsPrimo_valornull_ExceptionE1()
        {
            //Arrange
            
            //Act
            CalculoMatematico.EsPrimo(null);
            //Assert

        }

        // camino 1b: 1-E1-13
        [TestMethod]
        [ExpectedException(typeof(FaltanParametroException))]
        public void EsPrimo_valorvacio_ExceptionE1()
        {
            //Arrange

            //Act
            CalculoMatematico.EsPrimo(new string[0]);
            //Assert

        }

        // camino 2: 1-2-E2-13
        [TestMethod]
        [ExpectedException(typeof(DemasiadosParametrosException))]
        public void EsPrimo_valorDoble_ExceptionE2()
        {
            //Arrange

            //Act
            CalculoMatematico.EsPrimo(new string[3]);
            //Assert

        }

        // camino 3: 1-2-3-E3-13
        [TestMethod]
        [ExpectedException(typeof(NoNumeroException))]
        public void EsPrimo_valorNoNumerico_ExceptionE3()
        {
            //Arrange

            //Act
            CalculoMatematico.EsPrimo(new string[]{"a"});
            //Assert

        }

        // camino 4: 1-2-3-E4-13
        [TestMethod]
        [ExpectedException(typeof(FueraDeRangoException))]
        public void EsPrimo_valorMaximoMasUno_FueraDeRangoExceptionE4()
        {
            //Arrange
            long numero = (long)int.MaxValue +1;
            numero++;
            //Act
            CalculoMatematico.EsPrimo(new string[] { numero.ToString() });
            //Assert

        }

        // camino 5: 1-2-3-4-E5-13
        [TestMethod]
        [ExpectedException(typeof(NumeroNoPositivoException))]
        public void EsPrimo_valor0_NumeroNoPositivoE5()
        {
            //Arrange
            
            //Act
            CalculoMatematico.EsPrimo(new string[] {"0"});
            //Assert

        }

        // camino 6: 1-2-3-4-5-6-13
        [TestMethod]
        public void EsPrimo_valor1_False()
        {
            //Arrange
            bool resultado;
            //Act
            resultado = CalculoMatematico.EsPrimo(new string[] { "1" });
            //Assert
            Assert.IsFalse(resultado, "El numero es primo");
        }

        // camino 7: 1-2-3-4-5-6-7-8-12-13
        [TestMethod]
        public void EsPrimo_valor2_True()
        {
            //Arrange
            bool resultado;
            //Act
            resultado = CalculoMatematico.EsPrimo(new string[] { "2" });
            //Assert
            Assert.IsTrue(resultado, "El numero no es primo");
        }

        // camino 8: 1-2-3-4-5-6-7-8-9-10-13
        [TestMethod]
        public void EsPrimo_valorCualquierPAR_False()
        {
            //Arrange
            bool resultado;
            bool resultado1;
            int mayorPar = int.MaxValue - 1;
            //Act
            resultado = CalculoMatematico.EsPrimo(new string[] { "4" });
            resultado1 = CalculoMatematico.EsPrimo(new string[] { mayorPar.ToString() });
            //Assert
            Assert.IsFalse(resultado, "Primer intento. El numero es primo");
            Assert.IsFalse(resultado1, "Segundo intento. El numero es primo");
        }

        // camino 8: 1-2-3-4-5-6-7-8-9-10-13
        [TestMethod]
        public void EsPrimo_valor5_True()
        {
            //Arrange
            bool resultado;
            //Act
            resultado = CalculoMatematico.EsPrimo(new string[] { "5" });
            //Assert
            Assert.IsFalse(resultado, "El numero no es primo");
        }
    }
}
