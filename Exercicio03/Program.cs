using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double horaAtual;
           
            Console.WriteLine("Por favor, me diga a hora atual");
            horaAtual = double.Parse(Console.ReadLine());
            

            if (horaAtual >= 01 && horaAtual <= 12)
            {
                Console.WriteLine("Bom Dia");
                Console.ReadLine();
                Console.Clear();                
            }
            else if (horaAtual >= 13 && horaAtual <= 18)
            {
                Console.WriteLine("Boa Tarde");
                Console.ReadLine();
                Console.Clear();
            }
            else if (horaAtual >= 19 && horaAtual <= 24)
            {
                Console.WriteLine("Boa Noite");
                Console.ReadLine();
                Console.Clear();
            }

            

        }
    }
}
