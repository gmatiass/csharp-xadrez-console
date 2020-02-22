namespace tabuleiro
{
    class Tabuleiro
    {
        private Peca[,] Pecas;
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }  
    }
}