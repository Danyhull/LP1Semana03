using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks playerPerk = 0;
            
            foreach (char x in args[0])
            {
                switch(x)
                {
                    case 'w':
                        playerPerk ^= Perks.WaterBreathing;
                        break;
                    
                    case 's':
                        playerPerk ^= Perks.Stealth;
                        break;

                    case 'a':
                        playerPerk ^= Perks.AutoHeal;
                        break;
                    
                    case 'd':
                        playerPerk ^= Perks.DoubleJump;
                        break;

                    default:
                        Console.WriteLine("Unknown Perk!");
                        break;
                }
            }
            if (playerPerk == 0)
            {
                    Console.WriteLine("No Perks at all");
                    return;
            }

            

        }
    }
}
