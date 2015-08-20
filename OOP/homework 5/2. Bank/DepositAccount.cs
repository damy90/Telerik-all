//Deposit accounts are allowed to deposit and with draw money.
//Deposit accounts have no interest if their balance is positive and less than 1000.

public class DepositAccount : Account, IWithdraw
{
    public DepositAccount(Customer customer, decimal balance, decimal intrestRate) : base(customer, balance, intrestRate) { }

    public override void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        balance -= amount;
    }
    public override decimal CalcInterestAmount(int months)
    {
        if (balance < 1000)
            return 0;
        return base.CalcInterestAmount(months);
    }
}