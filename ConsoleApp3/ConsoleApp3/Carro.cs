using System;

public class Carro
{
	private String Marca;
	private String Modelo;
	private String Ano;
	private String Placa;
	private float Velocidade;
	private float VelocidadeMaxima;

	public Carro(String Marca, String Modelo, String Ano, String Placa, float Velocidade)
	{
		Marca = Marca;
		Modelo = Modelo;
		Ano = Ano;
		Placa = Placa;
		Velocidade = Velocidade;
		VelocidadeMaxima = 220; // todo objeto carro so vai poder acelerar ate ese valor de 200

	}
	/* Como as varivies são private! precisamos usar as propriedades para encapusua(ocultar) os metodos gets e sets 
	
	   as propreidades são justamente pra isso fica mais facil de usar elas sabem quando usar um get ou quando usar set
	   sem q a getne precise dizer de foram explicidata 
	*/
	public string Marca1 { get => Marca; set => Marca = value; } 
	public string Modelo1 { get => Modelo; set => Modelo = value; }
	public string Ano1 { get => Ano; set => Ano = value; }
	public string Placa1 { get => Placa; set => Placa = value; }
	public float Velocidade1 { get => Velocidade; set => Velocidade = value; }
	public float VelocidadeMaxima1 { get => VelocidadeMaxima;}

	public float Acelarar(float valor)
	{
		
		try
		{
		  Velocidade =  Velocidade + valor;
		}
		catch (FormatException)
		{
			Console.WriteLine("{0} nao e um valor validio r", valor);
			// Return? Loop round? Whatever.
		}

		return Velocidade;

	}

	public bool ChecarVelocidade()
    {
		bool AtingiuLimiteVelocidade= false;	

		if (Velocidade > VelocidadeMaxima)
        {
			Velocidade1 = VelocidadeMaxima1;
			throw new VelocidadeExcedidaException("Voce nao pode acelear mais q maxima premitidada");
			AtingiuLimiteVelocidade=true;

		}

		return AtingiuLimiteVelocidade;

    }



}


