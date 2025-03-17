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
    [JsonSerializable(typeof(Hotel))]
    internal class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int NumberOfRooms { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Client> Clients { get; set; }
        public Hotel()
        {
        }
        public Hotel(string name, string address, int numberOfRooms)
        {
            Name = name;
            Address = address;
            NumberOfRooms = numberOfRooms;
            Rooms = new List<Room>(numberOfRooms);
            Clients = new List<Client>();
        }
        public void AddClient(Client client, Room room)
        {
            if (client.RoomNumber == room.RoomNumber)
            {
                room.SetBusy();
            }
            Clients.Add(client);
        }
        public void DeleteClient(Client client, Room room)
        {
            if(client.RoomNumber == room.RoomNumber)
            {
                room.SetFree();
            }
            Clients.Remove(client);
        }
        public void SearchByName(string name, ListBox lb)
        {
            foreach (var client in Clients)
            {
                if (client.Name == name)
                {
                    lb.Text += client.Name + " " 
                            + client.Surname + " " 
                            + client.Phone + " " 
                            + client.CheckInDate + " " 
                            + client.CheckOutDate + " " 
                            + client.RoomNumber + "\n";
                }
            }
        }
        public void SortByRoomNumber(ListBox lb)
        {
            Rooms.Sort(new CmprtByRoomNumber());
            lb.Items.Clear();
            foreach (Room room in Rooms)
            {
                lb.Items.Add((Room)room);
            }
        }
        public void FreeRooms(ListBox lb)
        {
            lb.Items.Clear();
            foreach (Room room in Rooms)
            {
                if (room.IsFree)
                {
                    lb.Items.Add((Room)room);
                }
            }
        }
    }
}
