using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void Display()
        {
            int sum = 0, N;
            Console.WriteLine("Enter the number: ");
            int no = Convert.ToInt32(Console.ReadLine());
            N = no;
            for (int i = 1; i < no; i++)
            {
                if (no % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == N)
            {
                Console.WriteLine(" Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine(" Entered number is not perfect");
            }
            Console.ReadLine();
        }
    }
}
