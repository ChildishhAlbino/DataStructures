using System;
using System.Collections;

namespace DataStructures
{
    class Program
    {

        static void Main(string[] args)
        {
            BinaryTree<int> b = new BinaryTree<int>();

            for (int i = 0; i < 11; i++)
            {
                Random r = new Random();
                ArrayList quicklist = new ArrayList();
                int j = r.Next(0, 10);   
                if (!quicklist.Contains(j))
                {
                    quicklist.Add(j);
                    b.Add(j);
                }

            }

            b.Print();
            Console.ReadLine();
        }
    }
}
