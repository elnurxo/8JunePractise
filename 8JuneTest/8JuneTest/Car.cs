using System;
using System.Collections.Generic;
using System.Text;

namespace _8JuneTest
{
    class Car : IDriveable
    {
        public void Drive(double km)
        {
            Console.WriteLine($"I am car, km - {km}");
        }
    }
}
