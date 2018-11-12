using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class OnComeEventArgs : EventArgs
    {
        public string Name { get; private set; }
        public int Hours { get; private set; }

        public OnComeEventArgs(string name, int hours)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));

            if (hours < 0 || hours > 24)
                throw new ArgumentOutOfRangeException(nameof(hours));

            Hours = hours;
        }
    }
}
