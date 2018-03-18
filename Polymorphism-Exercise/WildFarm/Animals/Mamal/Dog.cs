using System;
using System.Collections.Generic;
using System.Text;

public class Dog : Mammal
{
    public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Woof!";
    }

    public override void IncreaseWeight(double foodQuantity)
    {
        this.Weight += foodQuantity * 0.4;
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
