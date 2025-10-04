using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question5
    {
        public void Solve()
        {
            Console.WriteLine("...........Table of a number...........");
            Console.WriteLine("\n\t Please enter a number to see its table");
            decimal number = Convert.ToInt32(Console.ReadLine());

           

            if (number == 0)
            {
                Console.WriteLine(" Invalid! enter non zero value");
              
            }
            else
            {
                Console.WriteLine("This is table for " + number);
                for (int i=1; i<=10; i++)
                
               
                Console.WriteLine( number + "*" + i + " = " + number*i);
            }
        }
    }
}
