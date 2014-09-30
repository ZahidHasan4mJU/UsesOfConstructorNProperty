using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankingProblem
{
    internal class Account
    {
        private string accNum;
        private string custName;
        private double balance;// = 0;

        public Account()
        {
            balance = 0;
        }

        public Account(string accNum, string custName)
        {
            AccountNum = accNum;
            CustName = custName;
           // Balance = balance;
        }
        public string AccountNum
        {
            set
            {
                accNum = value;
            }
            get
            {
                return accNum;
            }
        }

        public string CustName
        {
            set
            {
                custName = value;
            }
            get
            {
                return custName;
            }

        }

        public double Balance 
        {
            get
            {
                return balance;
            }
        }
        public double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }

        public double Withdraw(double amount)
        {
            balance -= amount;
            return balance;
        }
        
    
}
}
