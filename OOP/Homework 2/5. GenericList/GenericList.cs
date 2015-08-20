using System;
using System.Linq;

//5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.
//6. Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
//7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
//You may need to add a generic constraints for the type T.

class GenericList<T> where T : IComparable, new()
{
    private T[] elements;
    private int capacity;
    private int count;

    public GenericList(int capacity)
    {
        this.capacity = capacity;
        this.elements = new T[this.capacity];
        this.count = 0;
    }

    public int Count
    {
        get
        {
            return this.count;
        }
    }

    public T[] Elements
    {
        get
        {
            return this.elements;
        }
    }

    public int Capacity
    {
        get
        {
            return this.capacity;
        }
    }

    public void Add(T element)
    {
        if (this.count == this.capacity - 1)
        {
            GrowCapacity();
        }

        elements[this.count] = element;
        this.count++;
    }

    public T this[int index]
    {
        get
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            T result = elements[index];
            return result;
        }
    }

    public void RemoveAt(int index)
    {
        if (index >= count || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        for (int i = index; i < count; i++)
        {
            this.elements[i] = this.elements[i + 1];
        }

        count--;
    }

    public void Insert(int index, T element)
    {
        if (index > count || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        if (this.count == this.capacity - 1)
        {
            GrowCapacity();
        }

        for (int i = count; i > index; i--)
        {
            this.elements[i] = this.elements[i - 1];
        }

        this.elements[index] = element;
        this.count++;
    }

    public void Clear()
    {
        this.elements = new T[capacity];
        count = 0;
    }

    public int IndexOf(T element)
    {
        for (int i = 0; i < this.count; i++)
        {
            if (this.elements[i].Equals(element))
            {
                return i;
            }
        }
        return -1;
    }

    public override string ToString()
    {
        var elementsToString=new T[count];
        Array.Copy(this.elements, elementsToString, count);
        return string.Join(", ", elementsToString);
    }

    private void GrowCapacity()
    {
        this.capacity *= 2;
        Array.Resize(ref this.elements, capacity);
    }

    public T Min()
    {
        return this.elements.Min();
    }

    public T Max()
    {
        return this.elements.Max();
    }
}
