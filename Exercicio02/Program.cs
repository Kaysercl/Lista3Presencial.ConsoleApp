using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura, altura;

            Console.WriteLine("Digite a quantidade de linhas");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de colunas");
            largura = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < altura; x++)
            {
                Console.WriteLine("");
                for (int y = 0; y < largura; y++)
                {                    
                    if (x % 2 != 1)
                        Console.Write("A");
                    if (x % 2 != 0)
                        Console.Write("B");
                }
            }    
        }
    }
}
