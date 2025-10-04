using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question1
    {
        static void Main(string[] args)
        {
            //this is code for question1

             Console.WriteLine("Hello User! \n\t Please enter a number to check if its even or odd :");
             int number = Convert.ToInt32(Console.ReadLine());
             if (number == 0 || number == 1 )
             {
                 Console.WriteLine("Number should be 2 or  greater than 2");
             }

             else if (number % 2 == 0)
             {
                 Console.WriteLine(number + "is even number ");
             }
             else
             {
                 Console.WriteLine(number + "is odd number ");
             }
            Question2 q2 = new Question2();//to connect question with main
            q2.Solve(); 
            Question3 q3 = new Question3();//to connect question with main
            q3.Solve(); 
            Question4 q4 = new Question4();//to connect question with main
            q4.Solve();
            Question5 q5 = new Question5();//to connect question with main
            q5.Solve();
            Question6 q6 = new Question6();//to connect question with main
            q6.Solve(); 
            Question7 q7 = new Question7();//to connect question with main
            q7.Solve();
            Question8 q8 = new Question8();//to connect question with main
            q8.Solve();  
            Question9 q9 = new Question9();//to connect question with main
            q9.Solve(); 
            Question10 q10 = new Question10();//to connect question with main
            q10.Solve();
        }
    }
}
