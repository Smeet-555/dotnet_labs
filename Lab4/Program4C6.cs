using System;

namespace ConsoleApp1.Lab4
{
    public class Program4C6
    {
        class BankAccount
        {
            private int accountNumber;
            private string holderName;
            private double balance;

            public BankAccount(int accNum, string name, double bal)
            {
                accountNumber = accNum;
                holderName = name;
                balance = bal;
            }

            public int GetAccountNumber()
            {
                return accountNumber;
            }

            public string GetHolderName()
            {
                return holderName;
            }

            public double GetBalance()
            {
                return balance;
            }

            public void Deposit(double amount)
            {
                balance += amount;
            }

            public void Withdraw(double amount)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance!");
                }
            }
        }

        class BankTransaction
        {

            public void Transfer(BankAccount from, BankAccount to, double amount)
            {
                if (from.GetBalance() >= amount)
                {
                    from.Withdraw(amount);
                    to.Deposit(amount);
                    Console.WriteLine($"Transferred {amount} from Account {from.GetAccountNumber()} ({from.GetHolderName()}) to Account {to.GetAccountNumber()} ({to.GetHolderName()})");
                }
                else
                {
                    Console.WriteLine("Transfer failed: Insufficient balance!");
                }
            }

            public void Transfer(BankAccount from, BankAccount to, double amount, string description)
            {
                if (from.GetBalance() >= amount)
                {
                    from.Withdraw(amount);
                    to.Deposit(amount);
                    Console.WriteLine($"Transferred {amount} from Account {from.GetAccountNumber()} ({from.GetHolderName()}) to Account {to.GetAccountNumber()} ({to.GetHolderName()}) for {description}");
                }
                else
                {
                    Console.WriteLine("Transfer failed: Insufficient balance!");
                }
            }
        }

        public static void Run()
        {
            Console.WriteLine("Bank Transaction System - Method Overloading Demo");
            Console.WriteLine("--------------------------------------");

            BankAccount acc1 = new BankAccount(101, "Smit", 5000);
            BankAccount acc2 = new BankAccount(102, "asdfgh", 3000);

            Console.WriteLine($"\nInitial Balances:");
            Console.WriteLine($"{acc1.GetHolderName()} (Account {acc1.GetAccountNumber()}): {acc1.GetBalance()}");
            Console.WriteLine($"{acc2.GetHolderName()} (Account {acc2.GetAccountNumber()}): {acc2.GetBalance()}");

            BankTransaction transaction = new BankTransaction();

            Console.WriteLine($"\nPerforming Transfers:");
            transaction.Transfer(acc1, acc2, 1000);
            transaction.Transfer(acc1, acc2, 500, "Rent Payment");

            Console.WriteLine($"\nFinal Balances:");
            Console.WriteLine($"{acc1.GetHolderName()} Balance: {acc1.GetBalance()}");
            Console.WriteLine($"{acc2.GetHolderName()} Balance: {acc2.GetBalance()}");
        }
    }
}
