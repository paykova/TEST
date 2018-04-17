using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PokemonEvolution
{
    class PokemonEvolution
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (inputLine != "wubbalubbadubdub")
            {
                string[] pokemonData = inputLine.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = pokemonData[0];

                if (pokemonData.Length > 1)
                {
                    string type = pokemonData[1];
                    int index = int.Parse(pokemonData[2]);
                    string evolution = type + " <-> " + index;

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new List<string>());
                    }
                    dict[name].Add(evolution);
                }
                else if (pokemonData.Length == 1)
                {
                    if (dict.ContainsKey(name))
                    {
                        Console.WriteLine("# " + name);
                        Console.WriteLine(string.Join("\n", dict[name]));
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine("# " + item.Key);

                foreach (var it in item.Value.OrderByDescending(x => int.Parse(x.Split(new char[] 
                {' ', '-', '>', '<'}, StringSplitOptions.RemoveEmptyEntries).Last())))
                {
                    Console.WriteLine(it);
                }
            }
        }
    }
}
