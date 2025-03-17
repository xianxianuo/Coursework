using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CurseWork
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public bool IsFree { get; set; }
        public Room()
        {
        }
        public Room(int number, string type, decimal price, int capacity)
        {
            RoomNumber = number;
            Type = type;
            Price = price;
            IsFree = true;
            Capacity = capacity;
        }
        public void SetRoomNumber(int numRoom)
        {
            RoomNumber = 100 + numRoom;
        }
        public void SetFree()
        {
            IsFree = true;
        }
        public void SetBusy()
        {
            IsFree = false;
        }
    }
}
