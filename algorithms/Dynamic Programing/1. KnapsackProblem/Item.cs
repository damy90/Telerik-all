using System;


namespace _1.KnapsackProblem
{
    public class Item
    {

        public string Description;
        public int Weight;
        public int Value;
        public int Quantity;

        public Item(string description, int weight, int value, int quantity)
        {
            Description = description;
            Weight = weight;
            Value = value;
            Quantity = quantity;
        }

    }
}
