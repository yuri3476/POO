using System.Globalization;

namespace Encapsulamento
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        // construtor 
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // para eu conseguir ver esses valores privados em meu programa principal, 
        // tem que implementar os métodos GET e SET

        // GET é para eu conseguir visualizar o valor 
        // SET é para eu conseguir alterar o valor 
        public string GetNome()
        {
            return _nome;
        }
        // void pq ele nao vai retorna nada como saida, apenas alterar 
        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            _nome = nome;
        }

        public double Getpreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade; 
        }



        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
