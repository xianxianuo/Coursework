using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseWork
{
    internal class CmprtByRoomNumber : IComparer<Room>
    {
        public int Compare(Room? x, Room? y)
        {
            return x.RoomNumber.CompareTo(y.RoomNumber);
        }
    }
}
