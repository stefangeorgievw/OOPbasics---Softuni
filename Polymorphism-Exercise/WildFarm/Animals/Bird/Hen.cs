using System;
using System.Collections.Generic;
using System.Text;

public class Hen : Bird
{
    public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
    {
    }

    public override string ProduceSound()
    {
        return "Cluck";
    }

    public override void IncreaseWeight(double foodQuantity)
    {
        this.Weight += 0.35 * foodQuantity;
    }

    public override void Feed(Food food)
    {
        this.IncreaseWeight(food.Quantity);
        this.IncreaseEatenFood(food.Quantity);
    }
}
