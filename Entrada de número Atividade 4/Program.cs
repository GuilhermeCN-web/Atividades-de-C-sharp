using System;

namespace Entrada_de_número_Atividade_4
{
    class Program
    {
        static void Main(String[] args)
        {
            int n1;

            Console.WriteLine("Digite um número");
            n1 = int.Parse(Console.ReadLine());

            if (n1 > 0)
            {
                Console.WriteLine("O número é positivo");
            } else if (n1 < 0)
            {
                Console.WriteLine("O número é negativo");
            } else if (n1 == 0)
            {
                Console.WriteLine("O número é 0");
            }
        }
    }
}