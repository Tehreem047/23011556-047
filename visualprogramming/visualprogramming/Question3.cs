using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question3
    {
        public void Solve()
        {
            decimal marks = 0;
            char Grade = 'A';
            Console.WriteLine("...........Grade calculator...........");
            Console.WriteLine("\n\t Please enter your marks");
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks == 0)
            {
                Console.WriteLine("Invalid input !");
                return;
            }
            else if (marks < 40)
            {
                Grade = 'F';
                return;
            }
            else if (marks >= 40 || marks <= 54)
            {
                Grade = 'D';
                return;
            }
            else if (marks >= 55 || marks<= 69)
            {
                Grade = 'C';
                return;
            }
            else if (marks >= 70 || marks<= 84)
            {
                Grade = 'B';
                return;
            }
            else
            {
                Grade = 'A';
                return;
            }
                Console.WriteLine("Your Grade is: " + Grade);
        }

    }
}
