using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question7
    {
        public void Solve()
        {
            Console.WriteLine(".........Reverse a value.........");
            Console.WriteLine("Please enter a value to be reversed: ");
            long value = Convert.ToInt32(Console.ReadLine());
            long reversed = 0;
            while(value != 0)
            {
                long rem = value % 10;
                reversed = (reversed * 10) + rem;
                value = value / 10;

            }
            Console.WriteLine("The reversed value is: " + reversed);
        }
    }
}
