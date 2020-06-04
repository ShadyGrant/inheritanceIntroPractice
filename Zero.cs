using System;
namespace inheritanceIntroPractice
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeoooowww!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Vehicle gently rolls up to stop!");

        }
    }
}