using System;

namespace _03M.Megapixels
{
    public class Megapixels
    {
        public static void Main()
        {

            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine()); 

            Megapix(width, height);

        }

        private static void Megapix(decimal width, decimal heigth)
        {
            decimal result = ((width * heigth) / 1000000);
           
            Console.WriteLine("{0}x{1} => {2}MP", width, heigth, Math.Round(result, 1));
        }
    }
}
