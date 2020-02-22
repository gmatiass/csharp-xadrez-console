using System;
using tabuleiro;
using xadrez;

namespace Projeto_xadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try{
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(1, 9));
                tabuleiro.ColocarPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(0, 0));

                Tela.ImprimirTabuleiro(tabuleiro);

                Console.ReadLine();
            }
            catch(TabuleiroException exception){
                System.Console.WriteLine(exception.Message);
            }*/

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            System.Console.WriteLine(pos);

            System.Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
            
        }
    }
}
