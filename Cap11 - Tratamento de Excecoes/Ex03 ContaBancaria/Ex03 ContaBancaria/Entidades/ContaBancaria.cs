using Ex03.Entidades.Exceptions;

namespace Ex03.Entidades
{
    class ContaBancaria
    {
        public int Numero { get; protected set; }
        public string Titular { get; protected set; }
        public double Saldo { get; protected set; }
        public double LimiteDeSaque { get; protected set; }

        public ContaBancaria(int numero, string titular, double saldo, double limiteDeSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (Saldo == 0)
            {
                throw new DomainException("Não há saldo na conta");
            }
            if (valor > Saldo)
            {
                throw new DomainException("O valor do saque não pode ser maior do que o saldo na conta");
            }
            if (valor > LimiteDeSaque)
            {
                throw new DomainException("O valor do saque não pode ser maior do que valor limite de saque");
            }
            
            Saldo -= valor;
        }
    }
}
