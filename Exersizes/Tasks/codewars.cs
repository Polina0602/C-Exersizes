using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersizes.Tasks
{
    internal class codewars
    {

        public static void ArrayDiff(int[] a, int[] b)
        {
            List<int> UniqueNumbers = new List<int>();
            List<int> NotUniqueNumbers = new List<int>();
            bool isUnique;

            for (int i = 0; i < a.Length; i++)
            {
                isUnique = true;
                int c = a[i];
                for (int j = 0; j < b.Length; j++)
                {

                    int d = b[j];
                    if (c == d)
                    {
                        isUnique = false;
                        NotUniqueNumbers.Add(c);
                    }

                }
                for (int n = 0; n < NotUniqueNumbers.Count; n++)
                {
                    var e = NotUniqueNumbers[n];
                    if (c == e)
                    {
                        isUnique = false;
                    }
                }

                if (isUnique == true)
                {
                    UniqueNumbers.Add(a[i]);


                };
            }
            foreach (int i in UniqueNumbers)
            {
                Console.WriteLine(i);
            }

        }

    public static void CoprimeNumbers(int firstNumber, int secondNumber )
        {
            List<int> firstNumberFactors = new List<int>();
            List<int> secondNumberFactors = new List<int>();
            for (int i = 1; i <= firstNumber; i++)
            {
                if ((float)firstNumber / i % 1 == 0)
                {
                    firstNumberFactors.Add(Convert.ToInt32(i));
                }

            }

            foreach (int i in firstNumberFactors)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            for (int i = 1; i <= secondNumber; i++)
            {

                if ((float)secondNumber / i % 1 == 0)
                {
                    secondNumberFactors.Add(Convert.ToInt32(i));
                }

            }

            foreach (int i in secondNumberFactors)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine();

            //linq
            //var commonFactors = from number in firstNumberFactors
            //            where secondNumberFactors.Contains(number)
            //            select number;

            //lambda
            var commonFactors = firstNumberFactors.Where(number => secondNumberFactors.Contains(number));
            //уникальные номера первого массива
            //var commonFactors = firstNumberFactors.Where(number => !secondNumberFactors.Contains(number));

            foreach (int i in commonFactors)
            {
                Console.Write(" " + i);
            }
        }

        // образец сложения всех чисел в массиве
        static long TotalAllEvenNumbers(int[] intArray)
        {
            return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
        }

    }


}
