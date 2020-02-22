using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public int Linha { get; set; }
        public char Coluna { get; set; }
        
        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha; 
        }
    }
}