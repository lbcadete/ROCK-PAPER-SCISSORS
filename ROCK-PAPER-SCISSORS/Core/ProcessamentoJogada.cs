using System;

namespace ROCK_PAPER_SCISSORS.Core
{
    public static class ProcessamentoJogada
    {
        public static Jogador Processar(Jogador jogador1, Jogador jogador2)
        {
            if (jogador1.Jogada.ToUpper().Equals("R") && jogador2.Jogada.ToUpper().Equals("R"))
                return jogador1;
            if (jogador1.Jogada.ToUpper().Equals("P") && jogador2.Jogada.ToUpper().Equals("R"))
                return jogador1;
            if (jogador1.Jogada.ToUpper().Equals("S") && jogador2.Jogada.ToUpper().Equals("R"))
                return jogador2;

            if (jogador1.Jogada.ToUpper().Equals("R") && jogador2.Jogada.ToUpper().Equals("P"))
                return jogador2;
            if (jogador1.Jogada.ToUpper().Equals("P") && jogador2.Jogada.ToUpper().Equals("P"))
                return jogador1;
            if (jogador1.Jogada.ToUpper().Equals("S") && jogador2.Jogada.ToUpper().Equals("P"))
                return jogador1;

            if (jogador1.Jogada.ToUpper().Equals("R") && jogador2.Jogada.ToUpper().Equals("S"))
                return jogador1;
            if (jogador1.Jogada.ToUpper().Equals("P") && jogador2.Jogada.ToUpper().Equals("S"))
                return jogador2;
            if (jogador1.Jogada.ToUpper().Equals("S") && jogador2.Jogada.ToUpper().Equals("S"))
                return jogador1;

            throw new Exception();
        }
    }
}
