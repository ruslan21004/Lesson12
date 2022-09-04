using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework12
{
    class Vehicle
    {
        public string name_OfCar { get; set; }
        public string model { get; set; }
        public string name_OfEngine { get; set; }
        public double volume_OfEngine { get; set; }
        public string name_OfWheel { get; set; }
       
        public Vehicle(string name_OfCar, string model, string name_OfEngine, double volume_OfEngine, string name_OfWheel)
        {
            this.name_OfCar = name_OfCar;
            this.model = model;
            this.name_OfEngine = name_OfEngine;
            this.volume_OfEngine = volume_OfEngine;
            this.name_OfWheel = name_OfWheel;
        }

        public virtual void Print()
        {
            Console.WriteLine("You drive a vehicle");
        }
    }
}
//checked
