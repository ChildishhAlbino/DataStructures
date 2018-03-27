using System;
namespace DataStructures
{
    public class MyArrayList<T>
    {
        public int index = 0;
        public T[] array;

        public MyArrayList()
        {
            array = new T[1];
        }

        public MyArrayList(int size)
        {
            array = new T[size];
        }

        public void add(T value)
        {
            if (index >= array.Length) { Resize(array.Length * 2); }
            array[index] = value;
            index++;
        }

        public string get(int Index)
        {
            if (!(Index > array.Length))
            {
                return array[Index].ToString();
            }
            else
            {
                return "Index was outside array";
            }
        }

        public void Resize(int size)
        {
            Array.Resize(ref array, size);
        }

        public void Remove(T Value)
        {
            Remove(Value, false);
        }

        public void RemoveAll(T Value)
        {
            Remove(Value, true);
        }

        private void Remove(T value, bool all)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array.GetValue(i) != null && array.GetValue(i).Equals(value))
                {
                    array[i] = default(T);
                    Resize(array.Length - 1);
                    if (!all)
                    {
                        return;
                    }

                }
            }
        }

        public int GetSize()
        {
            return array.Length;
        }

    }
}
