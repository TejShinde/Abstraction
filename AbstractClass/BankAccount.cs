using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class BankAccount
    {
        public abstract void Deposit(double amt);
        public abstract void Withdraw(double amt);
    }

    class SavingAccount : BankAccount
    {
        private double balance;

        public SavingAccount()
        {
            balance = 0;
        }

        public override void Deposit(double amt)
        {
            balance += amt;
            Console.WriteLine($"Deposited {amt} to saving account.Current balance: {balance}");
        }
        public override void Withdraw(double amt)
        {
            if (amt > balance)
            {
                Console.WriteLine("Insufficient balance in saving account");
            }
            else
            {
                balance = balance - amt;
                Console.WriteLine($"Withdraw {amt} from saving account.Current balance: {balance}");
            }
        }

        public class CurrentAccount : BankAccount
        {
            private double balance;

            public CurrentAccount()
            {
                balance = 0;
            }
            public override void Deposit(double amt)
            {
                balance += amt;
                Console.WriteLine($"Deposited {amt} to current account.Current balance: {balance}");
            }

            public override void Withdraw(double amt)
            {
                if (amt > balance)
                {
                    Console.WriteLine("Insufficient balance in current account");
                }
                else
                {
                    balance = balance - amt;
                    Console.WriteLine($"Withdraw {amt} from current account.Current balance: {balance}");
                }
            }
        }
    }

}
