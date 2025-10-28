using SmartGarage_Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Motorcycle : Vehicle
{
    public int FuelPercentage { get; private set; }

    public Motorcycle(string model, int fuel) : base(model)
    {//
        FuelPercentage = Math.Clamp(fuel, 0, 100);
    }
    //
    public override void Drive()
    {
        if (FuelPercentage > 5)
        {
            FuelPercentage -= 5;
            Console.WriteLine($"Motorcycle {ModelName} zooms ahead. Fuel left: {FuelPercentage}%");
        }
        else
        {
            Console.WriteLine($"Motorcycle {ModelName} cannot drive. No fuel.");
        }
    }

    public void Refuel()
    {
        Console.WriteLine($"Refueling motorcycle {ModelName}...");
        FuelPercentage = 100;
    }

    public override void MoveLeft()
    {
        Console.WriteLine($"Motorcycle {ModelName} leans left.");
    }

    public override void MoveRight()
    {
        Console.WriteLine($"Motorcycle {ModelName} leans right.");
    }
}
 
