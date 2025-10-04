using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question9
    {
        public void Solve()
        {
            int[] numbers = new int[10];
            Console.WriteLine("..........Even and Odd count of numbers...........");
            Console.WriteLine("\n\tPlease enter at least 10 numbers");
            for(int i=0; i<10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int even = 0;
            int odd = 0;
            for (int x = 0; x < 10; x++)
            {
                if (numbers[x] == 0 || numbers[x] == 1)
                {
                    even =even;
                    odd =odd;
                }

                else if (numbers[x] >= 2 && numbers[x] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

            }
            Console.WriteLine("The even count is:" + even);
            Console.WriteLine("The odd count is: " + odd);

        }
    }
}
