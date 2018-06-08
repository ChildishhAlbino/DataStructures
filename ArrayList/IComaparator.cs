using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public interface IComaparator<T>
    {
        int Compare(T o1, T o2);
    }
}
