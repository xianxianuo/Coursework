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
        public List<Employee> Employees { get; set; }
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
            Employees = new List<Employee>();
        }
        public void AddClient(Client client, Hotel hotel)
        {
            if (Clients == null)
            {
                Clients = new List<Client>();
            }
            foreach (var room in hotel.Rooms)
            {
                if (client.RoomNumber == room.RoomNumber)
                {
                    room.SetBusy();
                }
            }
            Clients.Add(client);
        }
        public void AddEmployees(int numOfEmployees)
        {
            this.Employees = new List<Employee>();

            for (int i = 0; i < numOfEmployees; i++)
            {
                Employee employee = new Employee();
                employee.CreateNewEmployee();
                Employees.Add(employee);
            }
        }
        public static Hotel LoadFromFile()
        {
            string basePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Files");
            string filePathHotel = Path.Combine(basePath, "HotelData.json");

            Hotel hotel = new Hotel();

            // Завантаження даних готелю
            if (File.Exists(filePathHotel))
            {
                string hotelJson = File.ReadAllText(filePathHotel).Trim();
                if (!string.IsNullOrWhiteSpace(hotelJson))
                {
                    hotel = JsonConvert.DeserializeObject<Hotel>(hotelJson) ?? new Hotel();
                }
            }
            return hotel;
        }
        public void SaveToFile()
        {
            string basePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Files");

            // Шляхи до файлів
            string filePathHotel = Path.Combine(basePath, "HotelData.json");

            string hotelJson = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filePathHotel, hotelJson);
        }
        public void DeleteFileInfo()
        {
            string basePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Files");
            string filePathHotel = Path.Combine(basePath, "HotelData.json");
            if (File.Exists(filePathHotel))
            {
                File.WriteAllText(filePathHotel, string.Empty); // або File.Delete(filePathHotel);
            }
        }
    }
}