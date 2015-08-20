using System;
class Person
{
    private string name;
    public Person(string name)
    {
        this.Name = name;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Length < 4)
                throw new ArgumentException("The name must be at least 4 characters long");
            this.name = value;
        }
    }
}
