using System;

namespace Sequência_de_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 ;
            int n2 ;
            int n3 ;
            int n4 ;
            double media ;

            Console.WriteLine("Digite o primeiro número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o terceiro número");
            n3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o quarto número");
            n4 = int.Parse(Console.ReadLine());

               media = (n1 + n2 + n3 + n4)/ 4;

                int max = Math.Max(n1, n2, n3, n4);

                int min = Math.Min(n1, n2, n3, n4);

                    Console.WriteLine($"A media dos números é {media}");
                    Console.WriteLine($"O maior número da sequência é {max}");
                    Console.WriteLine($"O menor número da sequência é {min}");
        }
    }
}