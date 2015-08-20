namespace MyCollections
{
    using System;
    using System.Text;
    

    //Problem 5. Generic class
    //Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    //Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    //Implement methods for adding element, accessing element by index, removing element by index, inserting element at 
    //given position, clearing the list, finding element by its value and ToString().
    //Check all input parameters to avoid accessing elements at invalid positions.

    public class GenericList<T> where T : IComparable<T>
    {
#region Field
        private T[] elements;
        private int index;
        private int capacity;
        #endregion

#region Constructors
        public GenericList(int capacity)
        {

            this.Capacity = capacity;
            this.elements = new T[this.Capacity];
            this.Index = 0;
        }
#endregion

#region Properties
        public int Index { get; private set; }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (capacity < 0)
                {
                    throw new ArgumentOutOfRangeException("The capacity can not be negative.");
                }
                this.capacity = value;
            }
        }
#endregion

#region Method
        public void Add(T element)
        {
            AutoGrow();
            this.elements[this.Index] = element;
            this.Index++;
        }
        public T ElementAt(int index)
        {
            if (index < 0 || index >= Capacity)
            {
                throw new ArgumentOutOfRangeException("Index must be positive and less than the capacity.");
            }
            return this.elements[index];
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Capacity)
            {
                throw new ArgumentOutOfRangeException("Index must be positive and less than the capacity.");
            }
            this.Capacity--;
            T[] newElements = new T[this.Capacity];
            for (int i = 0; i < index; i++)
            {
                newElements[i] = elements[i];
            }
            for (int i = index + 1; i < elements.Length; i++)
            {
                newElements[i - 1] = elements[i];
            }
            elements = newElements;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index >= Capacity)
            {
                throw new ArgumentOutOfRangeException("Index must be positive and less than the capacity.");
            }
            T[] newElements = new T[this.Capacity];
            for (int i = 0; i < index; i++)
            {
                newElements[i] = elements[i];
            }
            newElements[index] = item;
            for (int i = index + 1; i < elements.Length; i++)
            {

                newElements[i] = elements[i - 1];
            }
            elements = newElements;
            this.Index++;
            AutoGrow();

        }
        public void Clear()
        {
            this.Capacity = 0;
            this.elements = new T[this.Capacity];
            this.Index = 0;
        }
        public int IndexOf(T item)
        {
            int idx = int.MinValue;
            int ind = 0;
            foreach (var el in this.elements)
            {

                if (item.CompareTo(el) == 0)
                {
                    idx = ind;
                }
                ind++;
            }

            return idx;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //foreach (var item in elements)
            //{
            //    sb.AppendFormat("{0}, ", item);
            //}
            for (int i = 0; i < this.Index-1; i++)
            {
                sb.AppendFormat("{0}, ", elements[i]);
            }

            return sb.ToString();
        }

        //    Problem 6. Auto-grow
        //Implement auto-grow functionality: when the internal array is full, create a new array of 
        //double size and move all elements to it.

        public void AutoGrow()
        {
            if (this.Capacity == 0)
            {
                this.Capacity = 1;
            }


            if (this.Index == this.Capacity)
            {
                this.Capacity *= 2;
            }


            T[] newArr = new T[this.Capacity];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newArr[i] = elements[i];
            }
            elements = newArr;
        }
    //    Problem 7. Min and Max
    //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
    //You may need to add a generic constraints for the type T.
        public T Min()
        {
            if (this.Index == 0)
            {
                throw new ArgumentException("There are no elements to compare.");
            }
            T min = this.elements[0];
            for (int i = 1; i < this.Index-1; i++)
            {
                if (min.CompareTo(this.elements[i]) >0)
                {
                    min = this.elements[i];
                } 
            }

            return min;
        }
        public T Max()
        {
            if (this.Index == 0)
            {
                throw new ArgumentException("There are no elements to compare.");
            }
            T max = this.elements[0];
            for (int i = 1; i < this.elements.Length; i++)
            {
                if (max.CompareTo(this.elements[i]) < 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }
#endregion
    }
}
