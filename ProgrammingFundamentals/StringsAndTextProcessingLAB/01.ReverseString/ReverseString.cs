using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var reversedText = text.ToCharArray().Reverse();
            Console.WriteLine(string.Join(string.Empty, reversedText));
        }
    }
}



