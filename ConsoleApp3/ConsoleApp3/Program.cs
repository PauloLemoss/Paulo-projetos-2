using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a maraca");
            String marca = Console.ReadLine();
            
            Console.WriteLine("Digite o modelo");
            String modelo = Console.ReadLine();
            
            Console.WriteLine("Digite a placa");
            String placa = Console.ReadLine();
            
           

            Carro carro = new Carro(marca, modelo, "2021", "JKI-5867", 0);
            Console.WriteLine("Vamos acelera o valor para 10");

            carro.Velocidade1 = carro.Velocidade1 + carro.Acelarar(10); // Estou fazendo uso da propriedade Volicidade1 que emcapsula os metodos get e sete de velocidade
            Console.WriteLine(carro.Velocidade1);

            Console.WriteLine("vamos aceleara mais 10");

            carro.Velocidade1 = carro.Velocidade1 + carro.Acelarar(10);
            Console.WriteLine(carro.Velocidade1);

           
            float VelocidadePassada = 0;

            Console.WriteLine("Atençã o laço e de 10 para nao ficar demorado");

            while (carro.Velocidade1 <= carro.VelocidadeMaxima1)
            {
                if (carro.ChecarVelocidade()==false)
                {
                    Console.WriteLine("Pode Celerara");
                    VelocidadePassada = float.Parse(Console.ReadLine());
                    carro.Acelarar(VelocidadePassada);
                 }

               

            }



        }
    }
}
