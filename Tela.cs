using System;
using tabuleiro;
//using xadrez;

namespace Projeto_xadrezConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for(int i = 0; i < tabuleiro.Linhas; i++)
            {
                for(int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if(tabuleiro.Peca(i, j) == null) System.Console.Write("- ");
                    else System.Console.Write(tabuleiro.Peca(i, j) + " ");
                }

                System.Console.WriteLine();
            }
        }
    }
}