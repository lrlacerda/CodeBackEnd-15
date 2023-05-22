namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void TesteSomarDoisNumeros()
        {
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            double resultado = Calculadora.Calculadora.Somar(pNum, sNum);

            Assert.Equal(rNum, resultado);

        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(3, 1, 2)]
        [InlineData(5, 1, 6)]
        [InlineData(10, 1, 11)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            double resultado = Calculadora.Calculadora.Somar(pNum, sNum);

            Assert.Equal(rNum, resultado);
        }
    }
}