using System;
using System.Linq;
using ROCK_PAPER_SCISSORS.Exceptions;

namespace ROCK_PAPER_SCISSORS.Core
{
    public class JogadaTorneio : Jogada
    {
        public void Rps_tournament_winner()
        {
            InformarJogadores();

            ValidarJogadores();

            var i = 0;
            while (jogadores.Count > 1)
            {
                if (i == jogadores.Count)
                    i = 0;

                var jogador1 = jogadores[i];
                var jogador2 = jogadores[i + 1];
                var vencedor = ProcessamentoJogada.Processar(jogador1, jogador2);
                jogadores.Remove(vencedor == jogador1 ? jogador2 : jogador1);

                i++;
            }

            Console.WriteLine("CAMPEÃO!!!");
            Console.WriteLine($"[{jogadores.First().Nome},{jogadores.First().Jogada}]");
        }

        protected override void ValidarJogadores()
        {
            var quantidadeJogadores = jogadores.Count;
            var count = 2;
            while (count < quantidadeJogadores)
                count = count * 2;
            if (count != quantidadeJogadores)
                throw new WrongNumberOfPlayersError();
        }
    }
}
