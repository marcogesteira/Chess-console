using Tabuleiro.Enums;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tabuleiro = tabuleiro;
            this.QtdMovimentos = 0;
        }
    }
}
