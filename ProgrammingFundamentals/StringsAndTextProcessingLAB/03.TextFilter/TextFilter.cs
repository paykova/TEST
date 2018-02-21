using System;
using System.Linq;
using System.Collections.Generic; 


namespace _03.TextFilter
{
    public class TextFilter
    {
     public static void Main()
        {
            Solution1();            
        }

        private static void Solution1()
        {
            string[] bannedWords = Console.ReadLine()
                 .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var bannedword in bannedWords)
            {
                    text = text.Replace(bannedword, new string('*', bannedword.Length));
            }
            Console.WriteLine(text);
        }
    }
}
