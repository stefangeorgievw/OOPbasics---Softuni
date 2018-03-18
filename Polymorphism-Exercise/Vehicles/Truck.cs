using System;
using System.Collections.Generic;
using System.Text;


public class Truck:Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumptionPerKm,double airConditioningConsumption, double tankCapacity) :base(fuelQuantity,fuelConsumptionPerKm,airConditioningConsumption,tankCapacity)
    {

    }

    public override void ReFuel(double fuel)
    {
        if (fuel > tankCapacity)
        {
            Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
        }
        else if (fuel <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            fuel = fuel * 0.95;
            fuelQuantity += fuel;
        }
    }
}

