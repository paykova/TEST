using System;
using System.Linq;
using System.Collections.Generic;


namespace _04.Palindromes
{
    public class Palindromes
    {
        public static void Main(string[] args)
        {   
           string[] text = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> polidrome = new List<string>(); 

            foreach (var item in text)
            {
                var rev = item.ToCharArray().Reverse();
                if (string.Join("", rev) == item)
                {
                    polidrome.Add(item); 
                }
            }
            var alphabetically = polidrome.OrderBy(a => a); 
            Console.WriteLine(string.Join(", ", alphabetically));
        }
    }
}


