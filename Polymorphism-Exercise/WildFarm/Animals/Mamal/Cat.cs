using System;
using System.Collections.Generic;
using System.Text;

public class Cat : Feline
{
    public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
    {
    }

    public override string ProduceSound()
    {
        return "Meow";
    }

    public override void IncreaseWeight(double foodQuantity)
    {
        this.Weight += foodQuantity * 0.3;
    }

    public override void Feed(Food food)
    {
        string foodType = food.GetType().Name;

        if (foodType == "Vegetable" || foodType == "Meat")
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
