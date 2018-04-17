using System;
using System.Collections.Generic;
using System.Linq;

namespace Spyfer
{
    class Spyfer
    {
        static void Main()
        {

          Solution1(); // 1 1 2 3 5 0  //1 2 3 5 0
            //Solution2();
           
        }

        private static void Solution2()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (i != 0 && i != numbers.Count - 1)
                {
                    int sumOfNeighbours = numbers[i - 1] + numbers[i + 1];

                    if (currentNumber == sumOfNeighbours)
                    {
                        numbers.RemoveAt(i + 1);
                        numbers.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else if (i == 0 && currentNumber == numbers[i + 1])
                {
                    numbers.RemoveAt(i + 1);
                    i = 0;
                }
                else if (i == numbers.Count - 1 && currentNumber == numbers[i - 1])
                {
                    numbers.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Solution1()
        {
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 0;
            int current = elements[count];


            while (count <= elements.Count - 1)
            {
                int first = CheckFirstIndex(count, elements);
                int second = CheckSecondIndex(count, elements);

                if (elements[count] == first + second)
                {
                    if (count == 0)
                    {
                        elements.RemoveAt(IndexToRemove(count, elements));
                    }
                    else if (count == elements.Count - 1)
                    {
                        elements.RemoveAt(count-1);
                    }
                    else
                    {
                        elements.RemoveAt(IndexToRemove(count, elements));
                        elements.RemoveAt(count);
                    }
                    
                    count = 0;
                }
                count++;
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        private static int IndexToRemove(int count, List<int> elements)
        {
            if (count - 1 < 0)
            {
                return count+1;
               
            }
            else
            {
                return count - 1;
            }
        }

        private static int CheckSecondIndex(int count, List<int> elements)
        {
           if (count + 1 > elements.Count - 1)
            {
                return elements[elements.Count - 1];
            } 
           else
            {
                return elements[count + 1];
            }
        }

        private static int CheckFirstIndex(int count, List<int> elements)
        {
            if (count - 1 < 0)
            {
                return 0; 
            }
            else
            {
                return elements[count - 1]; 
            }
        }
    }
}
