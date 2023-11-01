using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPratice
{
	public class Calculadora
	{
		// Regra de negócio no teste TDD: método: calculadora, conter dois parametros inteiro e retornar ao final o historico dos 3 ultimos calculos

		public int Somar(int x, int y)
		{
			return x + y;

		}
		public int Multiplicar(int x, int y)
		{
			return x * y;

		}
		
		public int Subtrair(int x, int y)
		{
			return x - y;

		}

		
		public int Dividir(int x, int y)
		{
			return x / y;

		}

		
	}
}
