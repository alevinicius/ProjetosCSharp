using System.Globalization;

namespace Exercicio_Lista_01 {
    class Funcionario {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentual) { 
            Salario += Salario * porcentual / 100;
        }

        public override string ToString() {
            return 
                $"{Id}, " +
                $"{Nome}, " +
                $"{Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
