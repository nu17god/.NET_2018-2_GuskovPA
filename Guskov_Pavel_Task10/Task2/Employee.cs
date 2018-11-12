using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Employee
    {
        public delegate void ComeEvenDelegate(Employee o, OnComeEventArgs args);
        public event ComeEvenDelegate Come;

        public delegate void LeaveEvenDelegate(Employee o, EventArgs args);
        public event LeaveEvenDelegate Leave;

        public string Name { get; private set; }
        public Office Office { get; private set; }

        public Employee(string name, Office office)
        {
            Name = name;
            Office = office ?? throw new ArgumentNullException(nameof(office));

            Come += office.OnCome;
            Leave += office.OnLeave;
        }

        public void SayHi(Employee e, OnComeEventArgs args)
        {
            string hello;

            if (args.Hours < 12)
                hello = "Good morning";
            else if (args.Hours > 12 && args.Hours < 17)
                hello = "Good day";
            else
                hello = "Good evening";


            Console.WriteLine($"{hello}, {args.Name} - Said {Name}");
        }

        public void SayGoodby(Employee e, EventArgs args)
        {
            Console.WriteLine($"Goodby,{e.Name} - Said {Name}");
        }

        public void GoToOffice(int time)
        {
            Come?.Invoke(this, new OnComeEventArgs(Name, time));
        }

        public void GoHome()
        {
            Leave?.Invoke(this, new EventArgs());
        }

        public void Leaved(Employee person)
        {
            Come -= person.SayHi;
        }
    }
}
