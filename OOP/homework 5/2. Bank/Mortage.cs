//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
public class Mortage : Account
{
    public Mortage(Customer customer, decimal balance, decimal intrestRate)
        : base(customer, balance, intrestRate)
    {
    }

    //the balance for this account is what you owe to the bank. Hence depositing decreases it.
    public override void Deposit(decimal amount)
    {
        balance -= amount;
    }

    public override decimal CalcInterestAmount(int months)
    {
        if (customer.Type == CustomerType.Company)
        {
            if (months <= 12)
                return base.CalcInterestAmount(months) / 2;
            else
                return CalcInterestAmount(12) + base.CalcInterestAmount(months - 12);
        }
        else
        {
            if (months <= 6)
                return base.CalcInterestAmount(months) / 2;
            else
                return CalcInterestAmount(6) + base.CalcInterestAmount(months - 6);
        }
    }
}