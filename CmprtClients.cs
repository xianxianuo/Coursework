using System;
using System.Collections.Generic;

namespace CurseWork
{
    internal class CmprtClientsByName : IComparer<Client>
    {
        public int Compare(Client? x, Client? y)
        {
            if (x == null || y == null) return 0;
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
    internal class CmprtClientsBySurname : IComparer<Client>
    {
        public int Compare(Client? x, Client? y)
        {
            if (x == null || y == null) return 0;
            return string.Compare(x.Surname, y.Surname, StringComparison.Ordinal);
        }
    }
    internal class CmprtClientsByCheckInDate : IComparer<Client>
    {
        public int Compare(Client? x, Client? y)
        {
            if (x == null || y == null) return 0;
            return x.CheckInDate.CompareTo(y.CheckInDate);
        }
    }
    internal class CmprtClientsByCheckOutDate : IComparer<Client>
    {
        public int Compare(Client? x, Client? y)
        {
            if (x == null || y == null) return 0;
            return x.CheckOutDate.CompareTo(y.CheckOutDate);
        }
    }
    internal class CmprtClientsByRoomNumber : IComparer<Client>
    {
        public int Compare(Client? x, Client? y)
        {
            if (x == null || y == null) return 0;
            return x.RoomNumber.CompareTo(y.RoomNumber);
        }
    }
}
