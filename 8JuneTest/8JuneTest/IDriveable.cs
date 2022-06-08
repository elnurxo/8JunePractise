using System;
using System.Collections.Generic;
using System.Text;

namespace _8JuneTest
{
    interface IDriveable
    {
        void Drive(double km);

        void Show()
        {
            Console.WriteLine("HEY THERE!");
        }
    }
}
