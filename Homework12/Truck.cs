using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Homework12
{
    class Truck : Vehicle
    {
        public Truck(string name_OfCar, string model, string name_OfEngine, double volume_OfEngine, string name_OfWheel)
            : base(name_OfCar, model, name_OfEngine, volume_OfEngine, name_OfWheel)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"You drive a truck\nThe characteristics of your truck :\n" +
                $"Name:\t\t\t{name_OfCar}\nModel:\t\t\t{model}\nEngine:\t\t\t{name_OfEngine}\n" +
                $"Engine's volume:\t{volume_OfEngine}\nWheel Type:\t\t{name_OfWheel}");
        }
    }
}