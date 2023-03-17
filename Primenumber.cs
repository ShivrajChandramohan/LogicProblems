using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicproblems
{
    public class Primenumber
    {
        public static void Findprime()
        {
            int i, n, a;

            Console.WriteLine("Enter Number:");
            
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                a = n % i;


                if (a == 0)
                {
                    Console.WriteLine("The given number is not a prime number");
                }

                else
                {
                    Console.WriteLine("The given number is a prime number");
                }
            }
        }
    }
}
