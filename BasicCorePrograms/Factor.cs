using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Factor
    {
        public static void FactorMethod()
        {
            Console.WriteLine("Enter any number to get it's Prime Factors ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i + " is prime factor of " + num);
                }
            }
        }
    }
}
