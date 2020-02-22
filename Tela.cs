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
                System.Console.Write(8 - i + " ");

                for(int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if(tabuleiro.Peca(i, j) == null) System.Console.Write("- ");
                    else
                    {
                        ImprimirPeca(tabuleiro.Peca(i, j));
                        System.Console.Write(" ");
                    }
                }

                System.Console.WriteLine();
            }

            System.Console.WriteLine("  a b c d e f g h ");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca.Cor == Cor.Branca) System.Console.Write(peca);
            else 
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Write(peca);
                Console.ForegroundColor = aux;

            }
        }
    }
}