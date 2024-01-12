using System;
using Tabuleiro;
using Tabuleiro.Enums;
using Xadrez;

namespace Chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(Cor.Preta, tab),new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(Cor.Preta, tab) ,new Posicao(2, 4));


            Tela.imprimirTabuleiro(tab);
        }
    }
}
