using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void display()
        {
            int count = 0;

            Console.WriteLine("enter the number to find prime number or not");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < num; i++)
            {
                int rem = num % i;
                if (rem == 0)
                { count++; break; }
            }
            if (count == 0)
            {
                Console.WriteLine(num + " number is prime number ");
            }
            else
            {
                Console.WriteLine(num + " number is not prime number ");
            }
        }
    }
}
