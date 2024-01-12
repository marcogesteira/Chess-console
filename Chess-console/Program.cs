using System;
using Tabuleiro;

namespace Chess_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tabuleiro);
        }
    }
}
