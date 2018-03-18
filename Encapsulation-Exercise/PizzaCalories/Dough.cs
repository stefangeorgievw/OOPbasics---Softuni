using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
    private Dictionary<string, double> avaliableFlourTypes =
      new Dictionary<string, double>()
      {
          ["white"] = 1.5,
          ["wholegrain"] = 1.0
      };
    private Dictionary<string, double> avaliableBakingTechniques =
        new Dictionary<string, double>()
        {
            ["crispy"] = 0.9,
            ["chewy"] = 1.1,
            ["homemade"] = 1.0
        };

    private double weight;
    private string flourType;
    private string bakingTechnique;

    private double FlourMultiplier => avaliableFlourTypes[flourType];

    private double TechniqueMultiplier => avaliableBakingTechniques[bakingTechnique];

    public double Weight
    {
        get { return weight; }

        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range[1..200].");
            }
            weight = value;
        }
    }

    public string FlourType
    {
        get
        {
            return flourType;
        }
        set
        {
            ValidateType(avaliableFlourTypes, value);
            flourType = value.ToLower();
        }
    }

    public string BakingTechnique
    {
        get
        {
            return bakingTechnique;
        }
        set
        {
            ValidateType(avaliableBakingTechniques, value);
            bakingTechnique = value.ToLower();
        }
    }

    public double Calories => (2 * Weight) * FlourMultiplier * TechniqueMultiplier;

    public Dough(double weight, string flourType, string bakingTechnique)
    {
        this.Weight = weight;
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
    }

    private void ValidateType(Dictionary<string, double> dictinary, string type)
    {
        if (!dictinary.ContainsKey(type.ToLower()))
        {
            throw new ArgumentException("Invalid type of dough.");
        }
    }
}


