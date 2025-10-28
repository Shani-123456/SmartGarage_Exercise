using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise;

public class Car : FuelVehicle
{

    public Car(string model, int fuel) : base(model,fuel)
    { 

    }

    public override void Drive()
    {
        if (FuelPercentage > 10)
        {
            FuelPercentage -= 10;
            Console.WriteLine($"The car {ModelName} goes 'Vroom Vroom'. Fuel left: {FuelPercentage}%");
        }
        else
        {
            Console.WriteLine($"The car {ModelName} cannot drive. No fuel.");
        }
    }

    public override void Refuel()
    {
        Console.WriteLine($"Refueling {ModelName}...");
        FuelPercentage = 100;
    }

    public override void MoveLeft()
    {
        Console.WriteLine($"Car {ModelName} turns left.");
    }

    public override void MoveRight()
    {
        Console.WriteLine($"Car {ModelName} turns right.");
    }
}