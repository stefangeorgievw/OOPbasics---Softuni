using System;
using System.Collections.Generic;
using System.Text;


public class Product
{
    private string name;
    private decimal cost;

    public Product(string name,decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name
    {
        get { return name; }
        private set
        {
            Validator.ValidateName(value);
            this.name = value;
        }
    }



    public decimal Cost
    {
        get { return cost; }
        private set
        {
            Validator.ValidateMoney(value);
            this.cost = value;
        }
    }




}

