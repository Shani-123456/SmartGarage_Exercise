namespace SmartGarage_Exercise
{
    namespace SmartGarage_Exercise
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                var garageItems = new object[]
                {
                new Car("Mazda", 80),
                new Motorcycle("Yamaha", 60),
                new CleaningRobot(50),
                new Drone(40)
                };
                
                SmartGarageTester.TestAllVehicles(new Vehicle[]
                {
                new Car("Mazda", 80),
                new Motorcycle("Yamaha", 60)
                });
            }
        }
    }
}