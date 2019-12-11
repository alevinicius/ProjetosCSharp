using System.Globalization;

namespace Ex_Vetor_02 {
    class Produto {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public override string ToString() {
            return $"Nome: {Nome}, Preço: R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
