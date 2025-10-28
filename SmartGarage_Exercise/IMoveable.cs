using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public interface IHorzantalMoveable
    {
        public void MoveLeft();
        public void MoveaRight();
    }
    public interface IMoveableup
    {
        public void Moveup();
        public void Moveadoun();
    }
}
