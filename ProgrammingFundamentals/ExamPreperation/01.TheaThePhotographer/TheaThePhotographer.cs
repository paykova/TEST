using System;

namespace _01.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main()
        {
            ulong amountOfPictures = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine());
            ulong percent = ulong.Parse(Console.ReadLine());
            ulong uploadTime = ulong.Parse(Console.ReadLine());

            ulong time1 = amountOfPictures * filterTime;
            double per = Math.Ceiling((double)percent / 100 * amountOfPictures);
            ulong time2 = (ulong)per * uploadTime;
            ulong result = time1 + time2;

            ulong days = (result / (3600 *24));
            result = result % (60 * 60 * 24);
            ulong h = result / 3600;
            result = result - (h * 3600);
            ulong m = result / 60;
            result = result - (m * 60);
            ulong s = result;
            if (h > 23)
            {
                h = h % 24;

            }
            Console.WriteLine($"{days:D1}:{h:D2}:{m:D2}:{s:D2}");
        }
    }
}
