using System;
using System.Collections.Generic;
using System.Text;

public class Bus:Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double airConditioningConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, airConditioningConsumption, tankCapacity)
    {

    }

    public string DriveEmpty(double distance)
    {
        
            var needFuel = (this.fuelConsumptionPerKm) * distance;
            if (needFuel > this.fuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.fuelQuantity = this.fuelQuantity - needFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        
    }
}

