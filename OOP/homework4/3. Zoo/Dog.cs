using System;

class Dog:Animal, ISound
{
    public Dog(string name, int age, Sex sex)
        : base(name, age, sex)
    { }

    protected override string Sound { get { return "Bauuu"; } }
    public void Talk()
    {
        Console.WriteLine(Sound);
    }
}
