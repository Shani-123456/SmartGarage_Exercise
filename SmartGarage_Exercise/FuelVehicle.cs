using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public abstract class FuelVehicle : Vehicle
    {
        public int FuelPercentage { get; protected set; }
    
    public FuelVehicle(string model, int fuelperce) :base(model)
        {
            FuelPercentage = Math.Clamp(fuelperce, 0, 100);

        }
        public virtual void Refuel()
        {
            Console.WriteLine($"Refueling {ModelName}...");
            FuelPercentage = 100;
        }
    }

}













