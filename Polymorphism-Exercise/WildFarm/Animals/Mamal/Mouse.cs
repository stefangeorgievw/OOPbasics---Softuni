using System;
using System.Collections.Generic;
using System.Text;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Squeak";
    }

    public override void IncreaseWeight(double foodQuantity)
    {
        this.Weight += foodQuantity * 0.1;
    }

    public override void Feed(Food food)
    {
        string foodType = food.GetType().Name;

        if (foodType == "Vegetable" || foodType == "Fruit")
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
