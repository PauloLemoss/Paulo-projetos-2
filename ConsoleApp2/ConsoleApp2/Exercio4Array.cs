using System;

public class Execericio4Arrya
{
	static float[] Elemntos = new float[5];
	public Execericio4Arrya()
	{
	 

	}

	
	public void PreencherArray()
    {
        try
        {
			for (int i = 0; i < 8; i += 3)
			{
				Elemntos[i] = i + 1;
			}

		}
		catch (Exception e)
		{
			Console.WriteLine(e.ToString());
		}


	}


}
