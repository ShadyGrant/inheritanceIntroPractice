using System;

namespace inheritanceIntroPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram ts6 = new Ram();

            fxs.MainColor = "Midnight Blue";
            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine();

            modelS.MainColor = "Burgundy";
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();

            mx410.MainColor = "White";
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine();

            ts6.MainColor = "Silver";
            ts6.Drive();
            ts6.Turn("right");
            ts6.Stop();
            Console.WriteLine();

        }
    }
}