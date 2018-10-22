using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    interface IIndexable<T>
    {
        T this[int index] { get; }
    }
}
