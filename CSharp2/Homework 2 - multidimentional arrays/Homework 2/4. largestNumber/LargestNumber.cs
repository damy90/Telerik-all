using System;
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K
class LargestNumber
    {
        static void Main()
        {
            int result;
            Console.Write("Please enter length of the array: ");
            //calling method for reading and validating input (try typing a negative number or a string for the size of the array)
            int length = ValidIntInput(0);//read a positive number
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Please enter array element {0}: ", i);
                array[i] = ValidIntInput(int.MinValue);
            }
            Console.Write("Please enter K: ");
            int K = ValidIntInput(int.MinValue);
            
            Array.Sort(array);

            if ( array[0] <= K )
            {
                int IndexOfElement = Array.BinarySearch(array, K);
                if (IndexOfElement >= 0)//there is an element with value K
                    result = array[IndexOfElement];
                else //there is an element with value less than K
                    result = array[~IndexOfElement - 1];
                Console.WriteLine("The greatest number <= K is: {0}", result);
            }
            else
                Console.WriteLine("There is no number that is less than or equal to K.");
        }

        //input and validation
        static int ValidIntInput(int min=int.MinValue, int max=int.MaxValue)
        {
            int value;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out value)&& value>=min)
                    break;
                Console.Write("Please enter an integer value between {0} and {1}: ", min, max);
            }
            return value;
        }
    }
