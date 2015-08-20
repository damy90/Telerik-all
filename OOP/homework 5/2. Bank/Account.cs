using System;

//All accounts have customer, balance and interest rate (monthly based).
//All accounts can calculate their interest amount for a given period (in months).
//In the common case its is calculated as follows: number_of_months * interest_rate.
public abstract class Account
{
    protected Customer customer;
    protected decimal balance;
    private readonly decimal intrestRate;

    public Account(Customer customer, decimal balance, decimal intrestRate)
    {
        this.customer = customer;
        this.balance = balance;
        this.intrestRate = intrestRate;
    }

    public Customer Customer
    {
        get
        {
            return this.customer;
        }
    }

    public decimal Balance
    {
        get
        {
            return this.balance;
        }
    }

    public decimal IntrestRate
    {
        get
        {
            return this.intrestRate;
        }
    }

    public abstract void Deposit(decimal amount);

    public virtual decimal CalcInterestAmount(int months)
    {
        return months * intrestRate;
    }
}