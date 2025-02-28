using System;
using System.Net;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
        do{
            Console.WriteLine("Start number: ");
            string str1 = Console.ReadLine();
            int start = int.Parse(str1);

            Console.WriteLine("Step number: ");
            string str2 = Console.ReadLine();
            int step = int.Parse(str2);
            

            if (start<1 || step>start || step<=1)
            {
            Console.WriteLine("Out-of-range start or step. Try again.");
            continue;
            }

            if (step>=start)
            {
            Console.WriteLine("Start must be higher than step. Try again.");
            continue;
            }
            
            if (start % step != 0)
            {
            Console.WriteLine("Start not divisible by step. Try again.");
            continue;
            }
            
            while (start!=0)
            {
            start=start-step;
            Console.WriteLine(start);
            continue;
            }

        }while(true);

            




        }
    }
}
