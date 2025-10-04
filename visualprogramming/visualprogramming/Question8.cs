using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question8
    {
        public void Solve()
        {
            int [] number = new int[10];
            Console.WriteLine("............Find minimum and maximum from a list of numbers...........");
            Console.WriteLine("Please enter any 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min =number[0];
            int max = number[0];
            for(int x =0; x<10; x++)
            {
                if (number[x] < min)
                {
                    min = number[x];
                }
                if (number[x] > max)
                {
                    max = number[x];
                }
            }
            Console.WriteLine("The minimum number among these is : "+min);
            Console.WriteLine("The maximum number among these is: "+max);
        }
    }
}
