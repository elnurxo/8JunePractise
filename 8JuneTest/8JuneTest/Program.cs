using System;

namespace _8JuneTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                Name = "Elnur",
                Age = 21,
                Position = "Developer"
            };

            Human human1 = new Human()
            {
                Name = "Tebriz",
                Age = 26
            };

            //human1 = employee1;

            Console.WriteLine(human1.Name);

            Human[] humans = new Human[] { employee1, human1 };

            int count = 0;
            foreach (var item in humans)
            {
                item.ShowInfo();
                if (item is Employee)
                {
                    count++;     
                }
            }
            if (count>0)
            {
                Console.WriteLine($"Humans arrayinde employee var! Sayi - {count}");
            }


            //Interface - polymorfism

            Car car = new Car();
            IDriveable driveable = car;

            driveable.Show();


            //Extention method
            int num = 5;
            int result = num.Add(6);
            Console.WriteLine(result);

          
        }
    }
}
