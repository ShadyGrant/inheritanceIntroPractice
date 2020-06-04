using System;
namespace inheritanceIntroPractice
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. Mmmmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla squeals aroung a {direction} turn");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved!");

        }
    }
}