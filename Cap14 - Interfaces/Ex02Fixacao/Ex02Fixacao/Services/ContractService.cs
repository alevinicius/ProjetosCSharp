using System;

using Ex02.Entities;

namespace Ex02.Services
{
    class ContractService
    {
        public void ProcessInstallments(Contract contract, int totalMounths, IPaymentService paymentService)
        {
            for (int i = 1; i <= totalMounths; i++)
            {                   
                contract.Installments.Add(
                    new Installment(contract.Date.AddMonths(i), 
                    paymentService.CalculateInstallment(contract.Value / totalMounths, i)));
            }
        }

    }
}
