using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    interface IIndexable<T>
    {
        T this[int index] { get; }
    }
}
