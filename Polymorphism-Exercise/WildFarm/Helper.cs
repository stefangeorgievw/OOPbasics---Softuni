using System;
using System.Collections.Generic;
using System.Text;

public class Helper
{
    public static void PrintInvalidFood(Food food, Animal animal)
    {
        throw new ArgumentException($"{animal.GetType().Name} does not eat {food.GetType().Name}!");
    }
}
