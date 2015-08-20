using System;
public abstract class Human
{
    private string name;
    private string lastName;

    public Human(string name, string lastName)
    {
        this.Name = name;
        this.LastName = lastName;
    }
    
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Names must have at leas one letter");
            }
            this.name = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Names must have at leas one letter");
            }
            this.lastName = value;
        }
    }
}
