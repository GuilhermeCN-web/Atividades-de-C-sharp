using System;

namespace Temperatura_Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            double F;

            Console.WriteLine("Digite a temperatura em C°");
            C = int.Parse(Console.ReadLine());

            F = C * 1.8 + 32;
            Console.WriteLine($"O valor em F° é {F}");
        }
    }
}