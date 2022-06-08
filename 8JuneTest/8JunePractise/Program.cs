using _8JunePractise.Classes;
using _8JunePractise.Extensions;
using System;

namespace _8JunePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = "salam";

            //int[] newArr =  word.FindIndexes('s');
            // foreach (var item in newArr)
            // {
            //     if (item==-1)
            //     {
            //         Console.WriteLine("no such a letter found!");
            //     }
            //     else
            //     {
            //         Console.WriteLine(item);
            //     }

            // }

            int num = 5;
            num = num.FindPower(4);
            Console.WriteLine(num);


            Alcohol alcohol1 = new Alcohol() { SpirtPercentage = 21 };
            Alcohol alcohol2 = new Alcohol() { SpirtPercentage = 45};
            Alcohol alcohol3 = new Alcohol() { SpirtPercentage = 26 };
            Alcohol alcohol4 = new Alcohol() { SpirtPercentage = 78 };
            Alcohol[] alcohols = { alcohol1, alcohol2, alcohol3, alcohol4 };
            Restaurant Starbucks = new Restaurant()
            {
                Name = "Starbucks",
                Alcoholdrinks = alcohols
            };

            Alcohol drink =  Starbucks.MaxAlcohol();
            Console.WriteLine(drink.SpirtPercentage);
        }
    }
}
