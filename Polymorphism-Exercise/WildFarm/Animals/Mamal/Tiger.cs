using System;
using System.Collections.Generic;
using System.Text;

public class Tiger : Feline
{
    public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
    {
    }

    public override string ProduceSound()
    {
        return "ROAR!!!";
    }

    public override void IncreaseWeight(double foodQuantity)
    {
        this.Weight += foodQuantity * 1.0;
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
