using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class fHotelInfo : Form
    {
        private Hotel hotel;
        public fHotelInfo()
        {
            InitializeComponent();
            hotel = Hotel.LoadFromFile();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fHotelInfo_Load(object sender, EventArgs e)
        {
            labelName.Text = "Name: " + hotel.Name;
            labelAddress.Text = "Address: " + hotel.Address;
            labelOfRooms.Text = "Number of rooms: " + hotel.NumberOfRooms;
            labelOfClient.Text = "Number of clients: " + hotel.Clients.Count;
        }
    }
}
