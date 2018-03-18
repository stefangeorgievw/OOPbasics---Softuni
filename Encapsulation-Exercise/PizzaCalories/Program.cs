using System;

public class Program
{
    static void Main(string[] args)
    {
        Pizza pizza;
        try
        {
            var pizzaName = Console.ReadLine().Split(' ', StringSplitOptions.None)[1];
            pizza = new Pizza(pizzaName);

            Dough myPizzaDough = ParseDough();
            pizza.SetDough(myPizzaDough);
            AddTopings(pizza);
            if (pizza.NumberOfTopings == 0)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        Console.WriteLine($"{pizza.Name} - {pizza.TotalCallories:f2} Calories.");
    }
    private static Dough ParseDough()
    {
        var inputLine = Console.ReadLine();
        var doughTokens = inputLine.Split(' ', StringSplitOptions.None);
        var flourType = doughTokens[1];
        var bakingTechnique = doughTokens[2];
        double doughWeight = double.Parse(doughTokens[3]);
        Dough dough = new Dough(doughWeight, flourType, bakingTechnique);

        return dough;

    }

    private static void AddTopings(Pizza pizza)
    {
        string inputLine;
        while ((inputLine = Console.ReadLine()) != "END")
        {
            var topingTokens = inputLine.Split(' ', StringSplitOptions.None);
            var topingType = topingTokens[1];
            var topingWeight = double.Parse(topingTokens[2]);
            Topping toping = new Topping(topingType, topingWeight);
            pizza.AddTopping(toping);

        }
    }
}


