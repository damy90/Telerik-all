public enum CustomerType
{
    Individual,
    Company
}

public class Customer
{
    private string Name;
    public CustomerType Type{get; private set;}

    public Customer(string name, CustomerType type)
    {
        this.Name = name;
        this.Type = type;
    }
}