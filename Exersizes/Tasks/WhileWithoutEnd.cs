using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersizes.Tasks
{
    internal class WhileWithoutEnd
    {
        public static void Multi_Numbers()
        {
            Console.WriteLine("Your first number is ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Your second number is ");
            int secondNumber = int.Parse(Console.ReadLine());

            while (true)

                if (firstNumber <= 0 || firstNumber >= 10 || secondNumber <= 0 || secondNumber >= 10)
                {
                    Console.WriteLine("Your numbers are wrong");
                }
                else
                {
                    int result = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                    break;
                }
            
        }
    }
}
