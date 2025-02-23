using System;

namespace Imposto_de_renda
{
    class Program
    {
        static void Main(string[] args)
        {
            double Imp;
            Console.WriteLine("Digite seu salário:");
            Imp = double.Parse(Console.ReadLine());

                if (Imp < 1903.98){
                    Console.WriteLine("Isento de imposto de renda");
                } else if (Imp > 1903.98)
                {
                    Console.WriteLine("Imposto de renda de 7,5%");
                } else if (Imp > 2826.65)
                {
                    Console.WriteLine("Imposto de renda de 15%");
                } else if (Imp > 3751.05)
                {
                    Console.WriteLine("Imposto de renda de 22,5%");
                } else if (Imp > 4664.68)
                {
                    Console.WriteLine("Imposto de renda de 27,5%");
                }
        }
    }
}