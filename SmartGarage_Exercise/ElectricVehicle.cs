using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public abstract class ElectricVehicle:Vehicle, IChargeable
    {
        public int Batterypercent { get; protected set; }

        protected ElectricVehicle(string modle): base(modle) {

            Batterypercent = 0;

        }
        public virtual void ChargeBattery()
        {
            Batterypercent = 100;
        }
    }
    
}
