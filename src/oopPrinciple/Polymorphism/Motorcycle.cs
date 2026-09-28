using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopPrinciple.Polymorphism
{
    public class userMotorcycle : Vechicle
    {
        public override void Start()
        {
            Console.WriteLine("Motorcycle is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping.");
        }
    }
}