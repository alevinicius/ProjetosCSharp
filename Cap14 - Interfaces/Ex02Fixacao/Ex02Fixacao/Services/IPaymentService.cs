namespace Ex02.Services
{
    interface IPaymentService
    {
        double CalculateInstallment(double value, int mounth);
    }
}
