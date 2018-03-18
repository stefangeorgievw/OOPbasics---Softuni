using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    public double fuelQuantity;
    public double fuelConsumptionPerKm;
    private double airConditioningConsumption;
    public double tankCapacity;


    public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double airConditioningConsumption,double tankCapacity)
    {
        this.fuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
        this.fuelConsumptionPerKm = fuelConsumptionPerKm;
        this.airConditioningConsumption = airConditioningConsumption;
        this.tankCapacity = tankCapacity;
    }

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { this.fuelQuantity = value; } 
    }




    public string Drive(double distance)
    {
        var needFuel = (this.fuelConsumptionPerKm + this.airConditioningConsumption) * distance;
        if (needFuel > this.fuelQuantity)
        {
            return $"{this.GetType().Name} needs refueling";
        }

        this.fuelQuantity = this.fuelQuantity - needFuel;
        return $"{this.GetType().Name} travelled {distance} km";
    }

    public virtual void ReFuel(double fuel)
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
            fuelQuantity += fuel;
        }
        
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
    }

}

