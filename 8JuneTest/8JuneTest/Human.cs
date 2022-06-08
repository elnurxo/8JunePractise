using System;
using System.Collections.Generic;
using System.Text;

namespace _8JuneTest
{
    class Human
    {
        public string Name;
        public byte Age;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name - {Name}, Age - {Age}");
        }
    }
}
