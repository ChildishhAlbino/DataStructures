using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class LengthComparer : IComparer<String>
    {
        public int Compare(string x, string y)
        {
            try
            {
                if (x.Length < y.Length)
                {
                    return -1;
                }
                else if (x.Length > y.Length)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (NullReferenceException ex)
            {
                if (x is null && !(y is null))
                {
                    return -1;
                }
                else if (y is null && !(x is null))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            ConnorArrayList<String> list = new ConnorArrayList<String>();
            list.add("This is a medium length setence!");
            list.add("This is a really really long setence!");
            list.add("This is a short setence!");

            list.Print();
            list.Sort(new LengthComparer());
            list.Print();
            Console.ReadLine();
        }
    }
}
