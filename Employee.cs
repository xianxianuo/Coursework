using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseWork
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Employee() { }
        public Employee(string id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
        public void CreateNewEmployee()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            Id = "";
            Password = "";
            for (int i = 0; i < 5; i++)
            {
                Id += chars[random.Next(chars.Length)];
                Password += chars[random.Next(chars.Length)];
            }
            Name = "simple employee";
        }

    }
}
