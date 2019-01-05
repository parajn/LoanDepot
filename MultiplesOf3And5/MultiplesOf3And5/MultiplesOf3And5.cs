using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    class MultiplesOf3And5
    {
        static void Main(string[] args)
        {
            MultiplesOf3And5 multipleObj = new MultiplesOf3And5();
            Console.WriteLine("Sum of all the multiples of 3 or 5 below 1000 is : "
                + multipleObj.FindSumOfAllTheMultiplesOf3And5Below1000());
            Console.WriteLine();
        }
        private long FindSumOfAllTheMultiplesOf3And5Below1000()
        {
            long sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
                else if (i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
