using Calculadora;

namespace TesteMsTest
{
    [TestClass]
    public class TesteCalcMsTest
    {
        [TestMethod]
        public void TesteSomarDoisNumeros()
        {
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            double resultado = Calculadora.Calculadora.Somar(pNum, sNum);

            Assert.AreEqual(rNum, resultado);

        }


        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 2, 6)]

        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            double resultado = Calculadora.Calculadora.Somar(pNum, sNum);

            Assert.AreEqual(rNum, resultado);
        }

    }
}