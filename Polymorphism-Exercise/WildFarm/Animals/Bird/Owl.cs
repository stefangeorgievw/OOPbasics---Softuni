using System;
using System.Collections.Generic;
using System.Text;

public class Owl : Bird
{
    public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
    {
    }

    public override string ProduceSound()
    {
        return "Hoot Hoot";
    }

    public override void IncreaseWeight(double foodQuantity)
    {
        this.Weight += foodQuantity * 0.25;
    }

    public override void Feed(Food food)
    {
        string foodType = food.GetType().Name;

        if (foodType == "Meat")
        {
            this.IncreaseWeight(food.Quantity);
            this.IncreaseEatenFood(food.Quantity);
        }
        else
        {
            Helper.PrintInvalidFood(food, this);
        }
    }
}
