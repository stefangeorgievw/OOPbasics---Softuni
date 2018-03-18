using System;
using System.Collections.Generic;
using System.Text;

public abstract class Food
{
    private int quantity;

    public int Quantity
    {
        get { return this.quantity; }
        protected set { this.quantity = value; }
    }

    protected Food(int quantity)
    {
        Quantity = quantity;
    }
}
