using System;
using Xunit;
using Calculadora;

namespace CalculadoraTestes
{
    public class CalculadoraTestes
    {

        public Calculadora construirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora("02/02/2020");

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        [InlineData(6, 7, 13)]
        [InlineData(8, 9, 17)]
        public void TestSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        [InlineData(7, 6, 1)]
        [InlineData(9, 8, 1)]
        public void TestSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(6, 7, 42)]
        [InlineData(8, 9, 72)]
        public void TestMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(6, 3, 2)]
        [InlineData(8, 4, 2)]
        public void TestDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();


            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

    }
}