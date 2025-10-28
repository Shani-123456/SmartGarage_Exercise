using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    /// <summary>
    /// Static class containing smart garage testing functions.
    /// </summary>
    public static class SmartGarageTester
    {
        /// <summary>
        /// Tests an array of vehicles using polymorphism.
        /// </summary>
        /// <param name="allVehicles">Array of Vehicle objects.</param>
        public static void TestAllVehicles(Vehicle[] allVehicles)
        {
            Console.WriteLine("\n--- Commencing Vehicle diagnostics ---");
            foreach (var v in allVehicles)
            {
                Console.WriteLine($"-- Testing {v.ModelName} --");
                v.Drive();
            }
        }

        /// <summary>
        /// Tests movable objects and charges only those that are also chargeable.
        /// </summary>
        /// <param name="movables">Array of IMovable objects.</param>
        public static void TestMovablesAndChargeables(IMovable[] movables)
        {
            Console.WriteLine("\n--- Commencing Movable/Chargeable test ---");

            foreach (var item in movables)
            {
                item.MoveRight();

                if (item is IChargeable chargeable)
                {
                    chargeable.ChargeBattery();
                }
            }

            Console.WriteLine("--- Movable/Chargeable test complete ---");
        }
        public static void ChargeMoving(IMovable[] moving)
        {
            foreach (var item in moving)
            {
                if (item is IChargeable chargeable)
                {
                    ((IChargeable)item).ChargeBattery();
                }
            }
        }
    }
}