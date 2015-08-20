

//Problem 5. Generic class
//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index,
//inserting element at given position, clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.
//
//Problem 6. Auto-grow
//Implement auto-grow functionality: when the internal array is full, create a new array of
//double size and move all elements to it.
//
//Problem 7. Min and Max
//Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
//You may need to add a generic constraints for the type T.



namespace Generic
{
    using System;
    using System.Text;

    public class GenericList<T>
        where T : IComparable<T>
    {
        private T[] array;
        private int capacity;
        private int length;
        public GenericList(int capacity = 0)
        {
            this.Capacity = capacity;
            this.Array = new T[Capacity];
            this.Length = 0;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public T[] Array
        {
            get
            {
                return this.array;
            }
            set
            {
                this.array = value;
            }
        }
        public int Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                this.length = value;
            }
        }



        public void ListAdd(T element)
        {
            if (this.length == capacity)
            {
                if (capacity == 0)
                {
                    capacity = capacity + 1;
                    length = length + 1;
                }
                else
                {
                    this.capacity = capacity * 2;
                    length++;
                }
                AutoGrow(capacity);
            }
            else
            {
                length++;
            }

            this.array[length - 1] = element;
        }


        public void AutoGrow(int capacity)
        {
            T[] cloned = array.Clone() as T[];
            this.array = new T[capacity];
            for (int i = 0; i < cloned.Length; i++)
            {
                this.array[i] = cloned[i];
            }
        }


        public T Access(int index)
        {
            T element;
            if (index < 0 || index > this.length - 1)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            else
            {
                return element = this.array[index];
            }
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.length - 1)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            else
            {
                int offset = 0;
                T[] newArray = new T[this.length];
                for (int i = 0; i < this.length; i++)
                {
                    if (i != index)
                    {
                        newArray[i - offset] = this.array[i];
                    }
                    if (i == index)
                    {
                        offset = 1;
                    }
                }
                this.array = newArray;
                this.length--;
            }
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index > this.length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            else
            {
                int offset = 0;
                T[] newArray = new T[this.length + 1];
                for (int i = 0; i <= this.length; i++)
                {
                    if (i != index)
                    {
                        newArray[i] = this.array[i - offset];
                    }
                    if (i == index)
                    {
                        offset = 1;
                        newArray[i] = value;
                    }
                }
                this.array = newArray;
                this.length++;
                if (this.length == capacity)
                {
                    AutoGrow(capacity * 2);
                }
            }
        }

        public void Clear()
        {
            capacity = 0;
            length = 0;
            this.array = new T[this.length];
        }

        public int GetIndexByValue(T value)
        {

            int index = -1;
            for (int i = 0; i < this.length; i++)
            {
                if (this.array[i].CompareTo(value) == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Length; i++)
            {
                sb.AppendFormat("Position[{0}]: Element value = {1}", i, array[i]).AppendLine();
            }
            return sb.ToString();
        }

        public dynamic Max<T>()
        {
            dynamic maxValue=this.array[0];
            for (int i = 0; i < this.length; i++)
            {
                if (this.array[i].CompareTo(maxValue)>0)
                {
                    maxValue = this.array[i];
                }
            }
            return maxValue;
        }
        public dynamic Min<T>()
        {
            dynamic minValue = this.array[0];
            for (int i = 0; i < this.length; i++)
            {
                if (this.array[i].CompareTo(minValue) < 0)
                {
                    minValue = this.array[i];
                }
            }
            return minValue;
        }
    }
}
