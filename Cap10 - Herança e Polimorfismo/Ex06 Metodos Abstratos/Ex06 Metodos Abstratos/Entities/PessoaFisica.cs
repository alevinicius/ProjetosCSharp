using Ex06_Metodos_Abstratos.Entities;

namespace Ex06_Metodos_Abstratos.Entities
{
    class PessoaFisica: Pessoa
    {
        public double GastosComSaude { get; private set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude)
            :base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public sealed override double Impostos()
        {
            double impostos;
            if (RendaAnual < 20000.0)
            {
                impostos = RendaAnual * 0.15;
            }
            else
            {
                impostos = RendaAnual * 0.25;
            }

            if(GastosComSaude > 0)
            {
                impostos -= GastosComSaude / 2;
            }

            return impostos;
        }
    }
}
