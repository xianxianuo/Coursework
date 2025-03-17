using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace CurseWork
{
    internal class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int RoomNumber { get; set; }
        public Client()
        {
        }
        public Client(string name, string surname, string phone, DateTime checkInDate, DateTime checkOutDate, int roomNumber)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            RoomNumber = roomNumber;
        }
    }
}
