using System;

namespace Dólar_Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dolar;
            double real;
            double converter;

            Console.WriteLine("Defina o valor em dolár para converter em real");
            dolar = int.Parse(Console.ReadLine());

            converter = dolar * 5.25;
            Console.WriteLine($"Seu valor em real é {converter}");
        }
    }
}
