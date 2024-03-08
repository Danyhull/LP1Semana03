using System;

namespace PowTwoUntil
{
    class Program
    {
        private static void PowerOfUntil5()
            {
                for (int i = 1, i <= (1 <<5); i = i <<1)
                {
                    Console.WriteLine(i);
                }

            }
        static void Main(string[] args)
        {
            PowerOfUntil5();
            PowerOfUntil5();
        }

    }
}
