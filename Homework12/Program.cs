using Homework12.auto_service;

namespace Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("Mitsubishi", "Lancer X", "D2", 2.0, "FWD");

            car.Print();

            Vehicle truck = new Truck("Volvo", "FM400", "D13", 13, "6*4");

            truck.Print();
        }
    }
}