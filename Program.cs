using System;
using tabuleiro;
using xadrez;

namespace Projeto_xadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                PartidaXadrez partida = new PartidaXadrez();

                while(!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);

                    System.Console.WriteLine();
                    System.Console.Write("Origem: ");;
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    System.Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
                

            }
            catch(TabuleiroException exception){
                System.Console.WriteLine(exception.Message);
            }
            Console.ReadLine();           
        }
    }
}
