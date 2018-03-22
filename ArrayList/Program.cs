using System;

namespace DataStrucures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                linkedList.Add(i);
                linkedList.Add(10);
            }
            
            //linkedList.Print();
            linkedList.Remove(5);
            linkedList.Print();
            linkedList.Remove(3);
            linkedList.Print();
            linkedList.RemoveAll(10);
            linkedList.Print();
            linkedList.RemoveAll(2);
            linkedList.Print();
            

            Console.ReadLine();
        }
    }
}
