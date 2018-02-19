using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            while (input[0] != "wubbalubbadubdub")
            {
                // Just pokemon name.
                if (input.Length == 1)
                {
                    string pokemonName = input[0];
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var evo in pokemons[pokemonName])
                        {
                            Console.WriteLine(evo);
                        }
                    }
                }
                // Pokemon with evolution.
                else
                {
                    string pokemonName = input[0];
                    string pokemonEvolution = input[1] + " <-> " + input[2];

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<string>();
                        pokemons[pokemonName].Add(pokemonEvolution);
                    }
                    else
                    {
                        pokemons[pokemonName].Add(pokemonEvolution);
                    }
                }

                input = Console.ReadLine().Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            }
            // Sort evolutions by index descendig order.
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                var evolutions = pokemon.Value;
                evolutions = evolutions.OrderByDescending(x =>
                int.Parse(x.Split(new[] { " <-> " }, StringSplitOptions.None)[1])).ToList();

                foreach (var evo in evolutions)
                {
                    Console.WriteLine(evo);
                }
            }

        }
    }
}
