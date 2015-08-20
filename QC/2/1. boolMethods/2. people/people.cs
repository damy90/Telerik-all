using System;
using System.Linq;

public enum Gender
{
    Male,
    Female
}

public class MainClass
{
    public void MakePerson(int age)
    {
        Person instanceOfPerson = new Person();
        instanceOfPerson.Age = age;

        // Assuming targeted audiance is bulgarian and the software is an April fools joke
        if (age % 2 == 0)
        {
            instanceOfPerson.Name = "Батката";
            instanceOfPerson.Sex = Gender.Male;
        }
        else
        {
            instanceOfPerson.Name = "Мацето";
            instanceOfPerson.Sex = Gender.Female;
        }
    }

    public class Person
    {
        public Gender Sex { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}