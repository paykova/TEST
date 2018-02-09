using System;

namespace _03.LastKNumbersSumsSequence
{
    public class LastKNumbers
    {
        public static void Main()
        {

           // Solution1();
            Solution2();
            
        }

        private static void Solution2()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (long j = i-k; j < i; j++)
                {
                    if (i-k<0)
                    {
                        for (int m = 0; m < i; m++) //1 1 2 4 7 13
                        {
                            sum += numbers[m];
                        }
                        break;
                    }
                    sum += numbers[j];
                }
               //for (int j = i - 1; j >= i - k; j--)
                //{
                //    if (j < 0)
                //    {
                //        break;
                //    }
                //    sum += numbers[j];
                //}
                numbers[i] = sum;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }




        private static void Solution1()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (int j = i - 1; j >= i - k; j--)
                {
                    if (j < 0)
                    {
                        break;
                    }
                    sum += numbers[j];
                }
                numbers[i] = sum;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }

}
