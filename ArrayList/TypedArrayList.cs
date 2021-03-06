﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class ConnorArrayList<T>
    {
        public int index = 0;
        public T[] array;

        public ConnorArrayList()
        {
            array = new T[1];
        }

        public ConnorArrayList(int size)
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

        public void Sort(IComparer<T> c)
        {
            Array.Sort(array, c);
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

        public bool Contains(T value)
        {
            for (int i = 0; i < GetSize() - 1; i++)
            {
                if (array[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }


        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    Console.WriteLine(array[i]);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Null");
                }    
            }
        }
    }
}
