using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualprogramming
{
    internal class Question2
    {
        public void Solve()
        {
            decimal number1, number2, result=0;// i use decimal because user can enter any type of value including fraction
            char op;
            Console.WriteLine("Hey user ! \n\t  This is a simple Calculator , lets check it out");
            Console.WriteLine("Enter first number: ");
             number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
             number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator (+ - * / %): ");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    if (number2 != 0)
                    result = number1 / number2;
                    
                    else 
                        Console.WriteLine("Error!");
                        break;
                case '%':
                    result = number1 % number2;
                    break;
                default:
                    Console.WriteLine("Invalid operation entered");
                    break;
                    
            }
            Console.WriteLine("Answer is : " + result);
        }
    }
}
