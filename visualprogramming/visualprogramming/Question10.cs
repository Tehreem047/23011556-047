using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question10
    {
        public void Solve()
        {
            int[] number = new int[10];
            Console.WriteLine("..........Search for a number in list...........");
            Console.WriteLine("\n\tPlease enter at least 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Please enter a number to be searched");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int x=0; x<10; x++)
            {
                if ( number[x] == num)
                { 
                Console.WriteLine("Number found !!");
                }

                else
                { 
                    Console.WriteLine("Number not found ! try again for another one.");
                    return;
                }
            }
            
        }
    }
}
