using System;

namespace Tabuada_de_multiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número que você quer ver a tabuada");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            for (var contador = 0; contador < 11; contador++)
            {
                Console.WriteLine(numero+" X "+contador+" = "+numero*contador);
            }
        }
    }
}
