using System.Globalization;

namespace ExercicioFixacao_01 {
    class Conta {
        private string _nomeTitular;
        public int Numero { get; }
        public double Saldo { get; private set; }

        public Conta(string nomeTitular, int numero) {
            _nomeTitular = nomeTitular;
            Numero = numero;
        }

        public Conta(string nomeTitular, int numero, double depositoInicial) : this(nomeTitular, numero) {
            Depositar(depositoInicial);
        }

        public string NomeTitular {
            get { return _nomeTitular; }
            set {
                if (value != null && value.Length > 2) {
                    _nomeTitular = value;
                }
            }
        }

        public void Depositar(double valor) {
            if (valor >= 0.00) {
                Saldo += valor;
            }

        }

        public void Sacar(double valor) {
            if (valor >= 0.00) {
                Saldo -= (valor + 5.00);
            }
        }

        public override string ToString() {
            return
                $"Titular: {NomeTitular}, " +
                $"Numero: {Numero}, " +
                $"Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
