using System;

//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
class Program
{
    static void Main()
    {
        Customer examplePerson = new Customer("Example Person", CustomerType.Individual);
        Customer exampleCompany = new Customer("Example Company", CustomerType.Company);

        DepositAccount deposit = new DepositAccount(examplePerson, 1200, (decimal)0.02);
        int period = 2;
        Console.WriteLine("Interest for: {0}, account type: {1}, balance: {2}, period: {3} months, interest rate: {4}%\n{5}%",
            deposit.Customer, deposit.GetType(), deposit.Balance, period, deposit.IntrestRate, deposit.CalcInterestAmount(period));

        deposit.Withdraw(300);
        Console.WriteLine("Interest for: {0}, account type: {1}, balance: {2}, period: {3} months, interest rate: {4}%\n{5}%",
            deposit.Customer, deposit.GetType(), deposit.Balance, period, deposit.IntrestRate, deposit.CalcInterestAmount(period));

        deposit.Deposit(1000);
        Console.WriteLine("Test depositing money balance: {0}", deposit.Balance);

        period = 3;
        Loan loan = new Loan(examplePerson, 1200, (decimal)0.02);
        Console.WriteLine("Interest for: {0}, account type: {1}, balance: {2}, period: {3} months, interest rate: {4}%\n{5}%",
            loan.Customer, loan.GetType(), loan.Balance, period, loan.IntrestRate, loan.CalcInterestAmount(period));

        period = 4;
        Console.WriteLine("Interest for: {0}, account type: {1}, balance: {2}, period: {3} months, interest rate: {4}%\n{5}%",
            loan.Customer, loan.GetType(), loan.Balance, period, loan.IntrestRate, loan.CalcInterestAmount(period));

        loan.Deposit(1200);
        Console.WriteLine("After repaying the loan the balance is: {0}", loan.Balance);

        //invalid period test
        //Console.WriteLine(loan.CalcInterestAmount(-3));
    }
}
