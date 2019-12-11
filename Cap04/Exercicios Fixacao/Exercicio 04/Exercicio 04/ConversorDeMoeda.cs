namespace Exercicio_04
{
    class ConversorDeMoeda
    {
        static double Iof = 6.00;

        public static double DeDolarParaReal(double qtdeDolares, double cotacaoDolar)
        {
            return (qtdeDolares * cotacaoDolar) + (qtdeDolares * cotacaoDolar * Iof / 100);             
        }
    }
}
