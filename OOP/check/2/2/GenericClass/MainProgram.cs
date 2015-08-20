namespace Generic
{
    using System;
    public class MainProgram
    {
        public static void Main()
        {
            GenericList<int> newList = new GenericList<int>();
            while (true)
            {
                Console.WriteLine("Enter number for adding to the Generic list OR \"end\":");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                newList.ListAdd(int.Parse(input));
            }
           
            while (true)
            {
                Console.WriteLine("Enter index which value you want to get from the Generic list OR \"end\":");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                int index=int.Parse(input);
                Console.WriteLine("The element with index {0} in the Generic list is {1}.",index,newList.Access(index));
            }

            while (true)
            {
                Console.WriteLine("Enter index which value you want to remove from the Generic list OR \"end\":");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                int index = int.Parse(input);
                newList.Remove(index);
            }
            while (true)
            {
                Console.WriteLine("Enter index and value which you want to insert at the Generic list OR \"end\":");
                Console.Write("Index: ");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                int index = int.Parse(input);
                Console.Write("Value:");
                int value = int.Parse(Console.ReadLine());
                newList.Insert(index,value);
            }

            Console.WriteLine("Do you want to clear the Generic list (\"Yes\" ot \"No\"):");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                newList.Clear();
                Console.WriteLine("The array is cleared");
            }
            else
            {
                Console.WriteLine("The array is NOT cleared.");
            }

            while (true)
            {
                Console.WriteLine("Enter value which will be searched at the Generic list OR \"end\":");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                int value = int.Parse(input);
                Console.WriteLine("The value {0} has index {1} in the Generic list.", value, newList.GetIndexByValue(value));
            }
            if (newList.Length > 0)
            {
                Console.WriteLine("The maximal value in the Generic list is {0}", newList.Max<int>());
                Console.WriteLine("The minimal value in the Generic list is {0}", newList.Min<int>());
            }
            else
            {
                Console.WriteLine("The generic list is empty.");
            }

        }
    }
}
