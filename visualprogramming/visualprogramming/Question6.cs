using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question6
    {
        public void Solve()
        {
            Console.WriteLine(".........Factorial of a number..........");
            Console.WriteLine("Please enter a number to see its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            if (number == 0 || number == 1)
            {
                factorial = 0;
               
            }
            else
            {
                int x = 1;

                while (x <= number)
                {
                    factorial = factorial * x;
                    x++;

                }
            }
            Console.WriteLine("Factorial of " + number + "is "+ factorial);
        }
    }
}
