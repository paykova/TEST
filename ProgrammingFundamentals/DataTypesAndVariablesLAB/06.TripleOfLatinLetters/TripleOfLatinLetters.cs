using System;

namespace _06.TripleOfLatinLetters
{
    public class TripleOfLatinLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + n; i++)
            {
                for (char j = 'a'; j < 'a' + n; j++)
                {

                    for (char k = 'a'; k < 'a' + n; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");

                    }
                }
            }
        }
    }
}
