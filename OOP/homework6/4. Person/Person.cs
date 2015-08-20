using System;

//Create a class Person with two fields – name and age.
//Age can be left unspecified (may contain null value.
//Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

class Person
{
    private string name;
    private int? age;

    public Person(string name, int? age)
    {
        this.Name = name;
        this.Age = age;
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
                throw new ArgumentNullException("A name must be specified!");
            this.name = value;
        }
    }

    public int? Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value<0)
                throw new ArgumentOutOfRangeException("Age cannot be negative!");
            this.age = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Name: {0}\nAge: {1}", name, Age!=null ? Age.ToString():"Age is not specified");
    }
}
