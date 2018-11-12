using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Office
    {
        public delegate void ComeDelegate(Employee o, OnComeEventArgs args);
        public event ComeDelegate Come;

        public delegate void LeaveDelegate(Employee e, EventArgs args);
        public event LeaveDelegate Leave;

        public void OnCome(Employee e, OnComeEventArgs args)
        {
            Come?.Invoke(e, args);

            Come += e.SayHi;
            Leave += e.SayGoodby;
        }

        public void OnLeave(Employee e, EventArgs args)
        {
            if (Leave != null)
                Leave -= e.SayGoodby;

            Leave?.Invoke(e, args);
        }
    }
}
