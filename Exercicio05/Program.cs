using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player1, player2;
             

            Console.WriteLine("Digite o nome do Player 1");
            player1 = Convert.ToString(Console.ReadLine()); 
            Console.WriteLine("Digite o nome do Player2");
            player2 = Convert.ToString(Console.ReadLine());

            int vitoriajogador1 = 0, vitoriajogador2 = 0;
            int rodadaatual = 1;
            

            while (rodadaatual <= 3)
            {
                Console.WriteLine(rodadaatual + "a rodada ");
                Random rand1 = new Random();
                
                int numeroplayer1 = rand1.Next(1, 7);
                Console.WriteLine(player1 + " tirou " + numeroplayer1);                
                int numeroplayer2 = rand1.Next(1, 7);
                Console.WriteLine(player2 + " tirou " + numeroplayer2);
                
                if (numeroplayer1 > numeroplayer2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(player1 + " ganhou a rodada");
                    Console.ReadLine();
                    vitoriajogador1++;
                    Console.ResetColor();
                }
                else if (numeroplayer1 == numeroplayer2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Empate");
                    Console.ReadLine();
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(player2 + " ganhou a rodada");
                    Console.ReadLine();
                    Console.ResetColor();
                    vitoriajogador2++;
                } 
                if (rodadaatual == 3)
                {
                    if (vitoriajogador1 > vitoriajogador2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(player1 + " venceu a partida");
                        Console.ResetColor();
                    }
                    else if (vitoriajogador1 == vitoriajogador2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" Houve um empate");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(player2 + " venceu a partida");
                        Console.ResetColor();
                    }
                    Console.ReadLine();
                    Console.Clear();                    
                }
                rodadaatual++;
            }                                   
        }
    }
}
