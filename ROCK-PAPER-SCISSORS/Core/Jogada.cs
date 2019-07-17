using System;
using System.Collections.Generic;
using ROCK_PAPER_SCISSORS.Exceptions;

namespace ROCK_PAPER_SCISSORS.Core
{
    public abstract class Jogada
    {
        protected IList<Jogador> jogadores;

        protected Jogada()
        {
            jogadores = new List<Jogador>();
        }

        protected void InformarJogadores()
        {
            do
            {
                var jogador = new Jogador();
                Console.WriteLine("Informe o nome do Jogador: ");
                jogador.Nome = Console.ReadLine();
                Console.WriteLine("Informe a jogada: (R,P,S)");
                jogador.Jogada = Console.ReadLine();
                ValidarJogada(jogador.Jogada);
                jogadores.Add(jogador);

                Console.WriteLine("Informe ESC para parar ou outra tecla para continuar");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        protected static void ValidarJogada(string jogada)
        {
            if (!jogada.ToUpper().Equals("R") && !jogada.ToUpper().Equals("P") && !jogada.ToUpper().Equals("S"))
                throw new NoSuchStrategyError();   
        }

        protected abstract void ValidarJogadores();
    }
}
