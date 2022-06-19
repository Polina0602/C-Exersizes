using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersizes.Tasks
{
    internal class Switch
    {
        public static void ChooseOne()
        {
            Console.WriteLine("Your first number is ");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is ");
            int SecondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose your operation: ");
            Console.WriteLine("1 - '+'");
            Console.WriteLine("2 - '-'");
            Console.WriteLine("3 - '*'");
            Console.WriteLine("4 - '/'");
            int result = int.Parse(Console.ReadLine());

            switch (result)
            {
                case 1:
                    int res1 = FirstNumber + SecondNumber;
                    Console.WriteLine($"{FirstNumber} + {SecondNumber} = {res1}");
                    break;
                case 2:
                    int res2 = FirstNumber - SecondNumber;
                    Console.WriteLine($"{FirstNumber} - {SecondNumber} = {res2}");
                    break;
                case 3:
                    int res3 = FirstNumber * SecondNumber;
                    Console.WriteLine($"{FirstNumber} * {SecondNumber} = {res3}");
                    break;
                case 4:
                    int res4 = FirstNumber - SecondNumber;
                    Console.WriteLine($"{FirstNumber} / {SecondNumber} = {res4}");
                    break;
                default:
                    Console.WriteLine("Operation undefined");
                    break;
            }
        }
    }
}
