using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4, valor5, media, positivos = 0, negativos = 0;
            
          
            Console.WriteLine("Digite o valor 1");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor 2");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor 3");
            valor3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor 4");
            valor4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor 5");
            valor5 = Convert.ToInt32(Console.ReadLine());

            if (valor1 < 0)
            {
                negativos++; 
            } 
            else
            {
                positivos++;
            }
            if (valor2 < 0)
            {
                negativos++;
            }
            else
            {
                positivos++;
            }
            if (valor3 < 0)
            {
                negativos++;
            }
            else
            {
                positivos++;
            }
            if (valor4 < 0)
            {
                negativos++;
            }
            else
            {
                positivos++;
            }
            if (valor5 < 0)
            {
                negativos++;
            }
            else
            {
                positivos++;
            }            

            media = (valor1 + valor2 + valor3 + valor4 + valor5) / 5;
            Console.WriteLine("A media dos valores é " + media);
            Console.WriteLine("A quantidade de números positivos é " + positivos);
            Console.WriteLine("A quantidade de números negativos é " + negativos);
        }
    }
}
