using System;
using System.Collections.Generic;

namespace CurseWork
{
    internal class CmprtRoomsByNumber : IComparer<Room>
    {
        public int Compare(Room? x, Room? y)
        {
            if (x == null || y == null) return 0;
            return x.RoomNumber.CompareTo(y.RoomNumber);
        }
    }

    internal class CmprtRoomsByPrice : IComparer<Room>
    {
        public int Compare(Room? x, Room? y)
        {
            if (x == null || y == null) return 0;
            return x.Price.CompareTo(y.Price);
        }
    }

    internal class CmprtRoomsByAvailability : IComparer<Room>
    {
        public int Compare(Room? x, Room? y)
        {
            if (x == null || y == null) return 0;
            return x.IsFree.CompareTo(y.IsFree);
        }
    }
}
