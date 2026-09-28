using System.Linq.Expressions;

namespace DesingPatternOOP.src.oopPrinciple.Encapsulations;

public class BankAccount
{
   private decimal balance;

   public  BankAccount(decimal initialBalance)
   {
       this.balance = initialBalance;
    //    Deposit(initialBalance);
   }

   public decimal Balance()
    {
        return balance;
    }

   public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative.");
        }
        this.balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds for withdrawal.");
        }

        this.balance -= amount;
        
    }
}
