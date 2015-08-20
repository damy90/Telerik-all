using System;

class Cat : Animal, ISound
{
    protected override string Sound { get; set; }

    public Cat(string name, int age, Sex sex)
        : base(name, age, sex)
    {
        Sound = "Miauuu";
    }

    
    public void Talk()
    {
        Console.WriteLine(Sound);
    }
}
