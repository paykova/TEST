using System;

namespace _03.Pokemon
{
    class Pokemon
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int originalValue = n; 
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;

            while (n >= m)
            {
                n = n - m;
                count++;
                if (n == originalValue * 0.5 && originalValue%2 == 0 && y!=0)
                {
                    n = n / y;
                }

                
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
