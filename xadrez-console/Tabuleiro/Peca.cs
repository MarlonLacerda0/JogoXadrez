namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            this.cor = cor;
            QteMovimentos = 0;
            
        }

        public void IncrementarQteMovimentos()
        {
        QteMovimentos++; 
        }
    }
}
