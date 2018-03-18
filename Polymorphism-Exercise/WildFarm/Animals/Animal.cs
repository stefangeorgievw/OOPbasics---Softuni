using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animal
{
    private string name;
    private double weight;
    private int foodEaten;

    protected Animal(string name, double weight, int foodEaten)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = foodEaten;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public double Weight
    {
        get { return this.weight; }
        protected set { this.weight = value; }
    }

    public int FoodEaten
    {
        get { return this.foodEaten; }
        protected set { this.foodEaten = value; }
    }


    public void IncreaseEatenFood(int currFoodEaten)
    {
        this.FoodEaten += currFoodEaten;
    }

    public virtual void IncreaseWeight(double foodQuantity)
    {
    }

    public virtual void Feed(Food food)
    {
    }

    public virtual string ProduceSound()
    {
        return "";
    }
}

