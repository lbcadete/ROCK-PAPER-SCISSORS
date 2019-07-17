using System;
using ROCK_PAPER_SCISSORS.Core;

namespace ROCK_PAPER_SCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Jogo Único");
            Console.WriteLine("2 - Torneio");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    new JogadaIndividual().Rps_gamer_winner();
                    break;
                case "2":
                    new JogadaTorneio().Rps_tournament_winner();
                    break;
                default:
                    Console.WriteLine("A opção informada é inválida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
