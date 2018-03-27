using System;

namespace DataStructures
{
    class Program
    {        
        
        static void Main(string[] args)
        {
            BinaryTree<int> b = new BinaryTree<int>();

            b.Add(10);
            b.Add(12);
            b.Add(9);

            Console.ReadLine();
        }
    }
}
