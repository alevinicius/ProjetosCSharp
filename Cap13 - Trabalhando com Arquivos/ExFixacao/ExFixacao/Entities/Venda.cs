namespace ExFixacao.Entities
{
    class Venda
    {
        public string Produto { get; private set; }
        public double ValorUnitario { get; private set; }
        public int Quantidade { get; private set; }
        public double Total { get; private set; }

        public Venda(string produto, double valorUnitario, int quantidade)
        {
            Produto = produto;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            Total = ValorUnitario * Quantidade;
        }
    }
}
