using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro){}

        private bool PodeMover(Posicao posicao)
        {
            Peca p = Tabuleiro.Peca(posicao);
            return p == null || p.Cor != Cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Norte
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if(Tabuleiro.PosicaoValida(pos) && PodeMover(pos)) mat[pos.Linha, pos.Coluna] = true;

            //Nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if(Tabuleiro.PosicaoValida(pos) && PodeMover(pos)) mat[pos.Linha, pos.Coluna] = true;

            //Leste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if(Tabuleiro.PosicaoValida(pos) && PodeMover(pos)) mat[pos.Linha, pos.Coluna] = true;

            //Sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if(Tabuleiro.PosicaoValida(pos) && PodeMover(pos)) mat[pos.Linha, pos.Coluna] = true;

            //Sul
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if(Tabuleiro.PosicaoValida(pos) && PodeMover(pos)) mat[pos.Linha, pos.Coluna] = true;

            //Sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if(Tabuleiro.PosicaoValida(pos) && PodeMover(pos)) mat[pos.Linha, pos.Coluna] = true;

            //Oeste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if(Tabuleiro.PosicaoValida(pos) && PodeMover(pos)) mat[pos.Linha, pos.Coluna] = true;

            //Noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if(Tabuleiro.PosicaoValida(pos) && PodeMover(pos)) mat[pos.Linha, pos.Coluna] = true;

            return mat;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}