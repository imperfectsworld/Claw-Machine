using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Claw_Machine2
{
    internal static class ClawMachine
    {
        static List<Reward> AllRewards {  get; } = new List<Reward>
        {
            new Reward("Cheap Candy", 0.50m),
            new Reward("Cheap Candy", 0.50m),
            new Reward("Cheap Candy", 0.50m),
            new Reward("Candy Bar", 1.00m),
            new Reward("Candy Bar", 1.00m),
            new Reward("Stuffed Animal", 10.00m)
        };

         static decimal CostToPlay { get; } = 1.50m; 


       public static Reward GetReward()
        {
            Random r = new Random();
            int rInt = r.Next(0, AllRewards.Count);
            return AllRewards[rInt];
        }

        public static bool MadeProfit(Reward reward)
        {
            if(reward.Value > CostToPlay)
            {
             return true;
            }
            return false;   
        }

        public static void Play ()
        {
            Reward reward = GetReward();
            Console.WriteLine(reward.Name);
            bool madeProfit = MadeProfit (reward);

            if (madeProfit) { 
                Console.WriteLine("You made a Profit!");
            }
            else
            {
                Console.WriteLine("You lost money Bozo!");
            }

        }       
        
    }
}
