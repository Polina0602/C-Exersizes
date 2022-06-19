using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersizes.Tasks
{
    internal class w3resourses
    {
        public static void Swap() {
            Console.WriteLine("Your First number is ");
            int fn = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Second number is ");
            int sn = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"fn = {fn}, sn = {sn}");

            System.Console.WriteLine();
            int tmp = fn;
            fn = sn;
            sn = tmp;

            Console.WriteLine($"fn = {fn}, sn = {sn}");
        }

        public static void Mult()
        {
            Console.WriteLine("Your First number is ");
            int fn = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Second number is ");
            int sn = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Third number is ");
            int tn = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"{fn} * {sn} * {tn} = {fn * sn * tn}");

        }

        public static void Calc() 
        {
            Console.WriteLine("Your First number is ");
            int fn = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Second number is ");
            int sn = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose your operation: +, -, *, / ");
            var op = Console.ReadLine();

            switch (op) {
                case "+":
                    Console.WriteLine(fn + sn); 
                    break;
                case "-":
                    Console.WriteLine(fn - sn);
                    break;
                case "*":
                    Console.WriteLine(fn * sn);
                    break;
                case "/":
                    Console.WriteLine(fn / sn);
                    break;
            }
        }

        public static void MultiTableForNumber() 
        {
            Console.WriteLine("Your number is ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} + {i} = {number * i}");
            }
        }

        public static void Average() 
        {
            Console.WriteLine("Your First number is ");
            int fn = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Second number is ");
            int sn = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Third number is ");
            int tn = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Fourth number is ");
            int fon = int.Parse(Console.ReadLine());

            Console.WriteLine($"The average is {(fn + sn + tn + fon) / 4}");
        }

        public static void RemoveCharacter(string myString) 
        {
            Console.WriteLine("Your Index is ");
            int index = int.Parse(Console.ReadLine());

            string myNewString = myString.Remove(index, 1);

            Console.WriteLine(myNewString);
        }

        public static int FindMin(int[] arr)
        {
           //int[] myArray = new int[4] { 1, 2, 3, 5 };

            //int? result = null;
            int? result = 0;

            foreach(int i in arr)
            {
                if(!result.HasValue || result > i) result = i;
            }

            return (int)result;

        }

        public static void ChangeChars(string myString) 
        { 
            //string[] chars = myString.Split(new char[] { ' ' });

            var first = myString[0];
            var last = myString[myString.Length -1];

            var tmp = first;

            first = last;
            last = tmp;

            //myString[0] = first;
            //myString[myString.Length - 1] = last;

            Console.WriteLine(myString);

        }

        public static void first_last(string ustr)
        {
            //Console.WriteLine( ustr.Length > 1
            //    ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr);

            Console.WriteLine(ustr.Substring(ustr.Length - 1));
            Console.WriteLine(ustr.Substring(1, ustr.Length - 2));
            Console.WriteLine(ustr.Substring(0, 1));

        }

        public static bool PoN(int x, int y)
        {
            if (x < 0 && y < 0 || x > 0 && y > 0) 
            { 
                return false;
            }
            else 
            {
                return true;
            }
            
        }

        public static void Triple(int x, int y) 
        {
            if (x == y) 
            {
                Console.WriteLine((x+y)*3);
            }
        }

        public static void Tern(int x, int y) 
        {
            Console.WriteLine(x > y ? (x-y)*2 : y - x);
        }

        public static void LongestWord(string myString)
        {
            string [] words = myString.Split(' ');

            string longest = words[0];

            for (int i = 0; i < words.Length; i++) 
            {
                
                if (words[i].Length > longest.Length) 
                { 
                    longest = words[i];
                }
 
            }

            Console.WriteLine(longest);
        }

        public static void SumOfDigits(int x) 
        {
            int sum = 0; 
            string xString = x.ToString();

            char [] digits = xString.ToCharArray();

            foreach (char digit in digits)
            {
                sum += int.Parse(digit.ToString());
            }

            Console.WriteLine(sum);
        }

        public static void Reverse(string myString) 
        { 
            List<string> newStringList = new List<string>();

            string[] words = myString.Split(' ');

            for (int i = words.Length - 1; i > 0; i--)
            {
                newStringList.Add(words[i]);
            }

            foreach (string word in newStringList)
            {
                Console.WriteLine($"{word} ");
            }

            
        }

        public static void MultArrays() 
        {
           int[] firstArray = { 1, 3, -5, 4 };
           int[] secondArray = { 1, 4, -5, -2 };

            List<int> result = new List<int>();

            for (int i = 0; i < firstArray.Length; i++) { 

                result.Add(firstArray[i] * secondArray[i]);
            }

            foreach(int i in result) { 
            Console.WriteLine(i);
            }
        }

        public static void MyArray() 
        {
            int[] myArray = new int [10];

            for(int i = 0; i < myArray.Length; i++)
            {
                if (i == 0)
                {
                    myArray[i] = 1;
                    Console.WriteLine($"element 0 = 1");
                }
                else 
                {
                    myArray[i] = 1;
                    Console.WriteLine($"element {i} = {i}");
                }
            }

        }

        public static void ArrayReverse() 
        {
            int[] MyArray = new int [3];
            int[] ReverseArray = new int [3];

            for(int i = 0;i < 3; i++)
            {
                Console.WriteLine("Input number ");
                var number = int.Parse(Console.ReadLine());
                MyArray[i] = number;
            }

           Array.Reverse(MyArray);

            foreach (int i in MyArray)
            {
                Console.Write($"{i} ");
            }
  
        }

        public static void SumOfArray()
        {
            int sum = 0;
            int[] myArray = { 1, 2, 3};

            foreach (int i in myArray)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
        public static void CopyArray()
        {
            int[] MyArray1 = { 5, 7, 12 };
            int[] MyArray2 = new int [3];

            for(int i = 0; i < MyArray1.Length; i++)
            {
                MyArray2[i] = MyArray1[i];
            }

            foreach (int i in MyArray1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(  );
            Console.WriteLine();

            foreach (int i in MyArray2)
            {
                Console.WriteLine(i);
            }
        }

        public static void CountDuplicate()
        {
            int count = 0;
            int[] MyArray = { 1, 2, 3, 5, 2,19, 1, 134,78, 19 };
            for (int i = 0;i < MyArray.Length-1; i++) 
            { 
                for (int j = i+1;j < MyArray.Length; j++)
                {
                    if(MyArray[i] == MyArray[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        public static void PrintUnique()
        {
            int[] MyArray = { 1, 56, 1, 12 };
            List<int> NotUniqueNumbers = new List<int>();
            bool isUnique;

            for(int i = 0; i < MyArray.Length; i++)
            {
                isUnique = true;
                int a = MyArray[i];
                for (int j = i+1; j < MyArray.Length; j++)
                {
                    
                    int b = MyArray[j];
                    if(a == b)
                    {
                        isUnique = false;
                        NotUniqueNumbers.Add(a);
                    }

                }
                for(int n = 0; n < NotUniqueNumbers.Count; n++)
                {
                    var c = NotUniqueNumbers[n];
                    if(a == c)
                    {
                        isUnique=false;
                    }
                }

                if (isUnique == true)
                {
                    Console.WriteLine(MyArray[i]);
                }
            }
        }

        public static void LINQ_Even() 
        
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;

            foreach(int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void PositiveNumbers() 
        {
            int[] n1 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

            var pos = from num in n1
                      where num > 0
                      select num;

            foreach(int num in pos)
            {
                Console.WriteLine(num);
            }
        }

        public static void Square() 
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var square = from num in numbers
                         let sqrNum = num * num
                         where sqrNum > 20
                         select new { num, sqrNum };

            foreach(var item in square)
            {
                Console.WriteLine(item);
            }
        }

        public static void Frequency()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var freq = from number in arr1
                       group number by number into nums
                       select nums;

                       foreach(var item in freq)
            {
                if (item.Count() > 1)
                {
                    Console.WriteLine($"The number {item.Key} appears {item.Count()} in this array");
                }
            }
        }

        

    }
}
