namespace _1.PriorityQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int childIndexer = data.Count - 1; // start at end
            while (childIndexer > 0)
            {
                int parentIndexer = (childIndexer - 1) / 2;
                if (data[childIndexer].CompareTo(data[parentIndexer]) >= 0)
                {
                    break;
                }

                T tmp = data[childIndexer];
                data[childIndexer] = data[parentIndexer];
                data[parentIndexer] = tmp;
                childIndexer = parentIndexer;
            }
        }

        public T Dequeue()
        {
            // assumes PriorityQueue is not empty
            int lastIndex = data.Count - 1; 
            T frontItem = data[0]; 
            data[0] = data[lastIndex];
            data.RemoveAt(lastIndex);

            --lastIndex; // last index (after removal)
            int parentIndex = 0; // start at front of PriorityQueue
            while (true)
            {
                int leftChildIndex = parentIndex * 2 + 1;
                if (leftChildIndex > lastIndex)
                {
                    break;
                }

                int rightChildIndex = leftChildIndex + 1;
                if (rightChildIndex <= lastIndex && data[rightChildIndex].CompareTo(data[leftChildIndex]) < 0)
                {
                    // if there is a rightChildIndex (leftChildIndex + 1), and it is smaller than left child, use the rightChildIndex instead
                    leftChildIndex = rightChildIndex;
                }

                if (data[parentIndex].CompareTo(data[leftChildIndex]) <= 0)
                {
                    break; 
                }

                T tmp = data[parentIndex];
                data[parentIndex] = data[leftChildIndex];
                data[leftChildIndex] = tmp; // swap parent and child
                parentIndex = leftChildIndex;
            }

            return frontItem;
        }

        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }

        public int Count()
        {
            return data.Count;
        }

        public override string ToString()
        {
            string result = string.Join(", ",this.data);

            result += " count = " + data.Count;
            return result;
        }

        public bool IsConsistent()
        {
            // is the heap property true for all data?
            if (data.Count == 0) return true;
            int lastIndex = data.Count - 1; // last index
            for (int parentIndex = 0; parentIndex < data.Count; ++parentIndex)
            {
                int leftChildIndex = 2 * parentIndex + 1;
                int rightChildIndex = 2 * parentIndex + 2;

                if (leftChildIndex <= lastIndex && data[parentIndex].CompareTo(data[leftChildIndex]) > 0)
                {
                    return false; // if leftChildIndex exists and it's greater than parent then bad.
                }

                if (rightChildIndex <= lastIndex && data[parentIndex].CompareTo(data[rightChildIndex]) > 0) return false; // check the right child too.
            }

            return true;
        }
    }
}