using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    private List<Product> bagOfProducts;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.bagOfProducts = new List<Product>();
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

    public decimal Money
    {
        get { return money; }
        set
        {
            Validator.ValidateMoney(value);
            this.money = value;
        }
    }
    public  void AddToBag(Product product)
    {
        this.bagOfProducts.Add(product);
    }

    public List<Product> GetBag()
    {
        return this.bagOfProducts;
    }


}

