using System;
using Tabuleiro;
using Tabuleiro.Enums;
using Tabuleiro.Exceptions;
using Xadrez;

namespace Chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.ToPosicao());


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
