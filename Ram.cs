using System;
namespace inheritanceIntroPractice
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero grwols by you. Rrrrrrruuuummmmmbbbble!!");
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