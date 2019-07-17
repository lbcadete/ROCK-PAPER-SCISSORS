using System;
using ROCK_PAPER_SCISSORS.Exceptions;

namespace ROCK_PAPER_SCISSORS.Core
{
    public class JogadaIndividual : Jogada
    {
        public void Rps_gamer_winner()
        {
            InformarJogadores();

            ValidarJogadores();

            var vencedor = ProcessamentoJogada.Processar(jogadores[0], jogadores[1]);

            Console.WriteLine($"[{vencedor.Nome},{vencedor.Jogada}]");
        }

        protected override void ValidarJogadores()
        {
            if (jogadores.Count != 2)
                throw new WrongNumberOfPlayersError();
        }
    }
}
