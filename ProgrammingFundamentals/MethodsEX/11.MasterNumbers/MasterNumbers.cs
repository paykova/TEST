using System;
using System.Collections.Generic;

namespace _11.MasterNumbers
{
    public class MasterNumbers
    {
        public static void Main()

        {
            int n = int.Parse(Console.ReadLine());

            FindMasterNumbers(n);
            Div7(n);
           
        }

        private static void Div7(int n)
        {
            List<int> sumList = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                int digit = 0;
                int sum = 0;
                int number = i;
                while (number != 0)
                {
                    digit = number % 10;
                    number = number / 10;
                    sum += digit;
                }

                if (sum % 7 == 0)
                {
                    sumList.Add(i);
                    //Console.WriteLine($"number: {i}, sum: {sum}");
                }
            }
        }


        static void IsPalindrome(int n, int[] palindrome)
        {
            bool isFind = false;

            //for (int i = palindrome[0]; i < palindrome[palindrome.Length - 1]; i++)
            //{

            //}

            foreach (var item in palindrome)
            {
                int i = palindrome[0];
                int j = palindrome [palindrome.Length - 1];

                while (i < j)
                {
                    if (palindrome[i] != palindrome[j])
                        isFind = false;
                   // Console.WriteLine(false);

                    i++;
                    j--;
                }
                if (!isFind)
                {
                    //Console.Write(item + " ");
                }
                
                    
              //  Console.WriteLine();
            }
        }

      






        private static void FindMasterNumbers(int n)
        {
           
            }
           Console.Write(string.Join(", ", sumList));
          Console.WriteLine();           
            Console.WriteLine(sumList.Count);
            Console.WriteLine();

            List<int> evenNumbers = new List<int>();

            foreach (var item in sumList)
            {
                int digit = 0;
                int number = item;
                while (number != 0)
                {
                    digit = number % 10;
                    if (digit % 2 == 0)
                    {
                        evenNumbers.Add(item);
                    }
                    number = number / 10;
                }               
            }
            int len = evenNumbers.Count; 
           Console.Write((string.Join(", ", evenNumbers)));
            Console.WriteLine();
            Console.WriteLine(evenNumbers.Count);
            Console.WriteLine();
        }
    }
}

