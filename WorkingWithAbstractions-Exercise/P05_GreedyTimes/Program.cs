using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class GreedyTimes
    {
        static void Main(string[] args)
        {
            long bagAmmount = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gems = 0;
            long cash = 0;

            for (int i = 0; i < input.Length; i += 2)
            {
                string typeOfValue = input[i];
                long count = long.Parse(input[i + 1]);

                string type = string.Empty;

                if (typeOfValue.Length == 3)
                {
                    type = "Cash";
                }
                else if (typeOfValue.ToLower().EndsWith("gem"))
                {
                    type = "Gem";
                }
                else if (typeOfValue.ToLower() == "gold")
                {
                    type = "Gold";
                }

                if (type == "")
                {
                    continue;
                }
                else if (bagAmmount < bag.Values.Select(x => x.Values.Sum()).Sum() + count)
                {
                    continue;
                }

                switch (type)
                {
                    case "Gem":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (count > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + count > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (count > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + count > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(type))
                {
                    bag[type] = new Dictionary<string, long>();
                }

                if (!bag[type].ContainsKey(typeOfValue))
                {
                    bag[type][typeOfValue] = 0;
                }

                bag[type][typeOfValue] += count;
                if (type == "Gold")
                {
                    gold += count;
                }
                else if (type == "Gem")
                {
                    gems += count;
                }
                else if (type == "Cash")
                {
                    cash += count;
                }
            }

            PrintResult(bag);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> bag)
        {
            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}