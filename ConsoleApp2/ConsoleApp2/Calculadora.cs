using System;

public class Calculadora
{

	private float Numero1;
	private float Numero2;
	private float Resultado;

	public Calculadora()
	{
	}

	public void Dividir()
	{
		Console.WriteLine("Digite o primerio numero");
		float primeiroNumero;
		if (!float.TryParse(Console.ReadLine(), out primeiroNumero))
		{
			throw new FormatException("Error de formatacao");
		}
		Console.WriteLine("Digite o segundo numero");
		float segundoNumero;

		if (!float.TryParse(Console.ReadLine(), out segundoNumero))
		{
			throw new FormatException("Error de formatacao");
		}

        Numero1 = primeiroNumero;
		Numero2 = segundoNumero;
		Resultado = Numero1 / Numero2;
		Console.WriteLine("O Resultado e");
		Console.WriteLine(Resultado);

		if (Resultado==0)
		{
			throw new InvalidOperationException("Não pode dividir Por zero");
		}
		


	}
}
