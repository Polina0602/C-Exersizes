using System;

namespace Exersizes.Tasks
{
    internal static class DepositInerest
    {
        static double sum;
        static double Interest;
        static int FirstRate = 5;
        static int SecondRate = 10;
        static double result;
        static int bonus = 15;

        public static void CountInterest(double sum)
        {
            if (sum < 100)
            {
                double Interest = sum / 100 * FirstRate;
                double result = sum + Interest + bonus;
               
                Console.WriteLine($"Your interest is {Interest}, there is {result} dollars on your account");
            }

            else
            {
                double Interest = sum / 100 * SecondRate;
                double result = sum + Interest + bonus;

                Console.WriteLine($"Your interest is {Interest}, there is {result} dollars on your account");
            }
  
        }

        public static void Percents()
        {
            Console.WriteLine("Your sum is: ");
            decimal sum = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Quantity of months is: ");
            int months = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= months; i++)
            //{
            //    sum += sum * 0.07M;
            //}
            int i = 1;
            while(i <= months)
            {
                sum += sum * 0.07M;
                i++;
            }

            Console.WriteLine("Your sum will be " + sum + "$");
        }
    }
}
