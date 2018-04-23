using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            string[] nameOfParticipants = Console.ReadLine().Split();
            List<double> trackLayout = Console.ReadLine().Split().Select(double.Parse).ToList(); 
            List<int> checkpoint = Console.ReadLine().Split().Select(int.Parse).ToList();

            double initialFuel = 0;
            

            for (int i = 0; i < nameOfParticipants.Length; i++)
            {
                bool isReached = false;
                int index = 0;
                foreach (var item in nameOfParticipants[i])
                {
                    initialFuel = item;
                    break; 
                }
                for (int j = 0; j < trackLayout.Count; j++)
                {
                    
                    if (checkpoint.Contains(j))
                    {
                        initialFuel += trackLayout[j];
                    }
                    else
                    {
                        initialFuel -= trackLayout[j]; 
                    }
                    if (initialFuel <= 0)
                    {
                        isReached = true;
                        index = j;
                        break;
                    }
                    
                }
                if (isReached)
                {
                    Console.WriteLine($"{nameOfParticipants[i]} - reached {index}");
                }
                else
                {
                    Console.WriteLine($"{nameOfParticipants[i]} - fuel left {initialFuel:F2}");
                }
            }
            
        }
    }
}
