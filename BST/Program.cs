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
            bST.Insert(22);
            bST.Insert(40);
            bST.Insert(11);
            bST.Insert(3);
            bST.Insert(16);
            bST.Insert(60);
            bST.Insert(95);
            bST.Insert(65);
            bST.Insert(63);
            bST.Insert(67);
            Console.WriteLine("Display using inorder traversal:");
            bST.Display();
            bST.SizeOfTree();
            bool result = bST.Search(63, bST);
            if (!result)
            {
                Console.WriteLine("Not Found");

            }
            Console.WriteLine(" ");
        }
    }
}
