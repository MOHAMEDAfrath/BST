using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BST");
            BSTOperations<int> bST = new BSTOperations<int>(56);
            bST.Insert(30);
            bST.Insert(70);
            Console.WriteLine("Display using inorder traversal:");
            bST.Display();
            Console.WriteLine(" ");
        }
    }
}
