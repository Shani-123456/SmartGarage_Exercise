using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public class Drone : IMovable, IChargeable
    {
        public int BatteryPercentage { get; private set; }

        public Drone(int battery)
        {
            BatteryPercentage = Math.Clamp(battery, 0, 100);
        }

        public void Fly()
        {
            Console.WriteLine("Drone is flying...");
        }

        public void ChargeBattery()
        {
            Console.WriteLine("Drone is charging...");
            BatteryPercentage = 100;
        }

        public void MoveLeft()
        {
            Console.WriteLine("Drone moved left.");
        }

        public void MoveRight()
        {
            Console.WriteLine("Drone moved right.");
        }
    }
}
