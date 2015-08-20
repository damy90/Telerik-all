using System;

class Node<T>// : ICloneable 
{
    public T Data;
    public Node<T> Left, Right;

    public Node(T data)
    {
        this.Data = data;
        Left = null;
        Right = null;
    }
    //object ICloneable.Clone()
    //{
    //    return this.Clone();
    //}

    //public Node<T> Clone()
    //{
    //    return new Node<T>(this.Data);
    //}
}