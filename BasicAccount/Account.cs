using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BasicAccount
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return "Account: " + Number + ", Holder: " + Holder + ", Balance : $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
