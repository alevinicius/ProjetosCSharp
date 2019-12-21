using Ex06_Metodos_Abstratos;

namespace Ex06_Metodos_Abstratos.Entities
{
    class PessoaJuridica: Pessoa
    {
        public int NumeroDeEmpregados { get; private set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeEmpregados)
            :base(nome, rendaAnual)
        {
            NumeroDeEmpregados = numeroDeEmpregados;
        }

        public sealed override double Impostos()
        {
            double impostos;

            if (NumeroDeEmpregados > 10)
            {
                impostos = RendaAnual * 0.14;
            }
            else
            {
                impostos = RendaAnual * 0.16;
            }     

            return impostos;
        }
    }
}
