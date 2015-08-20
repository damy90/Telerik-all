using System;
using System.Collections;
using System.Collections.Generic;

class BinaryTreeImp<T>:IEnumerable<int>// : ICloneable
{
    public Node<T> Root { get; private set; }

    public BinaryTreeImp()
    {
        Root = null;
    }

    //public object Clone()
    //{
    //    return new BinaryTreeImp<T>();
    //}

    IEnumerator IEnumerable.GetEnumerator()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public IEnumerator<int> GetEnumerator()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void InsertNode(T value)
    {
        InsertNode(this.Root, value);
    }

    private void InsertNode(Node<T> currentNode, T value)
    {
        Node<T> newNode = new Node<T>(value);

        if (this.Root == null)
        {
            currentNode = this.Root = newNode;
        }

        if (newNode.Data < (dynamic)currentNode.Data)
        {
            if (currentNode.Left == null)
            {
                currentNode.Left = newNode;
            }

            else
            {
                currentNode = currentNode.Left;
                InsertNode(currentNode, value);
            }
        }
        else if (newNode.Data > (dynamic)currentNode.Data)
        {
            if (currentNode.Right == null)
            {
                currentNode.Right = newNode;
            }

            else
            {
                currentNode = currentNode.Right;
                InsertNode(currentNode, value);
            }
        }
    }

    public void DisplayTree()
    {
        DisplayTree(this.Root);
    }

    private void DisplayTree(Node<T> node)
    {
        if (node == null)
            return;

        DisplayTree(node.Left);
        System.Console.Write(node.Data + " ");
        DisplayTree(node.Right);
    }

    public Node<T> Search(Node<T> root)
    {

    }
}