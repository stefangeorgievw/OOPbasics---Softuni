using System;
using System.Collections.Generic;
using System.Text;


public class Topping
{
    private Dictionary<string, double> avaliableToppingTypes =
        new Dictionary<string, double>()
        {
            ["meat"] = 1.2,
            ["veggies"] = 0.8,
            ["cheese"] = 1.1,
            ["sauce"] = 0.9
        };

    private string type;
    private double weight;

    private double TypeModifier => avaliableToppingTypes[type];

    public double Calories => (2 * weight) * TypeModifier;

    public string Type
    {
        get { return type; }
        set
        {
            if (!avaliableToppingTypes.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            type = value.ToLower();
        }
    }
    public Topping(string type, double weight)
    {
        this.Type = type;
        ValidateWeight(type, weight);
        this.weight = weight;
    }

    private void ValidateWeight(string type, double weight)
    {
        if (weight < 1 || weight > 50)
        {
            throw new ArgumentException($"{type} weight should be in the range [1..50].");
        }
    }
}

