using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question4
    {
        public void Solve()
        {
            decimal sum = 0;
            Console.WriteLine("..........Sum of natural numbers..........");
            Console.WriteLine("\n\t Please enter a number to find sum upto");
            decimal value = Convert.ToInt32(Console.ReadLine());
            if (value == 0)
            {
                Console.WriteLine("Invalid ! \n Please enter non zero number");
                return;
            }
            else
            {
                for(int i=0; i<=value; i++)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum upto  "   + value +  "\t is: " + sum);
        }
    }
}
