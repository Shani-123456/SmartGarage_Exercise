using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public interface IMovable
    {
        void MoveLeft();
        void MoveRight();
    }

    public interface IChargeable
    {
        void ChargeBattery();
    }
}
