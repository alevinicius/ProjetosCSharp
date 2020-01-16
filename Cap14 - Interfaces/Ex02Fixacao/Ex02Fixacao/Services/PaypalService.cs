namespace Ex02.Services
{
    class PaypalService : IPaymentService
    {
        private const double Interest = 0.01;
        private const double Fee = 0.02;

        public double CalculateInstallment(double value, int mounth)
        {
            double valueWithInterest = value + (value * Interest * mounth);
            double valueWithInterestAndFee = valueWithInterest + (valueWithInterest * Fee);
            return valueWithInterestAndFee;
        }
    }
}
