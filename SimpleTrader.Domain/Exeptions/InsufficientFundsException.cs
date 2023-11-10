using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Exeptions
{
    public class InsufficientFundsException : Exception
    {
        public double AccountBalance { get; set; }
        public double RequiredBalaтсу { get; set; }
        public InsufficientFundsException(double accountBalance, double requiredBalance)
        {
            AccountBalance=accountBalance;
            RequiredBalaтсу=requiredBalance;
        }

        public InsufficientFundsException(double accountBalance, double requiredBalance, string message) : base(message)
        {
            AccountBalance = accountBalance;
            RequiredBalaтсу = requiredBalance;
        }

        //public InsufficientFundsException(string symbol, string message, Exception innerException) : base(message, innerException)
        //{
            
        //}
    }
}
