using System;


public class Program
{
    public const double CAR_AIR_CONDITIONING = 0.9;
    public const double TRUCK_AIR_CONDITIONING = 1.6;
    static void Main(string[] args)
    {
        var carInput = Console.ReadLine().Split();
        var carFuelQuantity = double.Parse(carInput[1]);
        var carFuelPerKm = double.Parse(carInput[2]);
        var carTankCapacity = double.Parse(carInput[3]);
        var car = new Car(carFuelQuantity, carFuelPerKm, CAR_AIR_CONDITIONING,carTankCapacity);

        var truckInput = Console.ReadLine().Split();
        var truckFuelQuantity = double.Parse(truckInput[1]);
        var truckFuelPerKm = double.Parse(truckInput[2]);
        var truckTankCapacity = double.Parse(truckInput[3]);
        var truck = new Truck(truckFuelQuantity, truckFuelPerKm, TRUCK_AIR_CONDITIONING,truckTankCapacity);

        var busInput = Console.ReadLine().Split();
        var busFuelQuantity = double.Parse(busInput[1]);
        var busFuelPerKm = double.Parse(busInput[2]);
        var busTankCapacity = double.Parse(busInput[3]);
        var bus = new Bus(busFuelQuantity, busFuelPerKm,1.4, busTankCapacity);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            

            if (input[0] == "Drive")
            {
                double distance = double.Parse(input[2]);
                if (input[1] == "Car")
                {
                    Console.WriteLine(car.Drive(distance)); 
                }
                else if (input[1] == "Bus")
                {
                    Console.WriteLine(bus.Drive(distance));
                }
                else
                {
                    Console.WriteLine(truck.Drive(distance));
                }
            }
            if (input[0] == "Refuel")
            {
                double fuel = double.Parse(input[2]);
                if (input[1] == "Car")
                {
                    car.ReFuel(fuel);
                }
                else if(input[1] == "Bus")
                {
                    bus.ReFuel(fuel);
                }
                else
                {
                    truck.ReFuel(fuel);
                }
            }
            if (input[0] == "DriveEmpty")
            {
                var distance = double.Parse(input[2]);
                Console.WriteLine(bus.DriveEmpty(distance));
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);


    }
}

