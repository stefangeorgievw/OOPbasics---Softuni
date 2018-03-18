using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        int counter = 0;

        Animal animal = null;

        string line;
        while ((line = Console.ReadLine()) != "End")
        {
            string[] tokens = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (counter % 2 == 0)
            {
                animal = GetAnimal(tokens);
            }
            else
            {
                Food food = GetFood(tokens);
                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Feed(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                animals.Add(animal);
            }

            counter++;
        }

        foreach (var a in animals)
        {
            Console.WriteLine(a);
        }
    }

    private static Food GetFood(string[] tokens)
    {
        string foodType = tokens[0];
        int quantity = int.Parse(tokens[1]);

        switch (foodType)
        {
            case "Vegetable":
                return new Vegetable(quantity);
            case "Seeds":
                return new Seeds(quantity);
            case "Meat":
                return new Meat(quantity);
            case "Fruit":
                return new Fruit(quantity);
            default:
                throw new ArgumentException("Invalid food type");
        }
    }

    private static Animal GetAnimal(string[] tokens)
    {
        string animalType = tokens[0];

        string name;
        double weight;
        double wingSize;
        string livingRegion;
        string breed;

        switch (animalType)
        {
            case "Owl":
                name = tokens[1];
                weight = double.Parse(tokens[2]);
                wingSize = double.Parse(tokens[3]);
                return new Owl(name, weight, 0, wingSize);
            case "Hen":
                name = tokens[1];
                weight = double.Parse(tokens[2]);
                wingSize = double.Parse(tokens[3]);
                return new Hen(name, weight, 0, wingSize);
            case "Mouse":
                name = tokens[1];
                weight = double.Parse(tokens[2]);
                livingRegion = tokens[3];
                return new Mouse(name, weight, 0, livingRegion);
            case "Dog":
                name = tokens[1];
                weight = double.Parse(tokens[2]);
                livingRegion = tokens[3];
                return new Dog(name, weight, 0, livingRegion);
            case "Cat":
                name = tokens[1];
                weight = double.Parse(tokens[2]);
                livingRegion = tokens[3];
                breed = tokens[4];
                return new Cat(name, weight, 0, livingRegion, breed);
            case "Tiger":
                name = tokens[1];
                weight = double.Parse(tokens[2]);
                livingRegion = tokens[3];
                breed = tokens[4];
                return new Tiger(name, weight, 0, livingRegion, breed);
            default:
                throw new ArgumentException("Invalid input animal");
        }
    }
}

