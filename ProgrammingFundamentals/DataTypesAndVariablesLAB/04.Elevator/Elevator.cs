using System;

namespace _04.Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (numberOfPeople % capacity != 0)
            {
                int steps = (numberOfPeople / capacity) + 1;
                Console.WriteLine(steps);
            }
            else
            {
                int steps = (numberOfPeople / capacity);
                Console.WriteLine(steps);
            }
        }
    }
}
