using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode, DateTime date, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address address, Email email)
         : base(date, expireDate, total, totalPaid, document, payer, address, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}