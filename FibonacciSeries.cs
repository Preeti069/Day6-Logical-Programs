using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void DisplayFibo()
        {

            int n1 = 0, n2 = 1, n3, i, no;

            Console.WriteLine("Enter the number of element");

            no = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");

            for (i = 2; i < no; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
