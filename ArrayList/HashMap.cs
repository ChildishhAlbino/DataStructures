using System;
using System.Security.Cryptography;

namespace DataStructures
{
    public class HashMap<U>
    {
        private U[] array;

        public HashMap()
        {
            array = new U[1];
        }

        public void Add(string key, U value)
        {
            int index = Hash(key);
            while (array.Length < index)
            {
                Resize();
            }

            array[index] = value;
            Console.WriteLine($"{key} has been hashed to {Hash(key)} and value: {value} has been stored.");
        }
        public void Remove(string key)
        {

            Console.WriteLine($"{key} which was hashed to {Hash(key)} and it's value of: {Get(key)} has been removed.");
            array[Hash(key)] = default(U);
        }
        public U Get(string key)
        {
            return array[Hash(key)];
        }
        private int Hash(string key)
        {
            int index = 0;
            int i = 0;
            foreach (char c in key)
            {
                i++;
                int pseudorandom = c ^ i;
                index += (int)Math.Pow(c, key.IndexOf(c) + 1) + i;

            }
            int scramble = 0;
            for (int j = 0; j < index.ToString().Length; j += 2)
            {
                if (j < index.ToString().Length)
                {
                    scramble += index.ToString()[j] * j;
                }

            }
            return scramble;
        }

        private void Resize()
        {
            Array.Resize<U>(ref array, array.Length * 2);
        }


    }
}