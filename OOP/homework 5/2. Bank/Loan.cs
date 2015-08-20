//Loan and mortgage accounts can only deposit money.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.

public class Loan : Account
{
    private const int promoPerionIndividual = 3;
    private const int promoPerionCompany = 2;
    public Loan(Customer customer, decimal balance, decimal intrestRate)
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
        if (months < 0)
            throw new InvalidPeriodException("Invalid period");
        if (customer.Type == CustomerType.Individual)
        {
            if (months > promoPerionIndividual)
                return CalcInterestAmount(promoPerionIndividual) + base.CalcInterestAmount(months - promoPerionIndividual);
            else
                return 0;
        }
        else
        {
            if (months > promoPerionCompany)
                return CalcInterestAmount(promoPerionCompany) + base.CalcInterestAmount(months - promoPerionCompany);
            else
                return 0;
        }
    }
}