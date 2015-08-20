using System;

//Not finished!
class Program
{
    static void Main()
    {
        BinaryTreeImp<int> binaryTree = new BinaryTreeImp<int>();
        
        binaryTree.InsertNode(5);
        binaryTree.InsertNode(6);
        binaryTree.InsertNode(10);
        binaryTree.InsertNode(2);
        binaryTree.InsertNode(3);
        binaryTree.InsertNode(1);
        binaryTree.InsertNode(15);

        binaryTree.DisplayTree();
    }
}