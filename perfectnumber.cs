using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicproblems
{
    public class perfectnumber
    {
        public static void Findnumbers()
        {
            int n, i, sum;
            int mn, mx;

            Console.WriteLine("Find the perfect numbers within a given number of range");

            Console.WriteLine("Input the Starting range");

            mn=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the ending range");

            mx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The perfect number within the range:");

            for(n=mn; n<=mx; n++)
            {
                i = 1;
                sum=0;
                while(i<n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write(" {0} ", n);
            }
        }
        
    }
}
