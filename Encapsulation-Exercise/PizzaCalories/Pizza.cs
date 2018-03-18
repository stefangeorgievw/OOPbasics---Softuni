using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppings = new List<Topping>();

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }

    public int NumberOfTopings => toppings.Count;

    public double TotalCallories => dough.Calories + toppings.Select(t => t.Calories).Sum();

    public Pizza(string name)
    {
        this.Name = name;
    }

    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);
        if (this.toppings.Count > 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }

    public void SetDough(Dough dough)
    {
        if (this.dough == null)
        {
            this.dough = dough;
        }
    }
}


