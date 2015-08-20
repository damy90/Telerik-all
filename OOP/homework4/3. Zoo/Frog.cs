using System;

class Frog : Animal, ISound
{
    public Frog(string name, int age, Sex sex)
        : base(name, age, sex)
    { }

    protected override string Sound { get { return "If you kiss me I will turn into a princess"; } }
    public void Talk()
    {
        Console.WriteLine(Sound);
    }
}
