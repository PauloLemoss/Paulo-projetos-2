using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primerio numero");
            float primeiroNumero = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            float segundoNumero = float.Parse(Console.ReadLine());

            Numero num = new Numero();
            num.DividirDoisNumeros(primeiroNumero, segundoNumero);
           

            Console.Write("-------------seungda questão e Terceira----------------");
            Calculadora calc = new Calculadora();
            calc.Dividir();

            Console.WriteLine("------------Questoes 4 e 5");

            Execericio4Arrya array = new Execericio4Arrya();
            array.PreencherArray();

            Console.ReadKey();
        }
    }
}
