using System;

public class Chef
{
    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();
        Bowl bowl;
        Peel(potato);
        Peel(carrot);
        bowl = GetBowl();
        Cut(potato);
        Cut(carrot);
        bowl.Add(carrot);
        bowl.Add(potato);
    }

    private void Peel(Vegetable vegetable)
    {
        throw new NotImplementedException();
    }

    private Potato GetPotato()
    {
        throw new NotImplementedException();
    }

    private Carrot GetCarrot()
    {
        throw new NotImplementedException();
    }

    private Bowl GetBowl()
    { 
        throw new NotImplementedException();
    }

    private void Cut(Vegetable vegetable)
    {
        throw new NotImplementedException();
    }
}