using System;

namespace inheritanceIntroPractice
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero flashes by you like a hurricane. Zzzzzzzooooommm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for a mile and stops!");

        }
    }
}