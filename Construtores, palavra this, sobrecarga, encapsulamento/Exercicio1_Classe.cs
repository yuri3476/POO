using System.Globalization;


namespace Exercicio1
{
    internal class ContaBancaria
    {

        public int Numero { get;  private set; }
        public string Titular { get; set; } 
        public double Saldo { get; private set; }

        // construtores 

        public ContaBancaria(int numero, string titular) 
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        // void pq elas nao vao retornar uma saida, ela simplesmente vai alterar o valor do Saldo
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }


        // montar o padrao da saida
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
