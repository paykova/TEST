using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02.AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!dict.ContainsKey(name))
                {
                    List<double> grades = new List<double>();
                    dict.Add(name, grades); 
                }
                dict[name].Add(grade); 
            }

            foreach (var item in dict)
            {
                var average = item.Value.Average();
                Console.Write(item.Key + " -> ");
                foreach (var it in item.Value)
                {
                    Console.Write($"{it:F2} ");
                }               
                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
