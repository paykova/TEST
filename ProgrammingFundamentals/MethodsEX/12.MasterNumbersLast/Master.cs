using System;
using System.Collections.Generic;

namespace _12.MasterNumbersLast
{
    public class Master
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> listDiv7 = new List<int>();

            if (ContainsEvenDigit(n))
            {
                Console.WriteLine(string.Join(" ", listDiv7));

            }

            //for (int i = 0; i <= n; i++)
            //{
            //    if (ContainsEvenDigit(i) == true)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
        static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static bool ContainsEvenDigit(int n)
        {
            bool isFound = false;
            for (int i = 1; i <= n; i++)
            {

                var number = i;
                int counter = 0;
                while (number > 0)
                {

                    var digit = number % 10;

                    if (digit % 2 == 0)
                    {
                        counter++;

                    }
                    number = number / 10;
                }
                if (counter > 0)
                {
                    isFound = true;
                    // listDiv7.Add(i);
                }
            }
            if (isFound)
            {

                return true;
            }
            else
            {
                return false;
                    }
        }

                static bool SumOfDigits(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                var number = i;
                var sum = 0;
                while (number > 0)
                {
                    var digit = number % 10;
                    number = number / 10;
                    sum += digit;
                }
                if (sum % 7 != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}


//&& (SumOfDigits(i) == true) &&(IsPalindrome(i.ToString()) == true)
//                    (ContainsEvenDigit(i) == true))

