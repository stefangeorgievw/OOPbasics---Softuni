using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();

        var peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        var productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        try
        {
            AddPeople(peopleInput, people);
            AddProducts(productsInput, products);


            BuyProduct(people, products);


            foreach (var person in people)
            {
                var bag = person.GetBag();
                if (bag.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", bag.Select(p => p.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }



    private static void AddPeople(string[] peopleInput, List<Person> people)
    {
        for (int i = 0; i < peopleInput.Length; i++)
        {
            var peopleArgs = peopleInput[i].Split('=');
            string name = peopleArgs[0];
            decimal money = decimal.Parse(peopleArgs[1]);
            people.Add(new Person(name, money));

        }
    }

    private static void AddProducts(string[] productsInput, List<Product> products)
    {
        for (int i = 0; i < productsInput.Length; i++)
        {
            var productArgs = productsInput[i].Split('=');
            string name = productArgs[0];
            decimal cost = decimal.Parse(productArgs[1]);
            products.Add(new Product(name, cost));
        }
    }

    private static void BuyProduct(List<Person> people, List<Product> products)
    {
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var personName = commandArgs[0];
            var productName = commandArgs[1];
            Person person = people.Where(r => r.Name == personName).First();
            Product product = products.Where(p => p.Name == productName).First();

            if (person.Money >= product.Cost)
            {
                person.Money = person.Money - product.Cost;
                person.AddToBag(product);
                Console.WriteLine($"{person.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{person.Name} can't afford {product.Name}");
            }
        }
    }

}
