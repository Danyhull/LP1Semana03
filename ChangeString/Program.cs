using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char  a = Char.Parse(Console.ReadLine());

            foreach(char b in s)
            {
                if (b != a)
                {
                    Console.Write(b);
                }
                else
                {
                    Console.Write("X");
                }
            }
        }
    }
}
