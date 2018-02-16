using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            List<int> twoNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int bomb = twoNumbers[0];
            int power = twoNumbers[1];
            long sum = 0;

            for (int i = 0; i < input.Count; i++) //1 2 2 4 2 2 2 9
                                                  // 4 2

            {
                if (input[i] == bomb)
                {
                    if (i - power < 0)
                    {
                        for (int j = 0; j < i; j++)
                        {

                            input[j] = 0;
                        }
                    }
                    else
                    {
                        for (int j = i - power; j < i; j++)
                        {
                            input[j] = 0;  //1 1 2 1 1 1 2 1 1 1
                                           //  2 1

                        }
                    }

                    int length = power + i;

                    if (length > input.Count)
                    {
                        for (int k = i; k < input.Count; k++)
                        {

                            input[k] = 0;
                        }
                    }
                    else
                    {
                        for (int k = i; k <= length; k++)
                        {

                            input[k] = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != 0)
                {
                    sum += input[i];
                }

            }
            Console.WriteLine(sum);
        }
    }
}
