﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _8JuneTest
{
    class Employee:Human
    {
        public string Position;

        public override void ShowInfo()
        {
            Console.WriteLine($"Name - {Name}, Age - {Age}, Position - {Position}");
        }
    }
}
