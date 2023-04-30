using System;
using ContractProcess.Entities;

namespace ContractProcess.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue /= months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double newQuota = basicQuota + _paymentService.Interest(basicQuota, i);
                double fullQuota = newQuota + _paymentService.PaymentFee(newQuota);
                contract.AddInstallments(new Installment(date, fullQuota));
            }
        }
    }
}
