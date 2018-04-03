using System;
using System.Collections;

namespace DataStructures
{
    class Program
    {

        static void Main(string[] args)
        {
            HashMap<int> hashMap = new HashMap<int>();
            hashMap.Add("oggod", 10);
            hashMap.Add("doggo", -10);

            hashMap.Remove("doggo");
            Console.ReadLine();
        }
    }
}
