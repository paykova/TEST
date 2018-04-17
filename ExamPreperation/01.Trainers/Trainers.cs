using System;

namespace _01.Trainers
{
    class Trainers
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            decimal technical = 0;
            decimal theoretical = 0;
            decimal practical = 0; 

            for (int i = 0; i < n; i++)
            {
                long distanceInMeters = long.Parse(Console.ReadLine()) * 1600;
                decimal cargoInKilograms = decimal.Parse(Console.ReadLine()) * 1000;
                string team = Console.ReadLine();

                decimal cargoIncome = 1.5m * cargoInKilograms;
                decimal fuelConsumption = 0.7m * distanceInMeters * 2.5m;
                decimal participantsEarnedMoney = cargoIncome - fuelConsumption;


               
              // participantsEarnedMoney =(decimal)((cargoInKilograms * 1.5) - (0.7 * distanceInMeters * 2.5));

                if (team == "Technical")
                {
                    technical += participantsEarnedMoney;
                }
                else if (team == "Theoretical")
                {
                    theoretical += participantsEarnedMoney;

                }
                else if (team == "Practical")
                {
                    practical += participantsEarnedMoney;
                }
            }

            decimal winTeamSum = Math.Max(theoretical, Math.Max(technical, practical));

            if (winTeamSum == technical)
            {
                Console.WriteLine($"The Technical Trainers win with ${technical:F3}.");
            }
            else if (winTeamSum == theoretical)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${theoretical:F3}.");
            }
            else if (winTeamSum == practical)
            {
                Console.WriteLine($"The Practical Trainers win with ${practical:F3}.");
            }
        }
    }
}
