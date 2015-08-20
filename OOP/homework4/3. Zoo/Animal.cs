using System;

public abstract class Animal
{
    private string name;
    private int age;
    private Sex sex;

    protected abstract string Sound { get; }

    public Animal(string name, int age, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Age must be a positive number");
            this.age = value;
        }
    }

    public Sex Sex
    {
        get
        {
            return this.sex;
        }
        set
        {
            this.sex = value;
        }
    }
}
