using System;
using System.Collections.Generic;
using System.Text;

public abstract class Mammal:Animal
{
    private string livingRegion;

    protected Mammal(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion
    {
        get { return this.livingRegion; }
        set { this.livingRegion = value; }
    }


    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

