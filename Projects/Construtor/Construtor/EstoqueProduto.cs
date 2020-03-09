using System;
namespace Construtor
{
    public class EstoqueProduto
    {
        private string _nomeDoProduto;
        private double _precoDoProduto;
        private int _quantidadeEmEstoque;

        public EstoqueProduto() { }

        public EstoqueProduto(string nome, double preco, int quantidade)
        {
            _nomeDoProduto = nome;
            _precoDoProduto = preco;
            _quantidadeEmEstoque = quantidade;
        }

        public string NomeDoProduto
        {
            get { return _nomeDoProduto; }
            set { _nomeDoProduto = value; }
        }

        public double ValorTotalEmEstoque()
        {
            return _precoDoProduto * _quantidadeEmEstoque;
        }

        public void AdicionarProduto(int quantidade)
        {
            _quantidadeEmEstoque += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidadeEmEstoque -= quantidade;
        }

        public override string ToString()
        {
            return $"{_nomeDoProduto}, " +
                   $"$ {_precoDoProduto.ToString("f2")}, " +
                   $"{_quantidadeEmEstoque} unidades, total: $ {ValorTotalEmEstoque().ToString("f2")}";
        }
    }     
}
