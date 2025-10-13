using System;

namespace CSharp_Learning
{
    internal class Program
    {
        // Bank Account System - Different account types (Savings, Current, FixedDeposit) have common operations (Deposit, Withdraw), but their rules differ.
        // ABSTRACTION — common interface for all payment types
        public abstract class BankAccount
        {
            public string AccountNumber { get; set; }
            public decimal Balance { get; set; }
            public virtual void Deposit(decimal amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
            }
            public abstract void Withdraw(decimal amount);
        }

        public class SavingsAccount : BankAccount
        {
            public override void Withdraw(decimal amount)
            {
                if (Balance - amount < 1000)
                {
                    Console.WriteLine("Minimum balance of 1000 must be maintained.");
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawn {amount}. New Balance: {Balance}");
                }
            }
        }

        public class CurrentAccount :BankAccount
        {
            public override void Withdraw(decimal amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount}. New Balance: {Balance}");
            }
        }


        static void Main(string[] args)
        {

            SavingsAccount sw = new SavingsAccount();
            sw.Deposit(2000);

            CurrentAccount cw = new CurrentAccount();
            cw.Deposit(5000);
            cw.Withdraw(100);

            Console.ReadKey();
        }
    }
}
