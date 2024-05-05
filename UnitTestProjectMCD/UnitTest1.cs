using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoMCD;
using System;

namespace UnitTestProjectMCD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MCD_2numeros_TestMethod()
        {
            int nro1 = 8; 
            int nro2 = 12;
            int esperado = 4;
            int prueba = CalcularMCD.MCD(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }

        [TestMethod]
        public void MCD_4numeros_TestMethod()
        {
            int nro1 = 9;
            int nro2 = 12;
            int nro3 = 6;
            int nro4 = 15;
            int esperado = 3;
            int prueba = CalcularMCD.MCD(CalcularMCD.MCD(CalcularMCD.MCD(nro1,nro2),nro3),nro4);
            Assert.AreEqual(esperado, prueba);
        }
    }
}
