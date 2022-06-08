using System;
using System.Collections.Generic;
using System.Text;

namespace _8JunePractise.Classes
{
    class Restaurant
    {
        public string Name;
        public Alcohol[] Alcoholdrinks;
        public Coffee[] Coffeedrinks;

        public Alcohol MaxAlcohol()
        {
            double percentage = Alcoholdrinks[0].SpirtPercentage;
            Alcohol drink = null;
            for (int i = 1; i < Alcoholdrinks.Length; i++)
            {
                if (percentage < Alcoholdrinks[i].SpirtPercentage)
                {
                    drink = Alcoholdrinks[i];
                }
            }
            return drink;
        }
    }
}
