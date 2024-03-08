using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string as = Console.ReadLine();
            char  b = Char.Parse(Console.ReadLine());

            foreach(char a in s)
            {
                if(a == b)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(a);
                }
            }
        }
    }
}
