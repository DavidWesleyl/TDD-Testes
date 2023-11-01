using TDDPratice;

namespace Testes
{
	public class TesteCalculadora
	{
		[Theory]
		[InlineData(1, 2, 3)] // O numero 1 e 2 ser�o os somados, o 3 � o resultado esperado
		[InlineData(4, 5, 9)] // Ao inv�s de criarmos outro m�todo igual, podemos fazer s� isso.

		public void TestSoma(int num1, int num2, int resultado)
		{
			Calculadora calc = new Calculadora();

			int resultadoSoma = calc.Somar(num1, num2); // Deve retornar 3

			Assert.Equal(resultado, resultadoSoma);

		}

		[Theory]
		[InlineData(1, 2, 2)]
		[InlineData(4, 5, 20)]

		public void TestMultiplicar(int num1, int num2, int resultado)
		{
			Calculadora calc = new Calculadora();

			int resultadoSoma = calc.Multiplicar(num1, num2); // Deve retornar 3

			Assert.Equal(resultado, resultadoSoma);

		}


		[Theory]
		[InlineData(3, 3, 0)]

		public void TestSubitrair(int num1, int num2, int resultado)
		{
			Calculadora calc = new Calculadora();

			int resultadoSoma = calc.Subtrair(num1, num2);

			Assert.Equal(resultado, resultadoSoma);

		}

		[Theory]
		[InlineData(6, 2, 3)]
		[InlineData(8, 2, 4)]

		public void TestDividir(int num1, int num2, int resultado)
		{
			Calculadora calc = new Calculadora();

			int resultadoSoma = calc.Dividir(num1, num2);

			Assert.Equal(resultado, resultadoSoma);

		}

		[Fact]

		public void TestarDivisaoporZero()
		{
			Calculadora calc = new Calculadora();

			Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0)); // Express�o Lambda


		}



		// Poderiamos testar criando mais um m�todo. Por�m existe um jeito melhor e com menos linhas. Utilizando o Theory

		//[Fact]
		//public void teste2()
		//{
		//	Calculadora calc = new Calculadora();

		//	int resultadoSoma = calc.Somar(4, 5); // Deve retornar 3

		//	Assert.Equal(9, resultadoSoma);


		//}
	}
}