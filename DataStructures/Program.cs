using System;

namespace DataStrucures
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList<String> arrayList = new MyArrayList<String>();
            arrayList.add("Connor");
            for (int i = 0; i < 10; i++)
            {
                arrayList.add("Connor");
            }
            arrayList.add("Jack");
            arrayList.add("Chris");
            arrayList.Remove("Chris");
            arrayList.RemoveAll("Connor");
            Console.WriteLine(arrayList.GetSize());

            MyArrayList<int> intArrayList = new MyArrayList<int>(10);
            intArrayList.add(1);
            for (int i = 0; i < 10; i++)
            {
                intArrayList.add(10);
            }

        }
    }
}
