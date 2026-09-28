using System;
// using oopPrinciple.Polymorphism;

namespace oopPrinciple.Polymorphism;

class userCar : Vechicle
{
    public int NumberOfDoors { get; set; }
    public int NumberOFWheels {get; set;}

    public override void Start()
    {
        System.Console.WriteLine("Car is starting...");
    }

    public override void Stop()
    {
        System.Console.WriteLine("Car is stopping...");
    }
}