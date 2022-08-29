using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Homework12
{

    namespace auto_service
    {
        class Car : Vehicle
        {
            public Car(string name_OfCar, string model, string name_OfEngine, double volume_OfEngine, string name_OfWheel)
                : base(name_OfCar, model, name_OfEngine, volume_OfEngine, name_OfWheel)
            {

            }

            public override void Print()
            {
                Console.WriteLine($"You drive a car\nThe characteristics of your car :\n" +
                    $"Name:\t\t\t{name_OfCar}\nModel:\t\t\t{model}\nEngine:\t\t\t{name_OfEngine}\n" +
                    $"Engine's volume:\t{volume_OfEngine}\nWheel Type:\t\t{name_OfWheel}");
            }

        }
    }
}
