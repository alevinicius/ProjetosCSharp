using System.Globalization;

namespace Ex06_Metodos_Abstratos.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; protected set; }
        public double RendaAnual{ get; protected set; }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Impostos();

        public override string ToString()
        {
            return $"{ Nome }: ${Impostos().ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }
}
