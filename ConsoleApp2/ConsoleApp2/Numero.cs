using System;

public class Numero
{

	private float Numero1;
	private float Numero2;
	private float Resultado;
	public Numero()
	{
		
		

	}

	public void DividirDoisNumeros(float Num1, float Num2)
    {
        try
        {
			Numero1 = Num1;
			Numero2 = Num2;
			Resultado = Numero1/Numero2;
			Console.WriteLine("O Resultado e");
			Console.WriteLine(Resultado);

		}

		catch (DivideByZeroException e)
		{
			Console.WriteLine("Exception caught: {0}", e);
		}

	}

}
