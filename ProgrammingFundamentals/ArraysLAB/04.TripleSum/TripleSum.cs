using System;
using System.Linq;

namespace _04.TripleSum
{
    public class TripleSum
    {
        public static void Main()
        {
            Solution1();
            Solution2();
            Solution3();

        }

        private static void Solution3()
        {
            string text = Console.ReadLine();
            var splitText = text.Split(' ');
            var numbers = new int[splitText.Length];

            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentText = splitText[i];
                var currentNumber = int.Parse(currentText);
                numbers[i] = currentNumber;
            }

            for (int a = 0; a < numbers.Length - 1; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    int c = numbers[a] + numbers[b];
                    if (numbers.Contains(c))
                    {
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {c}");
                        //Console.WriteLine(a + "+" + b + "=" + c);
                        isFound = true;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }

        private static void Solution2()
        {
            int[] array = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();

            bool isFound = false;

            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = a + 1; b < array.Length; b++)
                {
                    for (int c = 0; c < array.Length; c++)
                    {
                        if (array[a] + array[b] == array[c])

                        {
                            isFound = true;
                            Console.WriteLine($"{array[a]} + {array[b]} == {array[c]}");
                        }
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }



        private static void Solution1()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isContains = false;
            for (int a = 0; a < arr.Length - 1; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    int sum = arr[a] + arr[b];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[a]} + {arr[b]} == {sum}");
                        isContains = true;
                    }
                }
            }

            if (!isContains)
            {
                Console.WriteLine("No");
            }
        }
    }

}